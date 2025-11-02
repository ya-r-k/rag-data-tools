# Архитектура и компоненты

## Обзор архитектуры

Библиотека `Sample.Chunkers` организована по принципу разделения ответственности с использованием методов расширения (extension methods) для предоставления API. Архитектура следует паттерну разделения на слои:

1. **Модели данных** - описание структуры чанков и связей
2. **Перечисления** - типы чанков, связей и семантики
3. **Расширения** - основная бизнес-логика обработки текста
4. **Вспомогательные классы** - утилиты (regex-шаблоны)

## Структура компонентов

### Models (Модели данных)

#### ChunkModel

**Назначение:** Представляет один чанк (фрагмент) текста или структурированного элемента.

**Описание:**
- `Index` - уникальный числовой идентификатор чанка в рамках обработки
- `ChunkType` - тип чанка (текст, код, таблица, заголовок и т.д.)
- `RawContent` - исходное содержимое чанка из документа
- `Data` - словарь с дополнительными метаданными чанка (зависит от типа)
- `RelatedChunksIndexes` - словарь, связывающий типы связанных чанков с их индексами

**Использование:**
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

**Особенности:**
- Использует `record` тип для неизменяемости данных
- `Data` содержит специфичную для типа чанка информацию:
  - Для `CodeBlock`: `language`, `content`
  - Для `Topic`: `name`, `level`
  - Для `ImageLink`/`AdditionalLink`: `url`, `alterText`
  - Для `TextChunk`: `content`
  - Для `Table`/`InfoBlock`: `content`

#### RelationshipModel

**Назначение:** Представляет связь между двумя чанками в графе.

**Описание:**
- `FirstChunkIndex` - индекс первого чанка в связи
- `SecondChunkIndex` - индекс второго чанка в связи
- `RelationshipType` - тип связи (следующий, подзаголовок, связанный код и т.д.)

**Типы связей:**
- `HasNextChunk` - следующий текстовый чанк
- `HasNextTopic` - следующий заголовок того же или более высокого уровня
- `HasFirstSubtopic` - первый подзаголовок (более низкого уровня)
- `RelatedCodeBlock` - связанный блок кода
- `RelatedTable` - связанная таблица
- `RelatedImage` - связанное изображение
- `RelatedInfoBlock` - связанный информационный блок
- `AdditionalLink` - дополнительная ссылка
- `StartsWith` - заголовок начинается с другого элемента

**Использование:**
```csharp
var relation = new RelationshipModel
{
    FirstChunkIndex = 1,
    SecondChunkIndex = 2,
    RelationshipType = RelationshipType.HasNextChunk
};
```

### Enums (Перечисления)

#### ChunkType

**Назначение:** Определяет тип извлеченного чанка.

**Типы:**
- `TextChunk` (0) - обычный текстовый чанк
- `Table` (1) - HTML таблица
- `CodeBlock` (2) - блок кода (Markdown)
- `MathBlock` (3) - математический блок (не используется в текущей реализации)
- `InfoBlock` (4) - информационный блок (blockquote в Markdown)
- `ImageLink` (5) - ссылка на изображение (Markdown)
- `Topic` (6) - заголовок (Markdown header)
- `AdditionalLink` (7) - внешняя ссылка (Markdown link)

#### RelationshipType

**Назначение:** Определяет тип связи между чанками.

**Типы связей:**
- `Unknown` (0) - неизвестная связь
- `StartsWith` (1) - заголовок начинается с другого чанка
- `RelatedCodeBlock` (2) - связанный блок кода
- `RelatedImage` (3) - связанное изображение
- `RelatedTable` (4) - связанная таблица
- `RelatedInfoBlock` (5) - связанный информационный блок
- `AdditionalLink` (6) - дополнительная ссылка
- `HasNextTopic` (7) - следующий заголовок
- `HasFirstSubtopic` (8) - первый подзаголовок
- `HasNextChunk` (9) - следующий текстовый чанк
- `LoadedFrom` (10) - загружен из источника (не используется)

#### SemanticsType

**Назначение:** Определяет семантическую единицу разбиения текста.

**Типы:**
- `Sentence` (1) - разбиение по предложениям
- `Paragraph` (2) - разбиение по параграфам

### Extensions (Расширения)

#### SimpleTextChunkerExtensions

**Назначение:** Базовые операции для работы с простым текстом без структурированных элементов.

**Основные методы:**

1. **`GetWords(string text)`**
   - **Назначение:** Разбивает текст на слова
   - **Возвращает:** `Span<string>` массив слов
   - **Логика:** Разбивает по пробелам, удаляет пустые элементы

2. **`ExtractSentenceStartIndices(string text)`**
   - **Назначение:** Находит индексы начала предложений в массиве слов
   - **Возвращает:** Массив индексов слов, с которых начинаются предложения
   - **Логика:** Использует regex для поиска границ предложений (`.`, `!`, `?`, `:\n`)

