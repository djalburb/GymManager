#pragma checksum "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "301f2e97651245fbecf6f9321256662feed024d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planes_Delete), @"mvc.1.0.view", @"/Views/Planes/Delete.cshtml")]
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
#line 1 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\_ViewImports.cshtml"
using GymManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\_ViewImports.cshtml"
using GymManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"301f2e97651245fbecf6f9321256662feed024d6", @"/Views/Planes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b1fa041cae22c10aa7f061ce18da8f8455ea16", @"/Views/_ViewImports.cshtml")]
    public class Views_Planes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManager.Models.Planes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">

                    <h4>¿Está seguro(a) que desea eliminar este Plan?</h4>
            </div>
            <div class=""card-body"">
                <ul class=""list-group"">
                    <li class=""list-group-item"">
                        <strong>");
#nullable restore
#line 18 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Descripcion1));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 18 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.Descripcion1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 21 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Descripcion2));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 21 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.Descripcion2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 24 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.CodigoAlterno));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 24 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                                                                                        Write(Html.DisplayFor(model => model.CodigoAlterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 27 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.DuracionDias));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 27 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.DuracionDias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 30 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 30 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                                                                                 Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 33 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 33 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                                                                                    Write(Html.DisplayFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 36 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.IdMoneda));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 36 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.Moneda.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "301f2e97651245fbecf6f9321256662feed024d610496", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "301f2e97651245fbecf6f9321256662feed024d610775", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 42 "D:\Carlos Files\Workspace\GymManager\GymManager\Views\Planes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdPlan);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" />\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "301f2e97651245fbecf6f9321256662feed024d612585", async() => {
                    WriteLiteral("Cancelar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymManager.Models.Planes> Html { get; private set; }
    }
}
#pragma warning restore 1591
