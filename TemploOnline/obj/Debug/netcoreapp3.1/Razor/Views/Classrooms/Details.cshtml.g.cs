#pragma checksum "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc51785d11778d79d21a66ce18e9157d6fba8d5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classrooms_Details), @"mvc.1.0.view", @"/Views/Classrooms/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc51785d11778d79d21a66ce18e9157d6fba8d5a", @"/Views/Classrooms/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b98cee3b395a04b063eb7746b3f78c9cfd50bfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Classrooms_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TemploOnline.Models.ViewModels.ClassroomViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PeopleClassrooms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/classrooms/details.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
  
  var title = "Detalhes da revista";
  ViewData["Title"] = title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc51785d11778d79d21a66ce18e9157d6fba8d5a6125", async() => {
                WriteLiteral("\r\n  <i class=\"fas fa-angle-double-left\"></i> Voltar\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc51785d11778d79d21a66ce18e9157d6fba8d5a7420", async() => {
                WriteLiteral("\r\n  <i class=\"far fa-edit\"></i> Editar\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<button class=\"btn btn-danger\" id=\"btn-delete\" data-classroom-id=\"");
#nullable restore
#line 16 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
                                                             Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n  <i class=\"fas fa-times\"></i> Remover\r\n</button>\r\n<hr>\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 21 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
                            Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </span>\r\n  <span>");
#nullable restore
#line 22 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 26 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
                            Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </span>\r\n  <span>");
#nullable restore
#line 27 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
 if (Model.Teachers.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>\r\n    <span class=\"font-weight-bold\">\r\n      Lições: \r\n    </span>\r\n  </p>\r\n  <ul>\r\n");
#nullable restore
#line 38 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
     foreach (var teacher in Model.Teachers.OrderBy(t => t.Name))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc51785d11778d79d21a66ce18e9157d6fba8d5a11991", async() => {
                WriteLiteral("\r\n        <span>");
#nullable restore
#line 45 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
         Write(teacher.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
            WriteLiteral(teacher.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </li>\r\n");
#nullable restore
#line 49 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n");
#nullable restore
#line 51 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<button data-classroom-id=\"");
#nullable restore
#line 52 "C:\Users\Pedro Henrique\Documents\github\Templo-Online\TemploOnline\Views\Classrooms\Details.cshtml"
                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btn btn-primary"" id=""btn-add-teacher"">
  <i class=""far fa-file""></i> Adicionar Professor
</button>

<div id=""modal-new-teacher"" class=""modal"">
  <div class=""modal-dialog"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <div class=""modal-title"">Escolha um professor</div>
      </div>
      <div class=""modal-body"">
        <select class=""form-control"" id=""select-teachers"">

        </select>
      </div>
      <div class=""modal-footer"">
        <button class=""btn bg-light"">Cancelar</button>
        <button class=""btn btn-primary"" id=""btn-save-person-classroom"">Salvar</button>
      </div>
    </div>
  </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n  <script src=\"https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/5.4.0/bootbox.min.js\"></script>\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc51785d11778d79d21a66ce18e9157d6fba8d5a16277", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TemploOnline.Models.ViewModels.ClassroomViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
