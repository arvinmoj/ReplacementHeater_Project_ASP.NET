#pragma checksum "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea09808079eeb89c35fe9b929d1f24f91e14a653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReplacementHeater_Details), @"mvc.1.0.view", @"/Views/ReplacementHeater/Details.cshtml")]
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
#line 1 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/_ViewImports.cshtml"
using My_Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/_ViewImports.cshtml"
using ViewModels.Error;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea09808079eeb89c35fe9b929d1f24f91e14a653", @"/Views/ReplacementHeater/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8432a923d36eb68c1934a42ed2cd80286925909a", @"/Views/_ViewImports.cshtml")]
    public class Views_ReplacementHeater_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.ReplacementHeater>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>جزئیات</h1>\n\n<div>\n    <h4>تعویض بخاری</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 14 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HeaterInstalledType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 17 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayFor(model => model.HeaterInstalledType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 20 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NameCEO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 23 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayFor(model => model.NameCEO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 26 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 29 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 32 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HeaterScrapType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 35 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayFor(model => model.HeaterScrapType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 38 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 41 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 44 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 47 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayFor(model => model.Capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 50 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HeaterScrapSerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 53 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayFor(model => model.HeaterScrapSerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 56 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HeaterInstalledSerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 59 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayFor(model => model.HeaterInstalledSerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 62 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InstallationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 65 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayFor(model => model.InstallationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 68 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InstallationTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 71 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
       Write(Html.DisplayFor(model => model.InstallationTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea09808079eeb89c35fe9b929d1f24f91e14a65311896", async() => {
                WriteLiteral("تغییرات");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/ReplacementHeater/Details.cshtml"
                                                   WriteLiteral(Model.Id);

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
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea09808079eeb89c35fe9b929d1f24f91e14a65314146", async() => {
                WriteLiteral("بازگشت");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.ReplacementHeater> Html { get; private set; }
    }
}
#pragma warning restore 1591
