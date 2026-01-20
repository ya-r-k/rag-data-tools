namespace Sample.Chunkers.UnitTests.TestData;

internal static class ArticlesTestData
{
    // NOT COVERED BY TESTS!!!!!!!!!!!
    // https://www.geeksforgeeks.org/functions-in-discrete-mathematics/
    internal const string ArticleWithMathInfoBlocks = @"# Functions in Discrete Mathematics

Last Updated : 
                                                    16 Sep, 2024

Comments

Improve

- 
- 
-

Suggest changes
                                                                                          
18 Likes

Like

Report

[!\[News\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)
                                                    Follow](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)

Functions are an important part of discrete mathematics. This article is all about functions, their types, and other details of functions. A function assigns exactly one element of a set to each element of the other set. Functions are the rules that assign one input to one output. The function can be represented as f: A **⇢** B. A is called the domain of the function and B is called the codomain function.

Table of Content

- What is Function?
    - Pre-Image and Image of a Function
    - Domain of a Function
    - Codomain (Range) of a Function
- Types of Function
- Inverse of a Function
- Composition of Functions
- Summary: Functions in Discrete Mathematics
- Sample Questions on Functions in Discrete Mathematics

## What is Function?

- A [function](https://www.geeksforgeeks.org/what-is-a-function/) assigns exactly one element of one set to each element of other sets.
- A function is a rule that assigns each input exactly one output.
- A function f from A to B is an assignment of exactly one element of B to each element of A (where  A and B are non-empty sets).
- A function f from set A to set B is represented as **f: A ⇢ B** where A is called the domain of f and B is called as codomain of f.
- If b is a unique element of B to element a of A assigned by function F then, it is written as f(a) = b.
- Function f maps A to B means f is a function from A to B i.e. f: A **⇢** B

### Pre-Image and Image of a Function

A function f: A **⇢** B such that for each a ∈ A, there exists a unique b ∈ B such that (a, b) ∈ R then, a is called the pre-image of f and b is called the image of f.

### Domain of a Function

- If f is a function from set A to set B then, A is called the domain of function f.
- The set of all inputs for a function is called its domain.

### Codomain (Range) of a Function

- If f is a function from set A to set B then, B is called the codomain of function f.
- The set of all allowable outputs for a function is called its codomain.

**Read More about** [**Domain and Range of Function**](https://www.geeksforgeeks.org/domain-and-range-of-function/)**.**

## Types of Function

Some of the common types of functions are:

- [One-One Function](https://www.geeksforgeeks.org/one-to-one-functions/)
- [Many-One Function](https://www.geeksforgeeks.org/many-one-functions/)
- [Onto Function](https://www.geeksforgeeks.org/onto-functions/)
- Into Function
- One-One Correspondent Function
- One-One Into Function
- Many-One Onto Function
- Many-One Into Function

Let’s discuss these in detail.

### One-One Function ( or Injective Function):

A function in which one element of the domain is connected to one element of the codomain.

A function f: A **⇢** B is said to be a one-one (injective) function if different elements of A have different images in B.

**f: A ⇢ B is one-one**

**⇒  a ≠ b ⇒  f(a) ≠ f(b)           for all a, b ∈  A**

**⇒  f(a) = f(b) ⇒ a = b           for all a, b ∈  A**

![ONE-ONE FUNCTION](https://media.geeksforgeeks.org/wp-content/uploads/20220519204920/oo-300x295.png)
ONE-ONE FUNCTION

### Many-One Function

A function f: A **⇢** B is said to be a many-one function if two or more elements of set A have the same image in B.

A function f: A **⇢** B is a many-one function if it is not a one-one function.

**f: A ⇢ B is many-one.**

**⇒ a ≠ b but f(a) = f(b)      for all a, b ∈  A**

![MANY-ONE FUNCTION](https://media.geeksforgeeks.org/wp-content/uploads/20220523142424/mof-284x300.png)
MANY-ONE FUNCTION

### Onto Function( or Surjective Function)

A function f: A ⇢ B is said to be onto (surjective) function if every element of B is an image of some element of A  i.e. f(A) = B or range of f is the codomain of f.

A function in which every element of the codomain has one pre-image.

 **f: A ⇢ B is onto if for each b∈ B, there exists a∈ A such that f(a) = b.**

![ONTO FUNCTION](https://media.geeksforgeeks.org/wp-content/uploads/20220519205009/ONTO-300x295.png)
ONTO FUNCTION

### Into Function

A function f: A **⇢** B is said to be an into a function if there exists an element in B with no pre-image in A.

A function f: A**⇢** B is into function when it is not onto.

![INTO FUNCTION](https://media.geeksforgeeks.org/wp-content/uploads/20220523142501/INTO-284x300.png)
INTO FUNCTION

### One-One Correspondent Function (or Bijective Function or One-One Onto Function)

A function which is both one-one and onto (both injective and surjective) is called one-one correspondent(bijective) function. 

**f : A ⇢ B is one-one correspondent (bijective) if:**

- one-one i.e. f(a) = f(b) 
    - ⇒ a = b for all a, b ∈  A
- onto i.e.  for each b ∈ B, there exists
    - a ∈ A such that f(a) = b.

![ONE-ONE CORRESPONDENT FUNCTION](https://media.geeksforgeeks.org/wp-content/uploads/20220524133000/OOO-284x300.png)
ONE-ONE CORRESPONDENT FUNCTION

### One-One Into Function

A function that is both one-one and into is called one-one into function.

![ONE-ONE INTO FUNCTION](https://media.geeksforgeeks.org/wp-content/uploads/20220524135114/ooi-284x300.png)
ONE-ONE INTO FUNCTION

### Many-One Onto Function

A function that is both many-one and onto is called many-one onto function.

![MANY-ONE ONTO FUNCTION](https://media.geeksforgeeks.org/wp-content/uploads/20220524134442/moon-284x300.png)
MANY-ONE ONTO FUNCTION

### Many-One Into Function

A function that is both many-one and into is called many-one into function.

![MANY-ONE INTO FUNCTION](https://media.geeksforgeeks.org/wp-content/uploads/20220524134449/moin-284x300.png)
MANY-ONE INTO FUNCTION

## Inverse of a Function

Let f: A **⇢** B be a bijection then, a function g: B **⇢** A which associates each element b ∈ B to a different element a ∈ A such that f(a) = b is called the inverse of f.

> 
> 
> **f(a) = b  ↔︎  g(b) = a**
> 

**Read More about** [**Inverse Function**](https://www.geeksforgeeks.org/inverse-functions/)**.**

## Composition of Functions

Let f: A **⇢** B and g: B **⇢** C be two functions then, a function gof: A **⇢** C is defined by 

> 
> 
> **(gof)(x) = g(f(x)), for all x ∈ A**
> 

Here, (gof)(x) is called the composition of f and g.

**Read More about** [**Composition of Function**](https://www.geeksforgeeks.org/composition-of-functions/)**.**

## Summary: Functions in Discrete Mathematics

Let X and Y be two sets with m and n elements and a function is defined as f : X⇢Y then,

- Total number of functions = n^m^
- Total number of one-one function =^n^Pm
- Total number of onto functions = n^m^ – ^n^C1(n-1)^m^ + ^n^C2(n-2)^m^ – . .  . + (-1)^n-1n^Cn-11^m^    if m ≥ n.

For the composition of functions f and g be two functions : 

- fog ≠ gof
- If f and g both are one-one function then fog is also one-one.
- If f and g both are onto function then fog is also onto.
- If f and fog both are one-one function then g is also one-one.
- If f and fog both are onto function then it is not necessary that g is also onto.
- (fog)^-1^ = g^-1^o f^-1^
- f^-1^o f = f^-1^(f(a)) = f^-1^(b) = a
- fof^-1^= f(f^-1^(b)) = f(a) = b

## Sample Questions on Functions in Discrete Mathematics

**Question 1: Show that the function f : R ⇢ R, given by f(x) = 2x, is one-one and onto.**

**Solution:**

> 
> 
> **For one-one:**
> 
> 
> Let a, b ∈ R such that f(a) = f(b) then,
> 
> 
> f(a) = f(b) 
> 
> 
> ⇒ 2a = 2b 
> 
> 
> ⇒ a = b
> 
> 
> **Therefore, f: R ⇢ R is one-one.**
> 
> 
> **For onto:**
> 
> 
> Let p be any real number in R (co-domain). f(x) = p
> 
> 
> ⇒ 2x = p 
> 
> 
> ⇒ x = p/2
> 
> 
> p/2 ∈ R for p ∈ R such that f(p/2) = 2(p/2) = p 
> 
> 
> For each p∈ R (codomain) there exists x = p/2 ∈ R (domain) such that f(x) = y
> 
> 
> For each element in codomain has its pre-image in domain.
> 
> 
> So, f: R ⇢ R is onto.
> 
> 
> Since f: R ⇢ R is both one-one and onto.
> 
> 
> f : R ⇢ R is one-one correspondent (bijective function).
> 

**Question 2: Let  f : R ⇢ R ; f(x) = cos x and  g : R ⇢ R ; g(x) = x** **^3^**  **. Find fog and gof.**

**Solution:**

> 
> 
> Since the range of f is a subset of the domain of g and the range of g is a subset of the domain of f. So, fog and gof both exist. 
> 
> 
> **gof (x)** = g(f(x)) = g(cos x) = (cos x)^3^ = cos^3^x
> 
> 
> **fog (x)** = f(g(x)) = f(x^3^) = cos x^3^
> 

**Question 3: If f : Q ⇢ Q is given by f(x) = x** **^2^**  **, then find f** **^-1^** **(16).**

**Solution:**

> 
> 
> Let f^-1^(16) = x
> 
> 
> f(x) = 16
> 
> 
> ⇒ x^2^ = 16
> 
> 
> ⇒ x = ± 4
> 
> 
> Thus, f^-1^(16) = {-4, 4}
> 

**Question 4: If f : R ⇢ R; f(x) = 2x + 7  is a bijective function then, find the inverse of f.**

**Solution:**

> 
> 
> Let x ∈ R (domain), y ∈ R (codomain) such that f(a) = b
> 
> 
> f(x) = y
> 
> 
> ⇒ 2x + 7 = y
> 
> 
> ⇒ x = (y -7)/2
> 
> 
> ⇒ f^-1^(y) = (y -7)/2 
> 
> 
> Thus,  f^-1 : R^⇢ R is defined as f^-1(x) = (x -7)/2  for all x∈ R.^
> 

**Question 5: If f : A ⇢ B and |A| = 5 and |B| = 3 then find total number of functions.**

**Solution:**

> 
> 
> Total number of functions = 3^5^ **** = 243
> 

### Related Articles:

- [Discrete Mathematics Tutorial](https://www.geeksforgeeks.org/discrete-mathematics-tutorial/)
- [Discrete Mathematics | Hasse Diagrams](https://www.geeksforgeeks.org/discrete-mathematics-hasse-diagrams/)

Comment

More info

                               [Advertise with us](https://www.geeksforgeeks.org/about/contact-us/?listicles)

[Next Article](https://www.geeksforgeeks.org/constant-function/?ref=next_article)

[Constant Function in Mathematics](https://www.geeksforgeeks.org/constant-function/?ref=next_article)

![https://media.geeksforgeeks.org/auth/avatar.png](https://media.geeksforgeeks.org/wp-content/uploads/20200717172614/authPreLogo.png)

GeeksforGeeks

[!\[News\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)

18

Improve

Article Tags :

- [Engineering Mathematics](https://www.geeksforgeeks.org/category/computer-subject/engineering-mathematics/?ref=article_category)
";


    // NOT COVERED BY TESTS!!!!!!!!!!!
    // https://en.wikipedia.org/wiki/Negation
    internal const string WikipediaArticleWithComplexNestedTables = @"Logical operation

For negation in linguistics, see [Affirmation and negation](/wiki/Affirmation_and_negation ""Affirmation and negation""). For other uses, see [Negation (disambiguation)](/wiki/Negation_%28disambiguation%29 ""Negation (disambiguation)"").

<table class=""infobox""><caption class=""infobox-title"" style=""background:navy; color:white;"">Negation</caption><tbody><tr><th colspan=""2"" class=""infobox-above"">NOT</th></tr><tr><td colspan=""2"" class=""infobox-image""><span typeof=""mw:File""><a href=""/wiki/File:Venn10.svg"" class=""mw-file-description"" title=""Venn diagram of Negation""><img alt=""Venn diagram of Negation"" src=""//upload.wikimedia.org/wikipedia/commons/thumb/7/73/Venn10.svg/150px-Venn10.svg.png"" decoding=""async"" width=""150"" height=""150"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/7/73/Venn10.svg/225px-Venn10.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/7/73/Venn10.svg/300px-Venn10.svg.png 2x"" data-file-width=""280"" data-file-height=""280""></a></span></td></tr><tr><th scope=""row"" class=""infobox-label"">Definition</th><td class=""infobox-data""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \lnot {x}}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi mathvariant=""normal"">¬<!-- ¬ --></mi>
        <mrow class=""MJX-TeXAtom-ORD"">
          <mi>x</mi>
        </mrow>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \lnot {x}}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/561558609a1ef8421895e7953c96ad487e960300"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:2.88ex; height:1.676ex;"" alt=""{\displaystyle \lnot {x}}""></span></td></tr><tr><th scope=""row"" class=""infobox-label""><a href=""/wiki/Truth_table"" title=""Truth table"">Truth table</a></th><td class=""infobox-data""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle (01)}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo stretchy=""false"">(</mo>
        <mn>01</mn>
        <mo stretchy=""false"">)</mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle (01)}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/0849a25948c03d17713210f17d69290cb574cb01"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.838ex; width:4.134ex; height:2.843ex;"" alt=""{\displaystyle (01)}""></span></td></tr><tr><th scope=""row"" class=""infobox-label""><a href=""/wiki/Logic_gate"" title=""Logic gate"">Logic gate</a></th><td class=""infobox-data""><span typeof=""mw:File""><a href=""/wiki/File:NOT_ANSI.svg"" class=""mw-file-description""><img src=""//upload.wikimedia.org/wikipedia/commons/thumb/b/bc/NOT_ANSI.svg/70px-NOT_ANSI.svg.png"" decoding=""async"" width=""70"" height=""35"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/b/bc/NOT_ANSI.svg/105px-NOT_ANSI.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/b/bc/NOT_ANSI.svg/140px-NOT_ANSI.svg.png 2x"" data-file-width=""100"" data-file-height=""50""></a></span></td></tr><tr><th colspan=""2"" class=""infobox-header"" style=""background:navy; color:white;"">Normal forms</th></tr><tr><th scope=""row"" class=""infobox-label""><a href=""/wiki/Disjunctive_normal_form"" title=""Disjunctive normal form"">Disjunctive</a></th><td class=""infobox-data""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \lnot {x}}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi mathvariant=""normal"">¬<!-- ¬ --></mi>
        <mrow class=""MJX-TeXAtom-ORD"">
          <mi>x</mi>
        </mrow>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \lnot {x}}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/561558609a1ef8421895e7953c96ad487e960300"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:2.88ex; height:1.676ex;"" alt=""{\displaystyle \lnot {x}}""></span></td></tr><tr><th scope=""row"" class=""infobox-label""><a href=""/wiki/Conjunctive_normal_form"" title=""Conjunctive normal form"">Conjunctive</a></th><td class=""infobox-data""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \lnot {x}}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi mathvariant=""normal"">¬<!-- ¬ --></mi>
        <mrow class=""MJX-TeXAtom-ORD"">
          <mi>x</mi>
        </mrow>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \lnot {x}}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/561558609a1ef8421895e7953c96ad487e960300"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:2.88ex; height:1.676ex;"" alt=""{\displaystyle \lnot {x}}""></span></td></tr><tr><th scope=""row"" class=""infobox-label""><a href=""/wiki/Zhegalkin_polynomial"" title=""Zhegalkin polynomial"">Zhegalkin polynomial</a></th><td class=""infobox-data""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle 1\oplus x}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mn>1</mn>
        <mo>⊕<!-- ⊕ --></mo>
        <mi>x</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle 1\oplus x}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/5b6360c75948cd75ab65f4b9691f620640bb6abd"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.505ex; width:5.333ex; height:2.343ex;"" alt=""{\displaystyle 1\oplus x}""></span></td></tr><tr><th colspan=""2"" class=""infobox-header"" style=""background:navy; color:white;""><a href=""/wiki/Post%27s_lattice"" title=""Post's lattice""><span style=""color:white;"">Post's lattices</span></a></th></tr><tr><th scope=""row"" class=""infobox-label"">0-preserving</th><td class=""infobox-data"">no</td></tr><tr><th scope=""row"" class=""infobox-label"">1-preserving</th><td class=""infobox-data"">no</td></tr><tr><th scope=""row"" class=""infobox-label""><a href=""/wiki/Monotonic_function"" title=""Monotonic function"">Monotone</a></th><td class=""infobox-data"">no</td></tr><tr><th scope=""row"" class=""infobox-label""><a href=""/wiki/Affine_transformation"" title=""Affine transformation"">Affine</a></th><td class=""infobox-data"">yes</td></tr><tr><th scope=""row"" class=""infobox-label"">Self-dual</th><td class=""infobox-data"">yes</td></tr><tr><td colspan=""2"" class=""infobox-navbar""><style data-mw-deduplicate=""TemplateStyles:r1129693374"">.mw-parser-output .hlist dl,.mw-parser-output .hlist ol,.mw-parser-output .hlist ul{margin:0;padding:0}.mw-parser-output .hlist dd,.mw-parser-output .hlist dt,.mw-parser-output .hlist li{margin:0;display:inline}.mw-parser-output .hlist.inline,.mw-parser-output .hlist.inline dl,.mw-parser-output .hlist.inline ol,.mw-parser-output .hlist.inline ul,.mw-parser-output .hlist dl dl,.mw-parser-output .hlist dl ol,.mw-parser-output .hlist dl ul,.mw-parser-output .hlist ol dl,.mw-parser-output .hlist ol ol,.mw-parser-output .hlist ol ul,.mw-parser-output .hlist ul dl,.mw-parser-output .hlist ul ol,.mw-parser-output .hlist ul ul{display:inline}.mw-parser-output .hlist .mw-empty-li{display:none}.mw-parser-output .hlist dt::after{content:"": ""}.mw-parser-output .hlist dd::after,.mw-parser-output .hlist li::after{content:"" · "";font-weight:bold}.mw-parser-output .hlist dd:last-child::after,.mw-parser-output .hlist dt:last-child::after,.mw-parser-output .hlist li:last-child::after{content:none}.mw-parser-output .hlist dd dd:first-child::before,.mw-parser-output .hlist dd dt:first-child::before,.mw-parser-output .hlist dd li:first-child::before,.mw-parser-output .hlist dt dd:first-child::before,.mw-parser-output .hlist dt dt:first-child::before,.mw-parser-output .hlist dt li:first-child::before,.mw-parser-output .hlist li dd:first-child::before,.mw-parser-output .hlist li dt:first-child::before,.mw-parser-output .hlist li li:first-child::before{content:"" ("";font-weight:normal}.mw-parser-output .hlist dd dd:last-child::after,.mw-parser-output .hlist dd dt:last-child::after,.mw-parser-output .hlist dd li:last-child::after,.mw-parser-output .hlist dt dd:last-child::after,.mw-parser-output .hlist dt dt:last-child::after,.mw-parser-output .hlist dt li:last-child::after,.mw-parser-output .hlist li dd:last-child::after,.mw-parser-output .hlist li dt:last-child::after,.mw-parser-output .hlist li li:last-child::after{content:"")"";font-weight:normal}.mw-parser-output .hlist ol{counter-reset:listitem}.mw-parser-output .hlist ol>li{counter-increment:listitem}.mw-parser-output .hlist ol>li::before{content:"" ""counter(listitem)""\a0 ""}.mw-parser-output .hlist dd ol>li:first-child::before,.mw-parser-output .hlist dt ol>li:first-child::before,.mw-parser-output .hlist li ol>li:first-child::before{content:"" (""counter(listitem)""\a0 ""}</style><style data-mw-deduplicate=""TemplateStyles:r1239400231"">.mw-parser-output .navbar{display:inline;font-size:88%;font-weight:normal}.mw-parser-output .navbar-collapse{float:left;text-align:left}.mw-parser-output .navbar-boxtext{word-spacing:0}.mw-parser-output .navbar ul{display:inline-block;white-space:nowrap;line-height:inherit}.mw-parser-output .navbar-brackets::before{margin-right:-0.125em;content:""[ ""}.mw-parser-output .navbar-brackets::after{margin-left:-0.125em;content:"" ]""}.mw-parser-output .navbar li{word-spacing:-0.125em}.mw-parser-output .navbar a>span,.mw-parser-output .navbar a>abbr{text-decoration:inherit}.mw-parser-output .navbar-mini abbr{font-variant:small-caps;border-bottom:none;text-decoration:none;cursor:inherit}.mw-parser-output .navbar-ct-full{font-size:114%;margin:0 7em}.mw-parser-output .navbar-ct-mini{font-size:114%;margin:0 4em}html.skin-theme-clientpref-night .mw-parser-output .navbar li a abbr{color:var(--color-base)!important}@media(prefers-color-scheme:dark){html.skin-theme-clientpref-os .mw-parser-output .navbar li a abbr{color:var(--color-base)!important}}@media print{.mw-parser-output .navbar{display:none!important}}</style><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Infobox_logical_connective"" title=""Template:Infobox logical connective""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Infobox_logical_connective"" title=""Template talk:Infobox logical connective""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Infobox_logical_connective"" title=""Special:EditPage/Template:Infobox logical connective""><abbr title=""Edit this template"">e</abbr></a></li></ul></div></td></tr></tbody></table>
<table class=""sidebar nomobile nowraplinks""><tbody><tr><th class=""sidebar-title"" style=""font-size: 130%; margin: 6px 0px 6px 0px; background: #ddf;""><a href=""/wiki/Logical_connective"" title=""Logical connective"">Logical connectives</a></th></tr><tr><td class=""sidebar-content"">
<table style=""width:100%;border-collapse:collapse;border-spacing:0px 0px;border:none;line-height:1.3em;""><tbody><tr style=""vertical-align:top""><td style=""text-align:left;""> <a class=""mw-selflink selflink"">NOT</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \neg A,-A,{\overline {A}},\sim A}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi mathvariant=""normal"">¬<!-- ¬ --></mi>
        <mi>A</mi>
        <mo>,</mo>
        <mo>−<!-- − --></mo>
        <mi>A</mi>
        <mo>,</mo>
        <mrow class=""MJX-TeXAtom-ORD"">
          <mover>
            <mi>A</mi>
            <mo accent=""false"">¯<!-- ¯ --></mo>
          </mover>
        </mrow>
        <mo>,</mo>
        <mo>∼<!-- ∼ --></mo>
        <mi>A</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \neg A,-A,{\overline {A}},\sim A}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/8eab858e54d8de87e36fc80a991b32e74201a600"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:16.001ex; height:3.343ex;"" alt=""{\displaystyle \neg A,-A,{\overline {A}},\sim A}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> <a href=""/wiki/Logical_conjunction"" title=""Logical conjunction"">AND</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A\land B,A\cdot B,AB,A\ \&amp;\ B,A\ \&amp;\&amp;\ B}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mo>∧<!-- ∧ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>⋅<!-- ⋅ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mtext>&nbsp;</mtext>
        <mi mathvariant=""normal"">&amp;<!-- & --></mi>
        <mtext>&nbsp;</mtext>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mtext>&nbsp;</mtext>
        <mi mathvariant=""normal"">&amp;<!-- & --></mi>
        <mi mathvariant=""normal"">&amp;<!-- & --></mi>
        <mtext>&nbsp;</mtext>
        <mi>B</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A\land B,A\cdot B,AB,A\ \&amp;\ B,A\ \&amp;\&amp;\ B}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/c041e99940ccd418648ea18d200af37e2b3548d2"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:33.68ex; height:2.509ex;"" alt=""{\displaystyle A\land B,A\cdot B,AB,A\ \&amp;\ B,A\ \&amp;\&amp;\ B}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> <a href=""/wiki/Sheffer_stroke"" title=""Sheffer stroke"">NAND</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A{\overline {\land }}B,A\uparrow B,A\mid B,{\overline {A\cdot B}}}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mrow class=""MJX-TeXAtom-ORD"">
          <mover>
            <mo>∧<!-- ∧ --></mo>
            <mo accent=""false"">¯<!-- ¯ --></mo>
          </mover>
        </mrow>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo stretchy=""false"">↑<!-- ↑ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>∣<!-- ∣ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mrow class=""MJX-TeXAtom-ORD"">
          <mover>
            <mrow>
              <mi>A</mi>
              <mo>⋅<!-- ⋅ --></mo>
              <mi>B</mi>
            </mrow>
            <mo accent=""false"">¯<!-- ¯ --></mo>
          </mover>
        </mrow>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A{\overline {\land }}B,A\uparrow B,A\mid B,{\overline {A\cdot B}}}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/b05374b45c2316947f052c6a46ca0f1d9381ed0e"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.838ex; width:24.98ex; height:3.509ex;"" alt=""{\displaystyle A{\overline {\land }}B,A\uparrow B,A\mid B,{\overline {A\cdot B}}}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> <a href=""/wiki/Logical_disjunction"" title=""Logical disjunction"">OR</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A\lor B,A+B,A\mid B,A\parallel B}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mo>∨<!-- ∨ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>+</mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>∣<!-- ∣ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>∥<!-- ∥ --></mo>
        <mi>B</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A\lor B,A+B,A\mid B,A\parallel B}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/a262d8ab1dd1738c2b888661fe847101b624992d"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.838ex; width:26.943ex; height:2.843ex;"" alt=""{\displaystyle A\lor B,A+B,A\mid B,A\parallel B}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> <a href=""/wiki/Logical_NOR"" title=""Logical NOR"">NOR</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A{\overline {\lor }}B,A\downarrow B,{\overline {A+B}}}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mrow class=""MJX-TeXAtom-ORD"">
          <mover>
            <mo>∨<!-- ∨ --></mo>
            <mo accent=""false"">¯<!-- ¯ --></mo>
          </mover>
        </mrow>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo stretchy=""false"">↓<!-- ↓ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mrow class=""MJX-TeXAtom-ORD"">
          <mover>
            <mrow>
              <mi>A</mi>
              <mo>+</mo>
              <mi>B</mi>
            </mrow>
            <mo accent=""false"">¯<!-- ¯ --></mo>
          </mover>
        </mrow>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A{\overline {\lor }}B,A\downarrow B,{\overline {A+B}}}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/331ccd940d0039678505e971d3e13a63fca14354"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:19.663ex; height:3.343ex;"" alt=""{\displaystyle A{\overline {\lor }}B,A\downarrow B,{\overline {A+B}}}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> <a href=""/wiki/XNOR_gate"" title=""XNOR gate"">XNOR</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A\odot B,{\overline {A{\overline {\lor }}B}}}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mo>⊙<!-- ⊙ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mrow class=""MJX-TeXAtom-ORD"">
          <mover>
            <mrow>
              <mi>A</mi>
              <mrow class=""MJX-TeXAtom-ORD"">
                <mover>
                  <mo>∨<!-- ∨ --></mo>
                  <mo accent=""false"">¯<!-- ¯ --></mo>
                </mover>
              </mrow>
              <mi>B</mi>
            </mrow>
            <mo accent=""false"">¯<!-- ¯ --></mo>
          </mover>
        </mrow>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A\odot B,{\overline {A{\overline {\lor }}B}}}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/7e5a7f5c2cebe8c2903dea347e6ce9223cc47e13"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:12.669ex; height:3.843ex;"" alt=""{\displaystyle A\odot B,{\overline {A{\overline {\lor }}B}}}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> └ <a href=""/wiki/Logical_biconditional"" title=""Logical biconditional"">equivalent</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A\equiv B,A\Leftrightarrow B,A\leftrightharpoons B}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mo>≡<!-- ≡ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo stretchy=""false"">⇔<!-- ⇔ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo stretchy=""false"">⇋<!-- ⇋ --></mo>
        <mi>B</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A\equiv B,A\Leftrightarrow B,A\leftrightharpoons B}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/73fd8a2bddea3e7553e1905a4b2b8944269d5430"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:22.916ex; height:2.509ex;"" alt=""{\displaystyle A\equiv B,A\Leftrightarrow B,A\leftrightharpoons B}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> <a href=""/wiki/Exclusive_or"" title=""Exclusive or"">XOR</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A{\underline {\lor }}B,A\oplus B}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mrow class=""MJX-TeXAtom-ORD"">
          <munder>
            <mo>∨<!-- ∨ --></mo>
            <mo>_<!-- _ --></mo>
          </munder>
        </mrow>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>⊕<!-- ⊕ --></mo>
        <mi>B</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A{\underline {\lor }}B,A\oplus B}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/d48ea5022d9d865ea81c6f954cf73429be684009"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.562ex; margin-bottom: -0.776ex; width:12.441ex; height:3.176ex;"" alt=""{\displaystyle A{\underline {\lor }}B,A\oplus B}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> └nonequivalent</td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A\not \equiv B,A\not \Leftrightarrow B,A\nleftrightarrow B}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mo>≢</mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>⇎</mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>↮<!-- ↮ --></mo>
        <mi>B</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A\not \equiv B,A\not \Leftrightarrow B,A\nleftrightarrow B}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/e31480781c46a0001e81f596615bc56e20d8aaa6"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.838ex; width:22.917ex; height:2.676ex;"" alt=""{\displaystyle A\not \equiv B,A\not \Leftrightarrow B,A\nleftrightarrow B}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> <a href=""/wiki/Material_conditional"" title=""Material conditional"">implies</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A\Rightarrow B,A\supset B,A\rightarrow B}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mo stretchy=""false"">⇒<!-- ⇒ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>⊃<!-- ⊃ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo stretchy=""false"">→<!-- → --></mo>
        <mi>B</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A\Rightarrow B,A\supset B,A\rightarrow B}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/da2d4ee4d40286755cb17f11743dcece3224fa90"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:22.916ex; height:2.509ex;"" alt=""{\displaystyle A\Rightarrow B,A\supset B,A\rightarrow B}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> <a href=""/wiki/Material_nonimplication"" title=""Material nonimplication"">nonimplication (NIMPLY)</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A\not \Rightarrow B,A\not \supset B,A\nrightarrow B}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mo>⇏</mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>⊅</mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>↛<!-- ↛ --></mo>
        <mi>B</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A\not \Rightarrow B,A\not \supset B,A\nrightarrow B}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/4d66f3ed3dc468f35292dfe91a75d59b3b5d4915"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.838ex; width:22.917ex; height:2.676ex;"" alt=""{\displaystyle A\not \Rightarrow B,A\not \supset B,A\nrightarrow B}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> <a href=""/wiki/Converse_(logic)"" title=""Converse (logic)"">converse</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A\Leftarrow B,A\subset B,A\leftarrow B}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mo stretchy=""false"">⇐<!-- ⇐ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>⊂<!-- ⊂ --></mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo stretchy=""false"">←<!-- ← --></mo>
        <mi>B</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A\Leftarrow B,A\subset B,A\leftarrow B}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/128eb93aed65dd2e3aa1a4aaef4171a44f9a6718"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:22.916ex; height:2.509ex;"" alt=""{\displaystyle A\Leftarrow B,A\subset B,A\leftarrow B}""></span></td></tr><tr style=""vertical-align:top""><td style=""text-align:left;""> <a href=""/wiki/Converse_nonimplication"" title=""Converse nonimplication"">converse nonimplication</a></td><td style=""text-align:right;font-size:125%;line-height:0.8em;vertical-align:middle;white-space:nowrap;font-family:serif;""> <span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle A\not \Leftarrow B,A\not \subset B,A\nleftarrow B}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>A</mi>
        <mo>⇍</mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>⊄</mo>
        <mi>B</mi>
        <mo>,</mo>
        <mi>A</mi>
        <mo>↚<!-- ↚ --></mo>
        <mi>B</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle A\not \Leftarrow B,A\not \subset B,A\nleftarrow B}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/651dce7a12fa2331a8c610ee47b32982552a01f4"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.838ex; width:22.917ex; height:2.676ex;"" alt=""{\displaystyle A\not \Leftarrow B,A\not \subset B,A\nleftarrow B}""></span></td></tr></tbody></table></td>
</tr><tr><th class=""sidebar-heading"" style=""background: #eef; text-align: center;"">
Related concepts</th></tr><tr><td class=""sidebar-content"">
<div class=""hlist"" style=""line-height:1.3em;""><ul><li><a href=""/wiki/Propositional_calculus"" title=""Propositional calculus"">Propositional calculus</a></li><li><a href=""/wiki/First-order_logic"" title=""First-order logic"">Predicate logic</a></li><li><a href=""/wiki/Boolean_algebra"" title=""Boolean algebra"">Boolean algebra</a></li><li><a href=""/wiki/Truth_table"" title=""Truth table"">Truth table</a></li><li><a href=""/wiki/Truth_function"" title=""Truth function"">Truth function</a></li><li><a href=""/wiki/Boolean_function"" title=""Boolean function"">Boolean function</a></li><li><a href=""/wiki/Functional_completeness"" title=""Functional completeness"">Functional completeness</a></li><li><a href=""/wiki/Scope_(logic)"" title=""Scope (logic)"">Scope (logic)</a></li></ul></div></td>
</tr><tr><th class=""sidebar-heading"" style=""background: #eef; text-align: center;"">
Applications</th></tr><tr><td class=""sidebar-content"">
<div class=""hlist""><ul><li><a href=""/wiki/Logic_gate"" title=""Logic gate"">Digital logic</a></li><li><a href=""/wiki/Programming_language"" title=""Programming language"">Programming languages</a></li><li><a href=""/wiki/Mathematical_logic"" title=""Mathematical logic"">Mathematical logic</a></li><li><a href=""/wiki/Philosophy_of_logic"" title=""Philosophy of logic"">Philosophy of logic</a></li></ul></div></td>
</tr><tr><td class=""sidebar-below hlist"" style=""background: #eef; text-align: center;"">
<span class=""noviewer"" typeof=""mw:File""><span title=""Category""><img alt="""" src=""//upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/16px-Symbol_category_class.svg.png"" decoding=""async"" width=""16"" height=""16"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/23px-Symbol_category_class.svg.png 1.5x, //upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/31px-Symbol_category_class.svg.png 2x"" data-file-width=""180"" data-file-height=""185""></span></span> <a href=""/wiki/Category:Logical_connectives"" title=""Category:Logical connectives"">Category</a></td></tr><tr><td class=""sidebar-navbar""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Logical_connectives_sidebar"" title=""Template:Logical connectives sidebar""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/w/index.php?title=Template_talk:Logical_connectives_sidebar&amp;action=edit&amp;redlink=1"" class=""new"" title=""Template talk:Logical connectives sidebar (page does not exist)""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Logical_connectives_sidebar"" title=""Special:EditPage/Template:Logical connectives sidebar""><abbr title=""Edit this template"">e</abbr></a></li></ul></div></td></tr></tbody></table>

In [logic](/wiki/Logic ""Logic""), **negation**, also called the **logical not** or **logical complement**, is an [operation](/wiki/Operation_%28mathematics%29 ""Operation (mathematics)"") that takes a [proposition](/wiki/Proposition_%28mathematics%29 ""Proposition (mathematics)"") 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) to another proposition ""not 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a)"", written 

        ¬
        P

    {\displaystyle \neg P}
  
![{\displaystyle \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58), 

            ∼

        P

    {\displaystyle {\mathord {\sim }}P}
  
![{\displaystyle {\mathord {\sim }}P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/9daca81525792364a725ec311d9d762a8a6956a9), 

          P
          
            ′

    {\displaystyle P^{\prime }}
  
![{\displaystyle P^{\prime }}](https://wikimedia.org/api/rest_v1/media/math/render/svg/56ad46bf6f18ec059e93caf8cc3d2db843366b76)^[1]^ or 

            P
            ¯

    {\displaystyle {\overline {P}}}
  
![{\displaystyle {\overline {P}}}](https://wikimedia.org/api/rest_v1/media/math/render/svg/d5e1bed5bc42d4e46dd9e5c7d2fc327927b87169).^[*[citation needed](/wiki/Wikipedia:Citation_needed ""Wikipedia:Citation needed"")*]^ It is interpreted intuitively as being true when 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) is false, and false when 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) is true.^[2]^^[3]^ For example, if 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) is ""Spot runs"", then ""not 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a)"" is ""Spot does not run"". An operand of a negation is called a ***negand*** or ***negatum***.^[4]^

Negation is a [unary](/wiki/Unary_operation ""Unary operation"") [logical connective](/wiki/Logical_connective ""Logical connective""). It may furthermore be applied not only to propositions, but also to [notions](/wiki/Notion_%28philosophy%29 ""Notion (philosophy)""), [truth values](/wiki/Truth_value ""Truth value""), or [semantic values](/wiki/Interpretation_%28logic%29 ""Interpretation (logic)"") more generally. In [classical logic](/wiki/Classical_logic ""Classical logic""), negation is normally identified with the [truth function](/wiki/Truth_function ""Truth function"") that takes *truth* to *falsity* (and vice versa). In [intuitionistic logic](/wiki/Intuitionistic_logic ""Intuitionistic logic""), according to the [Brouwer–Heyting–Kolmogorov interpretation](/wiki/Brouwer%E2%80%93Heyting%E2%80%93Kolmogorov_interpretation ""Brouwer–Heyting–Kolmogorov interpretation""), the negation of a proposition 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) is the proposition whose proofs are the refutations of 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a).

## Definition
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=1 ""Edit section: Definition"")]

*Classical negation* is an [operation](/wiki/Logical_operation ""Logical operation"") on one [logical value](/wiki/Logical_value ""Logical value""), typically the value of a [proposition](/wiki/Proposition ""Proposition""), that produces a value of *true* when its operand is false, and a value of *false* when its operand is true. Thus if statement  

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) is true, then 

        ¬
        P

    {\displaystyle \neg P}
  
![{\displaystyle \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58) (pronounced ""not P"") would then be false; and conversely, if 

        ¬
        P

    {\displaystyle \neg P}
  
![{\displaystyle \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58) is true, then 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) would be false.

The [truth table](/wiki/Truth_table ""Truth table"") of 

        ¬
        P

    {\displaystyle \neg P}
  
![{\displaystyle \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58) is as follows:

    - <table class=""wikitable"" style=""text-align:center; background-color: #ddffdd;"">

<tbody><tr bgcolor=""#ddeeff"">
<td><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle P}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>P</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle P}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:1.745ex; height:2.176ex;"" alt=""{\displaystyle P}""></span></td>
<td><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \neg P}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi mathvariant=""normal"">¬<!-- ¬ --></mi>
        <mi>P</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \neg P}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:3.296ex; height:2.176ex;"" alt=""{\displaystyle \neg P}""></span>
</td></tr>
<tr>
<td style=""background:#bfd; color:black; vertical-align:middle; text-align:center;"" class=""table-yes2"">True</td>
<td style=""background: #FFE3E3; color: black; vertical-align: middle; text-align: center;"" class=""table-no2"">False
</td></tr>
<tr>
<td style=""background: #FFE3E3; color: black; vertical-align: middle; text-align: center;"" class=""table-no2"">False</td>
<td style=""background:#bfd; color:black; vertical-align:middle; text-align:center;"" class=""table-yes2"">True
</td></tr></tbody></table>

Negation can be defined in terms of other logical operations. For example, 

        ¬
        P

    {\displaystyle \neg P}
  
![{\displaystyle \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58) can be defined as 

        P
        →
        ⊥

    {\displaystyle P\rightarrow \bot }
  
![{\displaystyle P\rightarrow \bot }](https://wikimedia.org/api/rest_v1/media/math/render/svg/21af5d568c2fd7384626959ef1f5985e2f59c298) (where 

        →

    {\displaystyle \rightarrow }
  
![{\displaystyle \rightarrow }](https://wikimedia.org/api/rest_v1/media/math/render/svg/53e574cc3aa5b4bf5f3f5906caf121a378eef08b) is [logical consequence](/wiki/Logical_consequence ""Logical consequence"") and 

        ⊥

    {\displaystyle \bot }
  
![{\displaystyle \bot }](https://wikimedia.org/api/rest_v1/media/math/render/svg/f282c7bc331cc3bfcf1c57f1452cc23c022f58de) is [absolute falsehood](/wiki/False_%28logic%29 ""False (logic)"")). Conversely, one can define 

        ⊥

    {\displaystyle \bot }
  
![{\displaystyle \bot }](https://wikimedia.org/api/rest_v1/media/math/render/svg/f282c7bc331cc3bfcf1c57f1452cc23c022f58de) as 

        Q
        ∧
        ¬
        Q

    {\displaystyle Q\land \neg Q}
  
![{\displaystyle Q\land \neg Q}](https://wikimedia.org/api/rest_v1/media/math/render/svg/cdaf497bd9328824019118ed8188eccc249803c6) for any proposition Q (where 

        ∧

    {\displaystyle \land }
  
![{\displaystyle \land }](https://wikimedia.org/api/rest_v1/media/math/render/svg/d6823e5a222eb3ca49672818ac3d13ec607052c4) is [logical conjunction](/wiki/Logical_conjunction ""Logical conjunction"")). The idea here is that any [contradiction](/wiki/Contradiction ""Contradiction"") is false, and while these ideas work in both classical and intuitionistic logic, they do not work in [paraconsistent logic](/wiki/Paraconsistent_logic ""Paraconsistent logic""), where contradictions are not necessarily false. As a further example, negation can be defined in terms of NAND and can also be defined in terms of NOR.

 Algebraically, classical negation corresponds to [complementation](/wiki/Complement_%28order_theory%29 ""Complement (order theory)"") in a [Boolean algebra](/wiki/Boolean_algebra_%28structure%29 ""Boolean algebra (structure)""), and intuitionistic negation to pseudocomplementation in a [Heyting algebra](/wiki/Heyting_algebra ""Heyting algebra""). These algebras provide a [semantics](/wiki/Algebraic_semantics_%28mathematical_logic%29 ""Algebraic semantics (mathematical logic)"") for classical and intuitionistic logic.

## Notation
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=2 ""Edit section: Notation"")]

The negation of a proposition p is notated in different ways, in various contexts of discussion and fields of application. The following table documents some of these variants:

<table class=""wikitable"">

<tbody><tr style=""background:paleturquoise"">
<th>Notation
</th>
<th>Plain text
</th>
<th>Vocalization
</th></tr>
<tr>
<td style=""text-align:center""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \neg p}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi mathvariant=""normal"">¬<!-- ¬ --></mi>
        <mi>p</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \neg p}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/e2b198c79234d926cbee42c0f271d903ea55dc21"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:2.72ex; height:2.009ex;"" alt=""{\displaystyle \neg p}""></span>
</td>
<td style=""text-align:center""><style data-mw-deduplicate=""TemplateStyles:r886049734"">.mw-parser-output .monospaced{font-family:monospace,monospace}</style><span class=""monospaced"">¬p</span> , <link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r886049734""><span class=""monospaced"">7p</span><sup id=""cite_ref-5"" class=""reference""><a href=""#cite_note-5""><span class=""cite-bracket"">[</span>5<span class=""cite-bracket"">]</span></a></sup>
</td>
<td>Not <i>p</i>
</td></tr>
<tr>
<td style=""text-align:center""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle {\mathord {\sim }}p}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mrow class=""MJX-TeXAtom-ORD"">
          <mrow class=""MJX-TeXAtom-ORD"">
            <mo>∼<!-- ∼ --></mo>
          </mrow>
        </mrow>
        <mi>p</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle {\mathord {\sim }}p}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/26fe3458fbf75f8454c1b27de390ad876ef54ccc"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:2.978ex; height:2.009ex;"" alt=""{\displaystyle {\mathord {\sim }}p}""></span>
</td>
<td style=""text-align:center""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r886049734""><span class=""monospaced"">~p</span>
</td>
<td>Not <i>p</i>
</td></tr>
<tr>
<td style=""text-align:center""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle -p}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo>−<!-- − --></mo>
        <mi>p</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle -p}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/233ea0d764a4823bcf8b9a31b2f25f3966e77845"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:2.978ex; height:2.343ex;"" alt=""{\displaystyle -p}""></span>
</td>
<td style=""text-align:center""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r886049734""><span class=""monospaced"">-p</span>
</td>
<td>Not <i>p</i>
</td></tr>
<tr>
<td style=""text-align:center""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle Np}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi>N</mi>
        <mi>p</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle Np}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/48d86ac82f9845ca629f9b3496c0d82908fb60f5"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:3.233ex; height:2.509ex;"" alt=""{\displaystyle Np}""></span>
</td>
<td>
</td>
<td>En <i>p</i>
</td></tr>
<tr>
<td style=""text-align:center""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle p'}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <msup>
          <mi>p</mi>
          <mo>′</mo>
        </msup>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle p'}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/40e623e3163571a220ed60ecb31aa78c24104b85"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; margin-left: -0.089ex; width:1.944ex; height:2.843ex;"" alt=""{\displaystyle p'}""></span>
</td>
<td style=""text-align:center""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r886049734""><span class=""monospaced"">p'</span>
</td>
<td><style data-mw-deduplicate=""TemplateStyles:r1126788409"">.mw-parser-output .plainlist ol,.mw-parser-output .plainlist ul{line-height:inherit;list-style:none;margin:0;padding:0}.mw-parser-output .plainlist ol li,.mw-parser-output .plainlist ul li{margin-bottom:0}</style><div class=""plainlist""><ul><li><i>p</i> prime,</li><li><i>p</i> complement</li></ul></div>
</td></tr>
<tr>
<td style=""text-align:center""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle {\overline {p}}}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mrow class=""MJX-TeXAtom-ORD"">
          <mover>
            <mi>p</mi>
            <mo accent=""false"">¯<!-- ¯ --></mo>
          </mover>
        </mrow>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle {\overline {p}}}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/3884eccbf972d435831da42dd4154e192d550e16"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; margin-left: -0.032ex; width:1.316ex; height:2.676ex;"" alt=""{\displaystyle {\overline {p}}}""></span>
</td>
<td style=""text-align:center""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r886049734""><span class=""monospaced""> ̅p</span>
</td>
<td><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1126788409""><div class=""plainlist""><ul><li><i>p</i> bar,</li><li>Bar <i>p</i></li></ul></div>
</td></tr>
<tr>
<td style=""text-align:center""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle !p}"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo>!</mo>
        <mi>p</mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle !p}</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/937175f4715102052885063560a251ad55aa2e65"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:1.816ex; height:2.509ex;"" alt=""{\displaystyle !p}""></span>
</td>
<td style=""text-align:center""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r886049734""><span class=""monospaced"">!p</span>
</td>
<td><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1126788409""><div class=""plainlist""><ul><li>Bang <i>p</i></li><li>Not <i>p</i></li></ul></div>
</td></tr>
</tbody></table>

The notation 

        N
        p

    {\displaystyle Np}
  
![{\displaystyle Np}](https://wikimedia.org/api/rest_v1/media/math/render/svg/48d86ac82f9845ca629f9b3496c0d82908fb60f5) is [Polish notation](/wiki/Polish_notation#Polish_notation_for_logic ""Polish notation"").

In [set theory](/wiki/Set_theory#Basic_concepts_and_notation ""Set theory""), 

        ∖

    {\displaystyle \setminus }
  
![{\displaystyle \setminus }](https://wikimedia.org/api/rest_v1/media/math/render/svg/d0e20e45087a97f0448fc3d4bc27b060084830f4) is also used to indicate 'not in the set of': 

        U
        ∖
        A

    {\displaystyle U\setminus A}
  
![{\displaystyle U\setminus A}](https://wikimedia.org/api/rest_v1/media/math/render/svg/584717f0e3e8f7f356c27423329325fcb9192e36) is the set of all members of U that are not members of A.

Regardless how it is notated or [symbolized](/wiki/List_of_logic_symbols ""List of logic symbols""), the negation 

        ¬
        P

    {\displaystyle \neg P}
  
![{\displaystyle \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58) can be read as ""it is not the case that P"", ""not that P"", or usually more simply as ""not P"".

### Precedence
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=3 ""Edit section: Precedence"")]

See also: [Logical connective § Order of precedence](/wiki/Logical_connective#Order_of_precedence ""Logical connective"")

As a way of reducing the number of necessary parentheses, one may introduce [precedence rules](/wiki/Precedence_rule ""Precedence rule""): ¬ has higher precedence than ∧, ∧ higher than ∨, and ∨ higher than →. So for example, 

        P
        ∨
        Q
        ∧
        
          ¬
          R
        
        →
        S

    {\displaystyle P\vee Q\wedge {\neg R}\rightarrow S}
  
![{\displaystyle P\vee Q\wedge {\neg R}\rightarrow S}](https://wikimedia.org/api/rest_v1/media/math/render/svg/a1fc0c4ae9cfddb8e178c7f59f2e77bd549afec5) is short for 

        (
        P
        ∨
        (
        Q
        ∧
        (
        ¬
        R
        )
        )
        )
        →
        S
        .

    {\displaystyle (P\vee (Q\wedge (\neg R)))\rightarrow S.}
  
![{\displaystyle (P\vee (Q\wedge (\neg R)))\rightarrow S.}](https://wikimedia.org/api/rest_v1/media/math/render/svg/e09942e077a17c2e657e603c4a66cbe03b12ba42)

Here is a table that shows a commonly used precedence of logical operators.^[6]^

<table class=""wikitable"" style=""text-align: center;"">
<tbody><tr>
<th>Operator</th>
<th>Precedence
</th></tr>
<tr>
<td><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \neg }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi mathvariant=""normal"">¬<!-- ¬ --></mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \neg }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/fa78fd02085d39aa58c9e47a6d4033ce41e02fad"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: 0.204ex; margin-bottom: -0.376ex; width:1.55ex; height:1.176ex;"" alt=""{\displaystyle \neg }""></span></td>
<td>1
</td></tr>
<tr>
<td><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \land }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo>∧<!-- ∧ --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \land }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/d6823e5a222eb3ca49672818ac3d13ec607052c4"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:1.55ex; height:2.009ex;"" alt=""{\displaystyle \land }""></span></td>
<td>2
</td></tr>
<tr>
<td><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \lor }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo>∨<!-- ∨ --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \lor }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/ab47f6b1f589aedcf14638df1d63049d233d851a"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:1.55ex; height:2.009ex;"" alt=""{\displaystyle \lor }""></span></td>
<td>3
</td></tr>
<tr>
<td><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \to }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo stretchy=""false"">→<!-- → --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \to }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/1daab843254cfcb23a643070cf93f3badc4fbbbd"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:2.324ex; height:1.843ex;"" alt=""{\displaystyle \to }""></span></td>
<td>4
</td></tr>
<tr>
<td><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \leftrightarrow }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo stretchy=""false"">↔<!-- ↔ --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \leftrightarrow }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/046b918c43e05caf6624fe9b676c69ec9cd6b892"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:2.324ex; height:1.843ex;"" alt=""{\displaystyle \leftrightarrow }""></span></td>
<td>5
</td></tr></tbody></table>

## Properties
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=4 ""Edit section: Properties"")]

### Double negation
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=5 ""Edit section: Double negation"")]

Within a system of [classical logic](/wiki/Classical_logic ""Classical logic""), double negation, that is, the negation of the negation of a proposition 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a), is [logically equivalent](/wiki/Logically_equivalent ""Logically equivalent"") to 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a).  Expressed in symbolic terms, 

        ¬
        ¬
        P
        ≡
        P

    {\displaystyle \neg \neg P\equiv P}
  
![{\displaystyle \neg \neg P\equiv P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/3bbf8c22800dfe80e6343d84718c229b41aff1d9). In [intuitionistic logic](/wiki/Intuitionistic_logic ""Intuitionistic logic""), a proposition implies its double negation, but not conversely. This marks one important difference between classical and intuitionistic negation. Algebraically, classical negation is called an [involution](/wiki/Involution_%28mathematics%29 ""Involution (mathematics)"") of period two.

However, in [intuitionistic logic](/wiki/Intuitionistic_logic ""Intuitionistic logic""), the weaker equivalence 

        ¬
        ¬
        ¬
        P
        ≡
        ¬
        P

    {\displaystyle \neg \neg \neg P\equiv \neg P}
  
![{\displaystyle \neg \neg \neg P\equiv \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/17089637b8b9487eac521d8650f18e10e1abd327) does hold. This is because in intuitionistic logic, 

        ¬
        P

    {\displaystyle \neg P}
  
![{\displaystyle \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58) is just a shorthand for  

        P
        →
        ⊥

    {\displaystyle P\rightarrow \bot }
  
![{\displaystyle P\rightarrow \bot }](https://wikimedia.org/api/rest_v1/media/math/render/svg/21af5d568c2fd7384626959ef1f5985e2f59c298), and we also have 

        P
        →
        ¬
        ¬
        P

    {\displaystyle P\rightarrow \neg \neg P}
  
![{\displaystyle P\rightarrow \neg \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/dc01898cc16ec321ac4b565e2fabbd988cf70f18). Composing that last implication with triple negation 

        ¬
        ¬
        P
        →
        ⊥

    {\displaystyle \neg \neg P\rightarrow \bot }
  
![{\displaystyle \neg \neg P\rightarrow \bot }](https://wikimedia.org/api/rest_v1/media/math/render/svg/3b4439d01da18810c6313f85f867c21ff42c64d2) implies that 

        P
        →
        ⊥

    {\displaystyle P\rightarrow \bot }
  
![{\displaystyle P\rightarrow \bot }](https://wikimedia.org/api/rest_v1/media/math/render/svg/21af5d568c2fd7384626959ef1f5985e2f59c298) .

As a result, in the propositional case, a sentence is classically provable if its double negation is intuitionistically provable. This result is known as [Glivenko's theorem](/wiki/Double-negation_translation ""Double-negation translation"").

### Distributivity
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=6 ""Edit section: Distributivity"")]

[De Morgan's laws](/wiki/De_Morgan%27s_laws ""De Morgan's laws"") provide a way of [distributing](/wiki/Distributive_property ""Distributive property"") negation over [disjunction](/wiki/Disjunction ""Disjunction"") and [conjunction](/wiki/Logical_conjunction ""Logical conjunction""):

    - ¬
        (
        P
        ∨
        Q
        )
        ≡
        (
        ¬
        P
        ∧
        ¬
        Q
        )

    {\displaystyle \neg (P\lor Q)\equiv (\neg P\land \neg Q)}
  
![{\displaystyle \neg (P\lor Q)\equiv (\neg P\land \neg Q)}](https://wikimedia.org/api/rest_v1/media/math/render/svg/7733a90cbe00f1903dfb0e39c260e014c9a32e1a),  and

    - ¬
        (
        P
        ∧
        Q
        )
        ≡
        (
        ¬
        P
        ∨
        ¬
        Q
        )

    {\displaystyle \neg (P\land Q)\equiv (\neg P\lor \neg Q)}
  
![{\displaystyle \neg (P\land Q)\equiv (\neg P\lor \neg Q)}](https://wikimedia.org/api/rest_v1/media/math/render/svg/71b34ce92fe822e82a92535a6d2afb8ac1d840a6).

### Linearity
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=7 ""Edit section: Linearity"")]

Let 

        ⊕

    {\displaystyle \oplus }
  
![{\displaystyle \oplus }](https://wikimedia.org/api/rest_v1/media/math/render/svg/8b16e2bdaefee9eed86d866e6eba3ac47c710f60) denote the logical [xor](/wiki/Xor ""Xor"") operation. In [Boolean algebra](/wiki/Boolean_algebra ""Boolean algebra""), a linear function is one such that:

If there exists 

          a
          
            0

        ,
        
          a
          
            1

        ,
        …
        ,
        
          a
          
            n

        ∈
        {
        0
        ,
        1
        }

    {\displaystyle a\_{0},a\_{1},\dots ,a\_{n}\in \{0,1\}}
  
![{\displaystyle a_{0},a_{1},\dots ,a_{n}\in \{0,1\}}](https://wikimedia.org/api/rest_v1/media/math/render/svg/224cb631d2e9cbcf4d7f496df0123fa74be206c9),

        f
        (
        
          b
          
            1

        ,
        
          b
          
            2

        ,
        …
        ,
        
          b
          
            n

        )
        =
        
          a
          
            0

        ⊕
        (
        
          a
          
            1

        ∧
        
          b
          
            1

        )
        ⊕
        ⋯
        ⊕
        (
        
          a
          
            n

        ∧
        
          b
          
            n

        )

    {\displaystyle f(b\_{1},b\_{2},\dots ,b\_{n})=a\_{0}\oplus (a\_{1}\land b\_{1})\oplus \dots \oplus (a\_{n}\land b\_{n})}
  
![{\displaystyle f(b_{1},b_{2},\dots ,b_{n})=a_{0}\oplus (a_{1}\land b_{1})\oplus \dots \oplus (a_{n}\land b_{n})}](https://wikimedia.org/api/rest_v1/media/math/render/svg/da68343e4aaa71e605d556df9e0612fef2372f2d),
for all 

          b
          
            1

        ,
        
          b
          
            2

        ,
        …
        ,
        
          b
          
            n

        ∈
        {
        0
        ,
        1
        }

    {\displaystyle b\_{1},b\_{2},\dots ,b\_{n}\in \{0,1\}}
  
![{\displaystyle b_{1},b_{2},\dots ,b_{n}\in \{0,1\}}](https://wikimedia.org/api/rest_v1/media/math/render/svg/d87cb0f3f85beecfefaa6b41810a8b7c2d80e35f).

Another way to express this is that each variable always makes a difference in the [truth-value](/wiki/Truth-value ""Truth-value"") of the operation, or it never makes a difference. Negation is a linear logical operator.

### Self dual
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=8 ""Edit section: Self dual"")]

In [Boolean algebra](/wiki/Boolean_algebra ""Boolean algebra""), a self dual function is a function such that:

        f
        (
        
          a
          
            1

        ,
        …
        ,
        
          a
          
            n

        )
        =
        ¬
        f
        (
        ¬
        
          a
          
            1

        ,
        …
        ,
        ¬
        
          a
          
            n

        )

    {\displaystyle f(a\_{1},\dots ,a\_{n})=\neg f(\neg a\_{1},\dots ,\neg a\_{n})}
  
![{\displaystyle f(a_{1},\dots ,a_{n})=\neg f(\neg a_{1},\dots ,\neg a_{n})}](https://wikimedia.org/api/rest_v1/media/math/render/svg/52dab6fe5a6356c7666bb42c3201cd803cb2d3a8) for all

          a
          
            1

        ,
        …
        ,
        
          a
          
            n

        ∈
        {
        0
        ,
        1
        }

    {\displaystyle a\_{1},\dots ,a\_{n}\in \{0,1\}}
  
![{\displaystyle a_{1},\dots ,a_{n}\in \{0,1\}}](https://wikimedia.org/api/rest_v1/media/math/render/svg/c0eed02a7d3fc2ee57a5a62960bd40d181ec3385).
Negation is a self dual logical operator.

### Negations of quantifiers
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=9 ""Edit section: Negations of quantifiers"")]

In [first-order logic](/wiki/First-order_logic ""First-order logic""), there are two quantifiers, one is the universal quantifier 

        ∀

    {\displaystyle \forall }
  
![{\displaystyle \forall }](https://wikimedia.org/api/rest_v1/media/math/render/svg/bfc1a1a9c4c0f8d5df989c98aa2773ed657c5937) (means ""for all"") and the other is the existential quantifier 

        ∃

    {\displaystyle \exists }
  
![{\displaystyle \exists }](https://wikimedia.org/api/rest_v1/media/math/render/svg/77ed842b6b90b2fdd825320cf8e5265fa937b583) (means ""there exists""). The negation of one quantifier is the other quantifier (

        ¬
        ∀
        x
        P
        (
        x
        )
        ≡
        ∃
        x
        ¬
        P
        (
        x
        )

    {\displaystyle \neg \forall xP(x)\equiv \exists x\neg P(x)}
  
![{\displaystyle \neg \forall xP(x)\equiv \exists x\neg P(x)}](https://wikimedia.org/api/rest_v1/media/math/render/svg/d93041045df4feb6cce740a7773e31dd9576c1e0) and 

        ¬
        ∃
        x
        P
        (
        x
        )
        ≡
        ∀
        x
        ¬
        P
        (
        x
        )

    {\displaystyle \neg \exists xP(x)\equiv \forall x\neg P(x)}
  
![{\displaystyle \neg \exists xP(x)\equiv \forall x\neg P(x)}](https://wikimedia.org/api/rest_v1/media/math/render/svg/fd301c4f840a19ec7bff3606ed9160b011bd19d8)). For example, with the predicate *P* as ""*x* is mortal"" and the domain of x as the collection of all humans, 

        ∀
        x
        P
        (
        x
        )

    {\displaystyle \forall xP(x)}
  
![{\displaystyle \forall xP(x)}](https://wikimedia.org/api/rest_v1/media/math/render/svg/25873948fc98344950ea1b91f88dd52239cf9c87) means ""a person x in all humans is mortal"" or ""all humans are mortal"". The negation of it is 

        ¬
        ∀
        x
        P
        (
        x
        )
        ≡
        ∃
        x
        ¬
        P
        (
        x
        )

    {\displaystyle \neg \forall xP(x)\equiv \exists x\neg P(x)}
  
![{\displaystyle \neg \forall xP(x)\equiv \exists x\neg P(x)}](https://wikimedia.org/api/rest_v1/media/math/render/svg/d93041045df4feb6cce740a7773e31dd9576c1e0), meaning ""there exists a person *x* in all humans who is not mortal"", or ""there exists someone who lives forever"".

## Rules of inference
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=10 ""Edit section: Rules of inference"")]

See also: [Double negation](/wiki/Double_negation ""Double negation"")

There are a number of equivalent ways to formulate rules for negation. One usual way to formulate classical negation in a [natural deduction](/wiki/Natural_deduction ""Natural deduction"") setting is to take as primitive rules of inference *negation introduction* (from a derivation of 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) to both 

        Q

    {\displaystyle Q}
  
![{\displaystyle Q}](https://wikimedia.org/api/rest_v1/media/math/render/svg/8752c7023b4b3286800fe3238271bbca681219ed) and 

        ¬
        Q

    {\displaystyle \neg Q}
  
![{\displaystyle \neg Q}](https://wikimedia.org/api/rest_v1/media/math/render/svg/fad34798abb0bbbc063c906e459f103a09b1660e), infer 

        ¬
        P

    {\displaystyle \neg P}
  
![{\displaystyle \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58); this rule also being called *[reductio ad absurdum](/wiki/Reductio_ad_absurdum ""Reductio ad absurdum"")*), *negation elimination* (from 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) and 

        ¬
        P

    {\displaystyle \neg P}
  
![{\displaystyle \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58) infer 

        Q

    {\displaystyle Q}
  
![{\displaystyle Q}](https://wikimedia.org/api/rest_v1/media/math/render/svg/8752c7023b4b3286800fe3238271bbca681219ed); this rule also being called *ex falso quodlibet*), and *double negation elimination* (from 

        ¬
        ¬
        P

    {\displaystyle \neg \neg P}
  
![{\displaystyle \neg \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/53d7b8bafb9762c3a07924b6c06be6e08cb5680f) infer 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a)). One obtains the rules for intuitionistic negation the same way but by excluding double negation elimination.

Negation introduction states that if an absurdity can be drawn as conclusion from 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) then 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) must not be the case (i.e. 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) is false (classically) or refutable (intuitionistically) or etc.). Negation elimination states that anything follows from an absurdity. Sometimes negation elimination is formulated using a primitive absurdity sign 

        ⊥

    {\displaystyle \bot }
  
![{\displaystyle \bot }](https://wikimedia.org/api/rest_v1/media/math/render/svg/f282c7bc331cc3bfcf1c57f1452cc23c022f58de). In this case the rule says that from 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) and 

        ¬
        P

    {\displaystyle \neg P}
  
![{\displaystyle \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58) follows an absurdity. Together with double negation elimination one may infer our originally formulated rule, namely that anything follows from an absurdity.

Typically the intuitionistic negation 

        ¬
        P

    {\displaystyle \neg P}
  
![{\displaystyle \neg P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/5eb0d6c8752f8c7256d69c62e77dfe4c466dbe58) of 

        P

    {\displaystyle P}
  
![{\displaystyle P}](https://wikimedia.org/api/rest_v1/media/math/render/svg/b4dc73bf40314945ff376bd363916a738548d40a) is defined as 

        P
        →
        ⊥

    {\displaystyle P\rightarrow \bot }
  
![{\displaystyle P\rightarrow \bot }](https://wikimedia.org/api/rest_v1/media/math/render/svg/21af5d568c2fd7384626959ef1f5985e2f59c298). Then negation introduction and elimination are just special cases of implication introduction ([conditional proof](/wiki/Conditional_proof ""Conditional proof"")) and elimination (*[modus ponens](/wiki/Modus_ponens ""Modus ponens"")*). In this case one must also add as a primitive rule *ex falso quodlibet*.

## Programming language and ordinary language
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=11 ""Edit section: Programming language and ordinary language"")]

""!vote"" redirects here. For use of !votes in Wikipedia discussions, see [Wikipedia:Polling is not a substitute for discussion § Not-votes](/wiki/Wikipedia:Polling_is_not_a_substitute_for_discussion#Not-votes ""Wikipedia:Polling is not a substitute for discussion"").

As in mathematics, negation is used in [computer science](/wiki/Computer_science ""Computer science"") to construct logical statements.

```lang
if (!(r == t))
{
    /*...statements executed when r does NOT equal t...*/
}
```

The [exclamation mark](/wiki/Exclamation_mark ""Exclamation mark"") ""`!`"" signifies logical NOT in [B](/wiki/B_%28programming_language%29 ""B (programming language)""), [C](/wiki/C_Programming_Language ""C Programming Language""), and languages with a C-inspired syntax such as [C++](/wiki/C%2B%2B ""C++""), [Java](/wiki/Java_%28programming_language%29 ""Java (programming language)""), [JavaScript](/wiki/JavaScript ""JavaScript""), [Perl](/wiki/Perl ""Perl""), and [PHP](/wiki/PHP ""PHP""). ""`NOT`"" is the operator used in [ALGOL 60](/wiki/ALGOL_60 ""ALGOL 60""), [BASIC](/wiki/BASIC ""BASIC""), and languages with an ALGOL- or BASIC-inspired syntax such as [Pascal](/wiki/Pascal_programming_language ""Pascal programming language""), [Ada](/wiki/Ada_programming_language ""Ada programming language""), [Eiffel](/wiki/Eiffel_%28programming_language%29 ""Eiffel (programming language)"") and [Seed7](/wiki/Seed7 ""Seed7""). Some languages (C++, Perl, etc.) provide more than one operator for negation. A few languages like [PL/I](/wiki/PL/I ""PL/I"") and [Ratfor](/wiki/Ratfor ""Ratfor"") use `¬` for negation. Most modern languages allow the above statement to be shortened from `if (!(r == t))` to `if (r != t)`, which allows sometimes, when the compiler/interpreter is not able to optimize it, faster programs.

In computer science there is also *[bitwise negation](/wiki/Bitwise_negation ""Bitwise negation"")*. This takes the value given and switches all the [binary](/wiki/Binary_numeral_system ""Binary numeral system"") 1s to 0s and 0s to 1s.  This is often used to create [ones' complement](/wiki/Signed_number_representations ""Signed number representations"") (or ""`~`"" in C or C++) and [two's complement](/wiki/Two%27s_complement ""Two's complement"") (just simplified to ""`-`"" or the [negative sign](/wiki/Negative_sign ""Negative sign""), as this is equivalent to taking the [arithmetic negation](/wiki/Negation_%28arithmetic%29 ""Negation (arithmetic)"") of the number).

To get the absolute (positive equivalent) value of a given integer the following would work as the ""`-`"" changes it from negative to positive (it is negative because ""`x < 0`"" yields true)

```lang
unsigned int abs(int x)
{
    if (x < 0)
        return -x;
    else
        return x;
}
```

To demonstrate logical negation:

```lang
unsigned int abs(int x)
{
    if (!(x < 0))
        return x;
    else
        return -x;
}
```

Inverting the condition and reversing the outcomes produces code that is logically equivalent to the original code, i.e. will have identical results for any input (depending on the compiler used, the actual instructions performed by the computer may differ).

In C (and some other languages descended from C), double negation (`!!x`) is used as an [idiom](/wiki/Programming_idiom ""Programming idiom"") to convert `x` to a canonical Boolean, ie. an integer with a value of either 0 or 1 and no other. Although any integer other than 0 is logically true in C and 1 is not special in this regard, it is sometimes important to ensure that a canonical value is used, for example for printing or if the number is subsequently used for arithmetic operations.^[7]^

The convention of using `!` to signify negation occasionally surfaces in ordinary written speech, as computer-related [slang](/wiki/Slang ""Slang"") for *not*.  For example, the phrase `!voting` means ""[not voting](/wiki/Not_voting ""Not voting"")"".  Another example is the phrase `!clue` which is used as a synonym for ""no-clue"" or ""clueless"".^[8]^^[9]^

## Kripke semantics
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=12 ""Edit section: Kripke semantics"")]

In [Kripke semantics](/wiki/Kripke_semantics ""Kripke semantics"") where the semantic values of formulae are sets of [possible worlds](/wiki/Possible_world ""Possible world""), negation can be taken to mean [set-theoretic complementation](/wiki/Set-theoretic_complement ""Set-theoretic complement"")^[*[citation needed](/wiki/Wikipedia:Citation_needed ""Wikipedia:Citation needed"")*]^ (see also [possible world semantics](/wiki/Possible_world_semantics ""Possible world semantics"") for more).

## See also
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=13 ""Edit section: See also"")]

- [Affirmation and negation](/wiki/Affirmation_and_negation ""Affirmation and negation"") (grammatical polarity)
- [Ampheck](/wiki/Ampheck ""Ampheck"")
- [Apophasis](/wiki/Apophasis ""Apophasis"")
- [Binary opposition](/wiki/Binary_opposition ""Binary opposition"")
- [Bitwise NOT](/wiki/Bitwise_NOT ""Bitwise NOT"")
- [Contraposition](/wiki/Contraposition ""Contraposition"")
- [Cyclic negation](/wiki/Cyclic_negation ""Cyclic negation"")
- [Negation as failure](/wiki/Negation_as_failure ""Negation as failure"")
- [NOT gate](/wiki/NOT_gate ""NOT gate"")
- [Plato's beard](/wiki/Plato%27s_beard ""Plato's beard"")
- [Square of opposition](/wiki/Square_of_opposition ""Square of opposition"")

## References
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=14 ""Edit section: References"")]

1. **^** Virtually all Turkish high school math textbooks use p' for negation due to the books handed out by the Ministry of National Education representing it as p'.
2. **^** Weisstein, Eric W. [""Negation""](https://mathworld.wolfram.com/Negation.html). *mathworld.wolfram.com*. Retrieved 2 September 2020.
3. **^** [""Logic and Mathematical Statements - Worked Examples""](https://www.math.toronto.edu/preparing-for-calculus/3_logic/we_3_negation.html). *www.math.toronto.edu*. Retrieved 2 September 2020.
4. **^** Beall, Jeffrey C. (2010). *Logic: the basics* (1. publ ed.). London: Routledge. p. 57. [ISBN](/wiki/ISBN_%28identifier%29 ""ISBN (identifier)"") [978-0-203-85155-5](/wiki/Special:BookSources/978-0-203-85155-5 ""Special:BookSources/978-0-203-85155-5"").
5. **^** Used as makeshift in early typewriter publications, e.g. Richard E. Ladner (January 1975). ""The circuit value problem is log space complete for P"". *ACM SIGACT News*. **7** (101): 18–20. [doi](/wiki/Doi_%28identifier%29 ""Doi (identifier)""):[10.1145/990518.990519](https://doi.org/10.1145%2F990518.990519).
6. **^** O'Donnell, John; Hall, Cordelia; Page, Rex (2007), [*Discrete Mathematics Using a Computer*](https://books.google.com/books?id=KKxyQQWQam4C&amp;pg=PA120), Springer, p. 120, [ISBN](/wiki/ISBN_%28identifier%29 ""ISBN (identifier)"") [9781846285981](/wiki/Special:BookSources/9781846285981 ""Special:BookSources/9781846285981"").
7. **^** Egan, David. [""Double Negation Operator Convert to Boolean in C""](https://dev-notes.eu/2019/10/Double-Negation-Operator-Convert-to-Boolean-in-C/). *Dev Notes*.
8. **^** [Raymond, Eric](/wiki/Eric_S._Raymond ""Eric S. Raymond"") and Steele, Guy.  [The New Hacker's Dictionary](https://books.google.com/books?id=g80P_4v4QbIC&amp;pg=PA18&amp;lpg=PA18), p. 18 (MIT Press 1996).
9. **^** Munat, Judith.  [Lexical Creativity, Texts and Context](https://books.google.com/books?id=UOPXXYslemYC&amp;pg=PA148&amp;lpg=PA148), p. 148 (John Benjamins Publishing, 2007).

## Further reading
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=15 ""Edit section: Further reading"")]

- [Gabbay, Dov](/wiki/Dov_Gabbay ""Dov Gabbay""), and Wansing, Heinrich, eds., 1999. *What is Negation?*, [Kluwer](/wiki/Kluwer ""Kluwer"").
- [Horn, L.](/wiki/Laurence_R._Horn ""Laurence R. Horn""), 2001. *A Natural History of Negation*, [University of Chicago Press](/wiki/University_of_Chicago_Press ""University of Chicago Press"").
- [G. H. von Wright](/wiki/G._H._von_Wright ""G. H. von Wright""), 1953–59, ""On the Logic of Negation"", *Commentationes Physico-Mathematicae 22*.
- Wansing, Heinrich, 2001, ""Negation"", in Goble, Lou, ed., *The Blackwell Guide to Philosophical Logic*, [Blackwell](/wiki/Wiley-Blackwell ""Wiley-Blackwell"").
- Tettamanti, Marco; Manenti, Rosa; Della Rosa, Pasquale A.; Falini, Andrea; Perani, Daniela; Cappa, Stefano F.; Moro, Andrea (2008). ""Negation in the brain: Modulating action representation"". *NeuroImage*. **43** (2): 358–367. [doi](/wiki/Doi_%28identifier%29 ""Doi (identifier)""):[10.1016/j.neuroimage.2008.08.004](https://doi.org/10.1016%2Fj.neuroimage.2008.08.004). [PMID](/wiki/PMID_%28identifier%29 ""PMID (identifier)"") [18771737](https://pubmed.ncbi.nlm.nih.gov/18771737). [S2CID](/wiki/S2CID_%28identifier%29 ""S2CID (identifier)"") [17658822](https://api.semanticscholar.org/CorpusID:17658822).

## External links
[[edit](/w/index.php?title=Negation&amp;action=edit&amp;section=16 ""Edit section: External links"")]

- Horn, Laurence R.; Wansing, Heinrich. [""Negation""](https://plato.stanford.edu/entries/negation/). In [Zalta, Edward N.](/wiki/Edward_N._Zalta ""Edward N. Zalta"") (ed.). *[Stanford Encyclopedia of Philosophy](/wiki/Stanford_Encyclopedia_of_Philosophy ""Stanford Encyclopedia of Philosophy"")*.
- [""Negation""](https://www.encyclopediaofmath.org/index.php?title=Negation), *[Encyclopedia of Mathematics](/wiki/Encyclopedia_of_Mathematics ""Encyclopedia of Mathematics"")*, [EMS Press](/wiki/European_Mathematical_Society ""European Mathematical Society""), 2001 [1994]
- [NOT](http://mathworld.wolfram.com/NOT.html), on [MathWorld](/wiki/MathWorld ""MathWorld"")

- [Tables of Truth](/wiki/Truth_table ""Truth table"") of composite clauses

- [""Table of truth for a NOT clause applied to an END sentence""](http://www.math.hawaii.edu/~ramsey/Logic/NotAnd.html). [Archived](https://web.archive.org/web/20000301195359/http://www.math.hawaii.edu/~ramsey/Logic/NotAnd.html) from the original on 1 March 2000.
- [""NOT clause of an END sentence""](http://www.math.hawaii.edu/~ramsey/Logic/NotAnd.html). [Archived](https://web.archive.org/web/20000301195359/http://www.math.hawaii.edu/~ramsey/Logic/NotAnd.html) from the original on 1 March 2000.
- [""NOT clause of an OR sentence""](http://www.math.hawaii.edu/~ramsey/Logic/NotOr.html). [Archived](https://web.archive.org/web/20000117134708/http://www.math.hawaii.edu/~ramsey/Logic/NotOr.html) from the original on 17 January 2000.
- [""NOT clause of an IF...THEN period""](http://www.math.hawaii.edu/~ramsey/Logic/NotIfThen.html). [Archived](https://web.archive.org/web/20000301223435/http://www.math.hawaii.edu/~ramsey/Logic/NotIfThen.html/) from the original on 1 March 2000.

<table class=""nowraplinks mw-collapsible autocollapse navbox-inner mw-made-collapsible mw-collapsed"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""3""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Logical_connectives"" title=""Template:Logical connectives""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Logical_connectives"" title=""Template talk:Logical connectives""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Logical_connectives"" title=""Special:EditPage/Template:Logical connectives""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Common_logical_connectives157"" style=""font-size:114%;margin:0 4em"">Common <a href=""/wiki/Logical_connective"" title=""Logical connective"">logical connectives</a></div></th></tr><tr style=""display: none;""><td colspan=""2"" class=""navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Tautology_(logic)"" title=""Tautology (logic)"">Tautology</a>/<a href=""/wiki/Logical_truth"" title=""Logical truth"">True</a>&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \top }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi mathvariant=""normal"">⊤<!-- ⊤ --></mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \top }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/cf12e436fef2365e76fcb1034a51179d8328bb33"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:1.808ex; height:2.176ex;"" alt=""{\displaystyle \top }""></span></li></ul>
</div></td><td class=""noviewer navbox-image"" rowspan=""5"" style=""width:1px;padding:0 0 0 2px""><div><span typeof=""mw:File""><a href=""/wiki/File:Logical_connectives_Hasse_diagram.svg"" class=""mw-file-description""><img src=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Logical_connectives_Hasse_diagram.svg/120px-Logical_connectives_Hasse_diagram.svg.png"" decoding=""async"" width=""80"" height=""113"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Logical_connectives_Hasse_diagram.svg/250px-Logical_connectives_Hasse_diagram.svg.png 2x"" data-file-width=""744"" data-file-height=""1052""></a></span></div></td></tr><tr style=""display: none;""><td colspan=""2"" class=""navbox-list navbox-even hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Sheffer_stroke"" title=""Sheffer stroke"">Alternative denial</a>&nbsp;(<a href=""/wiki/NAND_gate"" title=""NAND gate"">NAND gate</a>)&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \uparrow }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo stretchy=""false"">↑<!-- ↑ --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \uparrow }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/ddb20b28c74cdaa09e1f101d426441da1996072f"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:1.162ex; height:2.509ex;"" alt=""{\displaystyle \uparrow }""></span></li>
<li><a href=""/wiki/Converse_(logic)"" title=""Converse (logic)"">Converse implication</a>&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \leftarrow }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo stretchy=""false"">←<!-- ← --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \leftarrow }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/3c0fb4bce772117bbaf55b7ca1539ceff9ae218c"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:2.324ex; height:1.843ex;"" alt=""{\displaystyle \leftarrow }""></span></li>
<li><a href=""/wiki/Material_conditional"" title=""Material conditional"">Implication</a>&nbsp;(<a href=""/wiki/IMPLY_gate"" title=""IMPLY gate"">IMPLY gate</a>)&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \rightarrow }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo stretchy=""false"">→<!-- → --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \rightarrow }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/53e574cc3aa5b4bf5f3f5906caf121a378eef08b"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:2.324ex; height:1.843ex;"" alt=""{\displaystyle \rightarrow }""></span></li>
<li><a href=""/wiki/Logical_disjunction"" title=""Logical disjunction"">Disjunction</a>&nbsp;(<a href=""/wiki/OR_gate"" title=""OR gate"">OR gate</a>)&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \lor }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo>∨<!-- ∨ --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \lor }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/ab47f6b1f589aedcf14638df1d63049d233d851a"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:1.55ex; height:2.009ex;"" alt=""{\displaystyle \lor }""></span></li></ul>
</div></td></tr><tr style=""display: none;""><td colspan=""2"" class=""navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a class=""mw-selflink selflink"">Negation</a>&nbsp;(<a href=""/wiki/Inverter_(logic_gate)"" title=""Inverter (logic gate)"">NOT gate</a>)&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \neg }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi mathvariant=""normal"">¬<!-- ¬ --></mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \neg }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/fa78fd02085d39aa58c9e47a6d4033ce41e02fad"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: 0.204ex; margin-bottom: -0.376ex; width:1.55ex; height:1.176ex;"" alt=""{\displaystyle \neg }""></span></li>
<li><a href=""/wiki/Exclusive_or"" title=""Exclusive or"">Exclusive or</a>&nbsp;(<a href=""/wiki/XOR_gate"" title=""XOR gate"">XOR gate</a>)&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \not \leftrightarrow }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo>↮</mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \not \leftrightarrow }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/363ed81fd02da85c658dde9f17737c13b7263e49"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: 0.137ex; margin-bottom: -0.308ex; width:2.324ex; height:1.509ex;"" alt=""{\displaystyle \not \leftrightarrow }""></span></li>
<li><a href=""/wiki/Logical_biconditional"" title=""Logical biconditional"">Biconditional</a>&nbsp;(<a href=""/wiki/XNOR_gate"" title=""XNOR gate"">XNOR gate</a>)&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \leftrightarrow }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo stretchy=""false"">↔<!-- ↔ --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \leftrightarrow }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/046b918c43e05caf6624fe9b676c69ec9cd6b892"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:2.324ex; height:1.843ex;"" alt=""{\displaystyle \leftrightarrow }""></span></li>
<li><a href=""/wiki/Statement_(logic)"" title=""Statement (logic)"">Statement</a>&nbsp;(<a href=""/wiki/Digital_buffer"" title=""Digital buffer"">Digital buffer</a>)</li></ul>
</div></td></tr><tr style=""display: none;""><td colspan=""2"" class=""navbox-list navbox-even hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Logical_NOR"" title=""Logical NOR"">Joint denial</a>&nbsp;(<a href=""/wiki/NOR_gate"" title=""NOR gate"">NOR gate</a>)&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \downarrow }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo stretchy=""false"">↓<!-- ↓ --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \downarrow }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/4618f22b0f780805eb94bb407578d9bc9487947a"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.671ex; width:1.162ex; height:2.509ex;"" alt=""{\displaystyle \downarrow }""></span></li>
<li><a href=""/wiki/Material_nonimplication"" title=""Material nonimplication"">Nonimplication</a>&nbsp;(<a href=""/wiki/NIMPLY_gate"" title=""NIMPLY gate"">NIMPLY gate</a>)&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \nrightarrow }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo>↛<!-- ↛ --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \nrightarrow }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/4c458d67617e028ed10948d2dbcfef80e9e060a2"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: 0.137ex; margin-bottom: -0.308ex; width:2.324ex; height:1.509ex;"" alt=""{\displaystyle \nrightarrow }""></span></li>
<li><a href=""/wiki/Converse_nonimplication"" title=""Converse nonimplication"">Converse nonimplication</a>&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \nleftarrow }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo>↚<!-- ↚ --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \nleftarrow }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/7694c9fc8eebe8a57c8156dd3c2caf022a619439"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: 0.137ex; margin-bottom: -0.308ex; width:2.324ex; height:1.509ex;"" alt=""{\displaystyle \nleftarrow }""></span></li>
<li><a href=""/wiki/Logical_conjunction"" title=""Logical conjunction"">Conjunction</a>&nbsp;(<a href=""/wiki/AND_gate"" title=""AND gate"">AND gate</a>)&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \land }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mo>∧<!-- ∧ --></mo>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \land }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/d6823e5a222eb3ca49672818ac3d13ec607052c4"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:1.55ex; height:2.009ex;"" alt=""{\displaystyle \land }""></span></li></ul>
</div></td></tr><tr style=""display: none;""><td colspan=""2"" class=""navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Contradiction"" title=""Contradiction"">Contradiction</a>/<a href=""/wiki/False_(logic)"" title=""False (logic)"">False</a>&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \bot }"">
  <semantics>
    <mrow class=""MJX-TeXAtom-ORD"">
      <mstyle displaystyle=""true"" scriptlevel=""0"">
        <mi mathvariant=""normal"">⊥<!-- ⊥ --></mi>
      </mstyle>
    </mrow>
    <annotation encoding=""application/x-tex"">{\displaystyle \bot }</annotation>
  </semantics>
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/f282c7bc331cc3bfcf1c57f1452cc23c022f58de"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.338ex; width:1.808ex; height:2.176ex;"" alt=""{\displaystyle \bot }""></span></li></ul>
</div></td></tr><tr style=""display: none;""><td class=""navbox-abovebelow"" colspan=""3""><div><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><span><img alt="""" src=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/18px-Socrates.png"" decoding=""async"" width=""18"" height=""28"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/27px-Socrates.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/36px-Socrates.png 2x"" data-file-width=""326"" data-file-height=""500""></span></span> </span><a href=""/wiki/Portal:Philosophy"" title=""Portal:Philosophy"">Philosophy portal</a></div></td></tr></tbody></table>

<table class=""nowraplinks mw-collapsible autocollapse navbox-inner mw-made-collapsible mw-collapsed"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""2""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Common_logical_symbols"" title=""Template:Common logical symbols""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Common_logical_symbols"" title=""Template talk:Common logical symbols""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Common_logical_symbols"" title=""Special:EditPage/Template:Common logical symbols""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Common_logical_symbols334"" style=""font-size:114%;margin:0 4em"">Common <a href=""/wiki/List_of_logic_symbols"" title=""List of logic symbols"">logical symbols</a></div></th></tr><tr style=""display: none;""><td colspan=""2"" class=""navbox-list navbox-odd"" style=""width:100%;padding:0;background:transparent;color:inherit;""><div style=""padding:0px""><table class=""navbox-columns-table"" style=""border-spacing: 0px; text-align:left;width:100%;""><tbody><tr style=""vertical-align:top""><td class=""navbox-list"" style=""padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Wedge_(symbol)"" title=""Wedge (symbol)"">∧</a> &nbsp;<span style=""font-size:55%;""><i>or</i></span>&nbsp; <a href=""/wiki/Ampersand"" title=""Ampersand"">&amp;</a> </div> <a href=""/wiki/Logical_conjunction"" title=""Logical conjunction"">and</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Vel_(symbol)"" class=""mw-redirect"" title=""Vel (symbol)"">∨</a>        </div> <a href=""/wiki/Logical_disjunction"" title=""Logical disjunction"">or</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a class=""mw-selflink selflink"">¬</a> &nbsp;<span style=""font-size:55%;""><i>or</i></span>&nbsp; <a href=""/wiki/Tilde"" title=""Tilde"">~</a> </div> <a class=""mw-selflink selflink"">not</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Arrow_(symbol)"" title=""Arrow (symbol)"">→</a>      </div> <a href=""/wiki/Material_conditional"" title=""Material conditional"">implies</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Horseshoe_(symbol)"" title=""Horseshoe (symbol)"">⊃</a>  </div> <a href=""/wiki/Material_conditional"" title=""Material conditional"">implies</a>,<br><a href=""/wiki/Subset"" title=""Subset"">superset</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Arrow_(symbol)"" title=""Arrow (symbol)"">↔</a> &nbsp;<span style=""font-size:55%;""><i>or</i></span>&nbsp; <a href=""/wiki/Triple_bar"" title=""Triple bar"">≡</a> </div> <a href=""/wiki/If_and_only_if"" title=""If and only if"">iff</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Sheffer_stroke"" title=""Sheffer stroke"">|</a>  </div> <a href=""/wiki/Sheffer_stroke"" title=""Sheffer stroke"">nand</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Turned_A"" title=""Turned A"">∀</a>            </div> <div style=""display: inline-block; line-height: 1.2em; padding: .1em 0; line-height:1.15em""><a href=""/wiki/Universal_quantification"" title=""Universal quantification"">universal<br>quantification</a></div>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Existential_quantification"" title=""Existential quantification"">∃</a>            </div> <div style=""display: inline-block; line-height: 1.2em; padding: .1em 0; line-height:1.15em""><a href=""/wiki/Existential_quantification"" title=""Existential quantification"">existential<br>quantification</a></div>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Tee_(symbol)"" title=""Tee (symbol)"">⊤</a>        </div> <a href=""/wiki/True_(logic)"" class=""mw-redirect"" title=""True (logic)"">true</a>,<br><a href=""/wiki/Tautology_(logic)"" title=""Tautology (logic)"">tautology</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Up_tack"" title=""Up tack"">⊥</a>             </div> <a href=""/wiki/False_(logic)"" title=""False (logic)"">false</a>,<br><a href=""/wiki/Contradiction"" title=""Contradiction"">contradiction</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Turnstile_(symbol)"" title=""Turnstile (symbol)"">⊢</a>  </div> <a href=""/wiki/Turnstile_(symbol)"" title=""Turnstile (symbol)"">entails,<br>proves</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Double_turnstile"" title=""Double turnstile"">⊨</a>    </div> <a href=""/wiki/Double_turnstile"" title=""Double turnstile"">entails,<br>therefore</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Therefore_sign"" title=""Therefore sign"">∴</a>      </div> <a href=""/wiki/Logical_consequence"" title=""Logical consequence"">therefore</a>
</div></td><td class=""navbox-list"" style=""border-left:2px solid #fdfdfd;padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
<div style=""font-size:150%;margin-bottom:0.55em;""> <a href=""/wiki/Therefore_sign#Similar_signs"" title=""Therefore sign"">∵</a> </div> <a href=""/wiki/Therefore_sign#Similar_signs"" title=""Therefore sign"">because</a>
</div></td></tr></tbody></table></div></td></tr><tr style=""display: none;""><td class=""navbox-abovebelow"" colspan=""2""><div><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><span><img alt="""" src=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/18px-Socrates.png"" decoding=""async"" width=""18"" height=""28"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/27px-Socrates.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/36px-Socrates.png 2x"" data-file-width=""326"" data-file-height=""500""></span></span> </span><a href=""/wiki/Portal:Philosophy"" title=""Portal:Philosophy"">Philosophy portal</a><br><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><a href=""/wiki/File:Nuvola_apps_edu_mathematics_blue-p.svg"" class=""mw-file-description""><img alt=""icon"" src=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/28px-Nuvola_apps_edu_mathematics_blue-p.svg.png"" decoding=""async"" width=""28"" height=""28"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/42px-Nuvola_apps_edu_mathematics_blue-p.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/56px-Nuvola_apps_edu_mathematics_blue-p.svg.png 2x"" data-file-width=""128"" data-file-height=""128""></a></span> </span><a href=""/wiki/Portal:Mathematics"" title=""Portal:Mathematics"">Mathematics portal</a></div></td></tr></tbody></table>

<table class=""nowraplinks mw-collapsible autocollapse navbox-inner mw-made-collapsible mw-collapsed"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""2""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Formal_semantics"" title=""Template:Formal semantics""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Formal_semantics"" title=""Template talk:Formal semantics""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Formal_semantics"" title=""Special:EditPage/Template:Formal semantics""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Formal_semantics_(natural_language)78"" style=""font-size:114%;margin:0 4em""><a href=""/wiki/Formal_semantics_(natural_language)"" title=""Formal semantics (natural language)"">Formal semantics (natural language)</a></div></th></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%"">Central concepts</th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Principle_of_compositionality"" title=""Principle of compositionality"">Compositionality</a></li>
<li><a href=""/wiki/Denotation"" title=""Denotation"">Denotation</a></li>
<li><a href=""/wiki/Entailment_(linguistics)"" title=""Entailment (linguistics)"">Entailment</a></li>
<li><a href=""/wiki/Extension_(semantics)"" title=""Extension (semantics)"">Extension</a></li>
<li><a href=""/wiki/Generalized_quantifier"" title=""Generalized quantifier"">Generalized quantifier</a></li>
<li><a href=""/wiki/Intension"" title=""Intension"">Intension</a></li>
<li><a href=""/wiki/Logical_form_(linguistics)"" title=""Logical form (linguistics)"">Logical form</a></li>
<li><a href=""/wiki/Presupposition"" title=""Presupposition"">Presupposition</a></li>
<li><a href=""/wiki/Proposition"" title=""Proposition"">Proposition</a></li>
<li><a href=""/wiki/Reference"" title=""Reference"">Reference</a></li>
<li><a href=""/wiki/Scope_(formal_semantics)"" title=""Scope (formal semantics)"">Scope</a></li>
<li><a href=""/wiki/Speech_act"" title=""Speech act"">Speech act</a></li>
<li><a href=""/wiki/Syntax%E2%80%93semantics_interface"" title=""Syntax–semantics interface"">Syntax–semantics interface</a></li>
<li><a href=""/wiki/Truth-conditional_semantics"" title=""Truth-conditional semantics"">Truth conditions</a></li></ul>
</div></td></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%"">Topics</th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""></div><table class=""nowraplinks navbox-subgroup"" style=""border-spacing:0""><tbody><tr><th scope=""row"" class=""navbox-group"" style=""width:1%"">Areas</th><td class=""navbox-list-with-group navbox-list navbox-even"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Anaphora_(linguistics)"" title=""Anaphora (linguistics)"">Anaphora</a></li>
<li><a href=""/wiki/Ambiguity"" title=""Ambiguity"">Ambiguity</a></li>
<li><a href=""/wiki/Binding_(linguistics)"" title=""Binding (linguistics)"">Binding</a></li>
<li><a href=""/wiki/Conditional_sentence"" title=""Conditional sentence"">Conditionals</a></li>
<li><a href=""/wiki/Definiteness"" title=""Definiteness"">Definiteness</a></li>
<li><a href=""/wiki/Disjunction"" class=""mw-redirect"" title=""Disjunction"">Disjunction</a></li>
<li><a href=""/wiki/Evidentiality"" title=""Evidentiality"">Evidentiality</a></li>
<li><a href=""/wiki/Focus_(linguistics)"" title=""Focus (linguistics)"">Focus</a></li>
<li><a href=""/wiki/Indexicality"" title=""Indexicality"">Indexicality</a></li>
<li><a href=""/wiki/Lexical_semantics"" title=""Lexical semantics"">Lexical semantics</a></li>
<li><a href=""/wiki/Linguistic_modality"" class=""mw-redirect"" title=""Linguistic modality"">Modality</a></li>
<li><a class=""mw-selflink selflink"">Negation</a></li>
<li><a href=""/wiki/Propositional_attitudes"" class=""mw-redirect"" title=""Propositional attitudes"">Propositional attitudes</a></li>
<li><a href=""/wiki/Tense%E2%80%93aspect%E2%80%93mood"" title=""Tense–aspect–mood"">Tense–aspect–mood</a></li>
<li><a href=""/wiki/Quantifier_(logic)"" title=""Quantifier (logic)"">Quantification</a></li>
<li><a href=""/wiki/Vagueness"" title=""Vagueness"">Vagueness</a></li></ul>
</div></td></tr><tr><th scope=""row"" class=""navbox-group"" style=""width:1%"">Phenomena</th><td class=""navbox-list-with-group navbox-list navbox-odd"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Antecedent-contained_deletion"" title=""Antecedent-contained deletion"">Antecedent-contained deletion</a></li>
<li><a href=""/wiki/Cataphora"" title=""Cataphora"">Cataphora</a></li>
<li><a href=""/wiki/Coercion_(linguistics)"" title=""Coercion (linguistics)"">Coercion</a></li>
<li><a href=""/wiki/Conservativity"" title=""Conservativity"">Conservativity</a></li>
<li><a href=""/wiki/Counterfactuals"" class=""mw-redirect"" title=""Counterfactuals"">Counterfactuals</a></li>
<li><a href=""/wiki/Crossover_effects"" title=""Crossover effects"">Crossover effects</a></li>
<li><a href=""/wiki/Cumulativity_(linguistics)"" title=""Cumulativity (linguistics)"">Cumulativity</a></li>
<li><a href=""/wiki/De_dicto_and_de_re"" title=""De dicto and de re"">De dicto and de re</a></li>
<li><a href=""/wiki/De_se"" title=""De se"">De se</a></li>
<li><a href=""/wiki/Deontic_modality"" title=""Deontic modality"">Deontic modality</a></li>
<li><a href=""/wiki/Discourse_relation"" title=""Discourse relation"">Discourse relations</a></li>
<li><a href=""/wiki/Donkey_anaphora"" class=""mw-redirect"" title=""Donkey anaphora"">Donkey anaphora</a></li>
<li><a href=""/wiki/Epistemic_modality"" title=""Epistemic modality"">Epistemic modality</a></li>
<li><a href=""/wiki/Exhaustivity"" title=""Exhaustivity"">Exhaustivity</a></li>
<li><a href=""/wiki/Faultless_disagreement"" title=""Faultless disagreement"">Faultless disagreement</a></li>
<li><a href=""/wiki/Free_choice_inference"" title=""Free choice inference"">Free choice inferences</a></li>
<li><a href=""/wiki/Givenness"" title=""Givenness"">Givenness</a></li>
<li><a href=""/wiki/Homogeneity_(linguistics)"" class=""mw-redirect"" title=""Homogeneity (linguistics)"">Homogeneity (linguistics)</a></li>
<li><a href=""/wiki/Hurford_disjunction"" title=""Hurford disjunction"">Hurford disjunction</a></li>
<li><a href=""/wiki/Inalienable_possession"" title=""Inalienable possession"">Inalienable possession</a></li>
<li><a href=""/wiki/Intersective_modifier"" title=""Intersective modifier"">Intersective modification</a></li>
<li><a href=""/wiki/Logophoricity"" title=""Logophoricity"">Logophoricity</a></li>
<li><a href=""/wiki/Mirativity"" title=""Mirativity"">Mirativity</a></li>
<li><a href=""/wiki/Modal_subordination"" title=""Modal subordination"">Modal subordination</a></li>
<li><a href=""/wiki/Opaque_context"" title=""Opaque context"">Opaque contexts</a></li>
<li><a href=""/wiki/Performative_utterance"" title=""Performative utterance"">Performatives</a></li>
<li><a href=""/wiki/Polarity_item"" title=""Polarity item"">Polarity items</a></li>
<li><a href=""/wiki/Privative_adjective"" title=""Privative adjective"">Privative adjectives</a></li>
<li><a href=""/wiki/Quantificational_variability_effect"" title=""Quantificational variability effect"">Quantificational variability effect</a></li>
<li><a href=""/wiki/Responsive_predicate"" title=""Responsive predicate"">Responsive predicate</a></li>
<li><a href=""/wiki/Rising_declarative"" title=""Rising declarative"">Rising declaratives</a></li>
<li><a href=""/wiki/Scalar_implicature"" title=""Scalar implicature"">Scalar implicature</a></li>
<li><a href=""/wiki/Sloppy_identity"" title=""Sloppy identity"">Sloppy identity</a></li>
<li><a href=""/wiki/Subsective_modifier"" title=""Subsective modifier"">Subsective modification</a></li>
<li><a href=""/wiki/Subtrigging"" title=""Subtrigging"">Subtrigging</a></li>
<li><a href=""/wiki/Telicity"" title=""Telicity"">Telicity</a></li>
<li><a href=""/wiki/Temperature_paradox"" title=""Temperature paradox"">Temperature paradox</a></li>
<li><a href=""/wiki/Veridicality"" title=""Veridicality"">Veridicality</a></li></ul>
</div></td></tr></tbody></table><div></div></td></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%"">Formalism</th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""></div><table class=""nowraplinks navbox-subgroup"" style=""border-spacing:0""><tbody><tr><th scope=""row"" class=""navbox-group"" style=""width:1%"">Formal systems</th><td class=""navbox-list-with-group navbox-list navbox-even"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Alternative_semantics"" title=""Alternative semantics"">Alternative semantics</a></li>
<li><a href=""/wiki/Categorial_grammar"" title=""Categorial grammar"">Categorial grammar</a></li>
<li><a href=""/wiki/Combinatory_categorial_grammar"" title=""Combinatory categorial grammar"">Combinatory categorial grammar</a></li>
<li><a href=""/wiki/Discourse_representation_theory"" title=""Discourse representation theory"">Discourse representation theory (DRT)</a></li>
<li><a href=""/wiki/Dynamic_semantics"" title=""Dynamic semantics"">Dynamic semantics</a></li>
<li><a href=""/wiki/Generative_grammar"" title=""Generative grammar"">Generative grammar</a></li>
<li><a href=""/wiki/Glue_semantics"" title=""Glue semantics"">Glue semantics</a></li>
<li><a href=""/wiki/Inquisitive_semantics"" title=""Inquisitive semantics"">Inquisitive semantics</a></li>
<li><a href=""/wiki/Intensional_logic"" title=""Intensional logic"">Intensional logic</a></li>
<li><a href=""/wiki/Lambda_calculus"" title=""Lambda calculus"">Lambda calculus</a></li>
<li><a href=""/wiki/Mereology"" title=""Mereology"">Mereology</a></li>
<li><a href=""/wiki/Montague_grammar"" title=""Montague grammar"">Montague grammar</a></li>
<li><a href=""/wiki/Segmented_discourse_representation_theory"" class=""mw-redirect"" title=""Segmented discourse representation theory"">Segmented discourse representation theory (SDRT)</a></li>
<li><a href=""/wiki/Situation_semantics"" title=""Situation semantics"">Situation semantics</a></li>
<li><a href=""/wiki/Supervaluationism"" title=""Supervaluationism"">Supervaluationism</a></li>
<li><a href=""/wiki/Type_theory"" title=""Type theory"">Type theory</a></li>
<li><a href=""/wiki/Type_theory_with_records"" title=""Type theory with records"">TTR</a></li></ul>
</div></td></tr><tr><th scope=""row"" class=""navbox-group"" style=""width:1%"">Concepts</th><td class=""navbox-list-with-group navbox-list navbox-odd"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Autonomy_of_syntax"" title=""Autonomy of syntax"">Autonomy of syntax</a></li>
<li><a href=""/wiki/Context_set"" class=""mw-redirect"" title=""Context set"">Context set</a></li>
<li><a href=""/wiki/Continuation"" title=""Continuation"">Continuation</a></li>
<li><a href=""/wiki/Conversational_scoreboard"" title=""Conversational scoreboard"">Conversational scoreboard</a></li>
<li><a href=""/wiki/Downward_entailing"" title=""Downward entailing"">Downward entailing</a></li>
<li><a href=""/wiki/Existential_closure"" title=""Existential closure"">Existential closure</a></li>
<li><a href=""/wiki/Function_application"" title=""Function application"">Function application</a></li>
<li><a href=""/wiki/Meaning_postulate"" title=""Meaning postulate"">Meaning postulate</a></li>
<li><a href=""/wiki/Monad_(functional_programming)"" title=""Monad (functional programming)"">Monads</a></li>
<li><a href=""/wiki/Plural_quantification"" title=""Plural quantification"">Plural quantification</a></li>
<li><a href=""/wiki/Possible_world"" title=""Possible world"">Possible world</a></li>
<li><a href=""/wiki/Quantifier_raising"" class=""mw-redirect"" title=""Quantifier raising"">Quantifier raising</a></li>
<li><a href=""/wiki/Quantization_(linguistics)"" title=""Quantization (linguistics)"">Quantization</a></li>
<li><a href=""/wiki/Question_under_discussion"" title=""Question under discussion"">Question under discussion</a></li>
<li><a href=""/wiki/Semantic_parsing"" title=""Semantic parsing"">Semantic parsing</a></li>
<li><a href=""/wiki/Squiggle_operator"" title=""Squiggle operator"">Squiggle operator</a></li>
<li><a href=""/wiki/Strawson_entailment"" title=""Strawson entailment"">Strawson entailment</a></li>
<li><a href=""/wiki/Strict_conditional"" title=""Strict conditional"">Strict conditional</a></li>
<li><a href=""/wiki/Type_shifter"" title=""Type shifter"">Type shifter</a></li>
<li><a href=""/wiki/Universal_grinder"" title=""Universal grinder"">Universal grinder</a></li></ul>
</div></td></tr></tbody></table><div></div></td></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%"">See also</th><td class=""navbox-list-with-group navbox-list navbox-even hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Cognitive_semantics"" title=""Cognitive semantics"">Cognitive semantics</a></li>
<li><a href=""/wiki/Computational_semantics"" title=""Computational semantics"">Computational semantics</a></li>
<li><a href=""/wiki/Distributional_semantics"" title=""Distributional semantics"">Distributional semantics</a></li>
<li><a href=""/wiki/Formal_grammar"" title=""Formal grammar"">Formal grammar</a></li>
<li><a href=""/wiki/Inferentialism"" class=""mw-redirect"" title=""Inferentialism"">Inferentialism</a></li>
<li><a href=""/wiki/Logic_translation"" title=""Logic translation"">Logic translation</a></li>
<li><a href=""/wiki/Linguistics_wars"" title=""Linguistics wars"">Linguistics wars</a></li>
<li><a href=""/wiki/Philosophy_of_language"" title=""Philosophy of language"">Philosophy of language</a></li>
<li><a href=""/wiki/Pragmatics"" title=""Pragmatics"">Pragmatics</a></li>
<li><a href=""/wiki/Semantics_of_logic"" title=""Semantics of logic"">Semantics of logic</a></li></ul>
</div></td></tr></tbody></table>

<table class=""nowraplinks mw-collapsible mw-collapsed navbox-inner mw-made-collapsible"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""2""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Mathematical_logic"" title=""Template:Mathematical logic""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Mathematical_logic"" title=""Template talk:Mathematical logic""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Mathematical_logic"" title=""Special:EditPage/Template:Mathematical logic""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Mathematical_logic326"" style=""font-size:114%;margin:0 4em""><a href=""/wiki/Mathematical_logic"" title=""Mathematical logic"">Mathematical logic</a></div></th></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%"">General</th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Axiom"" title=""Axiom"">Axiom</a><ul><li><a href=""/wiki/List_of_axioms"" title=""List of axioms"">list</a></li></ul></li>
<li><a href=""/wiki/Cardinality"" title=""Cardinality"">Cardinality</a></li>
<li><a href=""/wiki/First-order_logic"" title=""First-order logic"">First-order logic</a></li>
<li><a href=""/wiki/Formal_proof"" title=""Formal proof"">Formal proof</a></li>
<li><a href=""/wiki/Formal_semantics_(logic)"" class=""mw-redirect"" title=""Formal semantics (logic)"">Formal semantics</a></li>
<li><a href=""/wiki/Foundations_of_mathematics"" title=""Foundations of mathematics"">Foundations of mathematics</a></li>
<li><a href=""/wiki/Information_theory"" title=""Information theory"">Information theory</a></li>
<li><a href=""/wiki/Lemma_(mathematics)"" title=""Lemma (mathematics)"">Lemma</a></li>
<li><a href=""/wiki/Logical_consequence"" title=""Logical consequence"">Logical consequence</a></li>
<li><a href=""/wiki/Structure_(mathematical_logic)"" title=""Structure (mathematical logic)"">Model</a></li>
<li><a href=""/wiki/Theorem"" title=""Theorem"">Theorem</a></li>
<li><a href=""/wiki/Theory_(mathematical_logic)"" title=""Theory (mathematical logic)"">Theory</a></li>
<li><a href=""/wiki/Type_theory"" title=""Type theory"">Type theory</a></li></ul>
</div></td></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%"">Theorems&nbsp;(<a href=""/wiki/Category:Theorems_in_the_foundations_of_mathematics"" title=""Category:Theorems in the foundations of mathematics"">list</a>)<br>&nbsp;and&nbsp;<a href=""/wiki/Paradoxes_of_set_theory"" title=""Paradoxes of set theory"">paradoxes</a></th><td class=""navbox-list-with-group navbox-list navbox-even hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/G%C3%B6del%27s_completeness_theorem"" title=""Gödel's completeness theorem"">Gödel's completeness</a>&nbsp;and&nbsp;<a href=""/wiki/G%C3%B6del%27s_incompleteness_theorems"" title=""Gödel's incompleteness theorems"">incompleteness theorems</a></li>
<li><a href=""/wiki/Tarski%27s_undefinability_theorem"" title=""Tarski's undefinability theorem"">Tarski's undefinability</a></li>
<li><a href=""/wiki/Banach%E2%80%93Tarski_paradox"" title=""Banach–Tarski paradox"">Banach–Tarski paradox</a></li>
<li>Cantor's&nbsp;<a href=""/wiki/Cantor%27s_theorem"" title=""Cantor's theorem"">theorem,</a>&nbsp;<a href=""/wiki/Cantor%27s_paradox"" title=""Cantor's paradox"">paradox</a>&nbsp;and&nbsp;<a href=""/wiki/Cantor%27s_diagonal_argument"" title=""Cantor's diagonal argument"">diagonal argument</a></li>
<li><a href=""/wiki/Compactness_theorem"" title=""Compactness theorem"">Compactness</a></li>
<li><a href=""/wiki/Halting_problem"" title=""Halting problem"">Halting problem</a></li>
<li><a href=""/wiki/Lindstr%C3%B6m%27s_theorem"" title=""Lindström's theorem"">Lindström's</a></li>
<li><a href=""/wiki/L%C3%B6wenheim%E2%80%93Skolem_theorem"" title=""Löwenheim–Skolem theorem"">Löwenheim–Skolem</a></li>
<li><a href=""/wiki/Russell%27s_paradox"" title=""Russell's paradox"">Russell's paradox</a></li></ul>
</div></td></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Logic"" title=""Logic"">Logics</a></th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""></div><table class=""nowraplinks navbox-subgroup"" style=""border-spacing:0""><tbody><tr><th id=""Traditional95"" scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Term_logic"" title=""Term logic"">Traditional</a></th><td class=""navbox-list-with-group navbox-list navbox-odd"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Classical_logic"" title=""Classical logic"">Classical logic</a></li>
<li><a href=""/wiki/Logical_truth"" title=""Logical truth"">Logical truth</a></li>
<li><a href=""/wiki/Tautology_(logic)"" title=""Tautology (logic)"">Tautology</a></li>
<li><a href=""/wiki/Proposition"" title=""Proposition"">Proposition</a></li>
<li><a href=""/wiki/Inference"" title=""Inference"">Inference</a></li>
<li><a href=""/wiki/Logical_equivalence"" title=""Logical equivalence"">Logical equivalence</a></li>
<li><a href=""/wiki/Consistency"" title=""Consistency"">Consistency</a><ul><li><a href=""/wiki/Equiconsistency"" title=""Equiconsistency"">Equiconsistency</a></li></ul></li>
<li><a href=""/wiki/Argument"" title=""Argument"">Argument</a></li>
<li><a href=""/wiki/Soundness"" title=""Soundness"">Soundness</a></li>
<li><a href=""/wiki/Validity_(logic)"" title=""Validity (logic)"">Validity</a></li>
<li><a href=""/wiki/Syllogism"" title=""Syllogism"">Syllogism</a></li>
<li><a href=""/wiki/Square_of_opposition"" title=""Square of opposition"">Square of opposition</a></li>
<li><a href=""/wiki/Venn_diagram"" title=""Venn diagram"">Venn diagram</a></li></ul>
</div></td></tr><tr><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Propositional_calculus"" title=""Propositional calculus"">Propositional</a></th><td class=""navbox-list-with-group navbox-list navbox-even"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Boolean_algebra"" title=""Boolean algebra"">Boolean algebra</a></li>
<li><a href=""/wiki/Boolean_function"" title=""Boolean function"">Boolean functions</a></li>
<li><a href=""/wiki/Logical_connective"" title=""Logical connective"">Logical connectives</a></li>
<li><a href=""/wiki/Propositional_calculus"" title=""Propositional calculus"">Propositional calculus</a></li>
<li><a href=""/wiki/Propositional_formula"" title=""Propositional formula"">Propositional formula</a></li>
<li><a href=""/wiki/Truth_table"" title=""Truth table"">Truth tables</a></li>
<li><a href=""/wiki/Many-valued_logic"" title=""Many-valued logic"">Many-valued logic</a><ul><li><a href=""/wiki/Three-valued_logic"" title=""Three-valued logic"">3</a></li>
<li><a href=""/wiki/Finite-valued_logic"" title=""Finite-valued logic"">finite</a></li>
<li><a href=""/wiki/Infinite-valued_logic"" title=""Infinite-valued logic"">∞</a></li></ul></li></ul>
</div></td></tr><tr><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Predicate_logic"" class=""mw-redirect"" title=""Predicate logic"">Predicate</a></th><td class=""navbox-list-with-group navbox-list navbox-odd"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/First-order_logic"" title=""First-order logic"">First-order</a><ul><li><a href=""/wiki/List_of_first-order_theories"" title=""List of first-order theories""><span style=""font-size: 85%;"">list</span></a></li></ul></li>
<li><a href=""/wiki/Second-order_logic"" title=""Second-order logic"">Second-order</a><ul><li><a href=""/wiki/Monadic_second-order_logic"" title=""Monadic second-order logic"">Monadic</a></li></ul></li>
<li><a href=""/wiki/Higher-order_logic"" title=""Higher-order logic"">Higher-order</a></li>
<li><a href=""/wiki/Fixed-point_logic"" title=""Fixed-point logic"">Fixed-point</a></li>
<li><a href=""/wiki/Free_logic"" title=""Free logic"">Free</a></li>
<li><a href=""/wiki/Quantifier_(logic)"" title=""Quantifier (logic)"">Quantifiers</a></li>
<li><a href=""/wiki/Predicate_(mathematical_logic)"" class=""mw-redirect"" title=""Predicate (mathematical logic)"">Predicate</a></li>
<li><a href=""/wiki/Monadic_predicate_calculus"" title=""Monadic predicate calculus"">Monadic predicate calculus</a></li></ul>
</div></td></tr></tbody></table><div></div></td></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Set_theory"" title=""Set theory"">Set theory</a></th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""></div><table class=""nowraplinks navbox-subgroup"" style=""border-spacing:0""><tbody><tr><td colspan=""2"" class=""navbox-list navbox-even"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Zermelo%E2%80%93Fraenkel_set_theory"" title=""Zermelo–Fraenkel set theory"">Set</a><ul><li><a href=""/wiki/Hereditary_set"" title=""Hereditary set"">hereditary</a></li></ul></li>
<li><a href=""/wiki/Class_(set_theory)"" title=""Class (set theory)"">Class</a></li>
<li>(<a href=""/wiki/Urelement"" title=""Urelement"">Ur-</a>)<a href=""/wiki/Element_(mathematics)"" title=""Element (mathematics)"">Element</a></li>
<li><a href=""/wiki/Ordinal_number"" title=""Ordinal number"">Ordinal number</a></li>
<li><a href=""/wiki/Extensionality"" title=""Extensionality"">Extensionality</a></li>
<li><a href=""/wiki/Forcing_(mathematics)"" title=""Forcing (mathematics)"">Forcing</a></li>
<li><a href=""/wiki/Relation_(mathematics)"" title=""Relation (mathematics)"">Relation</a><ul><li><a href=""/wiki/Equivalence_relation"" title=""Equivalence relation"">equivalence</a></li>
<li><a href=""/wiki/Partition_of_a_set"" title=""Partition of a set"">partition</a></li></ul></li>
<li>Set operations:<ul><li><a href=""/wiki/Intersection_(set_theory)"" title=""Intersection (set theory)"">intersection</a></li>
<li><a href=""/wiki/Union_(set_theory)"" title=""Union (set theory)"">union</a></li>
<li><a href=""/wiki/Complement_(set_theory)"" title=""Complement (set theory)"">complement</a></li>
<li><a href=""/wiki/Cartesian_product"" title=""Cartesian product"">Cartesian product</a></li>
<li><a href=""/wiki/Power_set"" title=""Power set"">power set</a></li>
<li><a href=""/wiki/List_of_set_identities_and_relations"" title=""List of set identities and relations"">identities</a></li></ul></li></ul>
</div></td></tr><tr><th scope=""row"" class=""navbox-group"" style=""width:1%"">Types of <a href=""/wiki/Set_(mathematics)"" title=""Set (mathematics)"">sets</a></th><td class=""navbox-list-with-group navbox-list navbox-odd"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Countable_set"" title=""Countable set"">Countable</a></li>
<li><a href=""/wiki/Uncountable_set"" title=""Uncountable set"">Uncountable</a></li>
<li><a href=""/wiki/Empty_set"" title=""Empty set"">Empty</a></li>
<li><a href=""/wiki/Inhabited_set"" title=""Inhabited set"">Inhabited</a></li>
<li><a href=""/wiki/Singleton_(mathematics)"" title=""Singleton (mathematics)"">Singleton</a></li>
<li><a href=""/wiki/Finite_set"" title=""Finite set"">Finite</a></li>
<li><a href=""/wiki/Infinite_set"" title=""Infinite set"">Infinite</a></li>
<li><a href=""/wiki/Transitive_set"" title=""Transitive set"">Transitive</a></li>
<li><a href=""/wiki/Ultrafilter_(set_theory)"" class=""mw-redirect"" title=""Ultrafilter (set theory)"">Ultrafilter</a></li>
<li><a href=""/wiki/Recursive_set"" class=""mw-redirect"" title=""Recursive set"">Recursive</a></li>
<li><a href=""/wiki/Fuzzy_set"" title=""Fuzzy set"">Fuzzy</a></li>
<li><a href=""/wiki/Universal_set"" title=""Universal set"">Universal</a></li>
<li><a href=""/wiki/Universe_(mathematics)"" title=""Universe (mathematics)"">Universe</a><ul><li><a href=""/wiki/Constructible_universe"" title=""Constructible universe"">constructible</a></li>
<li><a href=""/wiki/Grothendieck_universe"" title=""Grothendieck universe"">Grothendieck</a></li>
<li><a href=""/wiki/Von_Neumann_universe"" title=""Von Neumann universe"">Von Neumann</a></li></ul></li></ul>
</div></td></tr><tr><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Map_(mathematics)"" title=""Map (mathematics)"">Maps</a>&nbsp;and&nbsp;<a href=""/wiki/Cardinality"" title=""Cardinality"">cardinality</a></th><td class=""navbox-list-with-group navbox-list navbox-even"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Function_(mathematics)"" title=""Function (mathematics)"">Function</a>/<a href=""/wiki/Map_(mathematics)"" title=""Map (mathematics)"">Map</a><ul><li><a href=""/wiki/Domain_of_a_function"" title=""Domain of a function"">domain</a></li>
<li><a href=""/wiki/Codomain"" title=""Codomain"">codomain</a></li>
<li><a href=""/wiki/Image_(mathematics)"" title=""Image (mathematics)"">image</a></li></ul></li>
<li><a href=""/wiki/Injective_function"" title=""Injective function"">In</a>/<a href=""/wiki/Surjective_function"" title=""Surjective function"">Sur</a>/<a href=""/wiki/Bijection"" title=""Bijection"">Bi</a>-jection</li>
<li><a href=""/wiki/Schr%C3%B6der%E2%80%93Bernstein_theorem"" title=""Schröder–Bernstein theorem"">Schröder–Bernstein theorem</a></li>
<li><a href=""/wiki/Isomorphism"" title=""Isomorphism"">Isomorphism</a></li>
<li><a href=""/wiki/G%C3%B6del_numbering"" title=""Gödel numbering"">Gödel numbering</a></li>
<li><a href=""/wiki/Enumeration"" title=""Enumeration"">Enumeration</a></li>
<li><a href=""/wiki/Large_cardinal"" title=""Large cardinal"">Large cardinal</a><ul><li><a href=""/wiki/Inaccessible_cardinal"" title=""Inaccessible cardinal"">inaccessible</a></li></ul></li>
<li><a href=""/wiki/Aleph_number"" title=""Aleph number"">Aleph number</a></li>
<li><a href=""/wiki/Operation_(mathematics)"" title=""Operation (mathematics)"">Operation</a><ul><li><a href=""/wiki/Binary_operation"" title=""Binary operation"">binary</a></li></ul></li></ul>
</div></td></tr><tr><th scope=""row"" class=""navbox-group"" style=""width:1%"">Set theories</th><td class=""navbox-list-with-group navbox-list navbox-odd"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Zermelo%E2%80%93Fraenkel_set_theory"" title=""Zermelo–Fraenkel set theory"">Zermelo–Fraenkel</a><ul><li><a href=""/wiki/Axiom_of_choice"" title=""Axiom of choice"">axiom of choice</a></li>
<li><a href=""/wiki/Continuum_hypothesis"" title=""Continuum hypothesis"">continuum hypothesis</a></li></ul></li>
<li><a href=""/wiki/General_set_theory"" title=""General set theory"">General</a></li>
<li><a href=""/wiki/Kripke%E2%80%93Platek_set_theory"" title=""Kripke–Platek set theory"">Kripke–Platek</a></li>
<li><a href=""/wiki/Morse%E2%80%93Kelley_set_theory"" title=""Morse–Kelley set theory"">Morse–Kelley</a></li>
<li><a href=""/wiki/Naive_set_theory"" title=""Naive set theory"">Naive</a></li>
<li><a href=""/wiki/New_Foundations"" title=""New Foundations"">New Foundations</a></li>
<li><a href=""/wiki/Tarski%E2%80%93Grothendieck_set_theory"" title=""Tarski–Grothendieck set theory"">Tarski–Grothendieck</a></li>
<li><a href=""/wiki/Von_Neumann%E2%80%93Bernays%E2%80%93G%C3%B6del_set_theory"" title=""Von Neumann–Bernays–Gödel set theory"">Von Neumann–Bernays–Gödel</a></li>
<li><a href=""/wiki/Ackermann_set_theory"" title=""Ackermann set theory"">Ackermann</a></li>
<li><a href=""/wiki/Constructive_set_theory"" title=""Constructive set theory"">Constructive</a></li></ul>
</div></td></tr></tbody></table><div></div></td></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Formal_system"" title=""Formal system"">Formal systems</a>&nbsp;(<a href=""/wiki/List_of_formal_systems"" title=""List of formal systems""><span style=""font-size: 85%;"">list</span></a>),<br><a href=""/wiki/Formal_language"" title=""Formal language"">language</a>&nbsp;and&nbsp;<a href=""/wiki/Syntax_(logic)"" title=""Syntax (logic)"">syntax</a></th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""></div><table class=""nowraplinks navbox-subgroup"" style=""border-spacing:0""><tbody><tr><td colspan=""2"" class=""navbox-list navbox-even"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Alphabet_(formal_languages)"" title=""Alphabet (formal languages)"">Alphabet</a></li>
<li><a href=""/wiki/Arity"" title=""Arity"">Arity</a></li>
<li><a href=""/wiki/Automata_theory"" title=""Automata theory"">Automata</a></li>
<li><a href=""/wiki/Axiom_schema"" title=""Axiom schema"">Axiom schema</a></li>
<li><a href=""/wiki/Expression_(mathematics)"" title=""Expression (mathematics)"">Expression</a><ul><li><a href=""/wiki/Ground_expression"" title=""Ground expression"">ground</a></li></ul></li>
<li><a href=""/wiki/Extension_by_new_constant_and_function_names"" title=""Extension by new constant and function names"">Extension</a><ul><li><a href=""/wiki/Extension_by_definitions"" title=""Extension by definitions"">by definition</a></li>
<li><a href=""/wiki/Conservative_extension"" title=""Conservative extension"">conservative</a></li></ul></li>
<li><a href=""/wiki/Finitary_relation"" title=""Finitary relation"">Relation</a></li>
<li><a href=""/wiki/Formation_rule"" title=""Formation rule"">Formation rule</a></li>
<li><a href=""/wiki/Formal_grammar"" title=""Formal grammar"">Grammar</a></li>
<li><a href=""/wiki/Well-formed_formula"" title=""Well-formed formula"">Formula</a><ul><li><a href=""/wiki/Atomic_formula"" title=""Atomic formula"">atomic</a></li>
<li><a href=""/wiki/Sentence_(mathematical_logic)"" title=""Sentence (mathematical logic)"">closed</a></li>
<li><a href=""/wiki/Ground_formula"" class=""mw-redirect"" title=""Ground formula"">ground</a></li>
<li><a href=""/wiki/Open_formula"" title=""Open formula"">open</a></li></ul></li>
<li><a href=""/wiki/Free_variables_and_bound_variables"" title=""Free variables and bound variables"">Free/bound variable</a></li>
<li><a href=""/wiki/Formal_language"" title=""Formal language"">Language</a></li>
<li><a href=""/wiki/Metalanguage"" title=""Metalanguage"">Metalanguage</a></li>
<li><a href=""/wiki/Logical_connective"" title=""Logical connective"">Logical connective</a><ul><li><a class=""mw-selflink selflink"">¬</a></li>
<li><a href=""/wiki/Logical_disjunction"" title=""Logical disjunction"">∨</a></li>
<li><a href=""/wiki/Logical_conjunction"" title=""Logical conjunction"">∧</a></li>
<li><a href=""/wiki/Material_conditional"" title=""Material conditional"">→</a></li>
<li><a href=""/wiki/Logical_biconditional"" title=""Logical biconditional"">↔</a></li>
<li><a href=""/wiki/Logical_equality"" title=""Logical equality"">=</a></li></ul></li>
<li><a href=""/wiki/Predicate_(mathematical_logic)"" class=""mw-redirect"" title=""Predicate (mathematical logic)"">Predicate</a><ul><li><a href=""/wiki/Functional_predicate"" title=""Functional predicate"">functional</a></li>
<li><a href=""/wiki/Predicate_variable"" title=""Predicate variable"">variable</a></li>
<li><a href=""/wiki/Propositional_variable"" title=""Propositional variable"">propositional variable</a></li></ul></li>
<li><a href=""/wiki/Formal_proof"" title=""Formal proof"">Proof</a></li>
<li><a href=""/wiki/Quantifier_(logic)"" title=""Quantifier (logic)"">Quantifier</a><ul><li><a href=""/wiki/Existential_quantification"" title=""Existential quantification"">∃</a></li>
<li><a href=""/wiki/Uniqueness_quantification"" title=""Uniqueness quantification"">!</a></li>
<li><a href=""/wiki/Universal_quantification"" title=""Universal quantification"">∀</a></li>
<li><a href=""/wiki/Quantifier_rank"" title=""Quantifier rank"">rank</a></li></ul></li>
<li><a href=""/wiki/Sentence_(mathematical_logic)"" title=""Sentence (mathematical logic)"">Sentence</a><ul><li><a href=""/wiki/Atomic_sentence"" title=""Atomic sentence"">atomic</a></li>
<li><a href=""/wiki/Spectrum_of_a_sentence"" title=""Spectrum of a sentence"">spectrum</a></li></ul></li>
<li><a href=""/wiki/Signature_(logic)"" title=""Signature (logic)"">Signature</a></li>
<li><a href=""/wiki/String_(formal_languages)"" class=""mw-redirect"" title=""String (formal languages)"">String</a></li>
<li><a href=""/wiki/Substitution_(logic)"" title=""Substitution (logic)"">Substitution</a></li>
<li><a href=""/wiki/Symbol_(formal)"" title=""Symbol (formal)"">Symbol</a><ul><li><a href=""/wiki/Uninterpreted_function"" title=""Uninterpreted function"">function</a></li>
<li><a href=""/wiki/Logical_constant"" title=""Logical constant"">logical/constant</a></li>
<li><a href=""/wiki/Non-logical_symbol"" title=""Non-logical symbol"">non-logical</a></li>
<li><a href=""/wiki/Variable_(mathematics)"" title=""Variable (mathematics)"">variable</a></li></ul></li>
<li><a href=""/wiki/Term_(logic)"" title=""Term (logic)"">Term</a></li>
<li><a href=""/wiki/Theory_(mathematical_logic)"" title=""Theory (mathematical logic)"">Theory</a><ul><li><a href=""/wiki/List_of_mathematical_theories"" title=""List of mathematical theories""><span style=""font-size: 85%;"">list</span></a></li></ul></li></ul>
</div></td></tr><tr><th scope=""row"" class=""navbox-group"" style=""width:1%""><span class=""nowrap"">Example&nbsp;<a href=""/wiki/Axiomatic_system"" title=""Axiomatic system"">axiomatic<br>systems</a>&nbsp;<span style=""font-size: 85%;"">(<a href=""/wiki/List_of_first-order_theories"" title=""List of first-order theories"">list</a>)</span></span></th><td class=""navbox-list-with-group navbox-list navbox-odd"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li>of <a href=""/wiki/True_arithmetic"" title=""True arithmetic"">arithmetic</a>:<ul><li><a href=""/wiki/Peano_axioms"" title=""Peano axioms"">Peano</a></li>
<li><a href=""/wiki/Second-order_arithmetic"" title=""Second-order arithmetic"">second-order</a></li>
<li><a href=""/wiki/Elementary_function_arithmetic"" title=""Elementary function arithmetic"">elementary function</a></li>
<li><a href=""/wiki/Primitive_recursive_arithmetic"" title=""Primitive recursive arithmetic"">primitive recursive</a></li>
<li><a href=""/wiki/Robinson_arithmetic"" title=""Robinson arithmetic"">Robinson</a></li>
<li><a href=""/wiki/Skolem_arithmetic"" title=""Skolem arithmetic"">Skolem</a></li></ul></li>
<li>of the <a href=""/wiki/Construction_of_the_real_numbers"" title=""Construction of the real numbers"">real numbers</a><ul><li><a href=""/wiki/Tarski%27s_axiomatization_of_the_reals"" title=""Tarski's axiomatization of the reals"">Tarski's axiomatization</a></li></ul></li>
<li>of <a href=""/wiki/Axiomatization_of_Boolean_algebras"" class=""mw-redirect"" title=""Axiomatization of Boolean algebras"">Boolean algebras</a><ul><li><a href=""/wiki/Boolean_algebras_canonically_defined"" title=""Boolean algebras canonically defined"">canonical</a></li>
<li><a href=""/wiki/Minimal_axioms_for_Boolean_algebra"" title=""Minimal axioms for Boolean algebra"">minimal axioms</a></li></ul></li>
<li>of <a href=""/wiki/Foundations_of_geometry"" title=""Foundations of geometry"">geometry</a>:<ul><li><a href=""/wiki/Euclidean_geometry"" title=""Euclidean geometry"">Euclidean</a>:<ul><li><a href=""/wiki/Euclid%27s_Elements"" title=""Euclid's Elements""><i>Elements</i></a></li>
<li><a href=""/wiki/Hilbert%27s_axioms"" title=""Hilbert's axioms"">Hilbert's</a></li>
<li><a href=""/wiki/Tarski%27s_axioms"" title=""Tarski's axioms"">Tarski's</a></li></ul></li>
<li><a href=""/wiki/Non-Euclidean_geometry"" title=""Non-Euclidean geometry"">non-Euclidean</a></li></ul></li></ul><ul><li><i><a href=""/wiki/Principia_Mathematica"" title=""Principia Mathematica"">Principia Mathematica</a></i></li></ul>
</div></td></tr></tbody></table><div></div></td></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Proof_theory"" title=""Proof theory"">Proof theory</a></th><td class=""navbox-list-with-group navbox-list navbox-even hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Formal_proof"" title=""Formal proof"">Formal proof</a></li>
<li><a href=""/wiki/Natural_deduction"" title=""Natural deduction"">Natural deduction</a></li>
<li><a href=""/wiki/Logical_consequence"" title=""Logical consequence"">Logical consequence</a></li>
<li><a href=""/wiki/Rule_of_inference"" title=""Rule of inference"">Rule of inference</a></li>
<li><a href=""/wiki/Sequent_calculus"" title=""Sequent calculus"">Sequent calculus</a></li>
<li><a href=""/wiki/Theorem"" title=""Theorem"">Theorem</a></li>
<li><a href=""/wiki/Formal_system"" title=""Formal system"">Systems</a><ul><li><a href=""/wiki/Axiomatic_system"" title=""Axiomatic system"">axiomatic</a></li>
<li><a href=""/wiki/Deductive_system"" class=""mw-redirect"" title=""Deductive system"">deductive</a></li>
<li><a href=""/wiki/Hilbert_system"" title=""Hilbert system"">Hilbert</a><ul><li><a href=""/wiki/List_of_Hilbert_systems"" class=""mw-redirect"" title=""List of Hilbert systems"">list</a></li></ul></li></ul></li>
<li><a href=""/wiki/Complete_theory"" title=""Complete theory"">Complete theory</a></li>
<li><a href=""/wiki/Independence_(mathematical_logic)"" title=""Independence (mathematical logic)"">Independence</a>&nbsp;(<a href=""/wiki/List_of_statements_independent_of_ZFC"" title=""List of statements independent of ZFC"">from&nbsp;ZFC</a>)</li>
<li><a href=""/wiki/Proof_of_impossibility"" title=""Proof of impossibility"">Proof of impossibility</a></li>
<li><a href=""/wiki/Ordinal_analysis"" title=""Ordinal analysis"">Ordinal analysis</a></li>
<li><a href=""/wiki/Reverse_mathematics"" title=""Reverse mathematics"">Reverse mathematics</a></li>
<li><a href=""/wiki/Self-verifying_theories"" title=""Self-verifying theories"">Self-verifying theories</a></li></ul>
</div></td></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Model_theory"" title=""Model theory"">Model theory</a></th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Interpretation_(logic)"" title=""Interpretation (logic)"">Interpretation</a><ul><li><a href=""/wiki/Interpretation_function"" class=""mw-redirect"" title=""Interpretation function"">function</a></li>
<li><a href=""/wiki/Interpretation_(model_theory)"" title=""Interpretation (model theory)"">of models</a></li></ul></li>
<li><a href=""/wiki/Structure_(mathematical_logic)"" title=""Structure (mathematical logic)"">Model</a><ul><li><a href=""/wiki/Elementary_equivalence"" title=""Elementary equivalence"">equivalence</a></li>
<li><a href=""/wiki/Finite_model_theory"" title=""Finite model theory"">finite</a></li>
<li><a href=""/wiki/Saturated_model"" title=""Saturated model"">saturated</a></li>
<li><a href=""/wiki/Spectrum_of_a_theory"" title=""Spectrum of a theory"">spectrum</a></li>
<li><a href=""/wiki/Substructure_(mathematics)"" title=""Substructure (mathematics)"">submodel</a></li></ul></li>
<li><a href=""/wiki/Non-standard_model"" title=""Non-standard model"">Non-standard model</a><ul><li><a href=""/wiki/Non-standard_model_of_arithmetic"" title=""Non-standard model of arithmetic"">of arithmetic</a></li></ul></li>
<li><a href=""/wiki/Diagram_(mathematical_logic)"" title=""Diagram (mathematical logic)"">Diagram</a><ul><li><a href=""/wiki/Elementary_diagram"" title=""Elementary diagram"">elementary</a></li></ul></li>
<li><a href=""/wiki/Categorical_theory"" title=""Categorical theory"">Categorical theory</a></li>
<li><a href=""/wiki/Model_complete_theory"" title=""Model complete theory"">Model complete theory</a></li>
<li><a href=""/wiki/Satisfiability"" title=""Satisfiability"">Satisfiability</a></li>
<li><a href=""/wiki/Semantics_of_logic"" title=""Semantics of logic"">Semantics of logic</a></li>
<li><a href=""/wiki/Strength_(mathematical_logic)"" title=""Strength (mathematical logic)"">Strength</a></li>
<li><a href=""/wiki/Theories_of_truth"" class=""mw-redirect"" title=""Theories of truth"">Theories of truth</a><ul><li><a href=""/wiki/Semantic_theory_of_truth"" title=""Semantic theory of truth"">semantic</a></li>
<li><a href=""/wiki/Tarski%27s_theory_of_truth"" class=""mw-redirect"" title=""Tarski's theory of truth"">Tarski's</a></li>
<li><a href=""/wiki/Kripke%27s_theory_of_truth"" class=""mw-redirect"" title=""Kripke's theory of truth"">Kripke's</a></li></ul></li>
<li><a href=""/wiki/T-schema"" title=""T-schema"">T-schema</a></li>
<li><a href=""/wiki/Transfer_principle"" title=""Transfer principle"">Transfer principle</a></li>
<li><a href=""/wiki/Truth_predicate"" title=""Truth predicate"">Truth predicate</a></li>
<li><a href=""/wiki/Truth_value"" title=""Truth value"">Truth value</a></li>
<li><a href=""/wiki/Type_(model_theory)"" title=""Type (model theory)"">Type</a></li>
<li><a href=""/wiki/Ultraproduct"" title=""Ultraproduct"">Ultraproduct</a></li>
<li><a href=""/wiki/Validity_(logic)"" title=""Validity (logic)"">Validity</a></li></ul>
</div></td></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Computability_theory"" title=""Computability theory"">Computability theory</a></th><td class=""navbox-list-with-group navbox-list navbox-even hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Church_encoding"" title=""Church encoding"">Church encoding</a></li>
<li><a href=""/wiki/Church%E2%80%93Turing_thesis"" title=""Church–Turing thesis"">Church–Turing thesis</a></li>
<li><a href=""/wiki/Computably_enumerable_set"" title=""Computably enumerable set"">Computably enumerable</a></li>
<li><a href=""/wiki/Computable_function"" title=""Computable function"">Computable function</a></li>
<li><a href=""/wiki/Computable_set"" title=""Computable set"">Computable set</a></li>
<li><a href=""/wiki/Decision_problem"" title=""Decision problem"">Decision problem</a><ul><li><a href=""/wiki/Decidability_(logic)"" title=""Decidability (logic)"">decidable</a></li>
<li><a href=""/wiki/Undecidable_problem"" title=""Undecidable problem"">undecidable</a></li>
<li><a href=""/wiki/P_(complexity)"" title=""P (complexity)"">P</a></li>
<li><a href=""/wiki/NP_(complexity)"" title=""NP (complexity)"">NP</a></li>
<li><a href=""/wiki/P_versus_NP_problem"" title=""P versus NP problem"">P versus NP problem</a></li></ul></li>
<li><a href=""/wiki/Kolmogorov_complexity"" title=""Kolmogorov complexity"">Kolmogorov complexity</a></li>
<li><a href=""/wiki/Lambda_calculus"" title=""Lambda calculus"">Lambda calculus</a></li>
<li><a href=""/wiki/Primitive_recursive_function"" title=""Primitive recursive function"">Primitive recursive function</a></li>
<li><a href=""/wiki/Recursion"" title=""Recursion"">Recursion</a></li>
<li><a href=""/wiki/Recursive_set"" class=""mw-redirect"" title=""Recursive set"">Recursive set</a></li>
<li><a href=""/wiki/Turing_machine"" title=""Turing machine"">Turing machine</a></li>
<li><a href=""/wiki/Type_theory"" title=""Type theory"">Type theory</a></li></ul>
</div></td></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%"">Related</th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Abstract_logic"" title=""Abstract logic"">Abstract logic</a></li>
<li><a href=""/wiki/Algebraic_logic"" title=""Algebraic logic"">Algebraic logic</a></li>
<li><a href=""/wiki/Automated_theorem_proving"" title=""Automated theorem proving"">Automated theorem proving</a></li>
<li><a href=""/wiki/Category_theory"" title=""Category theory"">Category theory</a></li>
<li><a href=""/wiki/Concrete_category"" title=""Concrete category"">Concrete</a>/<a href=""/wiki/Category_(mathematics)"" title=""Category (mathematics)"">Abstract category</a></li>
<li><a href=""/wiki/Category_of_sets"" title=""Category of sets"">Category of sets</a></li>
<li><a href=""/wiki/History_of_logic"" title=""History of logic"">History of logic</a></li>
<li><a href=""/wiki/History_of_mathematical_logic"" class=""mw-redirect"" title=""History of mathematical logic"">History of mathematical logic</a><ul><li><a href=""/wiki/Timeline_of_mathematical_logic"" title=""Timeline of mathematical logic"">timeline</a></li></ul></li>
<li><a href=""/wiki/Logicism"" title=""Logicism"">Logicism</a></li>
<li><a href=""/wiki/Mathematical_object"" title=""Mathematical object"">Mathematical object</a></li>
<li><a href=""/wiki/Philosophy_of_mathematics"" title=""Philosophy of mathematics"">Philosophy of mathematics</a></li>
<li><a href=""/wiki/Supertask"" title=""Supertask"">Supertask</a></li></ul>
</div></td></tr><tr style=""display: none;""><td class=""navbox-abovebelow"" colspan=""2""><div><b><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><a href=""/wiki/File:Nuvola_apps_edu_mathematics_blue-p.svg"" class=""mw-file-description""><img alt=""icon"" src=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/15px-Nuvola_apps_edu_mathematics_blue-p.svg.png"" decoding=""async"" width=""15"" height=""15"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/23px-Nuvola_apps_edu_mathematics_blue-p.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/30px-Nuvola_apps_edu_mathematics_blue-p.svg.png 2x"" data-file-width=""128"" data-file-height=""128""></a></span> </span><a href=""/wiki/Portal:Mathematics"" title=""Portal:Mathematics"">Mathematics portal</a></b></div></td></tr></tbody></table>

<table class=""nowraplinks hlist navbox-inner"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Help:Authority_control"" title=""Help:Authority control"">Authority control databases</a>: National <span class=""mw-valign-text-top noprint"" typeof=""mw:File/Frameless""><a href=""https://www.wikidata.org/wiki/Q190558#identifiers"" title=""Edit this at Wikidata""><img alt=""Edit this at Wikidata"" src=""//upload.wikimedia.org/wikipedia/en/thumb/8/8a/OOjs_UI_icon_edit-ltr-progressive.svg/10px-OOjs_UI_icon_edit-ltr-progressive.svg.png"" decoding=""async"" width=""10"" height=""10"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/en/thumb/8/8a/OOjs_UI_icon_edit-ltr-progressive.svg/15px-OOjs_UI_icon_edit-ltr-progressive.svg.png 1.5x, //upload.wikimedia.org/wikipedia/en/thumb/8/8a/OOjs_UI_icon_edit-ltr-progressive.svg/20px-OOjs_UI_icon_edit-ltr-progressive.svg.png 2x"" data-file-width=""20"" data-file-height=""20""></a></span></th><td class=""navbox-list-with-group navbox-list navbox-odd"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><span class=""uid""><a rel=""nofollow"" class=""external text"" href=""https://d-nb.info/gnd/4137553-1"">Germany</a></span></li></ul></div></td></tr></tbody></table>
";

    // NOT COVERED BY TESTS!!!!!!!!!!!
    // https://www.geeksforgeeks.org/if-statement-in-programming/
    internal const string ArticleWithUnusualCodeBlocks = @"# If statement in Programming

Last Updated : 
                                                    09 Mar, 2024

Comments

Improve

- 
- 
-

Suggest changes
                                                                                          
Like Article

Like

Report

[!\[News\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)
                                                    Follow](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)

An **if statement** is a fundamental **control structure** in programming languages that allows you to execute specific code blocks based on whether a condition is **true** or **false**. It is used to make decisions and control the flow of execution in your program.

![](https://media.geeksforgeeks.org/wp-content/uploads/20191118171408/If-statement-GeeksforGeeks1.jpg)If statement in Programming
Table of Content

- What is an If Statement?
- Example of If Statement in Programming
- Conditional Operators in If Statements
- Common Mistakes to Avoid
- Best Practices for Using If Statements

## What is an if Statement?

The **if statement** is the most simple decision-making statement. It is used to decide whether a certain statement or block of statements will be executed or not i.e if a certain condition is **true** then a block of statement is executed otherwise not.

An if statement consists of two main parts:

- **Condition:** This is an expression that evaluates to either **true** or **false**.
- **Code block:** This is the code that will be executed if the condition is **true**.

## if Statement Syntax:

The syntax of the “if” statement varies slightly across different languages, but the **general syntax** of an if statement in most programming languages is as follows:

            Syntax

    `if (condition) {
  // Code to execute if condition is true
}
`

## Example of if Statement in Programming:

Let’s explore examples of “if” statements in various programming languages:

### 1. if Statement in **C**:

            C

    `#include <stdio.h>

int main()
{
    int x = 5;
    if (x > 0) {
        printf(""x is positive\n"");
    }

    return 0;
}
`

**Output**

```
x is positive
```

**Explanation:** In this example, the condition x &gt; 0 is evaluated to true because x is greater than 0. Therefore, the code inside the if block is executed, which prints ""x is positive"" to the console.

### 2. if Statement in **C++**:

            C++

    `#include <iostream>

using namespace std;

int main()
{
    int x = 5;
    if (x > 0) {
        printf(""x is positive\n"");
    }

    return 0;
}
`

**Output**

```
x is positive
```

**Explanation:** In this example, the condition x &gt; 0 is evaluated to true because x is greater than 0. Therefore, the code inside the if block is executed, which prints ""x is positive"" to the console.

### 3. if Statement in Java:

            Java

    `public class Main {
    public static void main(String[] args)
    {
        int x = 5;

        if (x > 0) {
            System.out.println(""x is positive"");
        }
    }
}
`

**Output**

```
x is positive
```

**Explanation:** In this example, the condition x &gt; 0 is evaluated to true because x is greater than 0. Therefore, the code inside the first if block is executed, which prints ""x is positive"" to the console. 

### 4. if Statement in Python:

            Python3

    `x = 5

if x > 0:
    print(""x is positive"")
`

**Output**

```
x is positive
```

**Explanation:** In this example, the condition x &gt; 0 is evaluated to true because x is greater than 0. Therefore, the code inside the first if block is executed, which prints ""x is positive"" to the console.

### 5. if Statement in Javascript:

            JavaScript

    `let x = 5;

if (x > 0) {
    console.log(""x is positive"");
}
`

**Output**

```
x is positive
```

**Explanation:** In this example, the condition x &gt; 0 is evaluated to true because x is greater than 0. Therefore, the code inside the first if block is executed, which prints ""x is positive"" to the console.

### 6. if Statement in C#:

            C#

    `using System;

class Program {
    static void Main()
    {
        int x = 5;

        if (x > 0) {
            Console.WriteLine(""x is positive"");
        }
    }
}
`

**Output**

```
x is positive
```

**Explanation:** In this example, the condition x &gt; 0 is evaluated to true because x is greater than 0. Therefore, the code inside the first if block is executed, which prints ""x is positive"" to the console. 

## Conditional Operators in if Statements

**Conditional operators** are used to compare two values and return a boolean value (**true** or **false**). The most common conditional operators are:

- == (equal to)
- != (not equal to)
- &gt; (greater than)
- &lt; (less than)
- &gt;= (greater than or equal to)
- &lt;= (less than or equal to)

**Example:**

            C++

    `#include <iostream>

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
`

            C

    `#include <stdio.h>

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
`

            Java

    `public class Main {
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
`

            Python

    `a = 5
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
`

            C#

    `using System;

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
`

            JavaScript

    `// Define variables a and b
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
`

**Output**

```
a is not equal to b
a is less than b
a is less than or equal to b
```

## Common Mistakes to Avoid:

- **Missing Parentheses**: Always put conditions inside parentheses when using if statements. Forgetting them can make your code confusing or cause errors.
- **Mixing up Assignment and Comparison operator**: Don't use the single equals sign **** **`=`**  **** in conditions. Use **`==`**  **** to check if things are equal. Mixing them up can make your program behave unexpectedly.
- **Forgetting Curly Braces**: Even for short if statements, it's safer to use curly braces **`{}`**. Forgetting them might cause issues, especially when you add more lines of code later.
- **Too Many Nested Ifs**: Avoid putting if statements inside other if statements too much. It can make your code hard to understand. Try to simplify by using logical operators like **`&&`** and **`||`** **.**
- **Forgetting Special Cases**: Make sure your if statements cover all possible situations. Test them with different values to be sure they work correctly.

## Best Practices for Using if Statements:

- **Clear Conditions**: Write if statements that are easy to understand. Use clear variable names and comments to explain what each condition does.
- **Consistent Formatting**: Keep your if statements looking the same throughout your code. Use the same amount of space and curly braces to make it easier to read.
- **Avoid Redundancy**: Don't repeat conditions that don't add anything new. Keep your code simple and easy to follow.
- **Logical Operators**: Use **`&&`** **,** **`||`** **,** and **`!`** to combine conditions when it makes sense. It helps make your code shorter and easier to understand.
- **Hardcoding Values**: Instead of putting specific numbers directly into if statements, use variables or constants. It makes your code easier to change later.

Comment

More info

                               [Advertise with us](https://www.geeksforgeeks.org/about/contact-us/?listicles)

[Next Article](https://www.geeksforgeeks.org/if-else-statement-in-programming/?ref=next_article)

[If Else Statement in Programming](https://www.geeksforgeeks.org/if-else-statement-in-programming/?ref=next_article)

[S](https://www.geeksforgeeks.org/user/singhdivya5/contributions/?itm_source=geeksforgeeks&amp;itm_medium=article_author&amp;itm_campaign=auth_user)

[singhdivya5](https://www.geeksforgeeks.org/user/singhdivya5/contributions/?itm_source=geeksforgeeks&amp;itm_medium=article_author&amp;itm_campaign=auth_user)

Follow

[!\[News\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)

Improve

Article Tags :

- [Programming](https://www.geeksforgeeks.org/category/programming/?ref=article_category)
";


    // https://dev.to/alex_ricciardi/recursion-in-programming-techniques-benefits-and-limitations-java-3o4p
    internal const string DevToRealWorldArticleText = @"This article explains the concept of recursion in programming, where a function calls itself to solve smaller instances of a problem, and its applications in tasks like tree traversal and divide-and-conquer algorithms. It also discusses the benefits of recursion for simplifying complex problems and improving code readability, while highlighting potential issues like stack overflow.

* * *

In computer science, recursion is an algorithmic technique in which a function calls itself to solve smaller instances of the same problem. In programming, recursion is an amazing technique with the help of which we can reduce the length of our code and make it easier to read and write” (GeeksforGeeks, 2024, p1). Recursion is used in programming to solve complex problems involving repetition and hierarchical structures such as tree traversals, graph algorithms, and divide-and-conquer problems like sorting and searching.

The basic components found in recursive functions are base cases and recursive cases. A base case is a condition that, when met, ends the recursion process (Ricciardi, 2024). A recursive case is a set of code lines that are executed until a base condition is met.

A classic example where recursion is well suited is in computing the factorial of a number. A factorial can be defined as a non-negative integer 𝑛, denoted 𝑛!, the product of all positive integers less than or equal to 𝑛:

𝑛! = 𝑛×(𝑛−1)!

In Java:

```
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
```

Enter fullscreen mode

    Exit fullscreen mode

Note that the factorial() method calls itself until it reaches the base case where 𝑛 = 0

There are various benefits to using recursion. One of the biggest benefits of using recursion is that it allows programmers to easily break down complex problems into simpler, more manageable subproblems. This approach is often referred to as the divide-and-conquer approach, it is implemented in algorithms like mergesort, where recursion divides a complex sort problem into smaller problems leading to a more efficient sort solution than the linear sort iterating solution. Additionally, recursion helps with code readability by simplifying and shortening code lines. When using recursion, programmers can write problems involving repetition or hierarchical structures (trees) without the need to implement complex loops. Recursion also simplifies, and it is efficient at handling dynamic and random data structures such as linked lists and tree structures. For instance, when traversing a binary tree, using recursion simplifies the implementation of the process without the need to implement a stack.

Although recursion has various advantages, in some scenarios using a stack is preferable over recursion. For example, recursion can generate a stack overflow error, ‘StackOverflowError ’, if the recursive depth (number of recursion calls) becomes too large. This can happen in cases like deep tree traversals or depth-first search algorithms, where the number of recursion calls may exceed the system’s call stack capacity. In Java, the limit of the call stack varies depending on the platform used and the Java Virtual Machine implemented. Java stack size can be configured using the JVM argument ‘-Xss’, for example ‘java -Xss1M MyProgram‘ where 1M is the size of the call back for MyProgram (Goodrich, Tamassia, & Goldwasser, 2023). It is best practice to use a stack or tail recursion, if possible, in this scenario. “A recursion is a tail recursion if any recursive call that is made from one context is the very last operation in that context, with the return value of the recursive call (if any) immediately returned by the enclosing recursion” (Goodrich, Tamassia, & Goldwasser, 2023, 5.5 Eliminating tail recursion). Note that while some programming languages optimize tail-recursive functions, Java does not. Thus, in Java, an optimized tail-recursive function needs to be implemented implicitly.

Below are examples of implementing a depth-first search (DFS) traversal of a tree, using recursion with a possibility of ‘StackOverflowError ’and a stack (Dequee) eliminating the possibility of a ‘StackOverflowError ’:

Using recursion possibility of ‘StackOverflowError’:

```
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
```

Enter fullscreen mode

    Exit fullscreen mode

Using the stack approach eliminating the possibility of a ‘StackOverflowError’:

```
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
```

Enter fullscreen mode

    Exit fullscreen mode

Output:

```
DFS Traversal using Deque:
1
2
4
5
3
```

Enter fullscreen mode

    Exit fullscreen mode

To summarize, recursion is a technique in which a function calls itself to solve smaller instances of the same problem, it is often used in problems like tree traversal, graph algorithms, and divide-and-conquer strategies. While recursion simplifies complex problems and code readability, excessive recursive calls can lead to stack overflow errors, particularly in deeply nested structures such as trees, making iterative approaches using explicit stacks preferable in certain cases.

* * *

**References:**

Arslan, Ş. (2023, February 25). *A Comprehensive tree traversal guide in Javascript — General and binary tree traversals.* Shinar Arslan Blog. https://www.sahinarslan.tech/posts/a-comprehensive-tree-traversal-guide-in-javascript-general-and-binary-tree-traversals

GeeksforGeeks (2024, August 18). *Introduction to recursion*. GeeksforGeeks. https://www.geeksforgeeks.org/introduction-to-recursion-2/Links to an external site

Goodrich T, M., Tamassia, R., & Goldwasser H. M. (2023, June). Chapter 5: Algorithms recursion. *Data structures and algorithms*. zyBook ISBN: 979–8–203–40813–6.

* * *

Originally published at [Alex.omegapy - Medium](https://medium.com/@alex.omegapy) on September 22, 2024.";

    // https://www.geeksforgeeks.org/data-modeling-a-comprehensive-guide-for-analysts/
    internal const string GeeksForGeeksTextAboutDataModeling = @"# Data Modeling: A Comprehensive Guide for Analysts

Last Updated : 
                                                    16 Jul, 2024

Comments

Improve

- 
- 
-

Suggest changes
                                                                                          
5 Likes

Like

Report

[!\[News\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)
                                                    Follow](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)

Data modelling is a fundamental component that facilitates the organisation, structuring, and interpretation of complicated datasets by analysts. 

In this tutorial we'll dive into the field of data modelling, examining its importance, the procedures involved, and answering common queries. 

Table of Content

- What is Data Modeling?
- Types of Data Models
- Data Modeling Process
- Types of Data Modeling
- Benefits of Data Modeling
- Data Modeling - FAQs

![Data-Modeling-in-Analysis](https://media.geeksforgeeks.org/wp-content/uploads/20240215112547/Data-Modeling-in-Analysis.webp)
## **What is Data Modeling?**

Data modelling in analysis is  the process of creating a visual representation , abstraction of data structures, relationships, and rules within a system or organization. Determining and analysing the data requirements required to support business activities within the bounds of related information systems in organisations is another process known as data modelling.  

The main objective of data modelling is to provide a precise and well-organized framework for data organisation and representation, since it enables efficient analysis and decision-making. Analysts can discover trends, understand the connections between various data items, and make sure that data is efficiently and accurately stored by building models.

### **What is Data Model?**

Data models are visual representations of an enterprise’s data elements and the connections between them. Models assist to define and arrange data in the context of key business processes, hence facilitating the creation of successful information systems. They let business and technical personnel to collaborate on how data will be kept, accessed, shared, updated, and utilised within an organisation.

## Types of Data Models

There are three main types of data models:

![modeling](https://media.geeksforgeeks.org/wp-content/uploads/20240215113046/modeling.webp)

- **Conceptual Data Model**: Conceptual Data Model is a representations of data Examine and describe in depth your abstract, high-level business concepts and structures. They are most commonly employed when working through high-level concepts and preliminary needs at the start of a new project. They are typically developed as alternatives or preludes to the logical data models that come later.T he main purpose of this data model is to organize, define business problems , rules and concepts. For instance, it helps business people to view any data like market data, customer data, and purchase data.
- **Logical Data Model**: In the logical data model, By offering a thorough representation of the data at a logical level, the logical data model expands on the conceptual model. It outlines the tables, columns, connections, and constraints that make up the[data structure.](https://www.geeksforgeeks.org/data-structures/) Although logical data models are not dependant on any particular database management system (DBMS), they are more similar to how data would be implemented in a database. The physical design of databases is based on this idea.
- **Physical Data Model**: In Physical Data model ,The implementation is explained with reference to a particular database system. It outlines every part and service needed to construct a database. It is made with queries and the database language. Every table, column, and constraint—such as primary key, foreign key, NOT NULL, etc.—is represented in the physical data model. The creation of a database is the primary task of the physical data model. Developers and database administrators (DBAs) designed this model. This kind of data modelling aids in the creation of the schema and provides us with an abstraction of the databases. This model explains how the data model is specifically implemented. Constraints, RDBMS features, and database column keys are made possible by the physical data model.

## Data Modeling Process

The practice of conceptually representing data items and their connections to one another is known as data modelling. Data modellers collaborate with stakeholders at each stage of the process to define entities and attributes, establish relationships between data objects, and create models that accurately represent the data in a format that can be consumed by applications. These stakeholders may include developers, database administrators, and other interested parties. Lets discuss the data modelling steps:

1. **Identifying data sources**: The first stage is to identify and investigate the different sources of data both inside and outside the company. It's critical to comprehend the sources of the data and how various sources add to the information as a whole. Determining the sources of data is essential since it guarantees a thorough framework for data modelling. It assists in gathering all pertinent data, setting the stage for a precise and comprehensive depiction of the data landscape.
2. **Defining Entities and Attributes**: This stage is all on identifying the entities (items or ideas) and the characteristics that go along with them. Entities constitute the subject matter of the data, whereas attributes specify the particular qualities of each entity. The foundation of data modelling is the definition of entities and characteristics. It offers an orderly and transparent framework, which is necessary to comprehend the characteristics of the data and create a useful model.
3. **Mapping Relationships**: Relationships show the connections or associations between various things. Relationship mapping entails locating and characterising these linkages, indicating the nature and cardinality of every relationship. In order to capture the interdependencies within the data, it is essential to understand relationships. It improves the correctness of the model by capturing the relationships between various data pieces that exist in the real world.
4. **Choosing a model Type**: The right data model type is selected based on the project needs and data properties. Choosing between conceptual, logical, or physical models, or going with a particular model like relational or object-oriented, may be part of this decision.  The degree of abstraction and detail in the representation is determined by the model type that is selected. It guarantees adherence to project objectives and facilitates the[development](https://www.geeksforgeeks.org/class-10-social-science-economics-chapter-1-development/) of a model appropriate for the data type.
5. **Implementing and Maintaining**: The process of implementation converts a physical or logical data model into a[database schema.](https://www.geeksforgeeks.org/database-schemas/) This entails establishing constraints, generating tables, and adding database-specific information. Updating the model to account for shifting technological or commercial needs is called maintenance. Significance: The theoretical model becomes a useful database upon implementation. Frequent upkeep guarantees that the model stays current and accurate, allowing it to adjust to the changing requirements of the company.

## Types of Data Modeling

These are the 5 different types of data models:

**Hierarchical Model**: The structure of the hierarchical model resembles a[tree.](https://www.geeksforgeeks.org/introduction-to-tree-data-structure-and-algorithm-tutorials/) The remaining child nodes are arranged in a certain sequence, and there is only one root node—or, alternatively, one parent node. However, the hierarchical approach is no longer widely applied. approach connections in the actual world may be modelled using this approach.

For Example , For example, in a college there are many courses, many professors and students. So college became a parent and professors and students became its children. 

![daat](https://media.geeksforgeeks.org/wp-content/uploads/20240215113207/daat.webp)**Relational Model** :Relational Mode represent the links between tables by representing data as rows and columns in tables. It is frequently utilised in[database design](https://www.geeksforgeeks.org/significance-of-database-design/) and is strongly related to relational database management systems (RDBMS).

**Object-Oriented Data Model**: In this model, data is represented as objects, similar to those used in object-oriented programming ,Creating objects with stored values is the object-oriented method. In addition to allowing data abstraction, inheritance, and encapsulation, the object-oriented architecture facilitates communication.

**Network Model** :We have a versatile approach to represent objects and the relationships among these things thanks to the network model. One of its features is a schema, which is a graph representation of the data. An item is stored within a node, and the relationship between them is represented as an edge. This allows them to generalise the maintenance of many parent and child records.

**ER-Model**: A high-level[relational model](https://www.geeksforgeeks.org/relational-model-in-dbms/) called the [entity-relationship model (ER model)](https://www.geeksforgeeks.org/introduction-of-er-model/) is used to specify the data pieces and relationships between the entities in a system. This conceptual design gives us an easier-to-understand perspective on the facts. An entity-relationship diagram, which is made up of entities, attributes, and relationships, is used in this model to depict the whole database.

A relationship between entities is called an association. Mapping cardinality many associations like:

- one to one
- one to many
- many to one
- many to many

## Benefits of Data Modeling

In order to organise and structure data and provide database design clarity, data modelling is essential. It acts as a common language, promoting efficient stakeholder communication. It directs the best database architecture for effective data storage and retrieval through visual representation. 

- Visualizes complex data structures, providing a clear roadmap for understanding relationships.
- Acts as a universal language, fostering effective communication between business and technical stakeholders.
- Creates organized databases by defining entities, properties, and relationships.
- Enhances data quality and[integrity](https://www.geeksforgeeks.org/integrity-importance-and-challenges/) by reducing anomalies and redundancy through[normalization.](https://www.geeksforgeeks.org/introduction-of-database-normalization/)
- Minimizes errors in database and application development.
- Ensures consistency in documentation and system designs across the organization.
- Improves database and application performance.
- Facilitates quick correlation of data across the company.
- Strengthens communication between business intelligence and development teams.

## Conclusion

In conclusion,Data modelling is an essential component of[data analysis](https://www.geeksforgeeks.org/data-analysis-tutorial/) that offers a methodical way to arrange and comprehend intricate facts. Analysts may create reliable models that improve insights and decision-making by adhering to the process's specified phases.

Comment

More info

                               [Advertise with us](https://www.geeksforgeeks.org/about/contact-us/?listicles)

[Next Article](https://www.geeksforgeeks.org/what-are-the-advantages-and-disadvantages-of-random-forest/?ref=next_article)

[What are the Advantages and Disadvantages of Random Forest?](https://www.geeksforgeeks.org/what-are-the-advantages-and-disadvantages-of-random-forest/?ref=next_article)

[R](https://www.geeksforgeeks.org/user/rahulpawar_7/contributions/?itm_source=geeksforgeeks&amp;itm_medium=article_author&amp;itm_campaign=auth_user)

[rahulpawar_7](https://www.geeksforgeeks.org/user/rahulpawar_7/contributions/?itm_source=geeksforgeeks&amp;itm_medium=article_author&amp;itm_campaign=auth_user)

Follow

[!\[News\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)

5

Improve

Article Tags :

- [Data Analysis](https://www.geeksforgeeks.org/category/ai-ml-ds/r-data-analysis/?ref=article_category)
- [AI-ML-DS](https://www.geeksforgeeks.org/category/ai-ml-ds/?ref=article_category)
";

    // https://www.geeksforgeeks.org/basic-operators-in-relational-algebra-2/
    internal const string GeeksForGeeksTextAboutRelationalAlgebra = @"# Basic Operators in Relational Algebra

Last Updated : 
                                                    19 Sep, 2024

Comments

Improve

- 
- 
-

Suggest changes
                                                                                          
75 Likes

Like

Report

[!\[News\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)
                                                    Follow](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)

The Relational Model is a way of structuring data using relations, which are a collection of tuples that have the same attributes. Relational Algebra is a procedural query language that takes relations as input and returns relations as output. It uses a set of operators to manipulate and retrieve data from these relations. Here, we’ll explore the basic operators of Relational Algebra using the STUDENT\_SPORTS, EMPLOYEE, and STUDENT relations from Table 1, Table 2, and Table 3, respectively.

**Table 1: STUDENT\_SPORTS**

<table>
<thead></thead>
<tbody>
<tr>
<td><b><strong>ROLL_NO</strong></b></td>
<td><b><strong>SPORTS</strong></b></td>
</tr>
<tr>
<td><span>1</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>2</span></td>
<td><span>Cricket</span></td>
</tr>
<tr>
<td><span>2</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>4</span></td>
<td><span>Badminton</span></td>
</tr>
</tbody>
</table>

 **Table 2: EMPLOYEE**

<table>
<thead></thead>
<tbody>
<tr>
<td><b><strong>EMP_NO</strong></b></td>
<td><b><strong>NAME</strong></b></td>
<td><b><strong>ADDRESS</strong></b></td>
<td><b><strong>PHONE</strong></b></td>
<td><b><strong>AGE</strong></b></td>
</tr>
<tr>
<td><span>1</span></td>
<td><span>RAM</span></td>
<td><span>DELHI</span></td>
<td><span>9455123451</span></td>
<td><span>18</span></td>
</tr>
<tr>
<td><span>5</span></td>
<td><span>NARESH</span></td>
<td><span>HISAR</span></td>
<td><span>9782918192</span></td>
<td><span>22</span></td>
</tr>
<tr>
<td><span>6</span></td>
<td><span>SWETA</span></td>
<td><span>RANCHI</span></td>
<td><span>9852617621</span></td>
<td><span>21</span></td>
</tr>
<tr>
<td><span>4</span></td>
<td><span>SURESH</span></td>
<td><span>DELHI</span></td>
<td><span>9156768971</span></td>
<td><span>18</span></td>
</tr>
</tbody>
</table>

**Table 3: STUDENT** 

<table>
<thead></thead>
<tbody>
<tr>
<td><b><strong>ROLL_NO</strong></b></td>
<td><b><strong>NAME</strong></b></td>
<td><b><strong>ADDRESS</strong></b></td>
<td><b><strong>PHONE</strong></b></td>
<td><b><strong>AGE</strong></b></td>
</tr>
<tr>
<td><span>1</span></td>
<td><span>RAM</span></td>
<td><span>DELHI</span></td>
<td><span>9455123451</span></td>
<td><span>18</span></td>
</tr>
<tr>
<td><span>2</span></td>
<td><span>RAMESH</span></td>
<td><span>GURGAON</span></td>
<td><span>9652431543</span></td>
<td><span>18</span></td>
</tr>
<tr>
<td><span>3</span></td>
<td><span>SUJIT</span></td>
<td><span>ROHTAK</span></td>
<td><span>9156253131</span></td>
<td><span>20</span></td>
</tr>
<tr>
<td><span>4</span></td>
<td><span>SURESH</span></td>
<td><span>DELHI</span></td>
<td><span>9156768971</span></td>
<td><span>18</span></td>
</tr>
</tbody>
</table>

## ***1. Selection operator (*****σ*****)***

Selection operator is used to selecting tuples from a relation based on some condition. Syntax: 

```
σ (Cond)(Relation Name)
```

Extract students whose age is greater than 18 from STUDENT relation given in Table 3  

```
σ (AGE>18)(STUDENT)
```

**[Note:** [SELECT operation](https://www.geeksforgeeks.org/select-operation-in-relational-algebra/) does not show any result, the projection operator must be called before the selection operator to generate or project the result. So, the correct syntax to generate the result is**:** ∏(**σ** (AGE&gt;18)(STUDENT))]

**RESULT:** 

<table>
<thead></thead>
<tbody>
<tr>
<td><b><strong>ROLL_NO</strong></b></td>
<td><b><strong>NAME</strong></b></td>
<td><b><strong>ADDRESS</strong></b></td>
<td><b><strong>PHONE</strong></b></td>
<td><b><strong>AGE</strong></b></td>
</tr>
<tr>
<td><span>3</span></td>
<td><span>SUJIT</span></td>
<td><span>ROHTAK</span></td>
<td><span>9156253131</span></td>
<td><span>20</span></td>
</tr>
</tbody>
</table>

## ***2. Projection Operator (*****∏*****)***

Projection operator is used to project particular columns from a relation. Syntax:  

```
∏(Column 1,Column 2….Column n)(Relation Name)
```

Extract ROLL\_NO and NAME from STUDENT relation given in Table 3  

```
∏(ROLL_NO,NAME)(STUDENT)
```

**RESULT:**  

<table>
<thead></thead>
<tbody>
<tr>
<td><b><strong>ROLL_NO</strong></b></td>
<td><b><strong>NAME</strong></b></td>
</tr>
<tr>
<td><span>1</span></td>
<td><span>RAM</span></td>
</tr>
<tr>
<td><span>2</span></td>
<td><span>RAMESH</span></td>
</tr>
<tr>
<td><span>3</span></td>
<td><span>SUJIT</span></td>
</tr>
<tr>
<td><span>4</span></td>
<td><span>SURESH</span></td>
</tr>
</tbody>
</table>

**Note:** If the resultant relation after projection has duplicate rows, it will be removed. For Example  **∏**(ADDRESS)(STUDENT) will remove one duplicate row with the value DELHI and return three rows. 

## ***3. Cross Product(X)***

Cross product is used to join two relations. For every row of Relation1, each row of Relation2 is concatenated. If Relation1 has m tuples and and Relation2 has n tuples, cross product of Relation1 and Relation2 will have m X n tuples. Syntax: 

```
Relation1 X Relation2
```

To apply Cross Product on STUDENT relation given in Table 1 and STUDENT\_SPORTS relation given in Table 2,  

```
STUDENT X STUDENT_SPORTS
```

**RESULT:** 

<table>
<thead></thead>
<tbody>
<tr>
<td><b><strong>ROLL_NO</strong></b></td>
<td><b><strong>NAME</strong></b></td>
<td><b><strong>ADDRESS</strong></b></td>
<td><b><strong>PHONE</strong></b></td>
<td><b><strong>AGE</strong></b></td>
<td><b><strong>ROLL_NO</strong></b></td>
<td><b><strong>SPORTS</strong></b></td>
</tr>
<tr>
<td><span>1</span></td>
<td><span>RAM</span></td>
<td><span>DELHI</span></td>
<td><span>9455123451</span></td>
<td><span>18</span></td>
<td><span>1</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>1</span></td>
<td><span>RAM</span></td>
<td><span>DELHI</span></td>
<td><span>9455123451</span></td>
<td><span>18</span></td>
<td><span>2</span></td>
<td><span>Cricket</span></td>
</tr>
<tr>
<td><span>1</span></td>
<td><span>RAM</span></td>
<td><span>DELHI</span></td>
<td><span>9455123451</span></td>
<td><span>18</span></td>
<td><span>2</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>1</span></td>
<td><span>RAM</span></td>
<td><span>DELHI</span></td>
<td><span>9455123451</span></td>
<td><span>18</span></td>
<td><span>4</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>2</span></td>
<td><span>RAMESH</span></td>
<td><span>GURGAON</span></td>
<td><span>9652431543</span></td>
<td><span>18</span></td>
<td><span>1</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>2</span></td>
<td><span>RAMESH</span></td>
<td><span>GURGAON</span></td>
<td><span>9652431543</span></td>
<td><span>18</span></td>
<td><span>2</span></td>
<td><span>Cricket</span></td>
</tr>
<tr>
<td><span>2</span></td>
<td><span>RAMESH</span></td>
<td><span>GURGAON</span></td>
<td><span>9652431543</span></td>
<td><span>18</span></td>
<td><span>2</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>2</span></td>
<td><span>RAMESH</span></td>
<td><span>GURGAON</span></td>
<td><span>9652431543</span></td>
<td><span>18</span></td>
<td><span>4</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>3</span></td>
<td><span>SUJIT</span></td>
<td><span>ROHTAK</span></td>
<td><span>9156253131</span></td>
<td><span>20</span></td>
<td><span>1</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>3</span></td>
<td><span>SUJIT</span></td>
<td><span>ROHTAK</span></td>
<td><span>9156253131</span></td>
<td><span>20</span></td>
<td><span>2</span></td>
<td><span>Cricket</span></td>
</tr>
<tr>
<td><span>3</span></td>
<td><span>SUJIT</span></td>
<td><span>ROHTAK</span></td>
<td><span>9156253131</span></td>
<td><span>20</span></td>
<td><span>2</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>3</span></td>
<td><span>SUJIT</span></td>
<td><span>ROHTAK</span></td>
<td><span>9156253131</span></td>
<td><span>20</span></td>
<td><span>4</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>4</span></td>
<td><span>SURESH</span></td>
<td><span>DELHI</span></td>
<td><span>9156768971</span></td>
<td><span>18</span></td>
<td><span>1</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>4</span></td>
<td><span>SURESH</span></td>
<td><span>DELHI</span></td>
<td><span>9156768971</span></td>
<td><span>18</span></td>
<td><span>2</span></td>
<td><span>Cricket</span></td>
</tr>
<tr>
<td><span>4</span></td>
<td><span>SURESH</span></td>
<td><span>DELHI</span></td>
<td><span>9156768971</span></td>
<td><span>18</span></td>
<td><span>2</span></td>
<td><span>Badminton</span></td>
</tr>
<tr>
<td><span>4</span></td>
<td><span>SURESH</span></td>
<td><span>DELHI</span></td>
<td><span>9156768971</span></td>
<td><span>18</span></td>
<td><span>4</span></td>
<td><span>Badminton</span></td>
</tr>
</tbody>
</table>

## ***4. Union (U)***

Union on two relations R1 and R2 can only be computed if R1 and R2 are **union compatible** (These two relations should have the same number of attributes and corresponding attributes in two relations have the same domain). Union operator when applied on two relations R1 and R2 will give a relation with tuples that are either in R1 or in R2. The tuples which are in both R1 and R2 will appear only once in the result relation. Syntax: 

```
 Relation1 U Relation2
```

Find the person who is either student or employees, we can use Union operators like: 

```
STUDENT U EMPLOYEE
```

**RESULT:**  

<table>
<thead></thead>
<tbody>
<tr>
<td><b><strong>ROLL_NO</strong></b></td>
<td><b><strong>NAME</strong></b></td>
<td><b><strong>ADDRESS</strong></b></td>
<td><b><strong>PHONE</strong></b></td>
<td><b><strong>AGE</strong></b></td>
</tr>
<tr>
<td><span>1</span></td>
<td><span>RAM</span></td>
<td><span>DELHI</span></td>
<td><span>9455123451</span></td>
<td><span>18</span></td>
</tr>
<tr>
<td><span>2</span></td>
<td><span>RAMESH</span></td>
<td><span>GURGAON</span></td>
<td><span>9652431543</span></td>
<td><span>18</span></td>
</tr>
<tr>
<td><span>3</span></td>
<td><span>SUJIT</span></td>
<td><span>ROHTAK</span></td>
<td><span>9156253131</span></td>
<td><span>20</span></td>
</tr>
<tr>
<td><span>4</span></td>
<td><span>SURESH</span></td>
<td><span>DELHI</span></td>
<td><span>9156768971</span></td>
<td><span>18</span></td>
</tr>
<tr>
<td><span>5</span></td>
<td><span>NARESH</span></td>
<td><span>HISAR</span></td>
<td><span>9782918192</span></td>
<td><span>22</span></td>
</tr>
<tr>
<td><span>6</span></td>
<td><span>SWETA</span></td>
<td><span>RANCHI</span></td>
<td><span>9852617621</span></td>
<td><span>21</span></td>
</tr>
</tbody>
</table>

## ***5. Minus (-) or Set Difference***

Minus on two relations R1 and R2 can only be computed if R1 and R2 are **union compatible**. Minus operator when applied on two relations as R1-R2 will give a relation with tuples that are in R1 but not in R2. Syntax: 

```
 Relation1 - Relation2
```

Find the person who is a student but not an employee, we can use minus operator like:  

```
STUDENT - EMPLOYEE
```

**RESULT:**  

<table>
<thead></thead>
<tbody>
<tr>
<td><b><strong>ROLL_NO</strong></b></td>
<td><b><strong>NAME</strong></b></td>
<td><b><strong>ADDRESS</strong></b></td>
<td><b><strong>PHONE</strong></b></td>
<td><b><strong>AGE</strong></b></td>
</tr>
<tr>
<td><span>2</span></td>
<td><span>RAMESH</span></td>
<td><span>GURGAON</span></td>
<td><span>9652431543</span></td>
<td><span>18</span></td>
</tr>
<tr>
<td><span>3</span></td>
<td><span>SUJIT</span></td>
<td><span>ROHTAK</span></td>
<td><span>9156253131</span></td>
<td><span>20</span></td>
</tr>
</tbody>
</table>

## ***6. Rename(*****ρ*****)***

[Rename operator](https://www.geeksforgeeks.org/rename-operation-in-relational-algebra/) is used to giving another name to a relation. Syntax:  

```
ρ(Relation2, Relation1)
```

To rename STUDENT relation to STUDENT1, we can use rename operator like:  

```
ρ(STUDENT1, STUDENT)
```

If you want to create a relation STUDENT\_NAMES with ROLL\_NO and NAME from STUDENT, it can be done using rename operator as:  

```
ρ(STUDENT_NAMES, ∏(ROLL_NO, NAME)(STUDENT))
```

### Extended Relational Algebra Operators

- Intersection (∩)
- Division (÷)
- Join Operations (⋈)
- [Natural Join](https://www.geeksforgeeks.org/sql-natural-join/)
- Theta Join
- Equi Join

These operators provide more functionality for complex queries in relational databases.

## Conclusion

[Relational Algebra](https://www.geeksforgeeks.org/introduction-of-relational-algebra-in-dbms/) provides a fundamental toolkit for querying and manipulating relations in a [database](https://www.geeksforgeeks.org/what-is-database/). It offers a set of operators that allow users to perform basic operations like selection, projection, union, and more. Understanding these operators is essential for working with relational databases and forms the basis for more advanced [SQL](https://www.geeksforgeeks.org/what-is-sql/) operations.

Comment

More info

                               [Advertise with us](https://www.geeksforgeeks.org/about/contact-us/?listicles)

[Next Article](https://www.geeksforgeeks.org/extended-operators-in-relational-algebra/?ref=next_article)

[Extended Operators in Relational Algebra](https://www.geeksforgeeks.org/extended-operators-in-relational-algebra/?ref=next_article)

![https://media.geeksforgeeks.org/auth/avatar.png](https://media.geeksforgeeks.org/wp-content/uploads/20200717172614/authPreLogo.png)

GeeksforGeeks

[!\[News\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)

75

Improve

Article Tags :

- [DBMS](https://www.geeksforgeeks.org/category/computer-subject/dbms/?ref=article_category)
- [DBMS-Relational Algebra](https://www.geeksforgeeks.org/tag/dbms-relational-algebra/?ref=article_tag)
";
}
