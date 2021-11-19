#pragma checksum "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd16ba36f80f1022e728cd8e0b1e482d4221e596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Delete), @"mvc.1.0.view", @"/Views/Group/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd16ba36f80f1022e728cd8e0b1e482d4221e596", @"/Views/Group/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e43ef5369640eb16f14a6e7b8016ce0c6fcdaf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimetableApp.Web.Models.GroupViewModel>
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
#line 2 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml"
   ViewBag.Title = ""; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Are you sure you want to <strong>delete this group</strong>?</h3>\n\n<div class=\"alert alert-secondary\" role=\"alert\">\n    <p><strong>");
#nullable restore
#line 7 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml"
          Write(Html.LabelFor(e => e.GroupName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 7 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml"
                                                     Write(Model.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p><strong>");
#nullable restore
#line 8 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml"
          Write(Html.LabelFor(e => e.GroupNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 8 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml"
                                                       Write(Model.GroupNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p><strong>");
#nullable restore
#line 9 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml"
          Write(Html.LabelFor(e => e.FacultyID));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 9 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml"
                                                     Write(Model.FacultyID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p><strong>");
#nullable restore
#line 10 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml"
          Write(Html.LabelFor(e => e.NumberOfStudents));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 10 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml"
                                                            Write(Model.NumberOfStudents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n<div>\n    ");
#nullable restore
#line 13 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml"
Write(Html.ActionLink("Delete", "ConfirmDelete", "Group", new { id = Model.GroupID, }, new { @class = "btn btn-outline-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<br />\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd16ba36f80f1022e728cd8e0b1e482d4221e5966329", async() => {
                WriteLiteral("Назад");
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
#line 20 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Group\Delete.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimetableApp.Web.Models.GroupViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
