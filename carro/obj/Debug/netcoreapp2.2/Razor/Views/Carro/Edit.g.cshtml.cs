#pragma checksum "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9a522040b1ef4a6074edb0293f5a3856c36d078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carro_Edit), @"mvc.1.0.view", @"/Views/Carro/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carro/Edit.cshtml", typeof(AspNetCore.Views_Carro_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9a522040b1ef4a6074edb0293f5a3856c36d078", @"/Views/Carro/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e088bc52c2b2e0f5f92214ff27fc518891f57153", @"/Views/_ViewImports.cshtml")]
    public class Views_Carro_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<carro.Models.Carro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 35, true);
            WriteLiteral("\n<div class=\"form-horizontal\">\n    ");
            EndContext();
            BeginContext(61, 1320, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9a522040b1ef4a6074edb0293f5a3856c36d0783922", async() => {
                BeginContext(95, 147, true);
                WriteLiteral("\n\n        <div class=\"form-group\">\n            <label>Id</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 242, "\"", 257, 2);
#line 9 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Edit.cshtml"
WriteAttributeValue("", 250, Model, 250, 6, false);

#line default
#line hidden
                WriteAttributeValue("", 256, ".", 256, 1, true);
                EndWriteAttribute();
                BeginContext(258, 191, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Ano de Fabricação</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"ano_fabricacao\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 449, "\"", 478, 1);
#line 15 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Edit.cshtml"
WriteAttributeValue("", 457, Model.ano_fabricacao, 457, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(479, 172, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Portas</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"portas\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 651, "\"", 672, 1);
#line 21 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Edit.cshtml"
WriteAttributeValue("", 659, Model.portas, 659, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(673, 167, true);
                WriteLiteral("/>\n        </div>\n\n\n        <div class=\"form-group\">\n            <label>cor</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"cor\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 840, "\"", 858, 1);
#line 28 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Edit.cshtml"
WriteAttributeValue("", 848, Model.cor, 848, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(859, 184, true);
                WriteLiteral("/>\n        </div>\n\n\n        <div class=\"form-group\">\n            <label>Tipo de Banco</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"tipo_banco\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1043, "\"", 1068, 1);
#line 35 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Edit.cshtml"
WriteAttributeValue("", 1051, Model.tipo_banco, 1051, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1069, 170, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Marca</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"marca\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1239, "\"", 1259, 1);
#line 41 "/home/gustavo/Área de Trabalho/tarefa-crud/carro/Views/Carro/Edit.cshtml"
WriteAttributeValue("", 1247, Model.marca, 1247, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1260, 114, true);
                WriteLiteral("/>\n        </div>\n\n\n\n        <input  class=\"btn btn-primary\" \n                type=\"submit\" value=\"Salvar\"/>\n\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1381, 9, true);
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<carro.Models.Carro> Html { get; private set; }
    }
}
#pragma warning restore 1591
