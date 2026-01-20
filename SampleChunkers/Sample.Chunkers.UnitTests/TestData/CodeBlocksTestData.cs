using Sample.Chunkers.Models;
using Sample.Chunkers.Models.Enums;

namespace Sample.Chunkers.UnitTests.TestData;

internal static class CodeBlocksTestData
{
    // https://www.geeksforgeeks.org/if-statement-in-programming/
    internal static readonly ChunkModel[] ArticleWithUnusualCodeBlocks =
    [
        new ChunkModel
        {
            Index = 1,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
x is positive
```",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"```
x is positive
```",
            },
        },
        new ChunkModel
        {
            Index = 2,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
x is positive
```",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"```
x is positive
```",
            },
        },
        new ChunkModel
        {
            Index = 3,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
x is positive
```",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"```
x is positive
```",
            },
        },
        new ChunkModel
        {
            Index = 4,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
x is positive
```",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"```
x is positive
```",
            },
        },
        new ChunkModel
        {
            Index = 5,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
x is positive
```",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"```
x is positive
```",
            },
        },
        new ChunkModel
        {
            Index = 6,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
x is positive
```",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"```
x is positive
```",
            },
        },
        new ChunkModel
        {
            Index = 7,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
a is not equal to b
a is less than b
a is less than or equal to b
```",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"```
a is not equal to b
a is less than b
a is less than or equal to b
```",
            },
        },
        new ChunkModel
        {
            Index = 8,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`if (condition) {
  // Code to execute if condition is true
}
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`if (condition) {
  // Code to execute if condition is true
}
`",
            },
        },
        new ChunkModel
        {
            Index = 9,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`#include <stdio.h>

int main()
{
    int x = 5;
    if (x > 0) {
        printf(""x is positive\n"");
    }

    return 0;
}
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`#include <stdio.h>

int main()
{
    int x = 5;
    if (x > 0) {
        printf(""x is positive\n"");
    }

    return 0;
}
`",
            },
        },
        new ChunkModel
        {
            Index = 10,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`#include <iostream>

using namespace std;

int main()
{
    int x = 5;
    if (x > 0) {
        printf(""x is positive\n"");
    }

    return 0;
}
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`#include <iostream>

using namespace std;

int main()
{
    int x = 5;
    if (x > 0) {
        printf(""x is positive\n"");
    }

    return 0;
}
`",
            },
        },
        new ChunkModel
        {
            Index = 11,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`public class Main {
    public static void main(String[] args)
    {
        int x = 5;

        if (x > 0) {
            System.out.println(""x is positive"");
        }
    }
}
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`public class Main {
    public static void main(String[] args)
    {
        int x = 5;

        if (x > 0) {
            System.out.println(""x is positive"");
        }
    }
}
`",
            },
        },
        new ChunkModel
        {
            Index = 12,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`x = 5

if x > 0:
    print(""x is positive"")
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`x = 5

if x > 0:
    print(""x is positive"")
`",
            },
        },
        new ChunkModel
        {
            Index = 13,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`let x = 5;

if (x > 0) {
    console.log(""x is positive"");
}
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`let x = 5;

if (x > 0) {
    console.log(""x is positive"");
}
`",
            },
        },
        new ChunkModel
        {
            Index = 14,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`using System;

class Program {
    static void Main()
    {
        int x = 5;

        if (x > 0) {
            Console.WriteLine(""x is positive"");
        }
    }
}
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`using System;

class Program {
    static void Main()
    {
        int x = 5;

        if (x > 0) {
            Console.WriteLine(""x is positive"");
        }
    }
}
`",
            },
        },
        new ChunkModel
        {
            Index = 15,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`#include <iostream>

using namespace std;

int main()
{
    int a = 5, b = 10;

    // Equal to
    if (a == b) {
        cout << ""a is equal to b"" << endl;
    }

    // Not equal to
    if (a != b) {
        cout << ""a is not equal to b"" << endl;
    }

    // Greater than
    if (a > b) {
        cout << ""a is greater than b"" << endl;
    }

    // Less than
    if (a < b) {
        cout << ""a is less than b"" << endl;
    }

    // Greater than or equal to
    if (a >= b) {
        cout << ""a is greater than or equal to b"" << endl;
    }

    // Less than or equal to
    if (a <= b) {
        cout << ""a is less than or equal to b"" << endl;
    }

    return 0;
}
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`#include <iostream>

using namespace std;

int main()
{
    int a = 5, b = 10;

    // Equal to
    if (a == b) {
        cout << ""a is equal to b"" << endl;
    }

    // Not equal to
    if (a != b) {
        cout << ""a is not equal to b"" << endl;
    }

    // Greater than
    if (a > b) {
        cout << ""a is greater than b"" << endl;
    }

    // Less than
    if (a < b) {
        cout << ""a is less than b"" << endl;
    }

    // Greater than or equal to
    if (a >= b) {
        cout << ""a is greater than or equal to b"" << endl;
    }

    // Less than or equal to
    if (a <= b) {
        cout << ""a is less than or equal to b"" << endl;
    }

    return 0;
}
`",
            },
        },
        new ChunkModel
        {
            Index = 16,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`#include <stdio.h>

int main()
{
    int a = 5, b = 10;

    // Equal to
    if (a == b) {
        printf(""a is equal to b\n"");
    }

    // Not equal to
    if (a != b) {
        printf(""a is not equal to b\n"");
    }

    // Greater than
    if (a > b) {
        printf(""a is greater than b\n"");
    }

    // Less than
    if (a < b) {
        printf(""a is less than b\n"");
    }

    // Greater than or equal to
    if (a >= b) {
        printf(""a is greater than or equal to b\n"");
    }

    // Less than or equal to
    if (a <= b) {
        printf(""a is less than or equal to b\n"");
    }

    return 0;
}
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`#include <stdio.h>

int main()
{
    int a = 5, b = 10;

    // Equal to
    if (a == b) {
        printf(""a is equal to b\n"");
    }

    // Not equal to
    if (a != b) {
        printf(""a is not equal to b\n"");
    }

    // Greater than
    if (a > b) {
        printf(""a is greater than b\n"");
    }

    // Less than
    if (a < b) {
        printf(""a is less than b\n"");
    }

    // Greater than or equal to
    if (a >= b) {
        printf(""a is greater than or equal to b\n"");
    }

    // Less than or equal to
    if (a <= b) {
        printf(""a is less than or equal to b\n"");
    }

    return 0;
}
`",
            },
        },
        new ChunkModel
        {
            Index = 17,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`public class Main {
    public static void main(String[] args)
    {
        int a = 5, b = 10;

        // Equal to
        if (a == b) {
            System.out.println(""a is equal to b"");
        }

        // Not equal to
        if (a != b) {
            System.out.println(""a is not equal to b"");
        }

        // Greater than
        if (a > b) {
            System.out.println(""a is greater than b"");
        }

        // Less than
        if (a < b) {
            System.out.println(""a is less than b"");
        }

        // Greater than or equal to
        if (a >= b) {
            System.out.println(
                ""a is greater than or equal to b"");
        }

        // Less than or equal to
        if (a <= b) {
            System.out.println(
                ""a is less than or equal to b"");
        }
    }
}
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`public class Main {
    public static void main(String[] args)
    {
        int a = 5, b = 10;

        // Equal to
        if (a == b) {
            System.out.println(""a is equal to b"");
        }

        // Not equal to
        if (a != b) {
            System.out.println(""a is not equal to b"");
        }

        // Greater than
        if (a > b) {
            System.out.println(""a is greater than b"");
        }

        // Less than
        if (a < b) {
            System.out.println(""a is less than b"");
        }

        // Greater than or equal to
        if (a >= b) {
            System.out.println(
                ""a is greater than or equal to b"");
        }

        // Less than or equal to
        if (a <= b) {
            System.out.println(
                ""a is less than or equal to b"");
        }
    }
}
`",
            },
        },
        new ChunkModel
        {
            Index = 18,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`a = 5
b = 10

# Equal to
if a == b:
    print(""a is equal to b"")

# Not equal to
if a != b:
    print(""a is not equal to b"")

# Greater than
if a > b:
    print(""a is greater than b"")

# Less than
if a < b:
    print(""a is less than b"")

# Greater than or equal to
if a >= b:
    print(""a is greater than or equal to b"")

# Less than or equal to
if a <= b:
    print(""a is less than or equal to b"")
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`a = 5
b = 10

# Equal to
if a == b:
    print(""a is equal to b"")

# Not equal to
if a != b:
    print(""a is not equal to b"")

# Greater than
if a > b:
    print(""a is greater than b"")

# Less than
if a < b:
    print(""a is less than b"")

# Greater than or equal to
if a >= b:
    print(""a is greater than or equal to b"")

# Less than or equal to
if a <= b:
    print(""a is less than or equal to b"")
`",
            },
        },
        new ChunkModel
        {
            Index = 19,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`using System;

class Program {
    static void Main()
    {
        int a = 5, b = 10;

        // Equal to
        if (a == b) {
            Console.WriteLine(""a is equal to b"");
        }

        // Not equal to
        if (a != b) {
            Console.WriteLine(""a is not equal to b"");
        }

        // Greater than
        if (a > b) {
            Console.WriteLine(""a is greater than b"");
        }

        // Less than
        if (a < b) {
            Console.WriteLine(""a is less than b"");
        }

        // Greater than or equal to
        if (a >= b) {
            Console.WriteLine(
                ""a is greater than or equal to b"");
        }

        // Less than or equal to
        if (a <= b) {
            Console.WriteLine(
                ""a is less than or equal to b"");
        }
    }
}
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`using System;

class Program {
    static void Main()
    {
        int a = 5, b = 10;

        // Equal to
        if (a == b) {
            Console.WriteLine(""a is equal to b"");
        }

        // Not equal to
        if (a != b) {
            Console.WriteLine(""a is not equal to b"");
        }

        // Greater than
        if (a > b) {
            Console.WriteLine(""a is greater than b"");
        }

        // Less than
        if (a < b) {
            Console.WriteLine(""a is less than b"");
        }

        // Greater than or equal to
        if (a >= b) {
            Console.WriteLine(
                ""a is greater than or equal to b"");
        }

        // Less than or equal to
        if (a <= b) {
            Console.WriteLine(
                ""a is less than or equal to b"");
        }
    }
}
`",
            },
        },
        new ChunkModel
        {
            Index = 20,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"`// Define variables a and b
let a = 5, b = 10;

// Equal to
if (a === b) {
    console.log(""a is equal to b"");
}

// Not equal to
if (a !== b) {
    console.log(""a is not equal to b"");
}

// Greater than
if (a > b) {
    console.log(""a is greater than b"");
}

// Less than
if (a < b) {
    console.log(""a is less than b"");
}

// Greater than or equal to
if (a >= b) {
    console.log(""a is greater than or equal to b"");
}

// Less than or equal to
if (a <= b) {
    console.log(""a is less than or equal to b"");
}
`",
            Data = new Dictionary<string, object>
            {
                ["language"] = "unknown",
                ["content"] = @"`// Define variables a and b
let a = 5, b = 10;

// Equal to
if (a === b) {
    console.log(""a is equal to b"");
}

// Not equal to
if (a !== b) {
    console.log(""a is not equal to b"");
}

// Greater than
if (a > b) {
    console.log(""a is greater than b"");
}

// Less than
if (a < b) {
    console.log(""a is less than b"");
}

// Greater than or equal to
if (a >= b) {
    console.log(""a is greater than or equal to b"");
}

// Less than or equal to
if (a <= b) {
    console.log(""a is less than or equal to b"");
}
`",
            },
        },
    ];

    // https://dev.to/alex_ricciardi/recursion-in-programming-techniques-benefits-and-limitations-java-3o4p
    internal static readonly ChunkModel[] DevToRealWorldArticleCodeBlocks =
    [
        new ChunkModel
        {
            Index = 1,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
public class Factorial {
    public static int factorial(int n) {
    // --- Base case: factorial of 0 is 1 ----
    if (n == 0) { 
            return 1;  
    // --- Recursive case ---
    } else {
        return n * factorial(n - 1);  
    }
}
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
public class Factorial {
    public static int factorial(int n) {
    // --- Base case: factorial of 0 is 1 ----
    if (n == 0) { 
            return 1;  
    // --- Recursive case ---
    } else {
        return n * factorial(n - 1);  
    }
}
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 2,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
public class DFS {
    // Node class
    static class Node {
        int value;
        Node left, right;
        // Constructor
        Node(int value) {
            this.value = value;
            left = right = null; // Left and right children are null initially
        }
    }
    // Recursive Depth-First Search (DFS) method
    public static void depthFirstSearchRecursive(Node node) {
        // --- Base case ---
        if (node == null) {
            return; 
        }
        // Process the current node (visit)
        System.out.println(node.value);
        // Recursively traverse the left subtree
        depthFirstSearchRecursive(node.left);
        //--- Recursive case ---
        depthFirstSearchRecursive(node.right);
        /*
          Potential stack overflow issue: Each recursive call adds a new 
           frame to the call stack. If the tree is too deep (e.g., with 
           many levels), the recursion
          depth can exceed the system's maximum stack size, causing a
          StackOverflowError.
         */
    }
    public static void main(String[] args) {
        // Create a binary tree
        Node root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.left = new Node(4);
        root.left.right = new Node(5);
        System.out.println(""DFS Traversal using Recursion:"");
        depthFirstSearchRecursive(root); 
    }
}
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
public class DFS {
    // Node class
    static class Node {
        int value;
        Node left, right;
        // Constructor
        Node(int value) {
            this.value = value;
            left = right = null; // Left and right children are null initially
        }
    }
    // Recursive Depth-First Search (DFS) method
    public static void depthFirstSearchRecursive(Node node) {
        // --- Base case ---
        if (node == null) {
            return; 
        }
        // Process the current node (visit)
        System.out.println(node.value);
        // Recursively traverse the left subtree
        depthFirstSearchRecursive(node.left);
        //--- Recursive case ---
        depthFirstSearchRecursive(node.right);
        /*
          Potential stack overflow issue: Each recursive call adds a new 
           frame to the call stack. If the tree is too deep (e.g., with 
           many levels), the recursion
          depth can exceed the system's maximum stack size, causing a
          StackOverflowError.
         */
    }
    public static void main(String[] args) {
        // Create a binary tree
        Node root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.left = new Node(4);
        root.left.right = new Node(5);
        System.out.println(""DFS Traversal using Recursion:"");
        depthFirstSearchRecursive(root); 
    }
}
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 3,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
import java.util.ArrayDeque;
import java.util.Deque;
public class DFS {
    // Single node in the binary tree
    static class Node {
        int value;
        Node left, right;
        // Node Constructor 
        Node(int value) {
            this.value = value;
            left = right = null; // Left and right children are null initially
        }
    }
    // Depth-First Search (DFS) traversal method 
    public static void depthFirstSearch(Node root) {
        Deque stack = new ArrayDeque<>();
        stack.push(root);
        // traverse the stack until is empty
        while (!stack.isEmpty()) {
            // Pop the top node from the stack
            Node current = stack.pop();
            System.out.println(current.value); 

            if (current.right != null) {
                stack.push(current.right); // Add right child to stack
            }
            if (current.left != null) {
                stack.push(current.left); // Add left child to stack
            }
        }
    }
    public static void main(String[] args) {
        // Create a binary tree
        Node root = new Node(1); 
        root.left = new Node(2); 
        root.right = new Node(3); 
        root.left.left = new Node(4); 
        root.left.right = new Node(5); 

        System.out.println(""DFS Traversal using Deque:"");
        depthFirstSearch(root); 
    }
}
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
import java.util.ArrayDeque;
import java.util.Deque;
public class DFS {
    // Single node in the binary tree
    static class Node {
        int value;
        Node left, right;
        // Node Constructor 
        Node(int value) {
            this.value = value;
            left = right = null; // Left and right children are null initially
        }
    }
    // Depth-First Search (DFS) traversal method 
    public static void depthFirstSearch(Node root) {
        Deque stack = new ArrayDeque<>();
        stack.push(root);
        // traverse the stack until is empty
        while (!stack.isEmpty()) {
            // Pop the top node from the stack
            Node current = stack.pop();
            System.out.println(current.value); 

            if (current.right != null) {
                stack.push(current.right); // Add right child to stack
            }
            if (current.left != null) {
                stack.push(current.left); // Add left child to stack
            }
        }
    }
    public static void main(String[] args) {
        // Create a binary tree
        Node root = new Node(1); 
        root.left = new Node(2); 
        root.right = new Node(3); 
        root.left.left = new Node(4); 
        root.left.right = new Node(5); 

        System.out.println(""DFS Traversal using Deque:"");
        depthFirstSearch(root); 
    }
}
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 4,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
DFS Traversal using Deque:
1
2
4
5
3
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
DFS Traversal using Deque:
1
2
4
5
3
```",
                ["language"] = "unknown",
            },
        },
    ];

    // https://www.geeksforgeeks.org/basic-operators-in-relational-algebra-2/
    internal static readonly ChunkModel[] GeeksForGeeksAboutRelationalAlgebraCodeBlocks = 
    [
        new ChunkModel
        {
            Index = 1,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
σ (Cond)(Relation Name)
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
σ (Cond)(Relation Name)
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 2,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
σ (AGE>18)(STUDENT)
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
σ (AGE>18)(STUDENT)
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 3,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
∏(Column 1,Column 2….Column n)(Relation Name)
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
∏(Column 1,Column 2….Column n)(Relation Name)
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 4,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
∏(ROLL_NO,NAME)(STUDENT)
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
∏(ROLL_NO,NAME)(STUDENT)
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 5,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
Relation1 X Relation2
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
Relation1 X Relation2
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 6,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
STUDENT X STUDENT_SPORTS
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
STUDENT X STUDENT_SPORTS
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 7,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = "```\r\n\u00A0Relation1\u00A0U Relation2\r\n```",
            Data = new Dictionary<string, object>
            {
                ["content"] = "```\r\n\u00A0Relation1\u00A0U Relation2\r\n```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 8,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
STUDENT U EMPLOYEE
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
STUDENT U EMPLOYEE
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 9,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = "```\r\n\u00A0Relation1 - Relation2\r\n```",
            Data = new Dictionary<string, object>
            {
                ["content"] = "```\r\n\u00A0Relation1 - Relation2\r\n```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 10,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
STUDENT - EMPLOYEE
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
STUDENT - EMPLOYEE
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 11,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
ρ(Relation2, Relation1)
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
ρ(Relation2, Relation1)
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 12,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
ρ(STUDENT1, STUDENT)
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
ρ(STUDENT1, STUDENT)
```",
                ["language"] = "unknown",
            },
        },
        new ChunkModel
        {
            Index = 13,
            ChunkType = ChunkType.CodeBlock,
            RelatedChunksIndexes = [],
            RawContent = @"```
ρ(STUDENT_NAMES, ∏(ROLL_NO, NAME)(STUDENT))
```",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"```
ρ(STUDENT_NAMES, ∏(ROLL_NO, NAME)(STUDENT))
```",
                ["language"] = "unknown",
            },
        },
    ];
}
