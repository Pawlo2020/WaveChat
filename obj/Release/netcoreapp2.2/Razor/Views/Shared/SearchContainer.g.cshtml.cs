#pragma checksum "D:\Projekty\WaveChat\WaveChat\Views\Shared\SearchContainer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8835eb3ab50807173ad77aa3e6a15e86ca3584d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SearchContainer), @"mvc.1.0.view", @"/Views/Shared/SearchContainer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/SearchContainer.cshtml", typeof(AspNetCore.Views_Shared_SearchContainer))]
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
#line 1 "D:\Projekty\WaveChat\WaveChat\Views\_ViewImports.cshtml"
using WaveChat;

#line default
#line hidden
#line 2 "D:\Projekty\WaveChat\WaveChat\Views\_ViewImports.cshtml"
using WaveChat.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8835eb3ab50807173ad77aa3e6a15e86ca3584d0", @"/Views/Shared/SearchContainer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3a88438003dd98c2bebbc032394f3456526aab", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SearchContainer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WaveChat.Models.ChatModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(154, 34, true);
            WriteLiteral("\r\n\r\n    <div class=\"list-group\">\r\n");
            EndContext();
#line 7 "D:\Projekty\WaveChat\WaveChat\Views\Shared\SearchContainer.cshtml"
         foreach (var item in Model.SearchModel)
        {
            

#line default
#line hidden
#line 9 "D:\Projekty\WaveChat\WaveChat\Views\Shared\SearchContainer.cshtml"
                                                                                                             

        }

#line default
#line hidden
            BeginContext(373, 16, true);
            WriteLiteral("    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WaveChat.Models.ChatModel> Html { get; private set; }
    }
}
#pragma warning restore 1591