using Sample.Chunkers.Models;
using Sample.Chunkers.Models.Enums;

namespace Sample.Chunkers.UnitTests.TestData;

internal class TablesTestData
{
    // https://en.wikipedia.org/wiki/Negation
    internal static readonly ChunkModel[] WikipediaArticleWithComplexNestedTables =
    [
        new ChunkModel
        {
            Index = 4,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            RawContent = @"<table class=""infobox""><caption class=""infobox-title"" style=""background:navy; color:white;"">Negation</caption><tbody><tr><th colspan=""2"" class=""infobox-above"">NOT</th></tr><tr><td colspan=""2"" class=""infobox-image""><span typeof=""mw:File""><a href=""/wiki/File:Venn10.svg"" class=""mw-file-description"" title=""Venn diagram of Negation""><img alt=""Venn diagram of Negation"" src=""//upload.wikimedia.org/wikipedia/commons/thumb/7/73/Venn10.svg/150px-Venn10.svg.png"" decoding=""async"" width=""150"" height=""150"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/7/73/Venn10.svg/225px-Venn10.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/7/73/Venn10.svg/300px-Venn10.svg.png 2x"" data-file-width=""280"" data-file-height=""280""></a></span></td></tr><tr><th scope=""row"" class=""infobox-label"">Definition</th><td class=""infobox-data""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \lnot {x}}"">
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
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/5b6360c75948cd75ab65f4b9691f620640bb6abd"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.505ex; width:5.333ex; height:2.343ex;"" alt=""{\displaystyle 1\oplus x}""></span></td></tr><tr><th colspan=""2"" class=""infobox-header"" style=""background:navy; color:white;""><a href=""/wiki/Post%27s_lattice"" title=""Post's lattice""><span style=""color:white;"">Post's lattices</span></a></th></tr><tr><th scope=""row"" class=""infobox-label"">0-preserving</th><td class=""infobox-data"">no</td></tr><tr><th scope=""row"" class=""infobox-label"">1-preserving</th><td class=""infobox-data"">no</td></tr><tr><th scope=""row"" class=""infobox-label""><a href=""/wiki/Monotonic_function"" title=""Monotonic function"">Monotone</a></th><td class=""infobox-data"">no</td></tr><tr><th scope=""row"" class=""infobox-label""><a href=""/wiki/Affine_transformation"" title=""Affine transformation"">Affine</a></th><td class=""infobox-data"">yes</td></tr><tr><th scope=""row"" class=""infobox-label"">Self-dual</th><td class=""infobox-data"">yes</td></tr><tr><td colspan=""2"" class=""infobox-navbar""><style data-mw-deduplicate=""TemplateStyles:r1129693374"">.mw-parser-output .hlist dl,.mw-parser-output .hlist ol,.mw-parser-output .hlist ul{margin:0;padding:0}.mw-parser-output .hlist dd,.mw-parser-output .hlist dt,.mw-parser-output .hlist li{margin:0;display:inline}.mw-parser-output .hlist.inline,.mw-parser-output .hlist.inline dl,.mw-parser-output .hlist.inline ol,.mw-parser-output .hlist.inline ul,.mw-parser-output .hlist dl dl,.mw-parser-output .hlist dl ol,.mw-parser-output .hlist dl ul,.mw-parser-output .hlist ol dl,.mw-parser-output .hlist ol ol,.mw-parser-output .hlist ol ul,.mw-parser-output .hlist ul dl,.mw-parser-output .hlist ul ol,.mw-parser-output .hlist ul ul{display:inline}.mw-parser-output .hlist .mw-empty-li{display:none}.mw-parser-output .hlist dt::after{content:"": ""}.mw-parser-output .hlist dd::after,.mw-parser-output .hlist li::after{content:"" · "";font-weight:bold}.mw-parser-output .hlist dd:last-child::after,.mw-parser-output .hlist dt:last-child::after,.mw-parser-output .hlist li:last-child::after{content:none}.mw-parser-output .hlist dd dd:first-child::before,.mw-parser-output .hlist dd dt:first-child::before,.mw-parser-output .hlist dd li:first-child::before,.mw-parser-output .hlist dt dd:first-child::before,.mw-parser-output .hlist dt dt:first-child::before,.mw-parser-output .hlist dt li:first-child::before,.mw-parser-output .hlist li dd:first-child::before,.mw-parser-output .hlist li dt:first-child::before,.mw-parser-output .hlist li li:first-child::before{content:"" ("";font-weight:normal}.mw-parser-output .hlist dd dd:last-child::after,.mw-parser-output .hlist dd dt:last-child::after,.mw-parser-output .hlist dd li:last-child::after,.mw-parser-output .hlist dt dd:last-child::after,.mw-parser-output .hlist dt dt:last-child::after,.mw-parser-output .hlist dt li:last-child::after,.mw-parser-output .hlist li dd:last-child::after,.mw-parser-output .hlist li dt:last-child::after,.mw-parser-output .hlist li li:last-child::after{content:"")"";font-weight:normal}.mw-parser-output .hlist ol{counter-reset:listitem}.mw-parser-output .hlist ol>li{counter-increment:listitem}.mw-parser-output .hlist ol>li::before{content:"" ""counter(listitem)""\a0 ""}.mw-parser-output .hlist dd ol>li:first-child::before,.mw-parser-output .hlist dt ol>li:first-child::before,.mw-parser-output .hlist li ol>li:first-child::before{content:"" (""counter(listitem)""\a0 ""}</style><style data-mw-deduplicate=""TemplateStyles:r1239400231"">.mw-parser-output .navbar{display:inline;font-size:88%;font-weight:normal}.mw-parser-output .navbar-collapse{float:left;text-align:left}.mw-parser-output .navbar-boxtext{word-spacing:0}.mw-parser-output .navbar ul{display:inline-block;white-space:nowrap;line-height:inherit}.mw-parser-output .navbar-brackets::before{margin-right:-0.125em;content:""[ ""}.mw-parser-output .navbar-brackets::after{margin-left:-0.125em;content:"" ]""}.mw-parser-output .navbar li{word-spacing:-0.125em}.mw-parser-output .navbar a>span,.mw-parser-output .navbar a>abbr{text-decoration:inherit}.mw-parser-output .navbar-mini abbr{font-variant:small-caps;border-bottom:none;text-decoration:none;cursor:inherit}.mw-parser-output .navbar-ct-full{font-size:114%;margin:0 7em}.mw-parser-output .navbar-ct-mini{font-size:114%;margin:0 4em}html.skin-theme-clientpref-night .mw-parser-output .navbar li a abbr{color:var(--color-base)!important}@media(prefers-color-scheme:dark){html.skin-theme-clientpref-os .mw-parser-output .navbar li a abbr{color:var(--color-base)!important}}@media print{.mw-parser-output .navbar{display:none!important}}</style><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Infobox_logical_connective"" title=""Template:Infobox logical connective""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Infobox_logical_connective"" title=""Template talk:Infobox logical connective""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Infobox_logical_connective"" title=""Special:EditPage/Template:Infobox logical connective""><abbr title=""Edit this template"">e</abbr></a></li></ul></div></td></tr></tbody></table>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table class=""infobox""><caption class=""infobox-title"" style=""background:navy; color:white;"">Negation</caption><tbody><tr><th colspan=""2"" class=""infobox-above"">NOT</th></tr><tr><td colspan=""2"" class=""infobox-image""><span typeof=""mw:File""><a href=""/wiki/File:Venn10.svg"" class=""mw-file-description"" title=""Venn diagram of Negation""><img alt=""Venn diagram of Negation"" src=""//upload.wikimedia.org/wikipedia/commons/thumb/7/73/Venn10.svg/150px-Venn10.svg.png"" decoding=""async"" width=""150"" height=""150"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/7/73/Venn10.svg/225px-Venn10.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/7/73/Venn10.svg/300px-Venn10.svg.png 2x"" data-file-width=""280"" data-file-height=""280""></a></span></td></tr><tr><th scope=""row"" class=""infobox-label"">Definition</th><td class=""infobox-data""><span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \lnot {x}}"">
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
</math></span><img src=""https://wikimedia.org/api/rest_v1/media/math/render/svg/5b6360c75948cd75ab65f4b9691f620640bb6abd"" class=""mwe-math-fallback-image-inline mw-invert skin-invert"" aria-hidden=""true"" style=""vertical-align: -0.505ex; width:5.333ex; height:2.343ex;"" alt=""{\displaystyle 1\oplus x}""></span></td></tr><tr><th colspan=""2"" class=""infobox-header"" style=""background:navy; color:white;""><a href=""/wiki/Post%27s_lattice"" title=""Post's lattice""><span style=""color:white;"">Post's lattices</span></a></th></tr><tr><th scope=""row"" class=""infobox-label"">0-preserving</th><td class=""infobox-data"">no</td></tr><tr><th scope=""row"" class=""infobox-label"">1-preserving</th><td class=""infobox-data"">no</td></tr><tr><th scope=""row"" class=""infobox-label""><a href=""/wiki/Monotonic_function"" title=""Monotonic function"">Monotone</a></th><td class=""infobox-data"">no</td></tr><tr><th scope=""row"" class=""infobox-label""><a href=""/wiki/Affine_transformation"" title=""Affine transformation"">Affine</a></th><td class=""infobox-data"">yes</td></tr><tr><th scope=""row"" class=""infobox-label"">Self-dual</th><td class=""infobox-data"">yes</td></tr><tr><td colspan=""2"" class=""infobox-navbar""><style data-mw-deduplicate=""TemplateStyles:r1129693374"">.mw-parser-output .hlist dl,.mw-parser-output .hlist ol,.mw-parser-output .hlist ul{margin:0;padding:0}.mw-parser-output .hlist dd,.mw-parser-output .hlist dt,.mw-parser-output .hlist li{margin:0;display:inline}.mw-parser-output .hlist.inline,.mw-parser-output .hlist.inline dl,.mw-parser-output .hlist.inline ol,.mw-parser-output .hlist.inline ul,.mw-parser-output .hlist dl dl,.mw-parser-output .hlist dl ol,.mw-parser-output .hlist dl ul,.mw-parser-output .hlist ol dl,.mw-parser-output .hlist ol ol,.mw-parser-output .hlist ol ul,.mw-parser-output .hlist ul dl,.mw-parser-output .hlist ul ol,.mw-parser-output .hlist ul ul{display:inline}.mw-parser-output .hlist .mw-empty-li{display:none}.mw-parser-output .hlist dt::after{content:"": ""}.mw-parser-output .hlist dd::after,.mw-parser-output .hlist li::after{content:"" · "";font-weight:bold}.mw-parser-output .hlist dd:last-child::after,.mw-parser-output .hlist dt:last-child::after,.mw-parser-output .hlist li:last-child::after{content:none}.mw-parser-output .hlist dd dd:first-child::before,.mw-parser-output .hlist dd dt:first-child::before,.mw-parser-output .hlist dd li:first-child::before,.mw-parser-output .hlist dt dd:first-child::before,.mw-parser-output .hlist dt dt:first-child::before,.mw-parser-output .hlist dt li:first-child::before,.mw-parser-output .hlist li dd:first-child::before,.mw-parser-output .hlist li dt:first-child::before,.mw-parser-output .hlist li li:first-child::before{content:"" ("";font-weight:normal}.mw-parser-output .hlist dd dd:last-child::after,.mw-parser-output .hlist dd dt:last-child::after,.mw-parser-output .hlist dd li:last-child::after,.mw-parser-output .hlist dt dd:last-child::after,.mw-parser-output .hlist dt dt:last-child::after,.mw-parser-output .hlist dt li:last-child::after,.mw-parser-output .hlist li dd:last-child::after,.mw-parser-output .hlist li dt:last-child::after,.mw-parser-output .hlist li li:last-child::after{content:"")"";font-weight:normal}.mw-parser-output .hlist ol{counter-reset:listitem}.mw-parser-output .hlist ol>li{counter-increment:listitem}.mw-parser-output .hlist ol>li::before{content:"" ""counter(listitem)""\a0 ""}.mw-parser-output .hlist dd ol>li:first-child::before,.mw-parser-output .hlist dt ol>li:first-child::before,.mw-parser-output .hlist li ol>li:first-child::before{content:"" (""counter(listitem)""\a0 ""}</style><style data-mw-deduplicate=""TemplateStyles:r1239400231"">.mw-parser-output .navbar{display:inline;font-size:88%;font-weight:normal}.mw-parser-output .navbar-collapse{float:left;text-align:left}.mw-parser-output .navbar-boxtext{word-spacing:0}.mw-parser-output .navbar ul{display:inline-block;white-space:nowrap;line-height:inherit}.mw-parser-output .navbar-brackets::before{margin-right:-0.125em;content:""[ ""}.mw-parser-output .navbar-brackets::after{margin-left:-0.125em;content:"" ]""}.mw-parser-output .navbar li{word-spacing:-0.125em}.mw-parser-output .navbar a>span,.mw-parser-output .navbar a>abbr{text-decoration:inherit}.mw-parser-output .navbar-mini abbr{font-variant:small-caps;border-bottom:none;text-decoration:none;cursor:inherit}.mw-parser-output .navbar-ct-full{font-size:114%;margin:0 7em}.mw-parser-output .navbar-ct-mini{font-size:114%;margin:0 4em}html.skin-theme-clientpref-night .mw-parser-output .navbar li a abbr{color:var(--color-base)!important}@media(prefers-color-scheme:dark){html.skin-theme-clientpref-os .mw-parser-output .navbar li a abbr{color:var(--color-base)!important}}@media print{.mw-parser-output .navbar{display:none!important}}</style><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Infobox_logical_connective"" title=""Template:Infobox logical connective""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Infobox_logical_connective"" title=""Template talk:Infobox logical connective""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Infobox_logical_connective"" title=""Special:EditPage/Template:Infobox logical connective""><abbr title=""Edit this template"">e</abbr></a></li></ul></div></td></tr></tbody></table>",
            },
        },
        new ChunkModel
        {
            Index = 5,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            RawContent = @"<table class=""sidebar nomobile nowraplinks""><tbody><tr><th class=""sidebar-title"" style=""font-size: 130%; margin: 6px 0px 6px 0px; background: #ddf;""><a href=""/wiki/Logical_connective"" title=""Logical connective"">Logical connectives</a></th></tr><tr><td class=""sidebar-content"">
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
<span class=""noviewer"" typeof=""mw:File""><span title=""Category""><img alt="""" src=""//upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/16px-Symbol_category_class.svg.png"" decoding=""async"" width=""16"" height=""16"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/23px-Symbol_category_class.svg.png 1.5x, //upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/31px-Symbol_category_class.svg.png 2x"" data-file-width=""180"" data-file-height=""185""></span></span> <a href=""/wiki/Category:Logical_connectives"" title=""Category:Logical connectives"">Category</a></td></tr><tr><td class=""sidebar-navbar""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Logical_connectives_sidebar"" title=""Template:Logical connectives sidebar""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/w/index.php?title=Template_talk:Logical_connectives_sidebar&amp;action=edit&amp;redlink=1"" class=""new"" title=""Template talk:Logical connectives sidebar (page does not exist)""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Logical_connectives_sidebar"" title=""Special:EditPage/Template:Logical connectives sidebar""><abbr title=""Edit this template"">e</abbr></a></li></ul></div></td></tr></tbody></table>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table class=""sidebar nomobile nowraplinks""><tbody><tr><th class=""sidebar-title"" style=""font-size: 130%; margin: 6px 0px 6px 0px; background: #ddf;""><a href=""/wiki/Logical_connective"" title=""Logical connective"">Logical connectives</a></th></tr><tr><td class=""sidebar-content"">
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
<span class=""noviewer"" typeof=""mw:File""><span title=""Category""><img alt="""" src=""//upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/16px-Symbol_category_class.svg.png"" decoding=""async"" width=""16"" height=""16"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/23px-Symbol_category_class.svg.png 1.5x, //upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/31px-Symbol_category_class.svg.png 2x"" data-file-width=""180"" data-file-height=""185""></span></span> <a href=""/wiki/Category:Logical_connectives"" title=""Category:Logical connectives"">Category</a></td></tr><tr><td class=""sidebar-navbar""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Logical_connectives_sidebar"" title=""Template:Logical connectives sidebar""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/w/index.php?title=Template_talk:Logical_connectives_sidebar&amp;action=edit&amp;redlink=1"" class=""new"" title=""Template talk:Logical connectives sidebar (page does not exist)""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Logical_connectives_sidebar"" title=""Special:EditPage/Template:Logical connectives sidebar""><abbr title=""Edit this template"">e</abbr></a></li></ul></div></td></tr></tbody></table>",
            },
        },
        new ChunkModel
        {
            Index = 6,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            RawContent = @"<table class=""wikitable"" style=""text-align:center; background-color: #ddffdd;"">

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
</td></tr></tbody></table>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table class=""wikitable"" style=""text-align:center; background-color: #ddffdd;"">

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
</td></tr></tbody></table>",
            },
        },
        new ChunkModel
        {
            Index = 7,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            RawContent = @"<table class=""wikitable"">

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
</tbody></table>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table class=""wikitable"">

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
</tbody></table>",
            },
        },
        new ChunkModel
        {
            Index = 8,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            RawContent = @"<table class=""wikitable"" style=""text-align: center;"">
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
</td></tr></tbody></table>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table class=""wikitable"" style=""text-align: center;"">
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
</td></tr></tbody></table>",
            },
        },
        new ChunkModel
        {
            Index = 9,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            RawContent = @"<table class=""nowraplinks mw-collapsible autocollapse navbox-inner mw-made-collapsible mw-collapsed"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""3""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Logical_connectives"" title=""Template:Logical connectives""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Logical_connectives"" title=""Template talk:Logical connectives""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Logical_connectives"" title=""Special:EditPage/Template:Logical connectives""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Common_logical_connectives157"" style=""font-size:114%;margin:0 4em"">Common <a href=""/wiki/Logical_connective"" title=""Logical connective"">logical connectives</a></div></th></tr><tr style=""display: none;""><td colspan=""2"" class=""navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Tautology_(logic)"" title=""Tautology (logic)"">Tautology</a>/<a href=""/wiki/Logical_truth"" title=""Logical truth"">True</a>&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \top }"">
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
</div></td></tr><tr style=""display: none;""><td class=""navbox-abovebelow"" colspan=""3""><div><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><span><img alt="""" src=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/18px-Socrates.png"" decoding=""async"" width=""18"" height=""28"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/27px-Socrates.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/36px-Socrates.png 2x"" data-file-width=""326"" data-file-height=""500""></span></span> </span><a href=""/wiki/Portal:Philosophy"" title=""Portal:Philosophy"">Philosophy portal</a></div></td></tr></tbody></table>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table class=""nowraplinks mw-collapsible autocollapse navbox-inner mw-made-collapsible mw-collapsed"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""3""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Logical_connectives"" title=""Template:Logical connectives""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Logical_connectives"" title=""Template talk:Logical connectives""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Logical_connectives"" title=""Special:EditPage/Template:Logical connectives""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Common_logical_connectives157"" style=""font-size:114%;margin:0 4em"">Common <a href=""/wiki/Logical_connective"" title=""Logical connective"">logical connectives</a></div></th></tr><tr style=""display: none;""><td colspan=""2"" class=""navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Tautology_(logic)"" title=""Tautology (logic)"">Tautology</a>/<a href=""/wiki/Logical_truth"" title=""Logical truth"">True</a>&nbsp;<span class=""mwe-math-element""><span class=""mwe-math-mathml-inline mwe-math-mathml-a11y"" style=""display: none;""><math xmlns=""http://www.w3.org/1998/Math/MathML"" alttext=""{\displaystyle \top }"">
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
</div></td></tr><tr style=""display: none;""><td class=""navbox-abovebelow"" colspan=""3""><div><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><span><img alt="""" src=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/18px-Socrates.png"" decoding=""async"" width=""18"" height=""28"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/27px-Socrates.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/36px-Socrates.png 2x"" data-file-width=""326"" data-file-height=""500""></span></span> </span><a href=""/wiki/Portal:Philosophy"" title=""Portal:Philosophy"">Philosophy portal</a></div></td></tr></tbody></table>",
            },
        },
        new ChunkModel
        {
            Index = 10,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            RawContent = @"<table class=""nowraplinks mw-collapsible autocollapse navbox-inner mw-made-collapsible mw-collapsed"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""2""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Common_logical_symbols"" title=""Template:Common logical symbols""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Common_logical_symbols"" title=""Template talk:Common logical symbols""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Common_logical_symbols"" title=""Special:EditPage/Template:Common logical symbols""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Common_logical_symbols334"" style=""font-size:114%;margin:0 4em"">Common <a href=""/wiki/List_of_logic_symbols"" title=""List of logic symbols"">logical symbols</a></div></th></tr><tr style=""display: none;""><td colspan=""2"" class=""navbox-list navbox-odd"" style=""width:100%;padding:0;background:transparent;color:inherit;""><div style=""padding:0px""><table class=""navbox-columns-table"" style=""border-spacing: 0px; text-align:left;width:100%;""><tbody><tr style=""vertical-align:top""><td class=""navbox-list"" style=""padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
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
</div></td></tr></tbody></table></div></td></tr><tr style=""display: none;""><td class=""navbox-abovebelow"" colspan=""2""><div><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><span><img alt="""" src=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/18px-Socrates.png"" decoding=""async"" width=""18"" height=""28"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/27px-Socrates.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/36px-Socrates.png 2x"" data-file-width=""326"" data-file-height=""500""></span></span> </span><a href=""/wiki/Portal:Philosophy"" title=""Portal:Philosophy"">Philosophy portal</a><br><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><a href=""/wiki/File:Nuvola_apps_edu_mathematics_blue-p.svg"" class=""mw-file-description""><img alt=""icon"" src=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/28px-Nuvola_apps_edu_mathematics_blue-p.svg.png"" decoding=""async"" width=""28"" height=""28"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/42px-Nuvola_apps_edu_mathematics_blue-p.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/56px-Nuvola_apps_edu_mathematics_blue-p.svg.png 2x"" data-file-width=""128"" data-file-height=""128""></a></span> </span><a href=""/wiki/Portal:Mathematics"" title=""Portal:Mathematics"">Mathematics portal</a></div></td></tr></tbody></table>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table class=""nowraplinks mw-collapsible autocollapse navbox-inner mw-made-collapsible mw-collapsed"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""2""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Common_logical_symbols"" title=""Template:Common logical symbols""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Common_logical_symbols"" title=""Template talk:Common logical symbols""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Common_logical_symbols"" title=""Special:EditPage/Template:Common logical symbols""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Common_logical_symbols334"" style=""font-size:114%;margin:0 4em"">Common <a href=""/wiki/List_of_logic_symbols"" title=""List of logic symbols"">logical symbols</a></div></th></tr><tr style=""display: none;""><td colspan=""2"" class=""navbox-list navbox-odd"" style=""width:100%;padding:0;background:transparent;color:inherit;""><div style=""padding:0px""><table class=""navbox-columns-table"" style=""border-spacing: 0px; text-align:left;width:100%;""><tbody><tr style=""vertical-align:top""><td class=""navbox-list"" style=""padding:0px;padding-top:0.85em;text-align:center;white-space:nowrap;padding-bottom:0.85em;width:10em;""><div>
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
</div></td></tr></tbody></table></div></td></tr><tr style=""display: none;""><td class=""navbox-abovebelow"" colspan=""2""><div><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><span><img alt="""" src=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/18px-Socrates.png"" decoding=""async"" width=""18"" height=""28"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/27px-Socrates.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Socrates.png/36px-Socrates.png 2x"" data-file-width=""326"" data-file-height=""500""></span></span> </span><a href=""/wiki/Portal:Philosophy"" title=""Portal:Philosophy"">Philosophy portal</a><br><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><a href=""/wiki/File:Nuvola_apps_edu_mathematics_blue-p.svg"" class=""mw-file-description""><img alt=""icon"" src=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/28px-Nuvola_apps_edu_mathematics_blue-p.svg.png"" decoding=""async"" width=""28"" height=""28"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/42px-Nuvola_apps_edu_mathematics_blue-p.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/56px-Nuvola_apps_edu_mathematics_blue-p.svg.png 2x"" data-file-width=""128"" data-file-height=""128""></a></span> </span><a href=""/wiki/Portal:Mathematics"" title=""Portal:Mathematics"">Mathematics portal</a></div></td></tr></tbody></table>",
            },
        },
        new ChunkModel
        {
            Index = 11,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            RawContent = @"<table class=""nowraplinks mw-collapsible autocollapse navbox-inner mw-made-collapsible mw-collapsed"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""2""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Formal_semantics"" title=""Template:Formal semantics""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Formal_semantics"" title=""Template talk:Formal semantics""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Formal_semantics"" title=""Special:EditPage/Template:Formal semantics""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Formal_semantics_(natural_language)78"" style=""font-size:114%;margin:0 4em""><a href=""/wiki/Formal_semantics_(natural_language)"" title=""Formal semantics (natural language)"">Formal semantics (natural language)</a></div></th></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%"">Central concepts</th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Principle_of_compositionality"" title=""Principle of compositionality"">Compositionality</a></li>
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
</div></td></tr></tbody></table>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table class=""nowraplinks mw-collapsible autocollapse navbox-inner mw-made-collapsible mw-collapsed"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""2""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Formal_semantics"" title=""Template:Formal semantics""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Formal_semantics"" title=""Template talk:Formal semantics""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Formal_semantics"" title=""Special:EditPage/Template:Formal semantics""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Formal_semantics_(natural_language)78"" style=""font-size:114%;margin:0 4em""><a href=""/wiki/Formal_semantics_(natural_language)"" title=""Formal semantics (natural language)"">Formal semantics (natural language)</a></div></th></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%"">Central concepts</th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Principle_of_compositionality"" title=""Principle of compositionality"">Compositionality</a></li>
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
</div></td></tr></tbody></table>",
            },
        },
        new ChunkModel
        {
            Index = 12,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            RawContent = @"<table class=""nowraplinks mw-collapsible mw-collapsed navbox-inner mw-made-collapsible"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""2""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Mathematical_logic"" title=""Template:Mathematical logic""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Mathematical_logic"" title=""Template talk:Mathematical logic""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Mathematical_logic"" title=""Special:EditPage/Template:Mathematical logic""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Mathematical_logic326"" style=""font-size:114%;margin:0 4em""><a href=""/wiki/Mathematical_logic"" title=""Mathematical logic"">Mathematical logic</a></div></th></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%"">General</th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Axiom"" title=""Axiom"">Axiom</a><ul><li><a href=""/wiki/List_of_axioms"" title=""List of axioms"">list</a></li></ul></li>
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
</div></td></tr><tr style=""display: none;""><td class=""navbox-abovebelow"" colspan=""2""><div><b><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><a href=""/wiki/File:Nuvola_apps_edu_mathematics_blue-p.svg"" class=""mw-file-description""><img alt=""icon"" src=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/15px-Nuvola_apps_edu_mathematics_blue-p.svg.png"" decoding=""async"" width=""15"" height=""15"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/23px-Nuvola_apps_edu_mathematics_blue-p.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/30px-Nuvola_apps_edu_mathematics_blue-p.svg.png 2x"" data-file-width=""128"" data-file-height=""128""></a></span> </span><a href=""/wiki/Portal:Mathematics"" title=""Portal:Mathematics"">Mathematics portal</a></b></div></td></tr></tbody></table>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table class=""nowraplinks mw-collapsible mw-collapsed navbox-inner mw-made-collapsible"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""col"" class=""navbox-title"" colspan=""2""><button type=""button"" class=""mw-collapsible-toggle mw-collapsible-toggle-default mw-collapsible-toggle-collapsed"" aria-expanded=""false"" tabindex=""0""><span class=""mw-collapsible-text"">show</span></button><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1129693374""><link rel=""mw-deduplicated-inline-style"" href=""mw-data:TemplateStyles:r1239400231""><div class=""navbar plainlinks hlist navbar-mini""><ul><li class=""nv-view""><a href=""/wiki/Template:Mathematical_logic"" title=""Template:Mathematical logic""><abbr title=""View this template"">v</abbr></a></li><li class=""nv-talk""><a href=""/wiki/Template_talk:Mathematical_logic"" title=""Template talk:Mathematical logic""><abbr title=""Discuss this template"">t</abbr></a></li><li class=""nv-edit""><a href=""/wiki/Special:EditPage/Template:Mathematical_logic"" title=""Special:EditPage/Template:Mathematical logic""><abbr title=""Edit this template"">e</abbr></a></li></ul></div><div id=""Mathematical_logic326"" style=""font-size:114%;margin:0 4em""><a href=""/wiki/Mathematical_logic"" title=""Mathematical logic"">Mathematical logic</a></div></th></tr><tr style=""display: none;""><th scope=""row"" class=""navbox-group"" style=""width:1%"">General</th><td class=""navbox-list-with-group navbox-list navbox-odd hlist"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><a href=""/wiki/Axiom"" title=""Axiom"">Axiom</a><ul><li><a href=""/wiki/List_of_axioms"" title=""List of axioms"">list</a></li></ul></li>
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
</div></td></tr><tr style=""display: none;""><td class=""navbox-abovebelow"" colspan=""2""><div><b><span class=""nowrap""><span class=""noviewer"" typeof=""mw:File""><a href=""/wiki/File:Nuvola_apps_edu_mathematics_blue-p.svg"" class=""mw-file-description""><img alt=""icon"" src=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/15px-Nuvola_apps_edu_mathematics_blue-p.svg.png"" decoding=""async"" width=""15"" height=""15"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/23px-Nuvola_apps_edu_mathematics_blue-p.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Nuvola_apps_edu_mathematics_blue-p.svg/30px-Nuvola_apps_edu_mathematics_blue-p.svg.png 2x"" data-file-width=""128"" data-file-height=""128""></a></span> </span><a href=""/wiki/Portal:Mathematics"" title=""Portal:Mathematics"">Mathematics portal</a></b></div></td></tr></tbody></table>",
            },
        },
        new ChunkModel
        {
            Index = 13,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            RawContent = @"<table class=""nowraplinks hlist navbox-inner"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Help:Authority_control"" title=""Help:Authority control"">Authority control databases</a>: National <span class=""mw-valign-text-top noprint"" typeof=""mw:File/Frameless""><a href=""https://www.wikidata.org/wiki/Q190558#identifiers"" title=""Edit this at Wikidata""><img alt=""Edit this at Wikidata"" src=""//upload.wikimedia.org/wikipedia/en/thumb/8/8a/OOjs_UI_icon_edit-ltr-progressive.svg/10px-OOjs_UI_icon_edit-ltr-progressive.svg.png"" decoding=""async"" width=""10"" height=""10"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/en/thumb/8/8a/OOjs_UI_icon_edit-ltr-progressive.svg/15px-OOjs_UI_icon_edit-ltr-progressive.svg.png 1.5x, //upload.wikimedia.org/wikipedia/en/thumb/8/8a/OOjs_UI_icon_edit-ltr-progressive.svg/20px-OOjs_UI_icon_edit-ltr-progressive.svg.png 2x"" data-file-width=""20"" data-file-height=""20""></a></span></th><td class=""navbox-list-with-group navbox-list navbox-odd"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><span class=""uid""><a rel=""nofollow"" class=""external text"" href=""https://d-nb.info/gnd/4137553-1"">Germany</a></span></li></ul></div></td></tr></tbody></table>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table class=""nowraplinks hlist navbox-inner"" style=""border-spacing:0;background:transparent;color:inherit""><tbody><tr><th scope=""row"" class=""navbox-group"" style=""width:1%""><a href=""/wiki/Help:Authority_control"" title=""Help:Authority control"">Authority control databases</a>: National <span class=""mw-valign-text-top noprint"" typeof=""mw:File/Frameless""><a href=""https://www.wikidata.org/wiki/Q190558#identifiers"" title=""Edit this at Wikidata""><img alt=""Edit this at Wikidata"" src=""//upload.wikimedia.org/wikipedia/en/thumb/8/8a/OOjs_UI_icon_edit-ltr-progressive.svg/10px-OOjs_UI_icon_edit-ltr-progressive.svg.png"" decoding=""async"" width=""10"" height=""10"" class=""mw-file-element"" srcset=""//upload.wikimedia.org/wikipedia/en/thumb/8/8a/OOjs_UI_icon_edit-ltr-progressive.svg/15px-OOjs_UI_icon_edit-ltr-progressive.svg.png 1.5x, //upload.wikimedia.org/wikipedia/en/thumb/8/8a/OOjs_UI_icon_edit-ltr-progressive.svg/20px-OOjs_UI_icon_edit-ltr-progressive.svg.png 2x"" data-file-width=""20"" data-file-height=""20""></a></span></th><td class=""navbox-list-with-group navbox-list navbox-odd"" style=""width:100%;padding:0""><div style=""padding:0 0.25em""><ul><li><span class=""uid""><a rel=""nofollow"" class=""external text"" href=""https://d-nb.info/gnd/4137553-1"">Germany</a></span></li></ul></div></td></tr></tbody></table>",
            },
        },
    ];

    // https://www.geeksforgeeks.org/basic-operators-in-relational-algebra-2/
    internal static readonly ChunkModel[] GeeksForGeeksAboutRelationalAlgebraTables =
    [
        new ChunkModel
        {
            Index = 14,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table>
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
</table>",
            },
            RawContent = @"<table>
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
</table>",
        },
        new ChunkModel
        {
            Index = 15,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>()
            {
                ["content"] = @"<table>
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
</table>",
            },
            RawContent = @"<table>
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
</table>",
        },
        new ChunkModel
        {
            Index = 16,
            ChunkType = ChunkType.Table,
            Data = new Dictionary<string, object>()
            {
                ["content"] = @"<table>
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
</table>",
            },
            RelatedChunksIndexes = [],
            RawContent = @"<table>
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
</table>",
        },
        new ChunkModel
        {
            Index = 17,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table>
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
</table>"
            },
            RawContent = @"<table>
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
</table>",
        },
        new ChunkModel
        {
            Index = 18,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table>
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
</table>",
            },
            RawContent = @"<table>
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
</table>",
        },
        new ChunkModel
        {
            Index = 19,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table>
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
</table>",
            },
            RawContent = @"<table>
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
</table>",
        },
        new ChunkModel
        {
            Index = 20,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table>
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
</table>",
            },
            RawContent = @"<table>
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
</table>",
        },
        new ChunkModel
        {
            Index = 21,
            ChunkType = ChunkType.Table,
            RelatedChunksIndexes = [],
            Data = new Dictionary<string, object>
            {
                ["content"] = @"<table>
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
</table>"
            },
            RawContent = @"<table>
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
</table>",
        },
    ];
}
