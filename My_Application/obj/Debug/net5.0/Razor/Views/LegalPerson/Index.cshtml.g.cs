#pragma checksum "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fd2247863ef863f4f3903970b4925fb408dd035"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LegalPerson_Index), @"mvc.1.0.view", @"/Views/LegalPerson/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fd2247863ef863f4f3903970b4925fb408dd035", @"/Views/LegalPerson/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8432a923d36eb68c1934a42ed2cd80286925909a", @"/Views/_ViewImports.cshtml")]
    public class Views_LegalPerson_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.LegalPerson>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>کاربر حقوقی</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd2247863ef863f4f3903970b4925fb408dd0355158", async() => {
                WriteLiteral("ایجاد");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n\n<br />\n\n<div class=\"container mb-3\">\n    <table class=\"table table-striped table-border mydatatable\" style=\"width: 100%;\">\n        <thead>\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 20 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.InstallerUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 23 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 26 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.NameCEO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 29 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 32 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 35 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 38 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 41 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 44 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 47 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.NationalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 50 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.RegistrationNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 53 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EconomicCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 56 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.RecipientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 59 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.InstallationLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 62 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.GasometerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 65 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.GasometerNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 68 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PersonNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 71 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Attachment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 77 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 81 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.InstallerUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 84 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 87 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NameCEO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 90 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 93 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 96 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 99 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 102 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 105 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NationalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 108 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RegistrationNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 111 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EconomicCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 114 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RecipientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 117 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.InstallationLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 120 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.GasometerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 123 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.GasometerNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 126 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PersonNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 129 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Attachment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd2247863ef863f4f3903970b4925fb408dd03519361", async() => {
                WriteLiteral("تغییرات");
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
#line 132 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                                               WriteLiteral(item.Id);

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
            WriteLiteral(" |\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd2247863ef863f4f3903970b4925fb408dd03521537", async() => {
                WriteLiteral("جزئیات");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 133 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                                                  WriteLiteral(item.Id);

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
            WriteLiteral(" |\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd2247863ef863f4f3903970b4925fb408dd03523715", async() => {
                WriteLiteral("حذف");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 134 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
                                                 WriteLiteral(item.Id);

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
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 137 "/Users/macbook/Desktop/ReplacementHeater_Project_ASP.NET/My_Application/Views/LegalPerson/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.LegalPerson>> Html { get; private set; }
    }
}
#pragma warning restore 1591
