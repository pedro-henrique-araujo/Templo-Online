#pragma checksum "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce3366e28f899adac76320fd6776a91d1922ee02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AttendancesLists_Details), @"mvc.1.0.view", @"/Views/AttendancesLists/Details.cshtml")]
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
#line 1 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\_ViewImports.cshtml"
using TemploOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\_ViewImports.cshtml"
using TemploOnline.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
using TemploOnline.Controllers.IdentityHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3366e28f899adac76320fd6776a91d1922ee02", @"/Views/AttendancesLists/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b98cee3b395a04b063eb7746b3f78c9cfd50bfe", @"/Views/_ViewImports.cshtml")]
    public class Views_AttendancesLists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TemploOnline.Models.ViewModels.AttendanceListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AttendancesLists", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/attendancesLists/details.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
  
  var title = "Detalhes da chamada";
  ViewData["Title"] = title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce3366e28f899adac76320fd6776a91d1922ee026109", async() => {
                WriteLiteral("\r\n  <i class=\"fas fa-angle-double-left\"></i> Voltar\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
                                                            WriteLiteral(Model.ClassroomId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
 if (User.IsInRole(Roles.Professor) || User.IsInRole(Roles.Admin) || User.IsInRole(Roles.Dev))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce3366e28f899adac76320fd6776a91d1922ee028975", async() => {
                WriteLiteral("\r\n    <i class=\"far fa-edit\"></i> Editar\r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
                         WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n");
            WriteLiteral("  <button class=\"btn btn-danger\" id=\"btn-delete\" data-attendanceList-id=\"");
#nullable restore
#line 17 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
                                                                    Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <i class=\"fas fa-times\"></i> Remover\r\n  </button>\r\n");
#nullable restore
#line 20 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 23 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
                            Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </span>\r\n  <span>");
#nullable restore
#line 24 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 27 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
                            Write(Html.DisplayNameFor(m => m.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </span>\r\n  <span>");
#nullable restore
#line 28 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
   Write(Model.Created.ToString("dd/MM/yyyy - HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 31 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
                            Write(Html.DisplayNameFor(m => m.Classroom));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </span>\r\n  <span>");
#nullable restore
#line 32 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
   Write(Model.Classroom.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 36 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
                            Write(Html.DisplayNameFor(m => m.Lesson));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </span>\r\n  <span>");
#nullable restore
#line 37 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
   Write(Model.Lesson.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n<div>\r\n  <span class=\"text-weight-bold\">Legenda: </span>\r\n  <ul>\r\n    <li class=\"text-success\">Presente</li>\r\n    <li class=\"text-danger\">Faltou</li>\r\n  </ul>\r\n</div>\r\n\r\n");
#nullable restore
#line 47 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
 if (Model.TeachersAttendances.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>Professores</h3>\r\n  <ul>\r\n");
#nullable restore
#line 51 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
     foreach (var attendance in Model.TeachersAttendances)
    {
      if (attendance.Attended)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-success\">\r\n          ");
#nullable restore
#line 56 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
     Write(attendance.Person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 58 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-danger\">\r\n          ");
#nullable restore
#line 62 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
     Write(attendance.Person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 64 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
      }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n");
#nullable restore
#line 67 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
 if (Model.StudentsAttendances.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>Alunos</h3>\r\n  <ul>   \r\n");
#nullable restore
#line 73 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
     foreach (var attendance in Model.StudentsAttendances)
    {
      if (attendance.Attended)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-success\">\r\n          ");
#nullable restore
#line 78 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
     Write(attendance.Person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 80 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"text-danger\">\r\n          ");
#nullable restore
#line 84 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
     Write(attendance.Person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 86 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
      }
     
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n");
#nullable restore
#line 90 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\AttendancesLists\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n  <script src=\"https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/5.4.0/bootbox.min.js\"></script>\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce3366e28f899adac76320fd6776a91d1922ee0218848", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TemploOnline.Models.ViewModels.AttendanceListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
