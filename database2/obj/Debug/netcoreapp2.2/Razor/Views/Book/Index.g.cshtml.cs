#pragma checksum "D:\Visual\database2\database2\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a798b62305a18f62f7cf0d407368d2e66fa1816"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
#line 1 "D:\Visual\database2\database2\Views\_ViewImports.cshtml"
using database2;

#line default
#line hidden
#line 2 "D:\Visual\database2\database2\Views\_ViewImports.cshtml"
using database2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a798b62305a18f62f7cf0d407368d2e66fa1816", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c93cd46084c593113a316e844ce137cdbdfb6ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "รายการหนังสือ";

#line default
#line hidden
            BeginContext(68, 26, true);
            WriteLiteral("\r\n<h1>รายการหนังสือ</h1>\r\n");
            EndContext();
#line 7 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(134, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(138, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a798b62305a18f62f7cf0d407368d2e66fa18165072", async() => {
                BeginContext(208, 16, true);
                WriteLiteral("เพิ่มหนังสือใหม่");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(228, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
}

#line default
#line hidden
            BeginContext(233, 78, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(312, 33, false);
#line 17 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
       Write(Html.DisplayNameFor(m => m[0].Id));

#line default
#line hidden
            EndContext();
            BeginContext(345, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(389, 35, false);
#line 20 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
       Write(Html.DisplayNameFor(m => m[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(424, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(468, 36, false);
#line 23 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
       Write(Html.DisplayNameFor(m => m[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(504, 17, true);
            WriteLiteral("\r\n        </th>\r\n");
            EndContext();
#line 25 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(577, 63, true);
            WriteLiteral("            <th>\r\n                (คำสั่ง)\r\n            </th>\r\n");
            EndContext();
#line 30 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(651, 25, true);
            WriteLiteral("            \r\n    </tr>\r\n");
            EndContext();
#line 33 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(717, 26, true);
            WriteLiteral("<tr>\r\n\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(744, 29, false);
#line 38 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
   Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(773, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(805, 31, false);
#line 41 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(836, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(868, 32, false);
#line 44 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
   Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(900, 13, true);
            WriteLiteral("\r\n    </td>\r\n");
            EndContext();
#line 46 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
            BeginContext(961, 26, true);
            WriteLiteral("        <td>\r\n            ");
            EndContext();
            BeginContext(987, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a798b62305a18f62f7cf0d407368d2e66fa181610233", async() => {
                BeginContext(1058, 5, true);
                WriteLiteral("แก้ไข");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1067, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1081, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a798b62305a18f62f7cf0d407368d2e66fa181612776", async() => {
                BeginContext(1154, 8, true);
                WriteLiteral("ลบข้อมูล");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1166, 17, true);
            WriteLiteral("\r\n        </td>\r\n");
            EndContext();
#line 52 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1190, 17, true);
            WriteLiteral("        \r\n</tr>\r\n");
            EndContext();
#line 55 "D:\Visual\database2\database2\Views\Book\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1214, 14, true);
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
