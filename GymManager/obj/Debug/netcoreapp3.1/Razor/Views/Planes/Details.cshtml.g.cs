#pragma checksum "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9aeede9cc2c002b9a8bc70f6d359486c8e2d53c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planes_Details), @"mvc.1.0.view", @"/Views/Planes/Details.cshtml")]
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
#line 1 "C:\Workspace\GymManager\GymManager\Views\_ViewImports.cshtml"
using GymManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\GymManager\GymManager\Views\_ViewImports.cshtml"
using GymManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9aeede9cc2c002b9a8bc70f6d359486c8e2d53c", @"/Views/Planes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b1fa041cae22c10aa7f061ce18da8f8455ea16", @"/Views/_ViewImports.cshtml")]
    public class Views_Planes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManager.Models.Planes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""d-flex"">
                    <h4>Plan</h4>
                    <div class=""ml-auto"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9aeede9cc2c002b9a8bc70f6d359486c8e2d53c4883", async() => {
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
#line 22 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Descripcion1));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 22 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.Descripcion1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 25 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Descripcion2));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 25 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.Descripcion2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 28 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.CodigoAlterno));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 28 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                                                                                        Write(Html.DisplayFor(model => model.CodigoAlterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 31 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.DuracionDias));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 31 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.DuracionDias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 34 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 34 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                                                                                 Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <strong>");
#nullable restore
#line 37 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 37 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                                                                                    Write(Html.DisplayFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9aeede9cc2c002b9a8bc70f6d359486c8e2d53c10632", async() => {
                WriteLiteral("Editar");
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
#line 42 "C:\Workspace\GymManager\GymManager\Views\Planes\Details.cshtml"
                                       WriteLiteral(Model.IdPlan);

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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
