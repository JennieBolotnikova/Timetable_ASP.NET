#pragma checksum "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bb2d89a89ba349493a11984830e73f960ba7727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Timetable_Index), @"mvc.1.0.view", @"/Views/Timetable/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bb2d89a89ba349493a11984830e73f960ba7727", @"/Views/Timetable/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e43ef5369640eb16f14a6e7b8016ce0c6fcdaf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Timetable_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimetableApp.Web.Models.PaginatedList<TimetableApp.Web.Models.TimetableViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Timetable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn createButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("editLabel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("deleteLabel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"table-wrapper\">\r\n        <div class=\"table-title\">\r\n            <div>\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bb2d89a89ba349493a11984830e73f960ba77276124", async() => {
                WriteLiteral("\r\n                        <span>Добавить запись</span>\r\n                    ");
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <table class=\"table table-hover\">\r\n            <thead>\r\n                <tr>\r\n");
#nullable restore
#line 20 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                     foreach (var item in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                         if (item == Model.First())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 25 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                           Write(Html.DisplayNameFor(model => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                               \r\n                                ");
#nullable restore
#line 29 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                           Write(Html.DisplayNameFor(model => item.Day));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                \r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 33 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                           Write(Html.DisplayNameFor(model => item.BellID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 36 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                           Write(Html.DisplayNameFor(model => item.Discipline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 39 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                           Write(Html.DisplayNameFor(model => item.ActivityType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 42 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                           Write(Html.DisplayNameFor(model => item.Group));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 45 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                           Write(Html.DisplayNameFor(model => item.Teacher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 48 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                           Write(Html.DisplayNameFor(model => item.Classroom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 51 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                           Write(Html.DisplayNameFor(model => item.Semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>Действия</th>\r\n");
#nullable restore
#line 54 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 62 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                    \r\n                        <th>\r\n\r\n                            ");
#nullable restore
#line 68 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.DisplayFor(model => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      \r\n                            ");
#nullable restore
#line 70 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.ActionLink("-", "Index", new { sortOrder = ViewBag.DaySortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n\r\n                            ");
#nullable restore
#line 74 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.DisplayFor(model => item.Day));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 75 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.ActionLink("-", "Index", new { sortOrder = ViewBag.DateSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 78 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.DisplayFor(model => item.BellID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 81 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.DisplayFor(model => item.Discipline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 82 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.ActionLink("-", "Index", new { sortOrder = ViewBag.DisciplineSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 85 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.DisplayFor(model => item.ActivityType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 86 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.ActionLink("-", "Index", new { sortOrder = ViewBag.ActivityTypeSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 89 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.DisplayFor(model => item.Group));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 90 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.ActionLink("-", "Index", new { sortOrder = ViewBag.GrouportParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 93 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.DisplayFor(model => item.Teacher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 94 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.ActionLink("-", "Index", new { sortOrder = ViewBag.TeacherSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 97 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.DisplayFor(model => item.Classroom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 98 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.ActionLink("-", "Index", new { sortOrder = ViewBag.ClassroomSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 101 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.DisplayFor(model => item.Semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 102 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                       Write(Html.ActionLink("-", "Index", new { sortOrder = ViewBag.SemesterSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bb2d89a89ba349493a11984830e73f960ba772718837", async() => {
                WriteLiteral("Редактирование");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                                                                                WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bb2d89a89ba349493a11984830e73f960ba772721359", async() => {
                WriteLiteral("Удаление");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                                                                                WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n");
#nullable restore
#line 109 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 113 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
          
            var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
            var nextDisabled = !Model.HasNextPage ? "disabled" : "";
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bb2d89a89ba349493a11984830e73f960ba772724544", async() => {
                WriteLiteral("\r\n            Previous\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                      WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5165, "btn", 5165, 3, true);
            AddHtmlAttributeValue(" ", 5168, "btn-default", 5169, 12, true);
#nullable restore
#line 121 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
AddHtmlAttributeValue(" ", 5180, prevDisabled, 5181, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bb2d89a89ba349493a11984830e73f960ba772727380", async() => {
                WriteLiteral("\r\n            Next\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
                      WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5353, "btn", 5353, 3, true);
            AddHtmlAttributeValue(" ", 5356, "btn-default", 5357, 12, true);
#nullable restore
#line 128 "E:\Git\Repository\Timetable_ASP.NET\Timetable\Timetable\Views\Timetable\Index.cshtml"
AddHtmlAttributeValue(" ", 5368, nextDisabled, 5369, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimetableApp.Web.Models.PaginatedList<TimetableApp.Web.Models.TimetableViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
