#pragma checksum "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13e2c96ab074277f3359c63e8743d33f9ef287b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profiles_Index), @"mvc.1.0.view", @"/Views/Profiles/Index.cshtml")]
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
#line 1 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\_ViewImports.cshtml"
using TemploOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\_ViewImports.cshtml"
using TemploOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13e2c96ab074277f3359c63e8743d33f9ef287b3", @"/Views/Profiles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b98cee3b395a04b063eb7746b3f78c9cfd50bfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TemploOnline.Models.ViewModels.ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
  
  var title = "Detalhes de usuário";
  ViewData["Title"] = title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e2c96ab074277f3359c63e8743d33f9ef287b35698", async() => {
                WriteLiteral("\r\n  <i class=\"fas fa-angle-double-left\"></i> Voltar\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e2c96ab074277f3359c63e8743d33f9ef287b36993", async() => {
                WriteLiteral("\r\n  <i class=\"far fa-edit\"></i> Editar\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e2c96ab074277f3359c63e8743d33f9ef287b38271", async() => {
                WriteLiteral("\r\n  <i class=\"fas fa-lock\"></i> Mudar senha\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<hr>\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 19 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
                            Write(Html.DisplayNameFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </span>\r\n  <span>");
#nullable restore
#line 20 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
   Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 23 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
                            Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </span>\r\n  <span>");
#nullable restore
#line 24 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 27 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
                            Write(Html.DisplayNameFor(m => m.Nickname));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </span>\r\n  <span>");
#nullable restore
#line 28 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
   Write(Model.Nickname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 31 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
                            Write(Html.DisplayNameFor(m => m.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </span>\r\n  <span>");
#nullable restore
#line 32 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
   Write(Model.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 36 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
                            Write(Html.DisplayNameFor(m => m.IsTeacher));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n  <span>");
#nullable restore
#line 37 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
   Write(Model.IsTeacher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n\r\n<p>\r\n  <span class=\"font-weight-bold\">");
#nullable restore
#line 41 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
                            Write(Html.DisplayNameFor(m => m.IsStudent));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n  <span>");
#nullable restore
#line 42 "C:\Users\Pedro Henrique\Documents\github\Templo-Online2\Templo-Online\TemploOnline\Views\Profiles\Index.cshtml"
   Write(Model.IsStudent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TemploOnline.Models.ViewModels.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591