#pragma checksum "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Semester\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a43332f466134436fa7a6bc438b82205e45b8b2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Semester_Delete), @"mvc.1.0.view", @"/Views/Semester/Delete.cshtml")]
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
#line 1 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\_ViewImports.cshtml"
using TimetableApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\_ViewImports.cshtml"
using TimetableApp.DataAccess.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a43332f466134436fa7a6bc438b82205e45b8b2a", @"/Views/Semester/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e43ef5369640eb16f14a6e7b8016ce0c6fcdaf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Semester_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimetableApp.Web.Models.SemesterViewModel>
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
#line 2 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Semester\Delete.cshtml"
   ViewBag.Title = ""; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Are you sure you want to <strong>delete this activity type</strong>?</h3>\n\n<div class=\"alert alert-secondary\" role=\"alert\">\n    <p><strong>");
#nullable restore
#line 7 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Semester\Delete.cshtml"
          Write(Html.LabelFor(e => e.SemesterNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 7 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Semester\Delete.cshtml"
                                                          Write(Model.SemesterNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p><strong>");
#nullable restore
#line 8 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Semester\Delete.cshtml"
          Write(Html.LabelFor(e => e.SemesterTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 8 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Semester\Delete.cshtml"
                                                         Write(Model.SemesterTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n</div>\n<div>\n    ");
#nullable restore
#line 12 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Semester\Delete.cshtml"
Write(Html.ActionLink("Delete", "ConfirmDelete", "Semester", new { id = Model.SemesterID, }, new { @class = "btn btn-outline-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<br />\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43332f466134436fa7a6bc438b82205e45b8b2a5285", async() => {
                WriteLiteral("??????????");
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
            WriteLiteral("\n</div>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 19 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Semester\Delete.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimetableApp.Web.Models.SemesterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
