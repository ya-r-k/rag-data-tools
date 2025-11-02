# Примеры использования

## Базовые примеры

### Пример 1: Простое извлечение текстовых чанков

```csharp
using Sample.Chunkers.Extensions;
using Sample.Chunkers.Enums;

var text = @"Первое предложение. Второе предложение. Третье предложение.";

var chunks = text.ExtractSemanticChunksFromText(
    chunkWordsCount: 5,
    semanticsType: SemanticsType.Sentence,
    overlapPercentage: 0.0
);

// Результат:
// chunks[0] = "Первое предложение."
// chunks[1] = "Второе предложение."
// chunks[2] = "Третье предложение."
```

---

### Пример 2: Извлечение чанков с перекрытием

```csharp
var text = @"Первое предложение. Второе предложение. Третье предложение. Четвертое предложение.";

var chunks = text.ExtractSemanticChunksFromText(
    chunkWordsCount: 5,
    semanticsType: SemanticsType.Sentence,
    overlapPercentage: 0.3  // 30% перекрытие
);

// Результат:
// chunks[0] = "Первое предложение. Второе предложение." (5 слов)
// chunks[1] = "Второе предложение. Третье предложение." (5 слов, начинается с 2-го предложения)
// chunks[2] = "Третье предложение. Четвертое предложение." (5 слов, начинается с 3-го предложения)
```

---

### Пример 3: Извлечение из Markdown с заголовками и кодом

````csharp
var markdown = @"# Введение

Это первый параграф текста.

```csharp
var code = ""example"";
````

## Подзаголовок

Еще один параграф.";

var chunks = markdown.ExtractSemanticChunksDeeply(
chunkWordsCount: 10,
semanticsType: SemanticsType.Paragraph,
overlapPercentage: 0.2
);

// Доступ к различным типам чанков
var topics = chunks[ChunkType.Topic]; // Заголовки
var codeBlocks = chunks[ChunkType.CodeBlock]; // Блоки кода
var textChunks = chunks[ChunkType.TextChunk]; // Текстовые чанки

Console.WriteLine($"Найдено заголовков: {topics.Count}");
Console.WriteLine($"Найдено блоков кода: {codeBlocks.Count}");
Console.WriteLine($"Найдено текстовых чанков: {textChunks.Count}");

````

---

### Пример 4: Извлечение только структурированных элементов

```csharp
var text = @"# Заголовок

Текст параграфа.

```csharp
var code = 1;
````

<table>
    <tr><td>Ячейка</td></tr>
</table>

![Изображение](image.jpg)
[Ссылка](https://example.com)";

// Извлекаем только структурированные элементы
var chunks = text.RetrieveChunksFromText(
withTables: true,
withInfoBlocks: false,
withCodeBlocks: true,
withImages: true,
withLinks: true
);

// chunks содержит только:
// - chunks[ChunkType.Topic] - заголовки
// - chunks[ChunkType.CodeBlock] - блоки кода
// - chunks[ChunkType.Table] - таблицы
// - chunks[ChunkType.ImageLink] - изображения
// - chunks[ChunkType.AdditionalLink] - ссылки
// TextChunk отсутствует!

````

---

### Пример 5: Обработка коллекции документов

```csharp
var documents = new Dictionary<int, string>
{
    [0] = @"# Документ 1

Текст первого документа.",

    [1] = @"# Документ 2

Текст второго документа.
```python
def hello():
    print('Hello')
```"
};

var allChunks = documents.ExtractSemanticChunksDeeply(
    chunkWordsCount: 20,
    semanticsType: SemanticsType.Sentence,
    overlapPercentage: 0.0
);

// Индексы накапливаются между документами
// chunks[0][ChunkType.Topic][0].Index = 1
// chunks[0][ChunkType.TextChunk][0].Index = 2
// chunks[1][ChunkType.Topic][0].Index = 3
// chunks[1][ChunkType.TextChunk][0].Index = 4
// chunks[1][ChunkType.CodeBlock][0].Index = 5

