# API Reference

## Обзор

Библиотека предоставляет методы расширения для работы со строками и коллекциями чанков. Все методы находятся в пространствах имен:
- `Sample.Chunkers.Extensions`
- `Sample.Chunkers.Enums`
- `Sample.Chunkers.Models`

## Пространства имен

### Sample.Chunkers.Extensions

Содержит методы расширения для работы с текстом и чанками.

### Sample.Chunkers.Models

Содержит модели данных: `ChunkModel`, `RelationshipModel`.

### Sample.Chunkers.Enums

Содержит перечисления: `ChunkType`, `RelationshipType`, `SemanticsType`.

---

## SimpleTextChunkerExtensions

Базовые операции для работы с простым текстом.

### GetWords

Разбивает текст на слова.

```csharp
public static Span<string> GetWords(this string text)
```

**Параметры:**
- `text` - текст для разбиения

**Возвращает:**
- `Span<string>` - массив слов

**Пример:**
```csharp
var text = "Hello world example";
var words = text.GetWords(); // ["Hello", "world", "example"]
```

**Примечания:**
- Разбивает по пробелам
- Удаляет пустые элементы

---

### ExtractSentenceStartIndices

Находит индексы начала предложений в массиве слов.

```csharp
public static int[] ExtractSentenceStartIndices(this string text)
```

**Параметры:**
- `text` - текст для анализа

**Возвращает:**
- `int[]` - массив индексов слов, с которых начинаются предложения

**Пример:**
```csharp
var text = "First sentence. Second sentence! Third?";
var indices = text.ExtractSentenceStartIndices(); // [0, 2, 4]
```

**Примечания:**
- Использует regex для поиска границ: `.`, `!`, `?`, `:\n`
- Индексы указывают на позицию в массиве слов

---

### ExtractParagraphStartIndexes

Находит индексы начала параграфов в массиве слов.

```csharp
public static int[] ExtractParagraphStartIndexes(this string text)
```

**Параметры:**
- `text` - текст для анализа

**Возвращает:**
- `int[]` - массив индексов слов, с которых начинаются параграфы

**Пример:**
```csharp
var text = "First paragraph.\n\nSecond paragraph.";
var indices = text.ExtractParagraphStartIndexes(); // [0, 3]
```

**Примечания:**
- Разбивает текст по `\n ` (новая строка с пробелом)

---

### PreprocessNaturalTextForChunking

Подготавливает текст для разбиения на чанки.

```csharp
public static string PreprocessNaturalTextForChunking(this string text)
```

**Параметры:**
- `text` - текст для предобработки

**Возвращает:**
- `string` - очищенный текст

**Выполняемые операции:**
- Удаляет лишние пробелы в начале/конце
- Заменяет неразрывные пробелы (`\u00A0`) на обычные
- Нормализует переводы строк (`\r\n` → `\n`)
- Заменяет длинное тире (`\u2014`) на дефис (`-`)
- Удаляет множественные пробелы

**Пример:**
```csharp
var text = "Text   with\n\r\nmultiple   spaces";
var cleaned = text.PreprocessNaturalTextForChunking();
```

---

### PreprocessNaturalTextsForChunking

Подготавливает массив текстов для разбиения.

```csharp
public static string[] PreprocessNaturalTextsForChunking(this string[] texts)
```

**Параметры:**
- `texts` - массив текстов

**Возвращает:**
- `string[]` - массив очищенных текстов

**Пример:**
```csharp
var texts = new[] { "Text 1", "Text  2" };
var cleaned = texts.PreprocessNaturalTextsForChunking();
```

---

### ExtractSemanticChunksFromText

Извлекает семантические чанки из текста.

```csharp
public static string[] ExtractSemanticChunksFromText(
    this string text, 
    int chunkWordsCount, 
    SemanticsType semanticsType, 
    double overlapPercentage = 0.0
)
```

**Параметры:**
- `text` - текст для разбиения
- `chunkWordsCount` - максимальное количество слов в чанке
- `semanticsType` - тип семантики (`Sentence` или `Paragraph`)
- `overlapPercentage` - процент перекрытия между чанками (0.0 - 1.0, по умолчанию 0.0)

**Возвращает:**
- `string[]` - массив текстовых чанков

**Пример:**
```csharp
var text = "Long text with multiple sentences. Second sentence. Third sentence.";
var chunks = text.ExtractSemanticChunksFromText(
    chunkWordsCount: 10, 
    semanticsType: SemanticsType.Sentence,
    overlapPercentage: 0.3
);
```