3. **`ExtractParagraphStartIndexes(string text)`**
   - **Назначение:** Находит индексы начала параграфов в массиве слов
   - **Возвращает:** Массив индексов слов, с которых начинаются параграфы
   - **Логика:** Разбивает текст по `\n ` (новая строка с пробелом)

4. **`PreprocessNaturalTextForChunking(string text)`**
   - **Назначение:** Подготавливает текст для разбиения на чанки
   - **Возвращает:** Очищенный текст
   - **Логика:**
     - Удаляет лишние пробелы
     - Заменяет неразрывные пробелы (`\u00A0`) на обычные
     - Нормализует переводы строк (`\r\n` → `\n`)
     - Заменяет длинное тире на дефис
     - Удаляет множественные пробелы

5. **`ExtractSemanticChunksFromText(string text, int chunkWordsCount, SemanticsType semanticsType, double overlapPercentage = 0.0)`**
   - **Назначение:** Основной метод разбиения текста на семантические чанки
   - **Параметры:**
     - `chunkWordsCount` - максимальное количество слов в чанке
     - `semanticsType` - тип семантики (предложения или параграфы)
     - `overlapPercentage` - процент перекрытия между чанками (0.0 - 1.0)
   - **Логика:**
     1. Предобрабатывает текст
     2. Разбивает на слова
     3. Определяет границы семантических единиц (предложения/параграфы)
     4. Создает чанки, соблюдая максимальный размер и границы семантики
     5. При перекрытии находит оптимальную точку начала следующего чанка

**Особенности:**
- Алгоритм чанкинга учитывает семантические границы (не разрывает предложения/параграфы)
- Поддерживает перекрытие для сохранения контекста между чанками
- При перекрытии выбирает ближайшую семантическую границу к целевой точке

#### ComplexDataChunkerExtensions

**Назначение:** Извлечение структурированных элементов (код, таблицы, ссылки и т.д.) и комплексная обработка текста.

**Основные методы:**

1. **`ExtractSemanticChunksDeeply<T>(Dictionary<T, string> texts, ...)`**
   - **Назначение:** Обрабатывает коллекцию документов с автоматической нумерацией
   - **Возвращает:** Словарь документов → типы чанков → списки чанков
   - **Логика:** 
     - Обрабатывает каждый документ последовательно
     - Накапливает индексы между документами
     - Позволяет опционально включать/исключать типы чанков

2. **`ExtractSemanticChunksDeeply(string text, ...)`**
   - **Назначение:** Основной метод комплексного извлечения чанков из одного текста
   - **Логика:**
     1. Извлекает структурированные элементы (код, таблицы, ссылки и т.д.)
     2. Заменяет их на плейсхолдеры в тексте
     3. Предобрабатывает текст
     4. Извлекает текстовые чанки из обработанного текста
     5. В текстовых чанках обнаруживает ссылки на извлеченные элементы
   - **Параметры фильтрации:**
     - `withTables`, `withInfoBlocks`, `withCodeBlocks`, `withImages`, `withLinks` - флаги включения типов

3. **`RetrieveChunksFromText(string text, ...)`**
   - **Назначение:** Извлекает только структурированные элементы без текстовых чанков
   - **Использование:** Когда нужны только таблицы, код, ссылки и т.д.

**Частные методы извлечения:**

1. **`ExtractMarkdownCodeBlocks(StringBuilder text, int lastUsedIndex)`**
   - Извлекает блоки кода формата ` ```language\ncode\n``` `
   - Определяет язык программирования
   - Заменяет блок на плейсхолдер `[RELATEDCHUNK]Code-Block-{index}[/RELATEDCHUNK]`

2. **`ExtractMarkdownUnusualCodeBlocks(StringBuilder text, int lastUsedIndex)`**
   - Извлекает нестандартные блоки кода формата `` `code\n` ``
   - Используется для обработки граничных случаев

3. **`ExtractHtmlTables(StringBuilder text, int lastUsedIndex)`**
   - Извлекает HTML таблицы с поддержкой вложенных таблиц
   - Использует алгоритм подсчета глубины вложенности по тегам `<table>`/`</table>`
   - Заменяет на плейсхолдер `[RELATEDCHUNK]Table-{index}[/RELATEDCHUNK]`

4. **`ExtractMarkdownInfoBlocks(StringBuilder text, int lastUsedIndex)`**
   - Извлекает blockquote элементы (начинаются с `>`)
   - Заменяет на плейсхолдер `[RELATEDCHUNK]Info-Block-{index}[/RELATEDCHUNK]`

