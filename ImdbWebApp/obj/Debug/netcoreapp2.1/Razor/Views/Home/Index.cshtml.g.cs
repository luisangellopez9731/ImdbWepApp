#pragma checksum "C:\Users\luisa\source\repos\ImdbWebApp\ImdbWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21af67ef991249a50eafb9e53a76cc66b12b8e39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\luisa\source\repos\ImdbWebApp\ImdbWebApp\Views\_ViewImports.cshtml"
using ImdbWebApp;

#line default
#line hidden
#line 2 "C:\Users\luisa\source\repos\ImdbWebApp\ImdbWebApp\Views\_ViewImports.cshtml"
using ImdbWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21af67ef991249a50eafb9e53a76cc66b12b8e39", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1472d8d0b9cf2f9646843c6bcd629c21e182101b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImdbWebApp.Models.Movie[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\luisa\source\repos\ImdbWebApp\ImdbWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var movies = Model;

#line default
#line hidden
            BeginContext(104, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(108, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "242c0387e743410fb63f088147d45531", async() => {
                BeginContext(137, 178, true);
                WriteLiteral("\r\n        <input type=\"text\" name=\"search\" value=\"\" placeholder=\"Search by title\" class=\"SearchInput\" />\r\n        <button class=\"SearchButton\" type=\"submit\">Search</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(322, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "C:\Users\luisa\source\repos\ImdbWebApp\ImdbWebApp\Views\Home\Index.cshtml"
     if(movies != null)
    {

#line default
#line hidden
            BeginContext(358, 22, true);
            WriteLiteral("<div class=\"Result\">\r\n");
            EndContext();
#line 14 "C:\Users\luisa\source\repos\ImdbWebApp\ImdbWebApp\Views\Home\Index.cshtml"
     foreach (var movie in movies)
    {

#line default
#line hidden
            BeginContext(423, 118, true);
            WriteLiteral("    <div class=\"Movie\">\r\n        <div>\r\n            <div class=\"PosterContainer\">\r\n                <img class=\"Poster\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 541, "\"", 560, 1);
#line 19 "C:\Users\luisa\source\repos\ImdbWebApp\ImdbWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 547, movie.Poster, 547, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(561, 76, true);
            WriteLiteral(" alt=\"Alternate Text\" />\r\n            </div>\r\n            <p class=\"Title\"> ");
            EndContext();
            BeginContext(638, 11, false);
#line 21 "C:\Users\luisa\source\repos\ImdbWebApp\ImdbWebApp\Views\Home\Index.cshtml"
                         Write(movie.Title);

#line default
#line hidden
            EndContext();
            BeginContext(649, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
            BeginContext(714, 42, true);
            WriteLiteral("        </div>\r\n        \r\n\r\n\r\n    </div>\r\n");
            EndContext();
#line 28 "C:\Users\luisa\source\repos\ImdbWebApp\ImdbWebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(763, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 31 "C:\Users\luisa\source\repos\ImdbWebApp\ImdbWebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(780, 4, true);
            WriteLiteral("    ");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImdbWebApp.Models.Movie[]> Html { get; private set; }
    }
}
#pragma warning restore 1591