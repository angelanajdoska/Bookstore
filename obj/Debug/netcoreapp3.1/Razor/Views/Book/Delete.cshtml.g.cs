#pragma checksum "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "579cb5b4a683d7008aaeb5900dff93206e823d61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Delete), @"mvc.1.0.view", @"/Views/Book/Delete.cshtml")]
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
#line 1 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\_ViewImports.cshtml"
using Bookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\_ViewImports.cshtml"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579cb5b4a683d7008aaeb5900dff93206e823d61", @"/Views/Book/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9813f32cfffdf724c39d00915f05a87ed3c57440", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookstore.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
  
    ViewData["Title"] = "Избриши";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Избриши</h1>\r\n\r\n<h3>Дали сте сигурни дека сакате да избришете ?</h3>\r\n<div>\r\n    <h4>Автор</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BooksID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BooksID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OriginalTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OriginalTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Synopsis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Synopsis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberofPages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumberofPages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n          <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n          <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Author.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "579cb5b4a683d7008aaeb5900dff93206e823d6112555", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "579cb5b4a683d7008aaeb5900dff93206e823d6112822", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 77 "C:\Users\Angela\Desktop\Ангела\трета година\шести семестар\Развој на серверски web апликации\проекти\Bookstore\Views\Book\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BooksID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Избриши\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "579cb5b4a683d7008aaeb5900dff93206e823d6114671", async() => {
                    WriteLiteral("Назад");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookstore.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
