#pragma checksum "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa4e05eb8d87bbc1383354705455c6645bdc0d61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Delete), @"mvc.1.0.view", @"/Views/Categories/Delete.cshtml")]
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
#line 1 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\_ViewImports.cshtml"
using TestProjectIsDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\_ViewImports.cshtml"
using TestProjectIsDB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4e05eb8d87bbc1383354705455c6645bdc0d61", @"/Views/Categories/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd576d6fcae38d29f7e64c1db1f9acdea07afe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestProjectIsDB.Models.Classes.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
   ViewBag.Title = "Delete"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Delete</h2>\n\n<div class=\"modal-header\">\n    <h5 class=\"modal-title\" id=\"deleteItemModalLabel\">Are you sure you want to delete ");
#nullable restore
#line 9 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
                                                                                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("&iquest;</h5>\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\n        <span aria-hidden=\"true\">&times;</span>\n    </button>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aa4e05eb8d87bbc1383354705455c6645bdc0d616214", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
            WriteLiteral("\n<div class=\"modal-body\">\n");
#nullable restore
#line 16 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
     for (int i = 0; i < Model.Items.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\n    <img src=\"Items[i].Image\" height=\"65\" width=\"60\" />\n\n    <div class=\"card-body\">\n        <h5 class=\"card-title\">");
#nullable restore
#line 22 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
                          Write(Html.DisplayFor(model => model.Items[i].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <p class=\"card-text\">\n            ");
#nullable restore
#line 24 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Items[i].Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(":&nbsp;");
#nullable restore
#line 24 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
                                                                         Write(Html.DisplayFor(model => model.Items[i].Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            ");
#nullable restore
#line 26 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Items[i].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(":&nbsp;");
#nullable restore
#line 26 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
                                                                       Write(Html.DisplayFor(model => model.Items[i].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            ");
#nullable restore
#line 28 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Items[i].EntryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":&nbsp;");
#nullable restore
#line 28 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
                                                                     Write(Html.DisplayFor(model => model.Items[i].EntryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            ");
#nullable restore
#line 30 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Items[i].Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(":&nbsp;");
#nullable restore
#line 30 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
                                                                    Write(Html.DisplayFor(model => model.Items[i].Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n</div>\n                <br />");
#nullable restore
#line 34 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"modal-footer\">\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa4e05eb8d87bbc1383354705455c6645bdc0d6111431", async() => {
                WriteLiteral("\n        ");
#nullable restore
#line 39 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Categories\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\n        <input type=\"submit\" class=\"btn btn-primary\" value=\"Delete\" />\n\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestProjectIsDB.Models.Classes.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