**Примечания:**
- Чанки не разрывают предложения/параграфы
- При перекрытии выбирается ближайшая семантическая граница
- Если текст меньше `chunkWordsCount`, возвращается один чанк

---

## ComplexDataChunkerExtensions

Извлечение структурированных элементов и комплексная обработка.

### ExtractSemanticChunksDeeply (коллекция)

Обрабатывает коллекцию документов с автоматической нумерацией.

```csharp
public static Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>> ExtractSemanticChunksDeeply<T>(
    this Dictionary<T, string> texts, 
    int chunkWordsCount, 
    SemanticsType semanticsType, 
    double overlapPercentage = 0.0, 
    bool withTables = true,
    bool withInfoBlocks = true,
    bool withCodeBlocks = true, 
    bool withImages = true, 
    bool withLinks = true
) where T : unmanaged
```

**Параметры:**
- `texts` - словарь документов (ключ → текст)
- `chunkWordsCount` - максимальное количество слов в текстовом чанке
- `semanticsType` - тип семантики
- `overlapPercentage` - процент перекрытия (0.0 - 1.0)
- `withTables` - извлекать таблицы (по умолчанию `true`)
- `withInfoBlocks` - извлекать информационные блоки (по умолчанию `true`)
- `withCodeBlocks` - извлекать блоки кода (по умолчанию `true`)
- `withImages` - извлекать изображения (по умолчанию `true`)
- `withLinks` - извлекать ссылки (по умолчанию `true`)

**Возвращает:**
- `Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>>` - словарь документов → типы чанков → списки чанков

**Пример:**
```csharp
var documents = new Dictionary<int, string>
{
    [0] = "# Doc 1\n\nText...",
    [1] = "# Doc 2\n\nText..."
};

var chunks = documents.ExtractSemanticChunksDeeply(
    chunkWordsCount: 100,
    semanticsType: SemanticsType.Sentence,
    overlapPercentage: 0.5
);

// chunks[0][ChunkType.TextChunk] - текстовые чанки первого документа
// chunks[1][ChunkType.CodeBlock] - блоки кода второго документа
```

**Примечания:**
- Индексы чанков накапливаются между документами
- Ключ должен быть `unmanaged` типом (int, string не поддерживается напрямую)

---

### ExtractSemanticChunksDeeply (один текст)

Извлекает все типы чанков из одного текста.

```csharp
public static Dictionary<ChunkType, List<ChunkModel>> ExtractSemanticChunksDeeply(
    this string text,
    int chunkWordsCount, 
    SemanticsType semanticsType, 
    double overlapPercentage = 0.0, 
    bool withTables = true,
    bool withInfoBlocks = true,
    bool withCodeBlocks = true, 
    bool withImages = true, 
    bool withLinks = true, 
    int lastUsedIndex = 0
)
```

**Параметры:**
- `text` - текст для обработки
- `chunkWordsCount` - максимальное количество слов в текстовом чанке
- `semanticsType` - тип семантики
- `overlapPercentage` - процент перекрытия (0.0 - 1.0)
- `withTables` - извлекать таблицы
- `withInfoBlocks` - извлекать информационные блоки
- `withCodeBlocks` - извлекать блоки кода
- `withImages` - извлекать изображения
- `withLinks` - извлекать ссылки
- `lastUsedIndex` - последний использованный индекс (для продолжения нумерации)

**Возвращает:**
- `Dictionary<ChunkType, List<ChunkModel>>` - словарь типов чанков → списки чанков

**Пример:**
```csharp
var markdown = @"# Title

Text paragraph.

```csharp
var code = ""example"";
```

<table>
    <tr><td>Cell</td></tr>
</table>";

var chunks = markdown.ExtractSemanticChunksDeeply(
    chunkWordsCount: 50,
    semanticsType: SemanticsType.Paragraph
);

var topics = chunks[ChunkType.Topic];
var codeBlocks = chunks[ChunkType.CodeBlock];
var tables = chunks[ChunkType.Table];
var textChunks = chunks[ChunkType.TextChunk];
```

**Порядок обработки:**
1. Извлекаются структурированные элементы (код, таблицы, ссылки и т.д.)
2. Элементы заменяются на плейсхолдеры в тексте
3. Текст предобрабатывается
4. Извлекаются текстовые чанки
5. В текстовых чанках обнаруживаются ссылки на извлеченные элементы

---

### RetrieveChunksFromText

Извлекает только структурированные элементы без текстовых чанков.

