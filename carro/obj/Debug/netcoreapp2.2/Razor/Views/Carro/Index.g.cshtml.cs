#pragma checksum "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ac8a003632a65e1173223d245c97387190a7784"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carro_Index), @"mvc.1.0.view", @"/Views/Carro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carro/Index.cshtml", typeof(AspNetCore.Views_Carro_Index))]
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
#line 1 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/_ViewImports.cshtml"
using carro;

#line default
#line hidden
#line 2 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/_ViewImports.cshtml"
using carro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac8a003632a65e1173223d245c97387190a7784", @"/Views/Carro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e088bc52c2b2e0f5f92214ff27fc518891f57153", @"/Views/_ViewImports.cshtml")]
    public class Views_Carro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<carro.Models.Carro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 485, true);
            WriteLiteral(@"
</br></br>
<a href=""Create"" class=""btn btn-primary"">Novo Carro</a>
</br></br>

<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Ano de Fabricação</th>
                <th>Quantidade de Portas</th>
                <th>Cor</th>
                <th>Tipo de Banco</th>
                <th>Marca</th>
                <th></th>
                <th></th>
            </tr>
            </tr>
        </thead>

");
            EndContext();
#line 23 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(570, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(608, 7, false);
#line 26 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Index.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(615, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(642, 19, false);
#line 27 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Index.cshtml"
               Write(item.ano_fabricacao);

#line default
#line hidden
            EndContext();
            BeginContext(661, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(688, 11, false);
#line 28 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Index.cshtml"
               Write(item.portas);

#line default
#line hidden
            EndContext();
            BeginContext(699, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(726, 8, false);
#line 29 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Index.cshtml"
               Write(item.cor);

#line default
#line hidden
            EndContext();
            BeginContext(734, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(761, 15, false);
#line 30 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Index.cshtml"
               Write(item.tipo_banco);

#line default
#line hidden
            EndContext();
            BeginContext(776, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(803, 10, false);
#line 31 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Index.cshtml"
               Write(item.marca);

#line default
#line hidden
            EndContext();
            BeginContext(813, 51, true);
            WriteLiteral("</td>\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", "\n                    href=\"", 864, "\"", 912, 2);
            WriteAttributeValue("", 891, "Carro/Delete/", 891, 13, true);
#line 33 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Index.cshtml"
WriteAttributeValue("", 904, item.id, 904, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(913, 64, true);
            WriteLiteral(">Delete</a> </td>\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " \n                    href=\"", 977, "\"", 1024, 2);
            WriteAttributeValue("", 1005, "Carro/Edit/", 1005, 11, true);
#line 35 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Index.cshtml"
WriteAttributeValue("", 1016, item.id, 1016, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1025, 36, true);
            WriteLiteral(">Editar</a> </td>\n            </tr>\n");
            EndContext();
#line 37 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1071, 19, true);
            WriteLiteral("    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<carro.Models.Carro>> Html { get; private set; }
    }
}
#pragma warning restore 1591