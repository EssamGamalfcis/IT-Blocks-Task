#pragma checksum "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "076f9f1e10d5f45d2ef3e6a00bbceb2538ff42b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Details.cshtml", typeof(AspNetCore.Views_Admin_Details))]
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
#line 1 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\_ViewImports.cshtml"
using IT_Blocks_Task;

#line default
#line hidden
#line 2 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\_ViewImports.cshtml"
using IT_Blocks_Task.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"076f9f1e10d5f45d2ef3e6a00bbceb2538ff42b4", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b9ae22a9ebf03d6d34aa22e8c13e13078f7d9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Admin_Layout.cshtml";

#line default
#line hidden
            BeginContext(118, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Book</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(246, 44, false);
#line 15 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(290, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(354, 40, false);
#line 18 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(394, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(457, 51, false);
#line 21 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookDescription));

#line default
#line hidden
            EndContext();
            BeginContext(508, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(572, 47, false);
#line 24 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookDescription));

#line default
#line hidden
            EndContext();
            BeginContext(619, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(682, 46, false);
#line 27 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookAmount));

#line default
#line hidden
            EndContext();
            BeginContext(728, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(792, 42, false);
#line 30 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookAmount));

#line default
#line hidden
            EndContext();
            BeginContext(834, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(897, 42, false);
#line 33 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(939, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1003, 50, false);
#line 36 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author.UserLoginId));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 104, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <input type=\"button\" value=\"Edit\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1157, "\"", 1231, 5);
            WriteAttributeValue("", 1167, "location.href=\'", 1167, 15, true);
#line 41 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml"
WriteAttributeValue("", 1182, Url.Action("Edit", "Admin"), 1182, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1210, "?id=\'", 1210, 5, true);
            WriteAttributeValue(" ", 1215, "+", 1216, 2, true);
#line 41 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Admin\Details.cshtml"
WriteAttributeValue(" ", 1217, Model.BookId, 1218, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1232, 12, true);
            WriteLiteral(" /> | \r\n    ");
            EndContext();
            BeginContext(1244, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "076f9f1e10d5f45d2ef3e6a00bbceb2538ff42b48658", async() => {
                BeginContext(1266, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(1282, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
