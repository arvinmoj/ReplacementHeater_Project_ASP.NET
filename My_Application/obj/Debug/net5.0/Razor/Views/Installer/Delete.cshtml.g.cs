#pragma checksum "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9544606c7b9896c974971a52ad4799fd936cca08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Installer_Delete), @"mvc.1.0.view", @"/Views/Installer/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9544606c7b9896c974971a52ad4799fd936cca08", @"/Views/Installer/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8432a923d36eb68c1934a42ed2cd80286925909a", @"/Views/_ViewImports.cshtml")]
    public class Views_Installer_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Installer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
  
    Layout = "_DetailsLayout";
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br>\n\n<h3>آیا مطمئن هستید که می خواهید این اطلاعات را حذف کنید؟</h3>\n\n<br>\n\n<h4>نصاب</h4>\n\n<br>\n\n<dl class=\"row\">\n\n    <dt class=\"col-sm-2\">\n        ");
#nullable restore
#line 21 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 24 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n\n    <hr class=\"my-2\" />\n\n    <dt class=\"col-sm-2\">\n        ");
#nullable restore
#line 30 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.InstallerUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 33 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayFor(model => model.InstallerUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n\n    <hr class=\"my-2\" />\n\n    <dt class=\"col-sm-2\">\n        ");
#nullable restore
#line 39 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.UserNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 42 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayFor(model => model.UserNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n\n    <hr class=\"my-2\" />\n\n    <dt class=\"col-sm-2\">\n        ");
#nullable restore
#line 48 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.NationalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 51 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayFor(model => model.NationalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n\n    <hr class=\"my-2\" />\n\n    <dt class=\"col-sm-2\">\n        ");
#nullable restore
#line 57 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 60 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n\n    <hr class=\"my-2\" />\n\n    <dt class=\"col-sm-2\">\n        ");
#nullable restore
#line 66 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.MobileNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 69 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayFor(model => model.MobileNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n\n    <hr class=\"my-2\" />\n\n    <dt class=\"col-sm-2\">\n        ");
#nullable restore
#line 75 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 78 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
   Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n</dl>\n\n<br>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9544606c7b9896c974971a52ad4799fd936cca089974", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9544606c7b9896c974971a52ad4799fd936cca0810232", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 85 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/Installer/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9544606c7b9896c974971a52ad4799fd936cca0811931", async() => {
                    WriteLiteral("بازگشت");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" |\n    <input type=\"submit\" value=\"حذف\" class=\"btn btn-danger\" />\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Installer> Html { get; private set; }
    }
}
#pragma warning restore 1591
