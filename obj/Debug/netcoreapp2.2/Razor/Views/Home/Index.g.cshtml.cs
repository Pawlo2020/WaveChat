<<<<<<< HEAD
#pragma checksum "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "091d35486c17d9f155a1a61ac3fc227d4f4b827e"
=======
#pragma checksum "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91aa07222b48bfe8ef073a84377bfefe746999a1"
>>>>>>> parent of e798fcb... Search
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
#line 1 "D:\Projekty\WaveChat\WaveChat\Views\_ViewImports.cshtml"
using WaveChat;

#line default
#line hidden
#line 2 "D:\Projekty\WaveChat\WaveChat\Views\_ViewImports.cshtml"
using WaveChat.Models;

#line default
#line hidden
#line 1 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"091d35486c17d9f155a1a61ac3fc227d4f4b827e", @"/Views/Home/Index.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91aa07222b48bfe8ef073a84377bfefe746999a1", @"/Views/Home/Index.cshtml")]
>>>>>>> parent of e798fcb... Search
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3a88438003dd98c2bebbc032394f3456526aab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WaveChat.Models.ChatModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.unobtrusive-ajax.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/font-awesome/css/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sendForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("_init()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Strona domowa";

#line default
#line hidden
            BeginContext(200, 39, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(239, 626, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "091d35486c17d9f155a1a61ac3fc227d4f4b827e6691", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91aa07222b48bfe8ef073a84377bfefe746999a16691", async() => {
>>>>>>> parent of e798fcb... Search
                BeginContext(245, 310, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <script src=""https://code.jquery.com/jquery-1.10.2.js""
            integrity=""sha256-it5nQKHTz+34HijZJQkpNBIHsjpV8b6QzMJs9tmOBSo=""
            crossorigin=""anonymous""></script>
    ");
                EndContext();
                BeginContext(555, 55, false);
<<<<<<< HEAD
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "091d35486c17d9f155a1a61ac3fc227d4f4b827e7393", async() => {
=======
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91aa07222b48bfe8ef073a84377bfefe746999a17393", async() => {
>>>>>>> parent of e798fcb... Search
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(610, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(616, 71, false);
<<<<<<< HEAD
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "091d35486c17d9f155a1a61ac3fc227d4f4b827e8646", async() => {
=======
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91aa07222b48bfe8ef073a84377bfefe746999a18646", async() => {
>>>>>>> parent of e798fcb... Search
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(687, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(693, 90, false);
<<<<<<< HEAD
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "091d35486c17d9f155a1a61ac3fc227d4f4b827e9899", async() => {
=======
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91aa07222b48bfe8ef073a84377bfefe746999a19899", async() => {
>>>>>>> parent of e798fcb... Search
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(783, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(793, 63, false);
<<<<<<< HEAD
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "091d35486c17d9f155a1a61ac3fc227d4f4b827e11157", async() => {
=======
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91aa07222b48bfe8ef073a84377bfefe746999a111157", async() => {
>>>>>>> parent of e798fcb... Search
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(856, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(865, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
<<<<<<< HEAD
            BeginContext(869, 4313, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "091d35486c17d9f155a1a61ac3fc227d4f4b827e13291", async() => {
                BeginContext(892, 1488, true);
=======
            BeginContext(869, 4280, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91aa07222b48bfe8ef073a84377bfefe746999a113291", async() => {
                BeginContext(892, 678, true);
>>>>>>> parent of e798fcb... Search
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row w-100"" >
            <div class=""col-md-4"" style=""background-color: #f1f2f6; border-radius: 4px 4px 4px 4px;"">

                <div class=""input-group"" style=""margin-top: 2%;"">
                    <input type=""text"" class=""form-control"" id=""searchBox"" placeholder=""Search..."" autocomplete=""off"" aria-label=""Search..."" aria-describedby=""basic-addon2"">
                    <div class=""input-group-append"">
                        <button class=""btn btn-primary"" id=""Person"" type=""button""><i class=""fas fa-search""></i></button>
                    </div>
                </div>
                <hr>
                ");
                EndContext();
                BeginContext(1571, 38, false);
#line 36 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
           Write(Html.Partial("SearchContainer", Model));

#line default
#line hidden
                EndContext();
                BeginContext(1609, 738, true);
                WriteLiteral(@"
            </div>
           
            <div class=""col-md-6"">
                <div class=""form-group"">
                    <label for=""exampleFormControlTextarea1"">Messages</label>
                        <div id=""div1"" class=""area"">
<<<<<<< HEAD
            <div class=""scrollbar-morpheus-den"" id=""ms");
                WriteLiteral(@"glist"" style="" overflow:auto;"">




                
=======
            <div class=""scrollbar-morpheus-den"" id=""msglist"" style="" overflow:auto;"">
>>>>>>> parent of e798fcb... Search
            </div>
        </div>
        
        <hr>
        <div style=""display: inline-block;
                margin: 0px 10px 0px 0px;"">

            <!-- <form asp-controller=""Home"" id=""sendForm"" asp-action=""SendMessage"" data-ajax=""true"" data-ajax-method=""POST"">
                <div class=""form-group"" style=""display:flex ;align-items: center;"">
                    
                    ");
                EndContext();
<<<<<<< HEAD
                BeginContext(2381, 325, false);
#line 61 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
=======
                BeginContext(2348, 325, false);
#line 54 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
>>>>>>> parent of e798fcb... Search
               Write(Html.TextBoxFor(m => m.MessageModel.Message, new
               {
                   @class = "form-control",
                   @id = "inlineFormInputName",
                   @placeholder = "Enter message...",
                   @style = "display: inline;",
                   @autocomplete = "off"
               }));

#line default
#line hidden
                EndContext();
<<<<<<< HEAD
                BeginContext(2706, 317, true);
=======
                BeginContext(2673, 317, true);
>>>>>>> parent of e798fcb... Search
                WriteLiteral(@"
                <span style=""width: 1rem; display: inline;""></span>
                <button id=""sendBut"" style=""display: inline;"" class=""btn btn-primary"" type=""submit"" formmethod=""post""><i class=""fas fa-paper-plane""></i></button>
                </div>
                
            </form> -->


            ");
                EndContext();
<<<<<<< HEAD
                BeginContext(3023, 545, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "091d35486c17d9f155a1a61ac3fc227d4f4b827e16242", async() => {
                    BeginContext(3043, 518, true);
=======
                BeginContext(2990, 545, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91aa07222b48bfe8ef073a84377bfefe746999a116481", async() => {
                    BeginContext(3010, 518, true);
>>>>>>> parent of e798fcb... Search
                    WriteLiteral(@"
                <div class = ""form-group"" style=""display:flex ;align-items: center;"">
                    <input id=""inlineFormInputName"" class=""form-control"" style=""display: inline"" autocomplete = ""off"" placeholder = ""Enter message..."">
                    <span style=""width: 1rem; display: inline;""></span>
                    <button id=""sendBut"" style=""display: inline;"" class=""btn btn-primary"" type=""submit"" formmethod=""post""><i class=""fas fa-paper-plane""></i></button>
                </div>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
<<<<<<< HEAD
                BeginContext(3568, 1108, true);
=======
                BeginContext(3535, 1108, true);
>>>>>>> parent of e798fcb... Search
                WriteLiteral(@"


        </div>
    </div>

        
    <!-- The core Firebase JS SDK is always required and must be listed first -->
    <script src=""https://www.gstatic.com/firebasejs/6.4.2/firebase-app.js""></script>

    <!-- TODO: Add SDKs for Firebase products that you want to use
        https://firebase.google.com/docs/web/setup#config-web-app -->
    <script src=""https://www.gstatic.com/firebasejs/6.4.1/firebase-database.js""></script>

    <script>
        // Your web app's Firebase configuration
        var firebaseConfig = {
            apiKey: ""AIzaSyAVFwti5cO3cNc8JOtlahOrrWbgIHVVXvI"",
            authDomain: ""wavechat-617f9.firebaseapp.com"",
            databaseURL: ""https://wavechat-617f9.firebaseio.com"",
            projectId: ""wavechat-617f9"",
            storageBucket: """",
            messagingSenderId: ""335817646110"",
            appId: ""1:335817646110:web:b8c82d74de7272c6""
        };
        // Initialize Firebase
        firebase.initializeApp(firebaseConfig);
        var data");
                WriteLiteral("base = firebase.database();\r\n\r\n        function getUsername(){\r\n            return \"");
                EndContext();
<<<<<<< HEAD
                BeginContext(4677, 29, false);
#line 112 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
=======
                BeginContext(4644, 29, false);
#line 105 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
>>>>>>> parent of e798fcb... Search
               Write(UserManager.GetUserName(User));

#line default
#line hidden
                EndContext();
<<<<<<< HEAD
                BeginContext(4706, 76, true);
                WriteLiteral("\";\r\n        }\r\n\r\n        function getFirstnLastName(){\r\n            return \"");
                EndContext();
                BeginContext(4783, 47, false);
#line 116 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
=======
                BeginContext(4673, 76, true);
                WriteLiteral("\";\r\n        }\r\n\r\n        function getFirstnLastName(){\r\n            return \"");
                EndContext();
                BeginContext(4750, 47, false);
#line 109 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
>>>>>>> parent of e798fcb... Search
               Write(UserManager.GetUserAsync(User).Result.FirstName);

#line default
#line hidden
                EndContext();
<<<<<<< HEAD
                BeginContext(4830, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(4832, 46, false);
#line 116 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
=======
                BeginContext(4797, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(4799, 46, false);
#line 109 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
>>>>>>> parent of e798fcb... Search
                                                                Write(UserManager.GetUserAsync(User).Result.LastName);

#line default
#line hidden
                EndContext();
<<<<<<< HEAD
                BeginContext(4878, 64, true);
                WriteLiteral("\";\r\n        }\r\n        function getGUID(){\r\n            return \"");
                EndContext();
                BeginContext(4943, 50, false);
#line 119 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
=======
                BeginContext(4845, 64, true);
                WriteLiteral("\";\r\n        }\r\n        function getGUID(){\r\n            return \"");
                EndContext();
                BeginContext(4910, 50, false);
#line 112 "D:\Projekty\WaveChat\WaveChat\Views\Home\Index.cshtml"
>>>>>>> parent of e798fcb... Search
               Write(UserManager.GetUserAsync(User).Result.FirebaseGUID);

#line default
#line hidden
                EndContext();
<<<<<<< HEAD
                BeginContext(4993, 182, true);
=======
                BeginContext(4960, 182, true);
>>>>>>> parent of e798fcb... Search
                WriteLiteral("\";\r\n        }\r\n    </script>\r\n    <script src=\"../js/connection.js\" charset=\"utf-8\"></script>\r\n    <script src=\"../js/search.js\" charset=\"utf-8\"></script>\r\n\r\n    </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
<<<<<<< HEAD
            BeginContext(5182, 21, true);
=======
            BeginContext(5149, 21, true);
>>>>>>> parent of e798fcb... Search
            WriteLiteral("\r\n\r\n\r\n\r\n</html>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<WaveChat.Areas.Identity.Data.WaveChatUser> UserManager { get; private set; }
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