```csharp
public static Dictionary<ChunkType, List<ChunkModel>> RetrieveChunksFromText(
    this string text, 
    bool withTables, 
    bool withInfoBlocks, 
    bool withCodeBlocks, 
    bool withImages, 
    bool withLinks, 
    int lastUsedIndex = 0
)
```

**Параметры:**
- `text` - текст для обработки
- `withTables` - извлекать таблицы
- `withInfoBlocks` - извлекать информационные блоки
- `withCodeBlocks` - извлекать блоки кода
- `withImages` - извлекать изображения
- `withLinks` - извлекать ссылки
- `lastUsedIndex` - последний использованный индекс

**Возвращает:**
- `Dictionary<ChunkType, List<ChunkModel>>` - словарь типов чанков → списки чанков

**Пример:**
```csharp
var text = "```csharp\ncode\n```\n\n![img](url.jpg)";
var chunks = text.RetrieveChunksFromText(
    withCodeBlocks: true,
    withImages: true,
    withTables: false,
    withInfoBlocks: false,
    withLinks: false
);

// chunks содержит только CodeBlock и ImageLink
// TextChunk отсутствует
```

**Примечания:**
- Используется когда нужны только структурированные элементы
- Текстовые чанки не извлекаются

---

## ChunksExtensions

Работа с коллекциями чанков: построение графа связей и поиск дубликатов.

### BuildRelationsGraph (коллекция)

Строит граф связей для коллекции документов.

```csharp
public static RelationshipModel[] BuildRelationsGraph<T>(
    this Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>> chunks
) where T : unmanaged
```

**Параметры:**
- `chunks` - словарь документов → типы чанков → списки чанков

**Возвращает:**
- `RelationshipModel[]` - массив связей

**Пример:**
```csharp
var chunks = documents.ExtractSemanticChunksDeeply(...);
var relationships = chunks.BuildRelationsGraph();

foreach (var relation in relationships)
{
    Console.WriteLine(
        $"Chunk {relation.FirstChunkIndex} -> " +
        $"{relation.RelationshipType} -> " +
        $"Chunk {relation.SecondChunkIndex}"
    );
}
```

---

### BuildRelationsGraph (один документ)

Строит граф связей для одного документа.

```csharp
public static RelationshipModel[] BuildRelationsGraph(
    this Dictionary<ChunkType, List<ChunkModel>> chunks
)
```

**Параметры:**
- `chunks` - словарь типов чанков → списки чанков

**Возвращает:**
- `RelationshipModel[]` - массив связей

**Пример:**
```csharp
var chunks = text.ExtractSemanticChunksDeeply(...);
var relationships = chunks.BuildRelationsGraph();
```

**Типы связей:**
- `HasNextChunk` - следующий текстовый чанк
- `HasNextTopic` - следующий заголовок
- `HasFirstSubtopic` - первый подзаголовок
- `RelatedCodeBlock` - связанный блок кода
- `RelatedTable` - связанная таблица
- `RelatedImage` - связанное изображение
- `RelatedInfoBlock` - связанный информационный блок
- `AdditionalLink` - дополнительная ссылка
- `StartsWith` - заголовок начинается с элемента

---

### FindRepeatedChunksWithUrls

Находит дубликаты чанков с одинаковыми URL.

```csharp
public static Dictionary<int, int> FindRepeatedChunksWithUrls<T>(
    this Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>> chunks
) where T : unmanaged
```

**Параметры:**
- `chunks` - словарь документов → типы чанков → списки чанков

**Возвращает:**
- `Dictionary<int, int>` - словарь `повторяющийся_индекс → уникальный_индекс`

**Пример:**
```csharp
var chunks = documents.ExtractSemanticChunksDeeply(...);
var duplicates = chunks.FindRepeatedChunksWithUrls();

// duplicates[10] = 5 означает:
// чанк с индексом 10 - дубликат чанка с индексом 5
```

**Примечания:**
- Работает только с чанками типа `ImageLink` и `AdditionalLink`
- Первый найденный чанк с URL считается уникальным
- Остальные чанки с тем же URL помечаются как дубликаты

---

## Модели данных

### ChunkModel

Представляет один чанк (фрагмент) текста или структурированного элемента.

```csharp
public record ChunkModel
{
    public int Index { get; set; }
    public required ChunkType ChunkType { get; set; }
    public required string RawContent { get; set; }
    public required Dictionary<string, object> Data { get; set; }
    public required Dictionary<ChunkType, List<int>> RelatedChunksIndexes { get; set; }
}
```

