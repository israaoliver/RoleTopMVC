#pragma checksum "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "170e7e102059154a60163b5506978a56bcbec7a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Eventos), @"mvc.1.0.view", @"/Views/Usuario/Eventos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Eventos.cshtml", typeof(AspNetCore.Views_Usuario_Eventos))]
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
#line 1 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"170e7e102059154a60163b5506978a56bcbec7a1", @"/Views/Usuario/Eventos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Eventos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.EventoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 208, true);
            WriteLiteral("<main class=\"flex\">\r\n    <div class=\"flex user-container\">\r\n            <i class=\"icon far fa-folder-open fa-3x\"></i>\r\n        <h1>Meus Eventos</h1>\r\n    </div>\r\n    <section class=\"event \" >\r\n        <div>\r\n");
            EndContext();
#line 9 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
             if(!string.IsNullOrEmpty(Model.Vazio))
            {
                foreach (var e in Model.Eventos)
                {
                    if (!(e.Status == 3))
                    {

#line default
#line hidden
            BeginContext(457, 714, true);
            WriteLiteral(@"                        <table>

                        <thead>
                            <tr>
                                <th>Nome</th>
                                <th>Data</th>
                                <th>Serviços</th>
                                <th>Tipo</th>
                                <th>Quantidade de Pessoas</th>
                                <th>Pagamento</th>
                                <th>Status</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <td colspan=""7"">
                                    <p>Esse evento foi atualizado em ");
            EndContext();
            BeginContext(1172, 14, false);
#line 31 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                                                Write(e.DataRegistro);

#line default
#line hidden
            EndContext();
            BeginContext(1186, 217, true);
            WriteLiteral("</p>\r\n                                </td>\r\n                            </tr>\r\n                        </tfoot>\r\n                        <tbody>\r\n                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1404, 12, false);
#line 37 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                               Write(e.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1416, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1460, 13, false);
#line 38 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                               Write(e.DiaDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1473, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1517, 15, false);
#line 39 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                               Write(e.Servicos.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1532, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1576, 12, false);
#line 40 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                               Write(e.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1632, 12, false);
#line 41 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                               Write(e.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(1644, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 42 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                 if (e.Pago)
                                {

#line default
#line hidden
            BeginContext(1730, 47, true);
            WriteLiteral("<td class=\"flex pagado\"><span >Pago</span></td>");
            EndContext();
#line 43 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                                                                }

#line default
#line hidden
            BeginContext(1780, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 44 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                 if(!e.Pago)
                                {

#line default
#line hidden
            BeginContext(1859, 39, true);
            WriteLiteral("<td class=\"flex pendente\">Pendente</td>");
            EndContext();
#line 45 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                                                        }                                 

#line default
#line hidden
            BeginContext(1934, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 46 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                 if (e.Status == 0)
                                {

#line default
#line hidden
            BeginContext(2020, 34, true);
            WriteLiteral("<td class=\"pendente\">Pendente</td>");
            EndContext();
#line 47 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                                                   }

#line default
#line hidden
            BeginContext(2057, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 48 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                 if (e.Status == 1)
                                {

#line default
#line hidden
            BeginContext(2143, 32, true);
            WriteLiteral("<td class=\"pagado\">Aprovado</td>");
            EndContext();
#line 49 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                                                 }

#line default
#line hidden
            BeginContext(2178, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 50 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                 if (e.Status == 2)
                                {

#line default
#line hidden
            BeginContext(2264, 36, true);
            WriteLiteral("<td class=\"reprovado\">Reprovado</td>");
            EndContext();
#line 51 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                                                     }

#line default
#line hidden
            BeginContext(2303, 408, true);
            WriteLiteral(@"                            </tr>
                        </tbody>
                    </table>
                    <br>
                    <br>
                    <div class=""flex last"">

                        <div>

                            <div class=""flex descricao"">
                                <p> Descrição</p>

                                <textarea id=""descricao"" disabled>");
            EndContext();
            BeginContext(2712, 11, false);
#line 64 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                                                             Write(e.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2723, 488, true);
            WriteLiteral(@"</textarea> 
                            </div>
                        </div>
                        <div class=""flex edit-container"">
                            <a class=""link"">
                            <div class=""flex"">
                                    <i class=""icon fas fa-edit fa-2x""></i>
                                    <p>Editar Informações.</p>
                            </div>
                            </a>
                            <a class=""link""");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3211, "\'", 3269, 1);
#line 74 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
WriteAttributeValue("", 3218, Url.Action("Remover", "Cliente", new {id = @e.Id}), 3218, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3270, 300, true);
            WriteLiteral(@" onclick=""return confirmacao()"">
                                <div class=""flex"">
                                    <i class=""icon fas fa-trash-alt fa-2x""></i>
                                    <p>Remover Evento</p>
                                </div>
                            </a>
");
            EndContext();
#line 80 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                             if (!e.Pago)
                            {

#line default
#line hidden
            BeginContext(3644, 47, true);
            WriteLiteral("                                <a class=\"link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3691, "\'", 3751, 1);
#line 82 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
WriteAttributeValue("", 3698, Url.Action("Pagamento", "Usuario", new {id = @e.Id}), 3698, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3752, 293, true);
            WriteLiteral(@">
                                    <div class=""flex"">
                                        <i class=""icon far fa-credit-card fa-2x""></i>
                                        <p>Pagar Evento</p>
                                    </div>
                                </a>    
");
            EndContext();
#line 88 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                            }

#line default
#line hidden
            BeginContext(4076, 200, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <br />\r\n                    <br />\r\n                    <br />\r\n                    <br />\r\n                    <hr />\r\n");
            EndContext();
#line 96 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                }
            }
            
                    
            }

#line default
#line hidden
            BeginContext(4361, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 101 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
             if(Model.NumeroDeApagados == Model.NumeroDeEventos )
            {
                

#line default
#line hidden
            BeginContext(4461, 60, true);
            WriteLiteral("                <div class=\"local\">\r\n                    <p>");
            EndContext();
            BeginContext(4522, 17, false);
#line 105 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
                  Write(Model.UsuarioNome);

#line default
#line hidden
            EndContext();
            BeginContext(4539, 258, true);
            WriteLiteral(@" você não possui nenhum evento cadastrado</p>
                    <br />
                    <i class=""icon far fa-grin-beam-sweat fa-8x""></i>
                    <p>Clique abaixo e cadastre um novo!</p>
                    <br />
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 4797, "\'", 4844, 1);
#line 110 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
WriteAttributeValue("", 4804, Url.Action("EventoCadastro", "Usuario"), 4804, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4845, 72, true);
            WriteLiteral("><button class=\"margin\">Cadastrar</button></a>\r\n                </div>\r\n");
            EndContext();
#line 112 "C:\Users\44346823858\Documents\2s---2019---Sprint4\RoleTopMVC\Views\Usuario\Eventos.cshtml"
            
            }

#line default
#line hidden
            BeginContext(4946, 187, true);
            WriteLiteral("\r\n    </section>\r\n\r\n</main>\r\n\r\n<script>\r\nfunction confirmacao()\r\n{   \r\nif (confirm(\"Tem Certeza?\")){\r\n\r\n    alert(\"Removido\")\r\n    return true;\r\n}else{\r\n\r\n    return false;}\r\n}\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591