5. **`ExtractMarkdownImageLinks(StringBuilder text, int lastUsedIndex)`**
   - Извлекает изображения формата `![alt](url)`
   - Сохраняет URL и альтернативный текст
   - Заменяет на плейсхолдер `[RELATEDCHUNK]Image-Link-{index}[/RELATEDCHUNK]`

6. **`ExtractMarkdownHeaders(StringBuilder text, int lastUsedIndex)`**
   - Извлекает заголовки формата `# Title`, `## Subtitle` и т.д.
   - Определяет уровень заголовка (количество `#`)
   - Извлекает связанные элементы из заголовка
   - Заменяет на плейсхолдер `[RELATEDCHUNK]Title-{index}[/RELATEDCHUNK]`

7. **`ExtractMarkdownLinks(StringBuilder text, int lastUsedIndex)`**
   - Извлекает ссылки формата `[text](url)`
   - Сохраняет URL и текст ссылки
   - Заменяет текст ссылки на текст + плейсхолдер `[RELATEDCHUNK]External-Link-{index}[/RELATEDCHUNK]`

**Важные детали:**
- Порядок извлечения важен: код → таблицы → info blocks → изображения → ссылки → заголовки
- После извлечения структурированных элементов, в тексте остаются только плейсхолдеры
- Метод `SquashLabelsIntoWords` убирает пробелы вокруг плейсхолдеров
- Метод `ExtractRelatedChunksIndexes` находит все плейсхолдеры в тексте и создает связи

#### ChunksExtensions

**Назначение:** Работа с коллекциями чанков: построение графа связей и поиск дубликатов.

**Основные методы:**

1. **`BuildRelationsGraph<T>(Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>> chunks)`**
   - **Назначение:** Строит граф связей для коллекции документов
   - **Возвращает:** Массив связей `RelationshipModel[]`

2. **`BuildRelationsGraph(Dictionary<ChunkType, List<ChunkModel>> chunks)`**
   - **Назначение:** Строит граф связей для одного документа
   - **Логика:**
     1. Строит последовательности текстовых чанков (`HasNextChunk`)
     2. Строит иерархию заголовков (`HasNextTopic`, `HasFirstSubtopic`)
     3. Извлекает связи из `RelatedChunksIndexes` каждого чанка

**Частные методы:**

1. **`BuildTextChunkSequenceRelations(List<ChunkModel> sequenceChunks)`**
   - Строит связи между последовательными текстовыми чанками
   - Условие: индексы должны идти подряд (разница = 1)
   - Тип связи: `HasNextChunk`

2. **`BuildTitlesSequenceRelations(List<ChunkModel> sequenceChunks)`**
   - Строит иерархию заголовков
   - Определяет тип связи:
     - Если уровень увеличился → `HasFirstSubtopic` (подзаголовок)
     - Если уровень тот же или уменьшился → `HasNextTopic` (следующий заголовок)
   - При уменьшении уровня находит последний заголовок того же уровня в истории

3. **`BuildRelationshipsForRelatedChunks(ChunkModel firstChunk)`**
   - Обрабатывает `RelatedChunksIndexes` чанка
   - Создает связи согласно приоритету типов:
     - `Topic` → `StartsWith` (заголовок начинается с элемента)
     - `CodeBlock` → `RelatedCodeBlock`
     - `InfoBlock` → `RelatedInfoBlock`
     - `ImageLink` → `RelatedImage`
     - `Table` → `RelatedTable`
     - `AdditionalLink` → `AdditionalLink`
   - Направление связи зависит от типа: для заголовков элемент ссылается на заголовок, для остальных - чанк ссылается на элемент

4. **`FindRepeatedChunksWithUrls<T>(Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>> chunks)`**
   - **Назначение:** Находит дубликаты чанков с URL (изображения и ссылки)
   - **Возвращает:** Словарь `повторяющийся_индекс → уникальный_индекс`
   - **Логика:**
     1. Находит все чанки с URL (ImageLink, AdditionalLink)
     2. Группирует по URL
     3. Для каждого URL оставляет первый индекс как уникальный
     4. Остальные индексы добавляет в результат как повторяющиеся

**Особенности:**
- Построение графа учитывает порядок индексов
- Иерархия заголовков строится с учетом истории уровней
- Связи между чанками создаются двунаправленными где необходимо

### Helpers (Вспомогательные классы)

#### ChunkTypesRegexHelper

**Назначение:** Содержит скомпилированные регулярные выражения для поиска структурированных элементов.

**Regex-паттерны:**
- `GetCodeBlockRegex()` - блоки кода с языком: ` ```language\ncode\n``` `
- `GetUnusualCodeBlockRegex()` - нестандартные блоки: `` `code\n` ``
- `GetMarkdownInfoBlockRegex()` - blockquotes: `^>.*` (многострочные)
- `GetHtmlTableTagsRegex()` - теги таблиц: `<table>` и `</table>`
- `GetExternalLinkRegex()` - ссылки: `[text](url)`
- `GetHeadingRegex()` - заголовки: `#+ text`
- `GetImageLinkRegex()` - изображения: `![alt](url)`
- `GetChunkLabelRegex()` - плейсхолдеры: `[RELATEDCHUNK]Type-{index}[/RELATEDCHUNK]`
- `GetChunkLabelWithWhitespacesRegex()` - плейсхолдеры с пробелами вокруг