**Свойства:**
- `Index` - уникальный числовой идентификатор чанка
- `ChunkType` - тип чанка (см. `ChunkType`)
- `RawContent` - исходное содержимое чанка
- `Data` - дополнительные метаданные:
  - Для `CodeBlock`: `language`, `content`
  - Для `Topic`: `name`, `level`
  - Для `ImageLink`/`AdditionalLink`: `url`, `alterText`
  - Для `TextChunk`: `content`
  - Для `Table`/`InfoBlock`: `content`
- `RelatedChunksIndexes` - словарь связей: `тип_связанного_чанка → список_индексов`

**Пример:**
```csharp
var chunk = new ChunkModel
{
    Index = 1,
    ChunkType = ChunkType.CodeBlock,
    RawContent = "```csharp\nvar x = 1;\n```",
    Data = new Dictionary<string, object>
    {
        ["language"] = "csharp",
        ["content"] = "```csharp\nvar x = 1;\n```"
    },
    RelatedChunksIndexes = new Dictionary<ChunkType, List<int>>()
};
```

---

### RelationshipModel

Представляет связь между двумя чанками.

```csharp
public record RelationshipModel
{
    public int FirstChunkIndex { get; set; }
    public int SecondChunkIndex { get; set; }
    public RelationshipType RelationshipType { get; set; }
}
```

**Свойства:**
- `FirstChunkIndex` - индекс первого чанка в связи
- `SecondChunkIndex` - индекс второго чанка в связи
- `RelationshipType` - тип связи (см. `RelationshipType`)

**Пример:**
```csharp
var relation = new RelationshipModel
{
    FirstChunkIndex = 1,
    SecondChunkIndex = 2,
    RelationshipType = RelationshipType.HasNextChunk
};
```

---

## Перечисления

### ChunkType

Типы извлеченных чанков.

```csharp
public enum ChunkType
{
    TextChunk = 0,      // Обычный текстовый чанк
    Table = 1,          // HTML таблица
    CodeBlock = 2,      // Блок кода (Markdown)
    MathBlock = 3,      // Математический блок (не используется)
    InfoBlock = 4,     // Информационный блок (blockquote)
    ImageLink = 5,      // Ссылка на изображение
    Topic = 6,          // Заголовок (Markdown header)
    AdditionalLink = 7   // Внешняя ссылка (Markdown link)
}
```

---

### RelationshipType

Типы связей между чанками.

```csharp
public enum RelationshipType
{
    Unknown = 0,            // Неизвестная связь
    StartsWith = 1,        // Заголовок начинается с элемента
    RelatedCodeBlock = 2,  // Связанный блок кода
    RelatedImage = 3,      // Связанное изображение
    RelatedTable = 4,      // Связанная таблица
    RelatedInfoBlock = 5,  // Связанный информационный блок
    AdditionalLink = 6,    // Дополнительная ссылка
    HasNextTopic = 7,      // Следующий заголовок
    HasFirstSubtopic = 8,  // Первый подзаголовок
    HasNextChunk = 9,      // Следующий текстовый чанк
    LoadedFrom = 10        // Загружен из источника (не используется)
}
```

---

### SemanticsType

Типы семантической единицы разбиения текста.

```csharp
public enum SemanticsType
{
    Sentence = 1,   // Разбиение по предложениям
    Paragraph = 2   // Разбиение по параграфам
}
```

---

## Обработка ошибок

Библиотека не выбрасывает исключения для большинства сценариев:
- Пустой текст → возвращается пустой словарь
- Текст без структурированных элементов → возвращаются только текстовые чанки
- Некорректный Markdown → обрабатывается как обычный текст

**Исключения:**
- `InvalidOperationException` при неподдерживаемом `SemanticsType`

---

## Ограничения

1. **Типы ключей в коллекциях:**
   - Методы с `Dictionary<T, ...>` требуют `unmanaged` тип для ключа
   - `string` не поддерживается напрямую, используйте `int` или другой числовой тип

2. **Производительность:**
   - Регулярные выражения компилируются во время сборки (`GeneratedRegex`)
   - Обработка больших документов (>1MB) может быть медленной

3. **Поддержка форматов:**
   - Markdown: частичная поддержка (основные элементы)
   - HTML: только таблицы
   - Math blocks: объявлены, но не реализованы

---

## Примеры использования

См. также [EXAMPLES.md](EXAMPLES.md) для подробных примеров.

