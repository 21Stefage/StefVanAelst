#pragma checksum "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6389268fae9126952c43a7f502d5b03cca95f35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artiest_Details), @"mvc.1.0.view", @"/Views/Artiest/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\_ViewImports.cshtml"
using Festival;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\_ViewImports.cshtml"
using Festival.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6389268fae9126952c43a7f502d5b03cca95f35", @"/Views/Artiest/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca0e10ffff9c7442efb1255b27b469deb66a868", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Artiest_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Festival.ViewModel.DetailsArtiestViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details</h1>\r\n<h4>Artiest</h4>\r\n<hr />\r\n\r\n<dl class=\"row\">\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 11 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 14 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayFor(model => model.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 17 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Achternaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 20 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayFor(model => model.Achternaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 23 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Artiestnaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 26 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayFor(model => model.Artiestnaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 29 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Leeftijd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 32 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayFor(model => model.Leeftijd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 35 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Dag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 38 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayFor(model => model.Dag.DagNaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 41 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 44 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayFor(model => model.Genre.GenreNaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        Liedjes van de artiest: \r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 50 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
   Write(Html.DisplayFor(model => model.ArtiestSong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n</dl>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6389268fae9126952c43a7f502d5b03cca95f358369", async() => {
                WriteLiteral("Terug naar de lijst");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 58 "D:\School\Schooljaar 22-23\WebApplicaties\0 - Project\StefVanAelst-R0752235\Festival\Views\Artiest\Details.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Festival.ViewModel.DetailsArtiestViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