**Особенности:**
- Использует `GeneratedRegex` для компиляции во время сборки (производительность)
- Оптимизированы для работы с многострочным текстом (`Multiline`, `Singleline`)

#### CommonRegexHelper

**Назначение:** Общие регулярные выражения.

**Regex-паттерны:**
- `GetMultipleSpacesRegex()` - множественные пробелы: ` {2,}`

### Константы

#### ChunksConsts

**Назначение:** Шаблоны плейсхолдеров для замены структурированных элементов в тексте.

**Шаблоны:**
- `ExternalLinkTemplate` - `[RELATEDCHUNK]External-Link-{0}[/RELATEDCHUNK]`
- `ImageLinkTemplate` - `[RELATEDCHUNK]Image-Link-{0}[/RELATEDCHUNK]`
- `TableTemplate` - `[RELATEDCHUNK]Table-{0}[/RELATEDCHUNK]`
- `CodeBlockTemplate` - `[RELATEDCHUNK]Code-Block-{0}[/RELATEDCHUNK]`
- `InfoBlockTemplate` - `[RELATEDCHUNK]Info-Block-{0}[/RELATEDCHUNK]`
- `HeaderTemplate` - `[RELATEDCHUNK]Title-{0}[/RELATEDCHUNK]`
- `RelatedChunkTemplate` - `[RELATEDCHUNK]Chunk-{0}[/RELATEDCHUNK]`

## Поток обработки данных

### Сценарий 1: Обработка одного документа

```
Текст → ExtractSemanticChunksDeeply
  ├─→ RetrieveChunksFromText (извлечение структурированных элементов)
  │   ├─→ ExtractMarkdownCodeBlocks
  │   ├─→ ExtractHtmlTables
  │   ├─→ ExtractMarkdownInfoBlocks
  │   ├─→ ExtractMarkdownImageLinks
  │   ├─→ ExtractMarkdownLinks
  │   └─→ ExtractMarkdownHeaders
  │
  ├─→ SquashLabelsIntoWords (удаление пробелов вокруг плейсхолдеров)
  ├─→ PreprocessNaturalTextForChunking (очистка текста)
  └─→ ExtractSemanticChunks (извлечение текстовых чанков)
      ├─→ GetWords
      ├─→ ExtractSentenceStartIndices / ExtractParagraphStartIndexes
      └─→ GetChunks (создание чанков с учетом границ и перекрытия)
```

### Сценарий 2: Построение графа связей

```
Коллекция чанков → BuildRelationsGraph
  ├─→ BuildTextChunkSequenceRelations (текстовые последовательности)
  ├─→ BuildTitlesSequenceRelations (иерархия заголовков)
  └─→ BuildRelationshipsForRelatedChunks (связи из RelatedChunksIndexes)
      └─→ Для каждого типа чанка создает соответствующую связь
```

### Сценарий 3: Поиск дубликатов

```
Коллекция чанков → FindRepeatedChunksWithUrls
  ├─→ Фильтрация чанков с URL (ImageLink, AdditionalLink)
  ├─→ Группировка по URL
  └─→ Выбор уникального индекса (первый) для каждого URL
```

## Особенности реализации

### Порядок извлечения элементов

Важен для корректной работы плейсхолдеров:
1. Блоки кода (чтобы не путать с markdown внутри)
2. Таблицы (самые большие структуры)
3. Info blocks
4. Изображения
5. Ссылки (чтобы не путать с markdown ссылками в коде)
6. Заголовки (в последнюю очередь, т.к. могут содержать плейсхолдеры)

### Индексация чанков

- Индексы назначаются последовательно при извлечении
- Для коллекций документов индексы накапливаются между документами
- Параметр `lastUsedIndex` позволяет задать начальный индекс

### Обработка вложенности

- HTML таблицы: подсчет глубины вложенности для корректного извлечения
- Markdown элементы внутри заголовков: извлекаются отдельно, затем создаются связи

### Перекрытие чанков

При `overlapPercentage > 0`:
- Вычисляется целевой индекс перекрытия
- Находится ближайшая семантическая граница к целевой точке
- Следующий чанк начинается с найденной границы

## Производительность

- Использование `GeneratedRegex` - компиляция во время сборки
- Использование `Span<T>` для работы со словами без выделения памяти
- `StringBuilder` для эффективной замены текста
- Минимизация выделений памяти через переиспользование структур

