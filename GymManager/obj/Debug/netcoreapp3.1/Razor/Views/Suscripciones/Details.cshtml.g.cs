#pragma checksum "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fe3b1685100eb1f9a36cda10186002937b86a31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Suscripciones_Details), @"mvc.1.0.view", @"/Views/Suscripciones/Details.cshtml")]
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
#line 1 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\_ViewImports.cshtml"
using GymManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\_ViewImports.cshtml"
using GymManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fe3b1685100eb1f9a36cda10186002937b86a31", @"/Views/Suscripciones/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b1fa041cae22c10aa7f061ce18da8f8455ea16", @"/Views/_ViewImports.cshtml")]
    public class Views_Suscripciones_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManager.Models.Suscripciones>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""d-flex"">
                    <h4>Detalles de Suscripcion</h4>
                    <div class=""ml-auto"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fe3b1685100eb1f9a36cda10186002937b86a314646", async() => {
                WriteLiteral("<i class=\"fas fa-arrow-left\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <ul class=\"list-group\">\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 21 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong> ");
#nullable restore
#line 21 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
                                                                                 Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 24 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Clientes));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 24 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.Clientes.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 24 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
                                                                                                                                     Write(Html.DisplayFor(model => model.Clientes.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </li>
                    <li>
                        <strong></strong>
                    </li>
                </ul>
            </div>
            <div class=""card-footer"">
                
            </div>
        </div>
    </div>
</div>
<h1>Details</h1>

<div>
    <h4>Suscripciones</h4>
    <hr />
    <dl class=""row"">
        <dt class = ""col-sm-2"">
            ");
#nullable restore
#line 44 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecioUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrecioUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            \r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            \r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MetodosPagos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.MetodosPagos.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Planes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Planes.Descripcion1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fe3b1685100eb1f9a36cda10186002937b86a3114971", async() => {
                WriteLiteral("Edit");
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
#line 112 "C:\Users\djalburb\Desktop\GymManager\GymManager\Views\Suscripciones\Details.cshtml"
                           WriteLiteral(Model.IdSuscripcion);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fe3b1685100eb1f9a36cda10186002937b86a3117129", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymManager.Models.Suscripciones> Html { get; private set; }
    }
}
#pragma warning restore 1591