// Доступ к чанкам конкретного документа
var doc0Topics = allChunks[0][ChunkType.Topic];
var doc1CodeBlocks = allChunks[1][ChunkType.CodeBlock];
````

---

### Пример 6: Построение графа связей

````csharp
var text = @"# Заголовок 1

Текст параграфа с [ссылкой](https://example.com).

```csharp
var code = 1;
````

## Заголовок 2

Еще текст.";

var chunks = text.ExtractSemanticChunksDeeply(
chunkWordsCount: 10,
semanticsType: SemanticsType.Paragraph
);

// Строим граф связей
var relationships = chunks.BuildRelationsGraph();

foreach (var relation in relationships)
{
var firstChunk = GetChunkByIndex(chunks, relation.FirstChunkIndex);
var secondChunk = GetChunkByIndex(chunks, relation.SecondChunkIndex);

    Console.WriteLine(
        $"{firstChunk.ChunkType}[{relation.FirstChunkIndex}] " +
        $"{relation.RelationshipType} " +
        $"{secondChunk.ChunkType}[{relation.SecondChunkIndex}]"
    );

}

// Вывод:
// Topic[1] StartsWith AdditionalLink[2]
// TextChunk[3] HasNextChunk TextChunk[4]
// Topic[5] HasNextTopic Topic[6]

````

---

### Пример 7: Поиск дубликатов по URL

```csharp
var documents = new Dictionary<int, string>
{
    [0] = @"![Image](https://example.com/image1.jpg)
Текст с [ссылкой](https://example.com/link)"),

    [1] = @"![Image](https://example.com/image1.jpg)  // Дубликат!
Текст с [ссылкой](https://example.com/link)")  // Дубликат!
};

var chunks = documents.ExtractSemanticChunksDeeply(10, SemanticsType.Sentence);

// Находим дубликаты
var duplicates = chunks.FindRepeatedChunksWithUrls();

foreach (var duplicate in duplicates)
{
    Console.WriteLine(
        $"Чанк с индексом {duplicate.Key} является дубликатом чанка {duplicate.Value}"
    );
}

// Вывод:
// Чанк с индексом 5 является дубликатом чанка 1  (изображение)
// Чанк с индексом 7 является дубликатом чанка 2  (ссылка)
````

---

## Продвинутые примеры

### Пример 8: Фильтрация типов чанков

````csharp
var text = @"# Заголовок
Текст с кодом ```code``` и [ссылкой](url)";

// Извлекаем только код и таблицы, игнорируем остальное
var chunks = text.ExtractSemanticChunksDeeply(
    chunkWordsCount: 10,
    semanticsType: SemanticsType.Sentence,
    withTables: true,
    withInfoBlocks: false,
    withCodeBlocks: true,
    withImages: false,      // Игнорируем изображения
    withLinks: false        // Игнорируем ссылки
);

// chunks содержит только CodeBlock, Table и TextChunk
````

---

### Пример 9: Работа с метаданными чанков

````csharp
var text = @"# Заголовок уровня 1

## Заголовок уровня 2

```python
def hello():
    print('Hello')
```";

var chunks = text.ExtractSemanticChunksDeeply(10, SemanticsType.Sentence);

// Работа с заголовками
foreach (var topic in chunks[ChunkType.Topic])
{
    var name = topic.Data["name"] as string;
    var level = (int)topic.Data["level"];

    Console.WriteLine($"Заголовок уровня {level}: {name}");
}

// Работа с блоками кода
foreach (var codeBlock in chunks[ChunkType.CodeBlock])
{
    var language = codeBlock.Data["language"] as string;
    var content = codeBlock.Data["content"] as string;

    Console.WriteLine($"Язык: {language}");
    Console.WriteLine($"Содержимое: {content}");
}

// Работа с изображениями/ссылками
foreach (var imageLink in chunks[ChunkType.ImageLink])
{
    var url = imageLink.Data["url"] as string;
    var altText = imageLink.Data["alterText"] as string;

    Console.WriteLine($"URL: {url}");
    Console.WriteLine($"Alt текст: {altText}");
}
````

---

### Пример 10: Работа с связанными чанками

```csharp
var text = @"# Заголовок с [ссылкой](https://example.com)

Текст параграфа.";

var chunks = text.ExtractSemanticChunksDeeply(10, SemanticsType.Sentence);

var topic = chunks[ChunkType.Topic].First();

// Проверяем связанные чанки
if (topic.RelatedChunksIndexes.TryGetValue(ChunkType.AdditionalLink, out var linkIndexes))
{
    foreach (var linkIndex in linkIndexes)
    {
        // Находим связанную ссылку
        var link = chunks[ChunkType.AdditionalLink]
            .FirstOrDefault(c => c.Index == linkIndex);

        if (link != null)
        {
            var url = link.Data["url"] as string;
            Console.WriteLine($"Заголовок связан со ссылкой: {url}");
        }
    }
}
```

---

### Пример 11: Извлечение с продолжением нумерации

```csharp
// Первый документ
var text1 = @"# Заголовок 1
Текст 1";
var chunks1 = text1.ExtractSemanticChunksDeeply(
    10, SemanticsType.Sentence,
    lastUsedIndex: 0
);

// Последний индекс после первого документа
var lastIndex = chunks1.Values.SelectMany(x => x).Max(c => c.Index);

// Второй документ с продолжением нумерации
var text2 = @"# Заголовок 2
Текст 2";
var chunks2 = text2.ExtractSemanticChunksDeeply(
    10, SemanticsType.Sentence,
    lastUsedIndex: lastIndex  // Продолжаем с последнего индекса
);

// chunks2[ChunkType.Topic][0].Index = lastIndex + 1
// chunks2[ChunkType.TextChunk][0].Index = lastIndex + 2
```

---

### Пример 12: Обработка вложенных таблиц

```csharp
var html = @"<table>
    <tr>
        <td>
            <table>
                <tr><td>Вложенная таблица</td></tr>
            </table>
        </td>
    </tr>
</table>";

var chunks = html.RetrieveChunksFromText(
    withTables: true,
    withInfoBlocks: false,
    withCodeBlocks: false,
    withImages: false,
    withLinks: false
);

// Обе таблицы извлечены отдельно
// chunks[ChunkType.Table][0] - внешняя таблица
// chunks[ChunkType.Table][1] - вложенная таблица (если поддерживается)
```

---

### Пример 13: Работа с информационными блоками (blockquotes)

```csharp
var markdown = @"Обычный текст.

> Это информационный блок
> Многострочный

Еще текст.";

var chunks = markdown.ExtractSemanticChunksDeeply(
    10, SemanticsType.Paragraph
);

foreach (var infoBlock in chunks[ChunkType.InfoBlock])
{
    var content = infoBlock.Data["content"] as string;
    Console.WriteLine($"Информационный блок: {content}");
}
```

---

### Пример 14: Комплексная обработка реальной статьи

````csharp
var article = @"
# Заголовок статьи

Введение с текстом.

## Первая секция

Текст секции с [ссылкой](https://example.com).

```csharp
public class Example
{
    public void Method() { }
}
````

### Подраздел

Текст подраздела с изображением:

![Изображение](https://example.com/image.jpg)

<table>
    <tr>
        <th>Заголовок</th>
        <th>Значение</th>
    </tr>
    <tr>
        <td>Данные</td>
        <td>123</td>
    </tr>
</table>

## Вторая секция

Еще текст.";

var chunks = article.ExtractSemanticChunksDeeply(
chunkWordsCount: 50,
semanticsType: SemanticsType.Sentence,
overlapPercentage: 0.3
);

// Построение графа связей
var relationships = chunks.BuildRelationsGraph();

// Статистика
Console.WriteLine($"Всего чанков: {chunks.Values.SelectMany(x => x).Count()}");
Console.WriteLine($"Заголовков: {chunks[ChunkType.Topic].Count}");
Console.WriteLine($"Блоков кода: {chunks[ChunkType.CodeBlock].Count}");
Console.WriteLine($"Таблиц: {chunks[ChunkType.Table].Count}");
Console.WriteLine($"Изображений: {chunks[ChunkType.ImageLink].Count}");
Console.WriteLine($"Ссылок: {chunks[ChunkType.AdditionalLink].Count}");
Console.WriteLine($"Текстовых чанков: {chunks[ChunkType.TextChunk].Count}");
Console.WriteLine($"Связей: {relationships.Length}");

````

---

## Практические сценарии

### Сценарий 1: Построение Knowledge Graph

```csharp
var documents = LoadDocuments(); // Загрузка документов
var allChunks = documents.ExtractSemanticChunksDeeply(100, SemanticsType.Paragraph);
var relationships = allChunks.BuildRelationsGraph();
var duplicates = allChunks.FindRepeatedChunksWithUrls();

// Создание узлов графа
var nodes = allChunks.Values
    .SelectMany(x => x.Values.SelectMany(chunks => chunks))
    .Select(chunk => new GraphNode
    {
        Id = chunk.Index,
        Type = chunk.ChunkType.ToString(),
        Content = chunk.RawContent,
        Metadata = chunk.Data
    })
    .ToList();

// Создание связей графа
var edges = relationships
    .Select(rel => new GraphEdge
    {
        Source = rel.FirstChunkIndex,
        Target = rel.SecondChunkIndex,
        Type = rel.RelationshipType.ToString()
    })
    .ToList();

// Объединение дубликатов
foreach (var duplicate in duplicates)
{
    // Объединить дубликаты в один узел
    MergeNodes(nodes, duplicate.Key, duplicate.Value);
}
````

---

### Сценарий 2: Векторизация для поиска

```csharp
var documents = LoadDocuments();
var allChunks = documents.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence);

// Извлечение текстовых чанков для векторизации
var textChunks = allChunks.Values
    .SelectMany(x => x[ChunkType.TextChunk])
    .Select(chunk => new VectorizableChunk
    {
        Id = chunk.Index,
        Text = chunk.Data["content"] as string ?? chunk.RawContent,
        Metadata = new
        {
            RelatedHeaders = GetRelatedHeaders(chunk, allChunks),
            RelatedCode = GetRelatedCode(chunk, allChunks),
            RelatedImages = GetRelatedImages(chunk, allChunks)
        }
    })
    .ToList();

// Векторизация (использование внешней библиотеки)
var vectors = Vectorize(textChunks);
```

---

### Сценарий 3: Экспорт в формат для внешних систем

```csharp
var chunks = document.ExtractSemanticChunksDeeply(100, SemanticsType.Paragraph);
var relationships = chunks.BuildRelationsGraph();

// Экспорт в JSON
var export = new
{
    Chunks = chunks.Values
        .SelectMany(x => x.Values.SelectMany(chunks => chunks))
        .Select(chunk => new
        {
            Id = chunk.Index,
            Type = chunk.ChunkType.ToString(),
            Content = chunk.RawContent,
            Data = chunk.Data,
            RelatedChunks = chunk.RelatedChunksIndexes
        }),
    Relationships = relationships.Select(rel => new
    {
        Source = rel.FirstChunkIndex,
        Target = rel.SecondChunkIndex,
        Type = rel.RelationshipType.ToString()
    })
};

var json = JsonSerializer.Serialize(export, new JsonSerializerOptions
{
    WriteIndented = true
});

File.WriteAllText("export.json", json);
```

---

## Заключение

Эти примеры демонстрируют основные возможности библиотеки. Для более подробной информации см. [API Reference](API.md).
