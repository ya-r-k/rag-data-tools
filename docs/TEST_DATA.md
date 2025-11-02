# Хранение тестовых данных

## Обзор текущего подхода

### Текущая структура

Тестовые данные хранятся в статических классах в директории `TestData/`:

```
Sample.Chunkers.UnitTests/
└── TestData/
    ├── ArticlesTestData.cs        # Полные тексты статей
    ├── CodeBlocksTestData.cs      # Ожидаемые блоки кода
    ├── HeadersTestData.cs         # Ожидаемые заголовки
    ├── ImageLinksTestData.cs      # Ожидаемые изображения
    ├── InfoBlocksTestData.cs      # Ожидаемые информационные блоки
    ├── LinksTestData.cs           # Ожидаемые ссылки
    ├── RelationsTestData.cs       # Ожидаемые связи
    ├── TablesTestData.cs          # Ожидаемые таблицы
    └── TextChunkTestData.cs       # Ожидаемые текстовые чанки
```

### Особенности текущего подхода

✅ **Преимущества:**
- Все данные в одном месте (легко найти)
- Данные компилируются вместе с кодом (нет файлов в рантайме)
- Быстрый доступ (статические константы)
- Типобезопасность (компилятор проверяет типы)

⚠️ **Недостатки:**
- Большие файлы с длинными строками (например, `ArticlesTestData.cs` - 3000+ строк)
- Сложно редактировать большие тексты в C# строках
- Нет поддержки многострочности в raw strings для больших текстов (до C# 11)
- Сложно отслеживать связи между входными данными и ожидаемыми результатами
- Дублирование данных (статьи разделены на разные файлы)
- Нет версионирования тестовых данных отдельно от кода

---

## Анализ форматов хранения

### Вариант 1: Статические классы (текущий подход)

**Описание:** Данные хранятся как константы в C# классах.

**Плюсы:**
- ✅ Быстрый доступ (компиляция во время сборки)
- ✅ Типобезопасность
- ✅ Не требует загрузки файлов в рантайме
- ✅ Не влияет на производительность тестов

**Минусы:**
- ❌ Сложно редактировать большие тексты
- ❌ Нет визуального форматирования (для Markdown/HTML)
- ❌ Сложно отслеживать связи между данными
- ❌ Большие файлы в коде

**Рекомендация:** Подходит для небольших тестовых данных, но не для больших статей.

---

### Вариант 2: Embedded Resources (.resx или файлы)

**Описание:** Данные хранятся как embedded resources в сборке.

**Плюсы:**
- ✅ Отделение данных от кода
- ✅ Можно редактировать в текстовых редакторах
- ✅ Поддержка различных форматов (JSON, Markdown, TXT)
- ✅ Не загромождает код

**Минусы:**
- ❌ Загрузка в рантайме (минимальное влияние)
- ❌ Нет типобезопасности (строка → объект)
- ❌ Требует парсинг для структурированных данных

**Пример использования:**
```csharp
// Загрузка из embedded resource
var assembly = Assembly.GetExecutingAssembly();
var resourceName = "Sample.Chunkers.UnitTests.TestData.Articles.article1.md";
using var stream = assembly.GetManifestResourceStream(resourceName);
using var reader = new StreamReader(stream);
var content = await reader.ReadToEndAsync();
```

**Рекомендация:** Хороший вариант для больших текстов, но требует дополнительного кода для загрузки.

---

### Вариант 3: Отдельные файлы в директории

**Описание:** Тестовые данные хранятся как отдельные файлы в директории проекта.

**Структура:**
```
TestData/
├── Articles/
│   ├── devto_article.md
│   ├── geeksforgeeks_data_modeling.md
│   └── wikipedia_complex_tables.md
├── Expected/
│   ├── code_blocks.json
│   ├── headers.json
│   ├── links.json
│   └── relations.json
└── Config/
    └── test_cases.json
```

**Плюсы:**
- ✅ Легко редактировать в любом редакторе
- ✅ Поддержка подсветки синтаксиса для Markdown/HTML
- ✅ Можно версионировать отдельно
- ✅ Читаемость и наглядность
- ✅ Легко добавлять новые тестовые случаи

**Минусы:**
- ❌ Загрузка в рантайме (но можно кешировать)
- ❌ Требует настройки копирования файлов в выходную директорию
- ❌ Нет типобезопасности для JSON

**Настройка в .csproj:**
```xml
<ItemGroup>
  <None Include="TestData\**\*" CopyToOutputDirectory="PreserveNewest" />
</ItemGroup>
```

**Рекомендация:** Отличный вариант для наглядности и поддержки, но требует настройки проекта.

---

### Вариант 4: JSON/YAML файлы

**Описание:** Структурированные данные хранятся в JSON или YAML файлах.

**Пример структуры JSON:**
```json
{
  "testCases": [
    {
      "name": "DevTo Real World Article",
      "input": "Articles/devto_article.md",
      "expected": {
        "codeBlocks": "Expected/devto_code_blocks.json",
        "links": "Expected/devto_links.json",
        "textChunks": "Expected/devto_text_chunks.json",
        "relations": "Expected/devto_relations.json"
      },
      "config": {
        "chunkWordsCount": 200,
        "semanticsType": "Sentence",
        "overlapPercentage": 0.5
      }
    }
  ]
}
```

**Плюсы:**
- ✅ Структурированность
- ✅ Легко парсить (System.Text.Json)
- ✅ Можно автоматизировать генерацию ожидаемых результатов
- ✅ Поддержка ссылок между файлами

**Минусы:**
- ❌ Требует парсинг
- ❌ Нет типобезопасности
- ❌ Больше кода для загрузки и парсинга

**Рекомендация:** Хороший вариант для структурированных тестовых конфигураций.

---

### Вариант 5: Hybrid подход (рекомендуемый)

**Описание:** Комбинация нескольких подходов в зависимости от типа данных.

**Структура:**
```
TestData/
├── Articles/                    # Embedded resources или файлы
│   ├── devto_article.md
│   ├── geeksforgeeks_data_modeling.md
│   └── wikipedia_complex_tables.md
├── Expected/                    # JSON файлы или код
│   ├── code_blocks/
│   │   ├── devto_code_blocks.json
│   │   └── geeksforgeeks_code_blocks.json
│   └── relations/
│       └── devto_relations.json
├── TestCases.cs                # Маленькие тестовые случаи в коде
└── TestDataLoader.cs           # Класс для загрузки данных
```

**Плюсы:**
- ✅ Гибкость: большие данные в файлах, маленькие в коде
- ✅ Оптимальная производительность
- ✅ Наглядность для больших данных
- ✅ Типобезопасность для маленьких данных

**Минусы:**
- ❌ Некоторая сложность в организации
- ❌ Требует нескольких подходов к загрузке

**Рекомендация:** Лучший вариант для баланса производительности, наглядности и поддерживаемости.

---

## Рекомендуемый подход

### Для данного проекта

**Рекомендация:** Использовать **гибридный подход (Option 5)** с оптимизацией:

1. **Большие статьи** → Embedded Resources (`.md` файлы)
2. **Ожидаемые результаты** → JSON файлы (легко редактировать и версионировать)
3. **Маленькие тестовые случаи** → C# код (статические классы)
4. **Загрузчик данных** → Единый класс `TestDataLoader` с кешированием

### Структура проекта

```
Sample.Chunkers.UnitTests/
├── TestData/
│   ├── Articles/                    # Embedded resources
│   │   ├── devto_article.md
│   │   ├── geeksforgeeks_data_modeling.md
│   │   └── wikipedia_complex_tables.md
│   │
│   ├── Expected/                     # JSON файлы
│   │   ├── code_blocks/
│   │   ├── headers/
│   │   ├── links/
│   │   ├── relations/
│   │   ├── tables/
│   │   └── text_chunks/
│   │
│   ├── SmallTestCases.cs            # Маленькие случаи в коде
│   └── TestDataLoader.cs            # Загрузчик данных
│
└── Extensions/
    └── ... (тесты)
```

### Реализация TestDataLoader

```csharp
namespace Sample.Chunkers.UnitTests.TestData;

public static class TestDataLoader
{
    private static readonly Dictionary<string, string> _cachedArticles = new();
    private static readonly Dictionary<string, ChunkModel[]> _cachedExpected = new();
    
    public static string LoadArticle(string fileName)
    {
        if (_cachedArticles.TryGetValue(fileName, out var cached))
            return cached;
            
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = $"Sample.Chunkers.UnitTests.TestData.Articles.{fileName}";
        
        using var stream = assembly.GetManifestResourceStream(resourceName);
        if (stream == null)
            throw new FileNotFoundException($"Article not found: {fileName}");
            
        using var reader = new StreamReader(stream);
        var content = reader.ReadToEnd();
        
        _cachedArticles[fileName] = content;
        return content;
    }
    
    public static ChunkModel[] LoadExpectedChunks(string testCase, ChunkType chunkType)
    {
        var key = $"{testCase}_{chunkType}";
        if (_cachedExpected.TryGetValue(key, out var cached))
            return cached;
            
        var jsonPath = Path.Combine("TestData", "Expected", 
            chunkType switch
            {
                ChunkType.CodeBlock => "code_blocks",
                ChunkType.Topic => "headers",
                ChunkType.AdditionalLink => "links",
                // ...
                _ => "text_chunks"
            }, 
            $"{testCase}_{chunkType}.json");
            
        var json = File.ReadAllText(jsonPath);
        var chunks = JsonSerializer.Deserialize<ChunkModel[]>(json);
        
        _cachedExpected[key] = chunks ?? Array.Empty<ChunkModel>();
        return _cachedExpected[key];
    }
}
```

### Использование в тестах

```csharp
[Test]
public void ExtractSemanticChunksDeeply_WithRealWorldText_ShouldReturnCorrectChunks()
{
    // Arrange
    var text = TestDataLoader.LoadArticle("devto_article.md");
    var expectedCodeBlocks = TestDataLoader.LoadExpectedChunks("devto", ChunkType.CodeBlock);
    var expectedLinks = TestDataLoader.LoadExpectedChunks("devto", ChunkType.AdditionalLink);
    
    // Act
    var chunks = text.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence, 0.5);
    
    // Assert
    chunks[ChunkType.CodeBlock].Should().BeEquivalentTo(expectedCodeBlocks);
    chunks[ChunkType.AdditionalLink].Should().BeEquivalentTo(expectedLinks);
}
```

---

## Альтернативные форматы для ожидаемых результатов

### Option A: JSON (рекомендуется)

**Плюсы:**
- ✅ Стандартный формат
- ✅ Легко парсить (`System.Text.Json`)
- ✅ Поддержка в IDE (форматирование)
- ✅ Читаемость

**Минусы:**
- ❌ Нет комментариев (можно использовать JSON5)

**Пример:**
```json
[
  {
    "Index": 1,
    "ChunkType": "CodeBlock",
    "RawContent": "```csharp\nvar x = 1;\n```",
    "Data": {
      "language": "csharp",
      "content": "```csharp\nvar x = 1;\n```"
    },
    "RelatedChunksIndexes": {}
  }
]
```

### Option B: YAML

**Плюсы:**
- ✅ Более читаемый чем JSON
- ✅ Поддержка комментариев
- ✅ Меньше скобок

**Минусы:**
- ❌ Требует дополнительную библиотеку (`YamlDotNet`)
- ❌ Меньше поддержки в .NET экосистеме

**Пример:**
```yaml
- Index: 1
  ChunkType: CodeBlock
  RawContent: |
    ```csharp
    var x = 1;
    ```
  Data:
    language: csharp
    content: |
      ```csharp
      var x = 1;
      ```
  RelatedChunksIndexes: {}
```

### Option C: C# код (текущий подход для маленьких случаев)

**Плюсы:**
- ✅ Типобезопасность
- ✅ Компилируется вместе с кодом
- ✅ Нет парсинга

**Минусы:**
- ❌ Сложно для больших данных
- ❌ Нет визуального форматирования

**Рекомендация:** Использовать для маленьких тестовых случаев (< 10 строк).

---

## Оптимизация производительности

### Кеширование

Все данные должны кешироваться при первой загрузке:

```csharp
private static readonly ConcurrentDictionary<string, string> _articleCache = new();
private static readonly ConcurrentDictionary<string, ChunkModel[]> _expectedCache = new();
```

### Предварительная загрузка

Для интеграционных тестов можно предзагрузить все данные:

```csharp
[OneTimeSetUp]
public void LoadTestData()
{
    TestDataLoader.PreloadAll();
}
```

### Производительность тестов

✅ **Текущий подход (статические классы):** ~0ms загрузка  
✅ **Embedded Resources:** ~1-5ms загрузка (с кешированием ~0ms после первого)  
✅ **JSON файлы:** ~5-10ms загрузка + парсинг (с кешированием ~0ms после первого)

**Вывод:** Разница в производительности минимальна при использовании кеширования.

---

## Рекомендации

### Для текущего проекта

1. **Сохранить текущий подход** для маленьких тестовых случаев
2. **Мигрировать большие статьи** на Embedded Resources (`.md` файлы)
3. **Мигрировать ожидаемые результаты** на JSON файлы
4. **Создать `TestDataLoader`** для единого доступа к данным
5. **Добавить кеширование** для производительности

### Приоритет миграции

1. ✅ Высокий: Исправить баг в тесте (строка 704)
2. ✅ Высокий: Вынести большие статьи в отдельные файлы
3. ✅ Средний: Мигрировать ожидаемые результаты на JSON
4. ✅ Средний: Создать TestDataLoader
5. ✅ Низкий: Добавить поддержку YAML (если потребуется)

### Инструменты

- **JSON:** `System.Text.Json` (встроен в .NET)
- **Markdown:** Текущий подход (raw strings)
- **YAML:** `YamlDotNet` (если выберете YAML)

---

## Пример миграции

### До миграции (текущий подход)

```csharp
// ArticlesTestData.cs (3000+ строк)
internal static class ArticlesTestData
{
    internal const string DevToRealWorldArticleText = @"# Article
Very long article text...
...";
}
```

### После миграции

```csharp
// TestDataLoader.cs
public static class TestDataLoader
{
    public static string GetDevToArticle() => 
        LoadArticle("devto_article.md");
}

// TestData/Articles/devto_article.md
# Article
Very long article text...
...
```

**Преимущества:**
- ✅ Читаемость (подсветка синтаксиса в IDE)
- ✅ Легче редактировать
- ✅ Отделение данных от кода
- ✅ Версионирование

---

## Заключение

**Рекомендуемый формат:**
- ✅ **Гибридный подход** (статический код + файлы)
- ✅ **Embedded Resources** для больших статей
- ✅ **JSON** для ожидаемых результатов
- ✅ **Кеширование** для производительности

**Следующие шаги:**
1. Создать структуру директорий
2. Мигрировать большие статьи
3. Создать TestDataLoader
4. Обновить тесты для использования нового подхода

