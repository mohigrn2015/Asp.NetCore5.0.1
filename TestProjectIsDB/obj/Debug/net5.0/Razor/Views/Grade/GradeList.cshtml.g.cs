#pragma checksum "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Grade\GradeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ec0e1bef864409831da8c7023d428d731ba940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grade_GradeList), @"mvc.1.0.view", @"/Views/Grade/GradeList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45ec0e1bef864409831da8c7023d428d731ba940", @"/Views/Grade/GradeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd576d6fcae38d29f7e64c1db1f9acdea07afe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Grade_GradeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestProjectIsDB.Models.Classes.Grade>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddGrade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Grade\GradeList.cshtml"
  
    ViewData["Title"] = "Grade List";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Grade List</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45ec0e1bef864409831da8c7023d428d731ba9403714", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Grade Id ");
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Grade Name\r\n");
            WriteLiteral("            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Grade\GradeList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Grade\GradeList.cshtml"
               Write(Html.DisplayFor(modelItem => item.GradeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Grade\GradeList.cshtml"
               Write(Html.DisplayFor(modelItem => item.GradeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Grade\GradeList.cshtml"
               Write(Html.ActionLink("Edit", "EditGrade", new { id = item.GradeID }, htmlAttributes: new { @class = "btn btn-primary", @role = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 38 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Grade\GradeList.cshtml"
               Write(Html.ActionLink("Delete", "DeleteGrate", new { id = item.GradeID }, htmlAttributes: new { @class = "btn btn-danger", @role = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "F:\Projects_Of_IsDB\TestProjectIsDB\TestProjectIsDB\Views\Grade\GradeList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestProjectIsDB.Models.Classes.Grade>> Html { get; private set; }
    }
}
#pragma warning restore 1591
