#pragma checksum "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b714f84f19f72a4795f3f6ea2e7818aedd34d653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NavHomePages), @"mvc.1.0.view", @"/Views/Shared/_NavHomePages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_NavHomePages.cshtml", typeof(AspNetCore.Views_Shared__NavHomePages))]
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
#line 1 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b714f84f19f72a4795f3f6ea2e7818aedd34d653", @"/Views/Shared/_NavHomePages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NavHomePages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sob"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logoff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 421, true);
            WriteLiteral(@"        <nav>
            <div class=""section-container"">

                <ul>
                    <li id=""bt-mobile-menu"">
                        <a href=""javascript:void(0);"" class=""icon"" onclick=""toggleMobileMenu()"">
                            <i class=""fa fa-bars fa-2x ""></i>
                        </a>
                    </li>
                    <li class=""bt-common-menu"">
                        ");
            EndContext();
            BeginContext(421, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b714f84f19f72a4795f3f6ea2e7818aedd34d6536199", async() => {
                BeginContext(465, 88, true);
                WriteLiteral("<img class=\"logo\" src=\"../img/logo_roletop.png\" alt=\"logo Rolêtop\" title=\"Logo RolêTop\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(557, 119, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\" class=\"sob\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 676, "\'", 719, 2);
#line 13 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml"
WriteAttributeValue("", 683, Url.Action("index", "Home"), 683, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 711, "#Eventos", 711, 8, true);
            EndWriteAttribute();
            BeginContext(720, 109, true);
            WriteLiteral(">Eventos</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\" class=\"sob\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 829, "\'", 873, 2);
#line 14 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml"
WriteAttributeValue("", 836, Url.Action("index", "Home"), 836, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 864, "#servicos", 864, 9, true);
            EndWriteAttribute();
            BeginContext(874, 110, true);
            WriteLiteral(">Serviços</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\" class=\"sob\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 984, "\'", 1042, 2);
#line 15 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml"
WriteAttributeValue("", 991, Url.Action("index", "Home"), 991, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1019, "#Infraestrutura-Galeria", 1019, 23, true);
            EndWriteAttribute();
            BeginContext(1043, 124, true);
            WriteLiteral(">Infraestrutura/Galeria</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\" class=\"sob\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1167, "\'", 1212, 2);
#line 16 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml"
WriteAttributeValue("", 1174, Url.Action("index", "Home"), 1174, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1202, "#orçamento", 1202, 10, true);
            EndWriteAttribute();
            BeginContext(1213, 111, true);
            WriteLiteral(">Orçamento</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\" class=\"sob\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1324, "\'", 1370, 2);
#line 17 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml"
WriteAttributeValue("", 1331, Url.Action("index", "Home"), 1331, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1359, "#calendario", 1359, 11, true);
            EndWriteAttribute();
            BeginContext(1371, 112, true);
            WriteLiteral(">Caléndario</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\" class=\"sob\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1483, "\'", 1522, 2);
#line 18 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml"
WriteAttributeValue("", 1490, Url.Action("index", "Home"), 1490, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1518, "#FAQ", 1518, 4, true);
            EndWriteAttribute();
            BeginContext(1523, 105, true);
            WriteLiteral(">FAQ</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\" class=\"sob\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1628, "\'", 1672, 2);
#line 19 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml"
WriteAttributeValue("", 1635, Url.Action("index", "Home"), 1635, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1663, "#Contatos", 1663, 9, true);
            EndWriteAttribute();
            BeginContext(1673, 110, true);
            WriteLiteral(">Contatos</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\" class=\"sob\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1783, "\'", 1830, 2);
#line 20 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml"
WriteAttributeValue("", 1790, Url.Action("index", "Home"), 1790, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1818, "#Localizacao", 1818, 12, true);
            EndWriteAttribute();
            BeginContext(1831, 23, true);
            WriteLiteral(">Localização</a></li>\r\n");
            EndContext();
#line 21 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml"
                     if(string.IsNullOrEmpty(Model.UsuarioEmail)){

#line default
#line hidden
            BeginContext(1922, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1946, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b714f84f19f72a4795f3f6ea2e7818aedd34d65313188", async() => {
                BeginContext(2019, 53, true);
                WriteLiteral("<i class=\"fas fa-user fa-5x\"></i><br> Login/Cadastro ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2076, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 23 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2155, 51, true);
            WriteLiteral("                        <li class=\"bt-common-menu\">");
            EndContext();
            BeginContext(2206, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b714f84f19f72a4795f3f6ea2e7818aedd34d65315354", async() => {
                BeginContext(2280, 49, true);
                WriteLiteral("<i class=\"fas fa-sign-out-alt fa-2x\"></i> Logoff ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2333, 58, true);
            WriteLiteral("</li>\r\n                        <li class=\"bt-common-menu\">");
            EndContext();
            BeginContext(2391, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b714f84f19f72a4795f3f6ea2e7818aedd34d65317205", async() => {
                BeginContext(2464, 47, true);
                WriteLiteral("<i class=\"fas fa-address-book fa-2x\"></i>Perfil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2515, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 28 "C:\Users\Junior\Documents\Docs\2s---2019---Sprint4\RoleTopMVC\Views\Shared\_NavHomePages.cshtml"
                    }

#line default
#line hidden
            BeginContext(2545, 59, true);
            WriteLiteral("                </ul>\r\n\r\n            </div>\r\n        </nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591