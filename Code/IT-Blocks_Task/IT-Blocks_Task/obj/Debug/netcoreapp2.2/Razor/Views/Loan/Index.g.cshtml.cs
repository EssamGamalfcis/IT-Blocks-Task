#pragma checksum "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5757057ad8143cf27a7bdf890de1160eff4d0aed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loan_Index), @"mvc.1.0.view", @"/Views/Loan/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Loan/Index.cshtml", typeof(AspNetCore.Views_Loan_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5757057ad8143cf27a7bdf890de1160eff4d0aed", @"/Views/Loan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b9ae22a9ebf03d6d34aa22e8c13e13078f7d9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Loan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.BookLoan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Loan_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 92, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <input type=\"button\" value=\"Create New\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 224, "\"", 279, 3);
            WriteAttributeValue("", 234, "location.href=\'", 234, 15, true);
#line 11 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
WriteAttributeValue("", 249, Url.Action("Create", "Loan"), 249, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 278, "\'", 278, 1, true);
            EndWriteAttribute();
            BeginContext(280, 137, true);
            WriteLiteral(" />\r\n</p>\r\n<table class=\"table table-striped table-dark table-bordered\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(418, 29, false);
#line 18 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
           Write(Html.DisplayName("Book Name"));

#line default
#line hidden
            EndContext();
            BeginContext(447, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(503, 37, false);
#line 21 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
           Write(Html.DisplayName("Person First Name"));

#line default
#line hidden
            EndContext();
            BeginContext(540, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(596, 36, false);
#line 24 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
           Write(Html.DisplayName("Person Last Name"));

#line default
#line hidden
            EndContext();
            BeginContext(632, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(688, 33, false);
#line 27 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
           Write(Html.DisplayName("Date Borrowed"));

#line default
#line hidden
            EndContext();
            BeginContext(721, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(777, 33, false);
#line 30 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
           Write(Html.DisplayName("Returned Date"));

#line default
#line hidden
            EndContext();
            BeginContext(810, 87, true);
            WriteLiteral("\r\n            </th>\r\n\r\n           <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(929, 50, true);
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(980, 48, false);
#line 41 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Book.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1084, 50, false);
#line 44 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Loan.LoanPFname));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1190, 50, false);
#line 47 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Loan.LoanPLname));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1296, 43, false);
#line 50 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanDate));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1395, 49, false);
#line 53 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 126, true);
            WriteLiteral("\r\n            </td>\r\n          \r\n            <td>\r\n\r\n                <input type=\"button\" value=\"Edit\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1570, "\"", 1640, 5);
            WriteAttributeValue("", 1580, "location.href=\'", 1580, 15, true);
#line 58 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
WriteAttributeValue("", 1595, Url.Action("Edit", "Loan"), 1595, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1622, "?id=\'", 1622, 5, true);
            WriteAttributeValue(" ", 1627, "+", 1628, 2, true);
#line 58 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
WriteAttributeValue(" ", 1629, item.BlId, 1630, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1641, 79, true);
            WriteLiteral(" />\r\n                <input type=\"button\" value=\"Delete\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1720, "\"", 1792, 5);
            WriteAttributeValue("", 1730, "location.href=\'", 1730, 15, true);
#line 59 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
WriteAttributeValue("", 1745, Url.Action("Delete", "Loan"), 1745, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 1774, "?id=\'", 1774, 5, true);
            WriteAttributeValue(" ", 1779, "+", 1780, 2, true);
#line 59 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
WriteAttributeValue(" ", 1781, item.BlId, 1782, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1793, 43, true);
            WriteLiteral(" />\r\n\r\n\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\essam\OneDrive\Desktop\IT-Blocks_Task\Code\IT-Blocks_Task\IT-Blocks_Task\Views\Loan\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1839, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.BookLoan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
