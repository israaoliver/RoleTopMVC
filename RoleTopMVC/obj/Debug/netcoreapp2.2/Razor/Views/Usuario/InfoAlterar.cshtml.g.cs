#pragma checksum "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Usuario\InfoAlterar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33f6ae4b8135c017434229075bdf268f58a23f7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_InfoAlterar), @"mvc.1.0.view", @"/Views/Usuario/InfoAlterar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/InfoAlterar.cshtml", typeof(AspNetCore.Views_Usuario_InfoAlterar))]
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
#line 1 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33f6ae4b8135c017434229075bdf268f58a23f7b", @"/Views/Usuario/InfoAlterar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_InfoAlterar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.BaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 216, true);
            WriteLiteral("<main class=\"informa flex\" >\r\n<div class=\"flex user-container\">\r\n    <i class=\"icon fas fa-address-card fa-3x\"></i>\r\n<h1>   Minhas Informações</h1>\r\n</div>\r\n<section id=\"informacao\">\r\n<div class=\"flex form-info\">\r\n\r\n");
            EndContext();
            BeginContext(260, 932, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33f6ae4b8135c017434229075bdf268f58a23f7b3941", async() => {
                BeginContext(340, 165, true);
                WriteLiteral("\r\n    <div>\r\n        <label for=\"nome\">Nome Completo</label>\r\n        <br>\r\n        <input class=\"lab\" id=\"nome\" type=\"text\" maxlength=\"30\" minlength=\"5\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 505, "\"", 532, 1);
#line 14 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Usuario\InfoAlterar.cshtml"
WriteAttributeValue("", 513, Model.Cliente.Nome, 513, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(533, 146, true);
                WriteLiteral(">\r\n    </div>\r\n    <div>\r\n        <label for=\"email\">E-mail</label>\r\n        <br>\r\n        <input class=\"lab\" id=\"email\" type=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 679, "\"", 707, 1);
#line 19 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Usuario\InfoAlterar.cshtml"
WriteAttributeValue("", 687, Model.Cliente.Email, 687, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(708, 156, true);
                WriteLiteral(">\r\n    </div>\r\n    <div>\r\n        <label for=\"telefone\">Telefone</label>\r\n        <br>\r\n        <input class=\"lab\" id=\"telefone\" type=\"text\" name=\"telefone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 864, "\"", 895, 1);
#line 24 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Usuario\InfoAlterar.cshtml"
WriteAttributeValue("", 872, Model.Cliente.Telefone, 872, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(896, 204, true);
                WriteLiteral(" minlength=\"10\" maxlength=\"11\" >\r\n\r\n    </div>\r\n    <div>\r\n        <label for=\"cpf\">CPF/CNPJ</label>\r\n        <br>\r\n        <input class=\"lab\" id=\"cpf\" name=\"cpf\" type=\"text\" maxlength=\"11\" minlength=\"11\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1100, "\"", 1126, 1);
#line 30 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Usuario\InfoAlterar.cshtml"
WriteAttributeValue("", 1108, Model.Cliente.CPF, 1108, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1127, 58, true);
                WriteLiteral(">\r\n    </div>\r\n    <input type=\"submit\" value=\"Mudar\">\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 10 "C:\Users\44346823858\Documents\RoleTopMVC\RoleTopMVC\Views\Usuario\InfoAlterar.cshtml"
AddHtmlAttributeValue("", 288, Url.Action("AlterarInformacaoUsuario", "Usuario"), 288, 50, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1192, 33, true);
            WriteLiteral("\r\n</div>\r\n\r\n</section>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.BaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
