using Sample.Chunkers.Models;
using Sample.Chunkers.Models.Enums;

namespace Sample.Chunkers.UnitTests.TestData;

internal static class TextChunkTestData
{
    // https://dev.to/alex_ricciardi/recursion-in-programming-techniques-benefits-and-limitations-java-3o4p
    internal static readonly ChunkModel[] DevToRealWorldArticleTextChunks = 
    [
        new ChunkModel
        {
            Index = 6,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>
            {
                ["content"] = "This article explains the concept of recursion in programming, where a function calls itself to solve smaller instances of a problem, and its applications in tasks like tree traversal and divide-and-conquer algorithms. It also discusses the benefits of recursion for simplifying complex problems and improving code readability, while highlighting potential issues like stack overflow.\n\n* * *\n\nIn computer science, recursion is an algorithmic technique in which a function calls itself to solve smaller instances of the same problem. In programming, recursion is an amazing technique with the help of which we can reduce the length of our code and make it easier to read and write” (GeeksforGeeks, 2024, p1). Recursion is used in programming to solve complex problems involving repetition and hierarchical structures such as tree traversals, graph algorithms, and divide-and-conquer problems like sorting and searching.\n\nThe basic components found in recursive functions are base cases and recursive cases. A base case is a condition that, when met, ends the recursion process (Ricciardi, 2024). A recursive case is a set of code lines that are executed until a base condition is met.\n\nA classic example where recursion is well suited is in computing the factorial of a number.",
            },
            RawContent = "This article explains the concept of recursion in programming, where a function calls itself to solve smaller instances of a problem, and its applications in tasks like tree traversal and divide-and-conquer algorithms. It also discusses the benefits of recursion for simplifying complex problems and improving code readability, while highlighting potential issues like stack overflow.\n\n* * *\n\nIn computer science, recursion is an algorithmic technique in which a function calls itself to solve smaller instances of the same problem. In programming, recursion is an amazing technique with the help of which we can reduce the length of our code and make it easier to read and write” (GeeksforGeeks, 2024, p1). Recursion is used in programming to solve complex problems involving repetition and hierarchical structures such as tree traversals, graph algorithms, and divide-and-conquer problems like sorting and searching.\n\nThe basic components found in recursive functions are base cases and recursive cases. A base case is a condition that, when met, ends the recursion process (Ricciardi, 2024). A recursive case is a set of code lines that are executed until a base condition is met.\n\nA classic example where recursion is well suited is in computing the factorial of a number.",
        },
        new ChunkModel
        {
            Index = 7,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedCodeBlock] = [CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[0].Index],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Recursion is used in programming to solve complex problems involving repetition and hierarchical structures such as tree traversals, graph algorithms, and divide-and-conquer problems like sorting and searching.\n\nThe basic components found in recursive functions are base cases and recursive cases. A base case is a condition that, when met, ends the recursion process (Ricciardi, 2024). A recursive case is a set of code lines that are executed until a base condition is met.\n\nA classic example where recursion is well suited is in computing the factorial of a number. A factorial can be defined as a non-negative integer 𝑛, denoted 𝑛!, the product of all positive integers less than or equal to 𝑛:\n\n𝑛! = 𝑛×(𝑛−1)!\n\nIn Java:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nNote that the factorial() method calls itself until it reaches the base case where 𝑛 = 0\n\nThere are various benefits to using recursion. One of the biggest benefits of using recursion is that it allows programmers to easily break down complex problems into simpler, more manageable subproblems.",
            },
            RawContent = "Recursion is used in programming to solve complex problems involving repetition and hierarchical structures such as tree traversals, graph algorithms, and divide-and-conquer problems like sorting and searching.\n\nThe basic components found in recursive functions are base cases and recursive cases. A base case is a condition that, when met, ends the recursion process (Ricciardi, 2024). A recursive case is a set of code lines that are executed until a base condition is met.\n\nA classic example where recursion is well suited is in computing the factorial of a number. A factorial can be defined as a non-negative integer 𝑛, denoted 𝑛!, the product of all positive integers less than or equal to 𝑛:\n\n𝑛! = 𝑛×(𝑛−1)!\n\nIn Java:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nNote that the factorial() method calls itself until it reaches the base case where 𝑛 = 0\n\nThere are various benefits to using recursion. One of the biggest benefits of using recursion is that it allows programmers to easily break down complex problems into simpler, more manageable subproblems.",
        },
        new ChunkModel
        {
            Index = 8,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedCodeBlock] = [CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[0].Index],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "A factorial can be defined as a non-negative integer 𝑛, denoted 𝑛!, the product of all positive integers less than or equal to 𝑛:\n\n𝑛! = 𝑛×(𝑛−1)!\n\nIn Java:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nNote that the factorial() method calls itself until it reaches the base case where 𝑛 = 0\n\nThere are various benefits to using recursion. One of the biggest benefits of using recursion is that it allows programmers to easily break down complex problems into simpler, more manageable subproblems. This approach is often referred to as the divide-and-conquer approach, it is implemented in algorithms like mergesort, where recursion divides a complex sort problem into smaller problems leading to a more efficient sort solution than the linear sort iterating solution. Additionally, recursion helps with code readability by simplifying and shortening code lines. When using recursion, programmers can write problems involving repetition or hierarchical structures (trees) without the need to implement complex loops. Recursion also simplifies, and it is efficient at handling dynamic and random data structures such as linked lists and tree structures. For instance, when traversing a binary tree, using recursion simplifies the implementation of the process without the need to implement a stack.\n\n",
            },
            RawContent = "A factorial can be defined as a non-negative integer 𝑛, denoted 𝑛!, the product of all positive integers less than or equal to 𝑛:\n\n𝑛! = 𝑛×(𝑛−1)!\n\nIn Java:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nNote that the factorial() method calls itself until it reaches the base case where 𝑛 = 0\n\nThere are various benefits to using recursion. One of the biggest benefits of using recursion is that it allows programmers to easily break down complex problems into simpler, more manageable subproblems. This approach is often referred to as the divide-and-conquer approach, it is implemented in algorithms like mergesort, where recursion divides a complex sort problem into smaller problems leading to a more efficient sort solution than the linear sort iterating solution. Additionally, recursion helps with code readability by simplifying and shortening code lines. When using recursion, programmers can write problems involving repetition or hierarchical structures (trees) without the need to implement complex loops. Recursion also simplifies, and it is efficient at handling dynamic and random data structures such as linked lists and tree structures. For instance, when traversing a binary tree, using recursion simplifies the implementation of the process without the need to implement a stack.\n\n",
        },
        new ChunkModel
        {
            Index = 9,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>
            {
                ["content"] = "This approach is often referred to as the divide-and-conquer approach, it is implemented in algorithms like mergesort, where recursion divides a complex sort problem into smaller problems leading to a more efficient sort solution than the linear sort iterating solution. Additionally, recursion helps with code readability by simplifying and shortening code lines. When using recursion, programmers can write problems involving repetition or hierarchical structures (trees) without the need to implement complex loops. Recursion also simplifies, and it is efficient at handling dynamic and random data structures such as linked lists and tree structures. For instance, when traversing a binary tree, using recursion simplifies the implementation of the process without the need to implement a stack.\n\nAlthough recursion has various advantages, in some scenarios using a stack is preferable over recursion. For example, recursion can generate a stack overflow error, ‘StackOverflowError ’, if the recursive depth (number of recursion calls) becomes too large. This can happen in cases like deep tree traversals or depth-first search algorithms, where the number of recursion calls may exceed the system’s call stack capacity. In Java, the limit of the call stack varies depending on the platform used and the Java Virtual Machine implemented.",
            },
            RawContent = "This approach is often referred to as the divide-and-conquer approach, it is implemented in algorithms like mergesort, where recursion divides a complex sort problem into smaller problems leading to a more efficient sort solution than the linear sort iterating solution. Additionally, recursion helps with code readability by simplifying and shortening code lines. When using recursion, programmers can write problems involving repetition or hierarchical structures (trees) without the need to implement complex loops. Recursion also simplifies, and it is efficient at handling dynamic and random data structures such as linked lists and tree structures. For instance, when traversing a binary tree, using recursion simplifies the implementation of the process without the need to implement a stack.\n\nAlthough recursion has various advantages, in some scenarios using a stack is preferable over recursion. For example, recursion can generate a stack overflow error, ‘StackOverflowError ’, if the recursive depth (number of recursion calls) becomes too large. This can happen in cases like deep tree traversals or depth-first search algorithms, where the number of recursion calls may exceed the system’s call stack capacity. In Java, the limit of the call stack varies depending on the platform used and the Java Virtual Machine implemented.",
        },
        new ChunkModel
        {
            Index = 10,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>
            {
                ["content"] = "For instance, when traversing a binary tree, using recursion simplifies the implementation of the process without the need to implement a stack.\n\nAlthough recursion has various advantages, in some scenarios using a stack is preferable over recursion. For example, recursion can generate a stack overflow error, ‘StackOverflowError ’, if the recursive depth (number of recursion calls) becomes too large. This can happen in cases like deep tree traversals or depth-first search algorithms, where the number of recursion calls may exceed the system’s call stack capacity. In Java, the limit of the call stack varies depending on the platform used and the Java Virtual Machine implemented. Java stack size can be configured using the JVM argument ‘-Xss’, for example ‘java -Xss1M MyProgram‘ where 1M is the size of the call back for MyProgram (Goodrich, Tamassia, & Goldwasser, 2023). It is best practice to use a stack or tail recursion, if possible, in this scenario.",
            },
            RawContent = "For instance, when traversing a binary tree, using recursion simplifies the implementation of the process without the need to implement a stack.\n\nAlthough recursion has various advantages, in some scenarios using a stack is preferable over recursion. For example, recursion can generate a stack overflow error, ‘StackOverflowError ’, if the recursive depth (number of recursion calls) becomes too large. This can happen in cases like deep tree traversals or depth-first search algorithms, where the number of recursion calls may exceed the system’s call stack capacity. In Java, the limit of the call stack varies depending on the platform used and the Java Virtual Machine implemented. Java stack size can be configured using the JVM argument ‘-Xss’, for example ‘java -Xss1M MyProgram‘ where 1M is the size of the call back for MyProgram (Goodrich, Tamassia, & Goldwasser, 2023). It is best practice to use a stack or tail recursion, if possible, in this scenario.",
        },
        new ChunkModel
        {
            Index = 11,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedCodeBlock] =
                [
                    CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[1].Index,
                    CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[2].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Java stack size can be configured using the JVM argument \u2018-Xss\u2019, for example \u2018java -Xss1M MyProgram\u2018 where 1M is the size of the call back for MyProgram (Goodrich, Tamassia, \u0026 Goldwasser, 2023). It is best practice to use a stack or tail recursion, if possible, in this scenario. \u201CA recursion is a tail recursion if any recursive call that is made from one context is the very last operation in that context, with the return value of the recursive call (if any) immediately returned by the enclosing recursion\u201D (Goodrich, Tamassia, \u0026 Goldwasser, 2023, 5.5 Eliminating tail recursion). Note that while some programming languages optimize tail-recursive functions, Java does not. Thus, in Java, an optimized tail-recursive function needs to be implemented implicitly.\n\nBelow are examples of implementing a depth-first search (DFS) traversal of a tree, using recursion with a possibility of \u2018StackOverflowError \u2019and a stack (Dequee) eliminating the possibility of a \u2018StackOverflowError \u2019:\n\nUsing recursion possibility of \u2018StackOverflowError\u2019:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nUsing the stack approach eliminating the possibility of a \u2018StackOverflowError\u2019:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nOutput:\n\n",
            },
            RawContent = "Java stack size can be configured using the JVM argument \u2018-Xss\u2019, for example \u2018java -Xss1M MyProgram\u2018 where 1M is the size of the call back for MyProgram (Goodrich, Tamassia, \u0026 Goldwasser, 2023). It is best practice to use a stack or tail recursion, if possible, in this scenario. \u201CA recursion is a tail recursion if any recursive call that is made from one context is the very last operation in that context, with the return value of the recursive call (if any) immediately returned by the enclosing recursion\u201D (Goodrich, Tamassia, \u0026 Goldwasser, 2023, 5.5 Eliminating tail recursion). Note that while some programming languages optimize tail-recursive functions, Java does not. Thus, in Java, an optimized tail-recursive function needs to be implemented implicitly.\n\nBelow are examples of implementing a depth-first search (DFS) traversal of a tree, using recursion with a possibility of \u2018StackOverflowError \u2019and a stack (Dequee) eliminating the possibility of a \u2018StackOverflowError \u2019:\n\nUsing recursion possibility of \u2018StackOverflowError\u2019:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nUsing the stack approach eliminating the possibility of a \u2018StackOverflowError\u2019:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nOutput:\n\n",
        },
        new ChunkModel
        {
            Index = 12,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedCodeBlock] = 
                [
                    CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[1].Index,
                    CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[2].Index,
                    CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[3].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Note that while some programming languages optimize tail-recursive functions, Java does not. Thus, in Java, an optimized tail-recursive function needs to be implemented implicitly.\n\nBelow are examples of implementing a depth-first search (DFS) traversal of a tree, using recursion with a possibility of ‘StackOverflowError ’and a stack (Dequee) eliminating the possibility of a ‘StackOverflowError ’:\n\nUsing recursion possibility of ‘StackOverflowError’:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nUsing the stack approach eliminating the possibility of a ‘StackOverflowError’:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nOutput:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nTo summarize, recursion is a technique in which a function calls itself to solve smaller instances of the same problem, it is often used in problems like tree traversal, graph algorithms, and divide-and-conquer strategies. While recursion simplifies complex problems and code readability, excessive recursive calls can lead to stack overflow errors, particularly in deeply nested structures such as trees, making iterative approaches using explicit stacks preferable in certain cases.\n\n* * *\n\n**References:**\n\nArslan, Ş. (2023, February 25). *A Comprehensive tree traversal guide in Javascript - General and binary tree traversals.* Shinar Arslan Blog. https://www.sahinarslan.tech/posts/a-comprehensive-tree-traversal-guide-in-javascript-general-and-binary-tree-traversals\n\nGeeksforGeeks (2024, August 18). *Introduction to recursion*. GeeksforGeeks.",
            },
            RawContent = "Note that while some programming languages optimize tail-recursive functions, Java does not. Thus, in Java, an optimized tail-recursive function needs to be implemented implicitly.\n\nBelow are examples of implementing a depth-first search (DFS) traversal of a tree, using recursion with a possibility of ‘StackOverflowError ’and a stack (Dequee) eliminating the possibility of a ‘StackOverflowError ’:\n\nUsing recursion possibility of ‘StackOverflowError’:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nUsing the stack approach eliminating the possibility of a ‘StackOverflowError’:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nOutput:\n\nEnter fullscreen mode\n\nExit fullscreen mode\n\nTo summarize, recursion is a technique in which a function calls itself to solve smaller instances of the same problem, it is often used in problems like tree traversal, graph algorithms, and divide-and-conquer strategies. While recursion simplifies complex problems and code readability, excessive recursive calls can lead to stack overflow errors, particularly in deeply nested structures such as trees, making iterative approaches using explicit stacks preferable in certain cases.\n\n* * *\n\n**References:**\n\nArslan, Ş. (2023, February 25). *A Comprehensive tree traversal guide in Javascript - General and binary tree traversals.* Shinar Arslan Blog. https://www.sahinarslan.tech/posts/a-comprehensive-tree-traversal-guide-in-javascript-general-and-binary-tree-traversals\n\nGeeksforGeeks (2024, August 18). *Introduction to recursion*. GeeksforGeeks.",
        },
        new ChunkModel
        {
            Index = 13,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedCodeBlock] =
                [
                    CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[3].Index,
                ],
                [RelationshipType.AdditionalLink] = [LinksTestData.DevToRealWorldArticleLinks[0].Index],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Enter fullscreen mode\n\nExit fullscreen mode\n\nTo summarize, recursion is a technique in which a function calls itself to solve smaller instances of the same problem, it is often used in problems like tree traversal, graph algorithms, and divide-and-conquer strategies. While recursion simplifies complex problems and code readability, excessive recursive calls can lead to stack overflow errors, particularly in deeply nested structures such as trees, making iterative approaches using explicit stacks preferable in certain cases.\n\n* * *\n\n**References:**\n\nArslan, \u015E. (2023, February 25). *A Comprehensive tree traversal guide in Javascript - General and binary tree traversals.* Shinar Arslan Blog. https://www.sahinarslan.tech/posts/a-comprehensive-tree-traversal-guide-in-javascript-general-and-binary-tree-traversals\n\nGeeksforGeeks (2024, August 18). *Introduction to recursion*. GeeksforGeeks. https://www.geeksforgeeks.org/introduction-to-recursion-2/Links to an external site\n\nGoodrich T, M., Tamassia, R., \u0026 Goldwasser H. M. (2023, June). Chapter 5: Algorithms recursion. *Data structures and algorithms*. zyBook ISBN: 979\u20138\u2013203\u201340813\u20136.\n\n* * *\n\nOriginally published at Alex.omegapy - Mediumon September 22, 2024.",
            },
            RawContent = "Enter fullscreen mode\n\nExit fullscreen mode\n\nTo summarize, recursion is a technique in which a function calls itself to solve smaller instances of the same problem, it is often used in problems like tree traversal, graph algorithms, and divide-and-conquer strategies. While recursion simplifies complex problems and code readability, excessive recursive calls can lead to stack overflow errors, particularly in deeply nested structures such as trees, making iterative approaches using explicit stacks preferable in certain cases.\n\n* * *\n\n**References:**\n\nArslan, \u015E. (2023, February 25). *A Comprehensive tree traversal guide in Javascript - General and binary tree traversals.* Shinar Arslan Blog. https://www.sahinarslan.tech/posts/a-comprehensive-tree-traversal-guide-in-javascript-general-and-binary-tree-traversals\n\nGeeksforGeeks (2024, August 18). *Introduction to recursion*. GeeksforGeeks. https://www.geeksforgeeks.org/introduction-to-recursion-2/Links to an external site\n\nGoodrich T, M., Tamassia, R., \u0026 Goldwasser H. M. (2023, June). Chapter 5: Algorithms recursion. *Data structures and algorithms*. zyBook ISBN: 979\u20138\u2013203\u201340813\u20136.\n\n* * *\n\nOriginally published at Alex.omegapy - Mediumon September 22, 2024.",
        },
    ];

    // https://www.geeksforgeeks.org/data-modeling-a-comprehensive-guide-for-analysts/
    internal static readonly ChunkModel[] GeeksForGeeksAboutDataModelingTextChunks =
    [
        new ChunkModel
        {
            Index = 33,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedImage] =
                [
                    ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[0].Index,
                    ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[1].Index,
                ],
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[0].Index,
                ],
                [RelationshipType.StartsWith] = 
                [
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[0].Index,
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[1].Index
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Last Updated :\n16 Jul, 2024\n\nComments\n\nImprove\n\n-\n-\n-\n\nSuggest changes\n\n5 Likes\n\nLike\n\nReport\n\nFollowData modelling is a fundamental component that facilitates the organisation, structuring, and interpretation of complicated datasets by analysts.\n\nIn this tutorial we'll dive into the field of data modelling, examining its importance, the procedures involved, and answering common queries.\n\nTable of Content\n\n- What is Data Modeling?\n- Types of Data Models\n- Data Modeling Process\n- Types of Data Modeling\n- Benefits of Data Modeling\n- Data Modeling - FAQs\n\nData modelling in analysis is the process of creating a visual representation , abstraction of data structures, relationships, and rules within a system or organization. Determining and analysing the data requirements required to support business activities within the bounds of related information systems in organisations is another process known as data modelling.\n\nThe main objective of data modelling is to provide a precise and well-organized framework for data organisation and representation, since it enables efficient analysis and decision-making. Analysts can discover trends, understand the connections between various data items, and make sure that data is efficiently and accurately stored by building models.\n\n",
            },
            RawContent = "Last Updated :\n16 Jul, 2024\n\nComments\n\nImprove\n\n-\n-\n-\n\nSuggest changes\n\n5 Likes\n\nLike\n\nReport\n\nFollowData modelling is a fundamental component that facilitates the organisation, structuring, and interpretation of complicated datasets by analysts.\n\nIn this tutorial we'll dive into the field of data modelling, examining its importance, the procedures involved, and answering common queries.\n\nTable of Content\n\n- What is Data Modeling?\n- Types of Data Models\n- Data Modeling Process\n- Types of Data Modeling\n- Benefits of Data Modeling\n- Data Modeling - FAQs\n\nData modelling in analysis is the process of creating a visual representation , abstraction of data structures, relationships, and rules within a system or organization. Determining and analysing the data requirements required to support business activities within the bounds of related information systems in organisations is another process known as data modelling.\n\nThe main objective of data modelling is to provide a precise and well-organized framework for data organisation and representation, since it enables efficient analysis and decision-making. Analysts can discover trends, understand the connections between various data items, and make sure that data is efficiently and accurately stored by building models.\n\n"
        },
        new ChunkModel
        {
            Index = 34,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedImage] =
                [
                    ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[2].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[2].Index,
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[3].Index
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Determining and analysing the data requirements required to support business activities within the bounds of related information systems in organisations is another process known as data modelling.\n\nThe main objective of data modelling is to provide a precise and well-organized framework for data organisation and representation, since it enables efficient analysis and decision-making. Analysts can discover trends, understand the connections between various data items, and make sure that data is efficiently and accurately stored by building models.\n\nData models are visual representations of an enterprise’s data elements and the connections between them. Models assist to define and arrange data in the context of key business processes, hence facilitating the creation of successful information systems. They let business and technical personnel to collaborate on how data will be kept, accessed, shared, updated, and utilised within an organisation.\n\nThere are three main types of data models:\n\n- **Conceptual Data Model**: Conceptual Data Model is a representations of data Examine and describe in depth your abstract, high-level business concepts and structures. They are most commonly employed when working through high-level concepts and preliminary needs at the start of a new project.",
            },
            RawContent = "Determining and analysing the data requirements required to support business activities within the bounds of related information systems in organisations is another process known as data modelling.\n\nThe main objective of data modelling is to provide a precise and well-organized framework for data organisation and representation, since it enables efficient analysis and decision-making. Analysts can discover trends, understand the connections between various data items, and make sure that data is efficiently and accurately stored by building models.\n\nData models are visual representations of an enterprise’s data elements and the connections between them. Models assist to define and arrange data in the context of key business processes, hence facilitating the creation of successful information systems. They let business and technical personnel to collaborate on how data will be kept, accessed, shared, updated, and utilised within an organisation.\n\nThere are three main types of data models:\n\n- **Conceptual Data Model**: Conceptual Data Model is a representations of data Examine and describe in depth your abstract, high-level business concepts and structures. They are most commonly employed when working through high-level concepts and preliminary needs at the start of a new project.",
        },
        new ChunkModel
        {
            Index = 35,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedImage] =
                [
                    ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[2].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[3].Index
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Models assist to define and arrange data in the context of key business processes, hence facilitating the creation of successful information systems. They let business and technical personnel to collaborate on how data will be kept, accessed, shared, updated, and utilised within an organisation.\n\nThere are three main types of data models:\n\n- **Conceptual Data Model**: Conceptual Data Model is a representations of data Examine and describe in depth your abstract, high-level business concepts and structures. They are most commonly employed when working through high-level concepts and preliminary needs at the start of a new project. They are typically developed as alternatives or preludes to the logical data models that come later.T he main purpose of this data model is to organize, define business problems , rules and concepts. For instance, it helps business people to view any data like market data, customer data, and purchase data.\n- **Logical Data Model**: In the logical data model, By offering a thorough representation of the data at a logical level, the logical data model expands on the conceptual model.",
            },
            RawContent = "Models assist to define and arrange data in the context of key business processes, hence facilitating the creation of successful information systems. They let business and technical personnel to collaborate on how data will be kept, accessed, shared, updated, and utilised within an organisation.\n\nThere are three main types of data models:\n\n- **Conceptual Data Model**: Conceptual Data Model is a representations of data Examine and describe in depth your abstract, high-level business concepts and structures. They are most commonly employed when working through high-level concepts and preliminary needs at the start of a new project. They are typically developed as alternatives or preludes to the logical data models that come later.T he main purpose of this data model is to organize, define business problems , rules and concepts. For instance, it helps business people to view any data like market data, customer data, and purchase data.\n- **Logical Data Model**: In the logical data model, By offering a thorough representation of the data at a logical level, the logical data model expands on the conceptual model.",
        },
        new ChunkModel
        {
            Index = 36,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[1].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "They are typically developed as alternatives or preludes to the logical data models that come later.T he main purpose of this data model is to organize, define business problems , rules and concepts. For instance, it helps business people to view any data like market data, customer data, and purchase data.\n- **Logical Data Model**: In the logical data model, By offering a thorough representation of the data at a logical level, the logical data model expands on the conceptual model. It outlines the tables, columns, connections, and constraints that make up thedata structure.Although logical data models are not dependant on any particular database management system (DBMS), they are more similar to how data would be implemented in a database. The physical design of databases is based on this idea.\n- **Physical Data Model**: In Physical Data model ,The implementation is explained with reference to a particular database system. It outlines every part and service needed to construct a database. It is made with queries and the database language. Every table, column, and constraint-such as primary key, foreign key, NOT NULL, etc.-is represented in the physical data model.",
            },
            RawContent = "They are typically developed as alternatives or preludes to the logical data models that come later.T he main purpose of this data model is to organize, define business problems , rules and concepts. For instance, it helps business people to view any data like market data, customer data, and purchase data.\n- **Logical Data Model**: In the logical data model, By offering a thorough representation of the data at a logical level, the logical data model expands on the conceptual model. It outlines the tables, columns, connections, and constraints that make up thedata structure.Although logical data models are not dependant on any particular database management system (DBMS), they are more similar to how data would be implemented in a database. The physical design of databases is based on this idea.\n- **Physical Data Model**: In Physical Data model ,The implementation is explained with reference to a particular database system. It outlines every part and service needed to construct a database. It is made with queries and the database language. Every table, column, and constraint-such as primary key, foreign key, NOT NULL, etc.-is represented in the physical data model.",
        },
        new ChunkModel
        {
            Index = 37,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[1].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[4].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "It outlines the tables, columns, connections, and constraints that make up thedata structure.Although logical data models are not dependant on any particular database management system (DBMS), they are more similar to how data would be implemented in a database. The physical design of databases is based on this idea.\n- **Physical Data Model**: In Physical Data model ,The implementation is explained with reference to a particular database system. It outlines every part and service needed to construct a database. It is made with queries and the database language. Every table, column, and constraint-such as primary key, foreign key, NOT NULL, etc.-is represented in the physical data model. The creation of a database is the primary task of the physical data model. Developers and database administrators (DBAs) designed this model. This kind of data modelling aids in the creation of the schema and provides us with an abstraction of the databases. This model explains how the data model is specifically implemented. Constraints, RDBMS features, and database column keys are made possible by the physical data model.\n\nThe practice of conceptually representing data items and their connections to one another is known as data modelling.",
            },
            RawContent = "It outlines the tables, columns, connections, and constraints that make up thedata structure.Although logical data models are not dependant on any particular database management system (DBMS), they are more similar to how data would be implemented in a database. The physical design of databases is based on this idea.\n- **Physical Data Model**: In Physical Data model ,The implementation is explained with reference to a particular database system. It outlines every part and service needed to construct a database. It is made with queries and the database language. Every table, column, and constraint-such as primary key, foreign key, NOT NULL, etc.-is represented in the physical data model. The creation of a database is the primary task of the physical data model. Developers and database administrators (DBAs) designed this model. This kind of data modelling aids in the creation of the schema and provides us with an abstraction of the databases. This model explains how the data model is specifically implemented. Constraints, RDBMS features, and database column keys are made possible by the physical data model.\n\nThe practice of conceptually representing data items and their connections to one another is known as data modelling.",
        },
        new ChunkModel
        {
            Index = 38,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[4].Index
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "The creation of a database is the primary task of the physical data model. Developers and database administrators (DBAs) designed this model. This kind of data modelling aids in the creation of the schema and provides us with an abstraction of the databases. This model explains how the data model is specifically implemented. Constraints, RDBMS features, and database column keys are made possible by the physical data model.\n\nThe practice of conceptually representing data items and their connections to one another is known as data modelling. Data modellers collaborate with stakeholders at each stage of the process to define entities and attributes, establish relationships between data objects, and create models that accurately represent the data in a format that can be consumed by applications. These stakeholders may include developers, database administrators, and other interested parties. Lets discuss the data modelling steps:\n\n1. **Identifying data sources**: The first stage is to identify and investigate the different sources of data both inside and outside the company. It's critical to comprehend the sources of the data and how various sources add to the information as a whole. Determining the sources of data is essential since it guarantees a thorough framework for data modelling.",
            },
            RawContent = "The creation of a database is the primary task of the physical data model. Developers and database administrators (DBAs) designed this model. This kind of data modelling aids in the creation of the schema and provides us with an abstraction of the databases. This model explains how the data model is specifically implemented. Constraints, RDBMS features, and database column keys are made possible by the physical data model.\n\nThe practice of conceptually representing data items and their connections to one another is known as data modelling. Data modellers collaborate with stakeholders at each stage of the process to define entities and attributes, establish relationships between data objects, and create models that accurately represent the data in a format that can be consumed by applications. These stakeholders may include developers, database administrators, and other interested parties. Lets discuss the data modelling steps:\n\n1. **Identifying data sources**: The first stage is to identify and investigate the different sources of data both inside and outside the company. It's critical to comprehend the sources of the data and how various sources add to the information as a whole. Determining the sources of data is essential since it guarantees a thorough framework for data modelling.",
        },
        new ChunkModel
        {
            Index = 39,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>
            {
                ["content"] = "Data modellers collaborate with stakeholders at each stage of the process to define entities and attributes, establish relationships between data objects, and create models that accurately represent the data in a format that can be consumed by applications. These stakeholders may include developers, database administrators, and other interested parties. Lets discuss the data modelling steps:\n\n1. **Identifying data sources**: The first stage is to identify and investigate the different sources of data both inside and outside the company. It's critical to comprehend the sources of the data and how various sources add to the information as a whole. Determining the sources of data is essential since it guarantees a thorough framework for data modelling. It assists in gathering all pertinent data, setting the stage for a precise and comprehensive depiction of the data landscape.\n2. **Defining Entities and Attributes**: This stage is all on identifying the entities (items or ideas) and the characteristics that go along with them. Entities constitute the subject matter of the data, whereas attributes specify the particular qualities of each entity. The foundation of data modelling is the definition of entities and characteristics.",
            },
            RawContent = "Data modellers collaborate with stakeholders at each stage of the process to define entities and attributes, establish relationships between data objects, and create models that accurately represent the data in a format that can be consumed by applications. These stakeholders may include developers, database administrators, and other interested parties. Lets discuss the data modelling steps:\n\n1. **Identifying data sources**: The first stage is to identify and investigate the different sources of data both inside and outside the company. It's critical to comprehend the sources of the data and how various sources add to the information as a whole. Determining the sources of data is essential since it guarantees a thorough framework for data modelling. It assists in gathering all pertinent data, setting the stage for a precise and comprehensive depiction of the data landscape.\n2. **Defining Entities and Attributes**: This stage is all on identifying the entities (items or ideas) and the characteristics that go along with them. Entities constitute the subject matter of the data, whereas attributes specify the particular qualities of each entity. The foundation of data modelling is the definition of entities and characteristics.",
        },
        new ChunkModel
        {
            Index = 40,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>
            {
                ["content"] = "Determining the sources of data is essential since it guarantees a thorough framework for data modelling. It assists in gathering all pertinent data, setting the stage for a precise and comprehensive depiction of the data landscape.\n2. **Defining Entities and Attributes**: This stage is all on identifying the entities (items or ideas) and the characteristics that go along with them. Entities constitute the subject matter of the data, whereas attributes specify the particular qualities of each entity. The foundation of data modelling is the definition of entities and characteristics. It offers an orderly and transparent framework, which is necessary to comprehend the characteristics of the data and create a useful model.\n3. **Mapping Relationships**: Relationships show the connections or associations between various things. Relationship mapping entails locating and characterising these linkages, indicating the nature and cardinality of every relationship. In order to capture the interdependencies within the data, it is essential to understand relationships. It improves the correctness of the model by capturing the relationships between various data pieces that exist in the real world.\n4. **Choosing a model Type**: The right data model type is selected based on the project needs and data properties.",
            },
            RawContent = "Determining the sources of data is essential since it guarantees a thorough framework for data modelling. It assists in gathering all pertinent data, setting the stage for a precise and comprehensive depiction of the data landscape.\n2. **Defining Entities and Attributes**: This stage is all on identifying the entities (items or ideas) and the characteristics that go along with them. Entities constitute the subject matter of the data, whereas attributes specify the particular qualities of each entity. The foundation of data modelling is the definition of entities and characteristics. It offers an orderly and transparent framework, which is necessary to comprehend the characteristics of the data and create a useful model.\n3. **Mapping Relationships**: Relationships show the connections or associations between various things. Relationship mapping entails locating and characterising these linkages, indicating the nature and cardinality of every relationship. In order to capture the interdependencies within the data, it is essential to understand relationships. It improves the correctness of the model by capturing the relationships between various data pieces that exist in the real world.\n4. **Choosing a model Type**: The right data model type is selected based on the project needs and data properties.",
        },
        new ChunkModel
        {
            Index = 41,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[2].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[3].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "It offers an orderly and transparent framework, which is necessary to comprehend the characteristics of the data and create a useful model.\n3. **Mapping Relationships**: Relationships show the connections or associations between various things. Relationship mapping entails locating and characterising these linkages, indicating the nature and cardinality of every relationship. In order to capture the interdependencies within the data, it is essential to understand relationships. It improves the correctness of the model by capturing the relationships between various data pieces that exist in the real world.\n4. **Choosing a model Type**: The right data model type is selected based on the project needs and data properties. Choosing between conceptual, logical, or physical models, or going with a particular model like relational or object-oriented, may be part of this decision. The degree of abstraction and detail in the representation is determined by the model type that is selected. It guarantees adherence to project objectives and facilitates thedevelopmentof a model appropriate for the data type.\n5. **Implementing and Maintaining**: The process of implementation converts a physical or logical data model into adatabase schema.This entails establishing constraints, generating tables, and adding database-specific information.",
            },
            RawContent = "It offers an orderly and transparent framework, which is necessary to comprehend the characteristics of the data and create a useful model.\n3. **Mapping Relationships**: Relationships show the connections or associations between various things. Relationship mapping entails locating and characterising these linkages, indicating the nature and cardinality of every relationship. In order to capture the interdependencies within the data, it is essential to understand relationships. It improves the correctness of the model by capturing the relationships between various data pieces that exist in the real world.\n4. **Choosing a model Type**: The right data model type is selected based on the project needs and data properties. Choosing between conceptual, logical, or physical models, or going with a particular model like relational or object-oriented, may be part of this decision. The degree of abstraction and detail in the representation is determined by the model type that is selected. It guarantees adherence to project objectives and facilitates thedevelopmentof a model appropriate for the data type.\n5. **Implementing and Maintaining**: The process of implementation converts a physical or logical data model into adatabase schema.This entails establishing constraints, generating tables, and adding database-specific information.",
        },
        new ChunkModel
        {
            Index = 42,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[2].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[3].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[4].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[5].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Choosing between conceptual, logical, or physical models, or going with a particular model like relational or object-oriented, may be part of this decision. The degree of abstraction and detail in the representation is determined by the model type that is selected. It guarantees adherence to project objectives and facilitates thedevelopmentof a model appropriate for the data type.\n5. **Implementing and Maintaining**: The process of implementation converts a physical or logical data model into adatabase schema.This entails establishing constraints, generating tables, and adding database-specific information. Updating the model to account for shifting technological or commercial needs is called maintenance. Significance: The theoretical model becomes a useful database upon implementation. Frequent upkeep guarantees that the model stays current and accurate, allowing it to adjust to the changing requirements of the company.\n\nThese are the 5 different types of data models:\n\n**Hierarchical Model**: The structure of the hierarchical model resembles atree.The remaining child nodes are arranged in a certain sequence, and there is only one root node-or, alternatively, one parent node. However, the hierarchical approach is no longer widely applied. approach connections in the actual world may be modelled using this approach.\n\n",
            },
            RawContent = "Choosing between conceptual, logical, or physical models, or going with a particular model like relational or object-oriented, may be part of this decision. The degree of abstraction and detail in the representation is determined by the model type that is selected. It guarantees adherence to project objectives and facilitates thedevelopmentof a model appropriate for the data type.\n5. **Implementing and Maintaining**: The process of implementation converts a physical or logical data model into adatabase schema.This entails establishing constraints, generating tables, and adding database-specific information. Updating the model to account for shifting technological or commercial needs is called maintenance. Significance: The theoretical model becomes a useful database upon implementation. Frequent upkeep guarantees that the model stays current and accurate, allowing it to adjust to the changing requirements of the company.\n\nThese are the 5 different types of data models:\n\n**Hierarchical Model**: The structure of the hierarchical model resembles atree.The remaining child nodes are arranged in a certain sequence, and there is only one root node-or, alternatively, one parent node. However, the hierarchical approach is no longer widely applied. approach connections in the actual world may be modelled using this approach.\n\n",
        },
        new ChunkModel
        {
            Index = 43,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedImage] =
                [
                    ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[3].Index
                ],
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[4].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[5].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[5].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Significance: The theoretical model becomes a useful database upon implementation. Frequent upkeep guarantees that the model stays current and accurate, allowing it to adjust to the changing requirements of the company.\n\nThese are the 5 different types of data models:\n\n**Hierarchical Model**: The structure of the hierarchical model resembles atree.The remaining child nodes are arranged in a certain sequence, and there is only one root node-or, alternatively, one parent node. However, the hierarchical approach is no longer widely applied. approach connections in the actual world may be modelled using this approach.\n\nFor Example , For example, in a college there are many courses, many professors and students. So college became a parent and professors and students became its children.\n\n**Relational Model** :Relational Mode represent the links between tables by representing data as rows and columns in tables. It is frequently utilised indatabase designand is strongly related to relational database management systems (RDBMS).\n\n**Object-Oriented Data Model**: In this model, data is represented as objects, similar to those used in object-oriented programming ,Creating objects with stored values is the object-oriented method. In addition to allowing data abstraction, inheritance, and encapsulation, the object-oriented architecture facilitates communication.\n\n",
            },
            RawContent = "Significance: The theoretical model becomes a useful database upon implementation. Frequent upkeep guarantees that the model stays current and accurate, allowing it to adjust to the changing requirements of the company.\n\nThese are the 5 different types of data models:\n\n**Hierarchical Model**: The structure of the hierarchical model resembles atree.The remaining child nodes are arranged in a certain sequence, and there is only one root node-or, alternatively, one parent node. However, the hierarchical approach is no longer widely applied. approach connections in the actual world may be modelled using this approach.\n\nFor Example , For example, in a college there are many courses, many professors and students. So college became a parent and professors and students became its children.\n\n**Relational Model** :Relational Mode represent the links between tables by representing data as rows and columns in tables. It is frequently utilised indatabase designand is strongly related to relational database management systems (RDBMS).\n\n**Object-Oriented Data Model**: In this model, data is represented as objects, similar to those used in object-oriented programming ,Creating objects with stored values is the object-oriented method. In addition to allowing data abstraction, inheritance, and encapsulation, the object-oriented architecture facilitates communication.\n\n",
        },
        new ChunkModel
        {
            Index = 44,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedImage] =
                [
                    ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[3].Index
                ],
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[5].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[6].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[7].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "So college became a parent and professors and students became its children.\n\n**Relational Model** :Relational Mode represent the links between tables by representing data as rows and columns in tables. It is frequently utilised indatabase designand is strongly related to relational database management systems (RDBMS).\n\n**Object-Oriented Data Model**: In this model, data is represented as objects, similar to those used in object-oriented programming ,Creating objects with stored values is the object-oriented method. In addition to allowing data abstraction, inheritance, and encapsulation, the object-oriented architecture facilitates communication.\n\n**Network Model** :We have a versatile approach to represent objects and the relationships among these things thanks to the network model. One of its features is a schema, which is a graph representation of the data. An item is stored within a node, and the relationship between them is represented as an edge. This allows them to generalise the maintenance of many parent and child records.\n\n**ER-Model**: A high-levelrelational modelcalled the entity-relationship model (ER model)is used to specify the data pieces and relationships between the entities in a system. This conceptual design gives us an easier-to-understand perspective on the facts.",
            },
            RawContent = "So college became a parent and professors and students became its children.\n\n**Relational Model** :Relational Mode represent the links between tables by representing data as rows and columns in tables. It is frequently utilised indatabase designand is strongly related to relational database management systems (RDBMS).\n\n**Object-Oriented Data Model**: In this model, data is represented as objects, similar to those used in object-oriented programming ,Creating objects with stored values is the object-oriented method. In addition to allowing data abstraction, inheritance, and encapsulation, the object-oriented architecture facilitates communication.\n\n**Network Model** :We have a versatile approach to represent objects and the relationships among these things thanks to the network model. One of its features is a schema, which is a graph representation of the data. An item is stored within a node, and the relationship between them is represented as an edge. This allows them to generalise the maintenance of many parent and child records.\n\n**ER-Model**: A high-levelrelational modelcalled the entity-relationship model (ER model)is used to specify the data pieces and relationships between the entities in a system. This conceptual design gives us an easier-to-understand perspective on the facts.",
        },
        new ChunkModel
        {
            Index = 45,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[6].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[7].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[6].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "One of its features is a schema, which is a graph representation of the data. An item is stored within a node, and the relationship between them is represented as an edge. This allows them to generalise the maintenance of many parent and child records.\n\n**ER-Model**: A high-levelrelational modelcalled the entity-relationship model (ER model)is used to specify the data pieces and relationships between the entities in a system. This conceptual design gives us an easier-to-understand perspective on the facts. An entity-relationship diagram, which is made up of entities, attributes, and relationships, is used in this model to depict the whole database.\n\nA relationship between entities is called an association. Mapping cardinality many associations like:\n\n- one to one\n- one to many\n- many to one\n- many to many\n\nIn order to organise and structure data and provide database design clarity, data modelling is essential. It acts as a common language, promoting efficient stakeholder communication. It directs the best database architecture for effective data storage and retrieval through visual representation.\n\n- Visualizes complex data structures, providing a clear roadmap for understanding relationships.\n- Acts as a universal language, fostering effective communication between business and technical stakeholders.\n",
            },
            RawContent = "One of its features is a schema, which is a graph representation of the data. An item is stored within a node, and the relationship between them is represented as an edge. This allows them to generalise the maintenance of many parent and child records.\n\n**ER-Model**: A high-levelrelational modelcalled the entity-relationship model (ER model)is used to specify the data pieces and relationships between the entities in a system. This conceptual design gives us an easier-to-understand perspective on the facts. An entity-relationship diagram, which is made up of entities, attributes, and relationships, is used in this model to depict the whole database.\n\nA relationship between entities is called an association. Mapping cardinality many associations like:\n\n- one to one\n- one to many\n- many to one\n- many to many\n\nIn order to organise and structure data and provide database design clarity, data modelling is essential. It acts as a common language, promoting efficient stakeholder communication. It directs the best database architecture for effective data storage and retrieval through visual representation.\n\n- Visualizes complex data structures, providing a clear roadmap for understanding relationships.\n- Acts as a universal language, fostering effective communication between business and technical stakeholders.\n",
        },
        new ChunkModel
        {
            Index = 46,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[8].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[9].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[10].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[6].Index,
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[7].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "A relationship between entities is called an association. Mapping cardinality many associations like:\n\n- one to one\n- one to many\n- many to one\n- many to many\n\nIn order to organise and structure data and provide database design clarity, data modelling is essential. It acts as a common language, promoting efficient stakeholder communication. It directs the best database architecture for effective data storage and retrieval through visual representation.\n\n- Visualizes complex data structures, providing a clear roadmap for understanding relationships.\n- Acts as a universal language, fostering effective communication between business and technical stakeholders.\n- Creates organized databases by defining entities, properties, and relationships.\n- Enhances data quality andintegrityby reducing anomalies and redundancy throughnormalization.- Minimizes errors in database and application development.\n- Ensures consistency in documentation and system designs across the organization.\n- Improves database and application performance.\n- Facilitates quick correlation of data across the company.\n- Strengthens communication between business intelligence and development teams.\n\nIn conclusion,Data modelling is an essential component ofdata analysisthat offers a methodical way to arrange and comprehend intricate facts. Analysts may create reliable models that improve insights and decision-making by adhering to the process's specified phases.\n\n",
            },
            RawContent = "A relationship between entities is called an association. Mapping cardinality many associations like:\n\n- one to one\n- one to many\n- many to one\n- many to many\n\nIn order to organise and structure data and provide database design clarity, data modelling is essential. It acts as a common language, promoting efficient stakeholder communication. It directs the best database architecture for effective data storage and retrieval through visual representation.\n\n- Visualizes complex data structures, providing a clear roadmap for understanding relationships.\n- Acts as a universal language, fostering effective communication between business and technical stakeholders.\n- Creates organized databases by defining entities, properties, and relationships.\n- Enhances data quality andintegrityby reducing anomalies and redundancy throughnormalization.- Minimizes errors in database and application development.\n- Ensures consistency in documentation and system designs across the organization.\n- Improves database and application performance.\n- Facilitates quick correlation of data across the company.\n- Strengthens communication between business intelligence and development teams.\n\nIn conclusion,Data modelling is an essential component ofdata analysisthat offers a methodical way to arrange and comprehend intricate facts. Analysts may create reliable models that improve insights and decision-making by adhering to the process's specified phases.\n\n",
        },
        new ChunkModel
        {
            Index = 47,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedImage] =
                [
                    ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[0].Index,
                ],
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[8].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[9].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[10].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[11].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[12].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[13].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[14].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[15].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[16].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[17].Index,
                    LinksTestData.GeeksForGeeksAboutDataModelingLinks[18].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[7].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "- Creates organized databases by defining entities, properties, and relationships.\n- Enhances data quality andintegrityby reducing anomalies and redundancy throughnormalization.- Minimizes errors in database and application development.\n- Ensures consistency in documentation and system designs across the organization.\n- Improves database and application performance.\n- Facilitates quick correlation of data across the company.\n- Strengthens communication between business intelligence and development teams.\n\nIn conclusion,Data modelling is an essential component ofdata analysisthat offers a methodical way to arrange and comprehend intricate facts. Analysts may create reliable models that improve insights and decision-making by adhering to the process's specified phases.\n\nComment\n\nMore info\n\nAdvertise with usNext ArticleWhat are the Advantages and Disadvantages of Random Forest?Rrahulpawar_7Follow\n\n5\n\nImprove\n\nArticle Tags :\n\n- Data Analysis- AI-ML-DS",
            },
            RawContent = "- Creates organized databases by defining entities, properties, and relationships.\n- Enhances data quality andintegrityby reducing anomalies and redundancy throughnormalization.- Minimizes errors in database and application development.\n- Ensures consistency in documentation and system designs across the organization.\n- Improves database and application performance.\n- Facilitates quick correlation of data across the company.\n- Strengthens communication between business intelligence and development teams.\n\nIn conclusion,Data modelling is an essential component ofdata analysisthat offers a methodical way to arrange and comprehend intricate facts. Analysts may create reliable models that improve insights and decision-making by adhering to the process's specified phases.\n\nComment\n\nMore info\n\nAdvertise with usNext ArticleWhat are the Advantages and Disadvantages of Random Forest?Rrahulpawar_7Follow\n\n5\n\nImprove\n\nArticle Tags :\n\n- Data Analysis- AI-ML-DS",
        },
    ];

    // https://www.geeksforgeeks.org/basic-operators-in-relational-algebra-2/
    internal static readonly ChunkModel[] GeeksForGeeksAboutRelationalAlgebraTextChunks =
    [
        new ChunkModel
        {
            Index = 47,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedCodeBlock] =
                [
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[0].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[1].Index,
                ],
                [RelationshipType.RelatedTable] =
                [
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[0].Index,
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[1].Index,
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[2].Index,
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[3].Index,
                ],
                [RelationshipType.RelatedImage] =
                [
                    ImageLinksTestData.GeeksForGeeksAboutRelationalAlgebraImageLinks[0].Index,
                ],
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[0].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[1].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[0].Index,
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[1].Index,
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[2].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Last Updated :\n19 Sep, 2024\n\nComments\n\nImprove\n\n-\n-\n-\n\nSuggest changes\n\n75 Likes\n\nLike\n\nReport\n\nFollowThe Relational Model is a way of structuring data using relations, which are a collection of tuples that have the same attributes. Relational Algebra is a procedural query language that takes relations as input and returns relations as output. It uses a set of operators to manipulate and retrieve data from these relations. Here, we\u2019ll explore the basic operators of Relational Algebra using the STUDENT\\_SPORTS, EMPLOYEE, and STUDENT relations from Table 1, Table 2, and Table 3, respectively.\n\n**Table 1: STUDENT\\_SPORTS**\n\n**Table 2: EMPLOYEE**\n\n**Table 3: STUDENT**\n\nSelection operator is used to selecting tuples from a relation based on some condition. Syntax:\n\nExtract students whose age is greater than 18 from STUDENT relation given in Table 3\n\n**Note:** [SELECT operationdoes not show any result, the projection operator must be called before the selection operator to generate or project the result. So, the correct syntax to generate the result is**:** \u220F(**\u03C3** (AGE\u0026gt;18)(STUDENT))]\n\n**RESULT:**\n\nProjection operator is used to project particular columns from a relation. Syntax:\n\n",
            },
            RawContent = "Last Updated :\n19 Sep, 2024\n\nComments\n\nImprove\n\n-\n-\n-\n\nSuggest changes\n\n75 Likes\n\nLike\n\nReport\n\nFollowThe Relational Model is a way of structuring data using relations, which are a collection of tuples that have the same attributes. Relational Algebra is a procedural query language that takes relations as input and returns relations as output. It uses a set of operators to manipulate and retrieve data from these relations. Here, we\u2019ll explore the basic operators of Relational Algebra using the STUDENT\\_SPORTS, EMPLOYEE, and STUDENT relations from Table 1, Table 2, and Table 3, respectively.\n\n**Table 1: STUDENT\\_SPORTS**\n\n**Table 2: EMPLOYEE**\n\n**Table 3: STUDENT**\n\nSelection operator is used to selecting tuples from a relation based on some condition. Syntax:\n\nExtract students whose age is greater than 18 from STUDENT relation given in Table 3\n\n**Note:** [SELECT operationdoes not show any result, the projection operator must be called before the selection operator to generate or project the result. So, the correct syntax to generate the result is**:** \u220F(**\u03C3** (AGE\u0026gt;18)(STUDENT))]\n\n**RESULT:**\n\nProjection operator is used to project particular columns from a relation. Syntax:\n\n"
        },
        new ChunkModel
        {
            Index = 48,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedCodeBlock] =
                [
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[0].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[1].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[2].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[3].Index,
                ],
                [RelationshipType.RelatedTable] = 
                [
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[0].Index,
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[1].Index,
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[2].Index,
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[3].Index,
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[4].Index,
                ],
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[1].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[1].Index,
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[2].Index,
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[3].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "**Table 1: STUDENT\\_SPORTS**\n\n**Table 2: EMPLOYEE**\n\n**Table 3: STUDENT**\n\nSelection operator is used to selecting tuples from a relation based on some condition. Syntax:\n\nExtract students whose age is greater than 18 from STUDENT relation given in Table 3\n\n**Note:** [SELECT operationdoes not show any result, the projection operator must be called before the selection operator to generate or project the result. So, the correct syntax to generate the result is**:** \u220F(**\u03C3** (AGE\u0026gt;18)(STUDENT))]\n\n**RESULT:**\n\nProjection operator is used to project particular columns from a relation. Syntax:\n\nExtract ROLL\\_NO and NAME from STUDENT relation given in Table 3\n\n**RESULT:**\n\n**Note:** If the resultant relation after projection has duplicate rows, it will be removed. For Example **\u220F**(ADDRESS)(STUDENT) will remove one duplicate row with the value DELHI and return three rows.\n\nCross product is used to join two relations. For every row of Relation1, each row of Relation2 is concatenated. If Relation1 has m tuples and and Relation2 has n tuples, cross product of Relation1 and Relation2 will have m X n tuples. Syntax:\n\n",
            },
            RawContent = "**Table 1: STUDENT\\_SPORTS**\n\n**Table 2: EMPLOYEE**\n\n**Table 3: STUDENT**\n\nSelection operator is used to selecting tuples from a relation based on some condition. Syntax:\n\nExtract students whose age is greater than 18 from STUDENT relation given in Table 3\n\n**Note:** [SELECT operationdoes not show any result, the projection operator must be called before the selection operator to generate or project the result. So, the correct syntax to generate the result is**:** \u220F(**\u03C3** (AGE\u0026gt;18)(STUDENT))]\n\n**RESULT:**\n\nProjection operator is used to project particular columns from a relation. Syntax:\n\nExtract ROLL\\_NO and NAME from STUDENT relation given in Table 3\n\n**RESULT:**\n\n**Note:** If the resultant relation after projection has duplicate rows, it will be removed. For Example **\u220F**(ADDRESS)(STUDENT) will remove one duplicate row with the value DELHI and return three rows.\n\nCross product is used to join two relations. For every row of Relation1, each row of Relation2 is concatenated. If Relation1 has m tuples and and Relation2 has n tuples, cross product of Relation1 and Relation2 will have m X n tuples. Syntax:\n\n",
        },
        new ChunkModel
        {
            Index = 49,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedCodeBlock] =
                [
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[4].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[5].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[6].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[7].Index,
                ],
                [RelationshipType.RelatedTable] = 
                [
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[5].Index,
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[6].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[3].Index,
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[4].Index,
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[5].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "For Example **∏**(ADDRESS)(STUDENT) will remove one duplicate row with the value DELHI and return three rows.\n\nCross product is used to join two relations. For every row of Relation1, each row of Relation2 is concatenated. If Relation1 has m tuples and and Relation2 has n tuples, cross product of Relation1 and Relation2 will have m X n tuples. Syntax:\n\nTo apply Cross Product on STUDENT relation given in Table 1 and STUDENT\\_SPORTS relation given in Table 2,\n\n**RESULT:**\n\nUnion on two relations R1 and R2 can only be computed if R1 and R2 are **union compatible** (These two relations should have the same number of attributes and corresponding attributes in two relations have the same domain). Union operator when applied on two relations R1 and R2 will give a relation with tuples that are either in R1 or in R2. The tuples which are in both R1 and R2 will appear only once in the result relation. Syntax:\n\nFind the person who is either student or employees, we can use Union operators like:\n\n**RESULT:**\n\nMinus on two relations R1 and R2 can only be computed if R1 and R2 are **union compatible**.",
            },
            RawContent = "For Example **∏**(ADDRESS)(STUDENT) will remove one duplicate row with the value DELHI and return three rows.\n\nCross product is used to join two relations. For every row of Relation1, each row of Relation2 is concatenated. If Relation1 has m tuples and and Relation2 has n tuples, cross product of Relation1 and Relation2 will have m X n tuples. Syntax:\n\nTo apply Cross Product on STUDENT relation given in Table 1 and STUDENT\\_SPORTS relation given in Table 2,\n\n**RESULT:**\n\nUnion on two relations R1 and R2 can only be computed if R1 and R2 are **union compatible** (These two relations should have the same number of attributes and corresponding attributes in two relations have the same domain). Union operator when applied on two relations R1 and R2 will give a relation with tuples that are either in R1 or in R2. The tuples which are in both R1 and R2 will appear only once in the result relation. Syntax:\n\nFind the person who is either student or employees, we can use Union operators like:\n\n**RESULT:**\n\nMinus on two relations R1 and R2 can only be computed if R1 and R2 are **union compatible**.",
        },
        new ChunkModel
        {
            Index = 50,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedCodeBlock] =
                [
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[6].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[7].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[8].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[9].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[10].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[11].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[12].Index,
                ],
                [RelationshipType.RelatedTable] = 
                [
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[6].Index,
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[7].Index,
                ],
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[2].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[3].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[5].Index,
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[6].Index,
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[7].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Union operator when applied on two relations R1 and R2 will give a relation with tuples that are either in R1 or in R2. The tuples which are in both R1 and R2 will appear only once in the result relation. Syntax:\n\nFind the person who is either student or employees, we can use Union operators like:\n\n**RESULT:**\n\nMinus on two relations R1 and R2 can only be computed if R1 and R2 are **union compatible**. Minus operator when applied on two relations as R1-R2 will give a relation with tuples that are in R1 but not in R2. Syntax:\n\nFind the person who is a student but not an employee, we can use minus operator like:\n\n**RESULT:**\n\nRename operatoris used to giving another name to a relation. Syntax:\n\nTo rename STUDENT relation to STUDENT1, we can use rename operator like:\n\nIf you want to create a relation STUDENT\\_NAMES with ROLL\\_NO and NAME from STUDENT, it can be done using rename operator as:\n\n- Intersection (∩)\n- Division (÷)\n- Join Operations (⋈)\n- Natural Join- Theta Join\n- Equi Join\n\nThese operators provide more functionality for complex queries in relational databases.\n\n",
            },
            RawContent = "Union operator when applied on two relations R1 and R2 will give a relation with tuples that are either in R1 or in R2. The tuples which are in both R1 and R2 will appear only once in the result relation. Syntax:\n\nFind the person who is either student or employees, we can use Union operators like:\n\n**RESULT:**\n\nMinus on two relations R1 and R2 can only be computed if R1 and R2 are **union compatible**. Minus operator when applied on two relations as R1-R2 will give a relation with tuples that are in R1 but not in R2. Syntax:\n\nFind the person who is a student but not an employee, we can use minus operator like:\n\n**RESULT:**\n\nRename operatoris used to giving another name to a relation. Syntax:\n\nTo rename STUDENT relation to STUDENT1, we can use rename operator like:\n\nIf you want to create a relation STUDENT\\_NAMES with ROLL\\_NO and NAME from STUDENT, it can be done using rename operator as:\n\n- Intersection (∩)\n- Division (÷)\n- Join Operations (⋈)\n- Natural Join- Theta Join\n- Equi Join\n\nThese operators provide more functionality for complex queries in relational databases.\n\n",
        },
        new ChunkModel
        {
            Index = 51,
            ChunkType = ChunkType.TextChunk,
            RelatedChunksIndexes = new()
            {
                [RelationshipType.RelatedCodeBlock] =
                [
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[8].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[9].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[10].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[11].Index,
                    CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[12].Index,
                ],
                [RelationshipType.RelatedTable] = 
                [
                    TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[7].Index,
                ],
                [RelationshipType.RelatedImage] =
                [
                    ImageLinksTestData.GeeksForGeeksAboutRelationalAlgebraImageLinks[0].Index,
                    ImageLinksTestData.GeeksForGeeksAboutRelationalAlgebraImageLinks[1].Index,
                ],
                [RelationshipType.AdditionalLink] =
                [
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[2].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[3].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[4].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[5].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[6].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[7].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[8].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[9].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[10].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[11].Index,
                    LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[12].Index,
                ],
                [RelationshipType.StartsWith] =
                [
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[6].Index,
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[7].Index,
                    HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[8].Index,
                ],
            },
            Data = new Dictionary<string, object>
            {
                ["content"] = "Find the person who is a student but not an employee, we can use minus operator like:\n\n**RESULT:**\n\nRename operatoris used to giving another name to a relation. Syntax:\n\nTo rename STUDENT relation to STUDENT1, we can use rename operator like:\n\nIf you want to create a relation STUDENT\\_NAMES with ROLL\\_NO and NAME from STUDENT, it can be done using rename operator as:\n\n- Intersection (\u2229)\n- Division (\u00F7)\n- Join Operations (\u22C8)\n- Natural Join- Theta Join\n- Equi Join\n\nThese operators provide more functionality for complex queries in relational databases.\n\nRelational Algebraprovides a fundamental toolkit for querying and manipulating relations in a database. It offers a set of operators that allow users to perform basic operations like selection, projection, union, and more. Understanding these operators is essential for working with relational databases and forms the basis for more advanced SQLoperations.\n\nComment\n\nMore info\n\nAdvertise with usNext ArticleExtended Operators in Relational AlgebraGeeksforGeeks\n\n75\n\nImprove\n\nArticle Tags :\n\n- DBMS- DBMS-Relational Algebra",
            },
            RawContent = "Find the person who is a student but not an employee, we can use minus operator like:\n\n**RESULT:**\n\nRename operatoris used to giving another name to a relation. Syntax:\n\nTo rename STUDENT relation to STUDENT1, we can use rename operator like:\n\nIf you want to create a relation STUDENT\\_NAMES with ROLL\\_NO and NAME from STUDENT, it can be done using rename operator as:\n\n- Intersection (\u2229)\n- Division (\u00F7)\n- Join Operations (\u22C8)\n- Natural Join- Theta Join\n- Equi Join\n\nThese operators provide more functionality for complex queries in relational databases.\n\nRelational Algebraprovides a fundamental toolkit for querying and manipulating relations in a database. It offers a set of operators that allow users to perform basic operations like selection, projection, union, and more. Understanding these operators is essential for working with relational databases and forms the basis for more advanced SQLoperations.\n\nComment\n\nMore info\n\nAdvertise with usNext ArticleExtended Operators in Relational AlgebraGeeksforGeeks\n\n75\n\nImprove\n\nArticle Tags :\n\n- DBMS- DBMS-Relational Algebra",
        },
    ];
}
