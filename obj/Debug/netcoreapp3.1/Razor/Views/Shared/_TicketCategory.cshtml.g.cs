#pragma checksum "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Shared\_TicketCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0db20b802b02a0e3869ff8f65084230f626991e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TicketCategory), @"mvc.1.0.view", @"/Views/Shared/_TicketCategory.cshtml")]
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
#line 1 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\_ViewImports.cshtml"
using OnlineLottery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\_ViewImports.cshtml"
using OnlineLottery.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\_ViewImports.cshtml"
using OnlineLottery.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db20b802b02a0e3869ff8f65084230f626991e4", @"/Views/Shared/_TicketCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368e07dbb380cb2526a319a88db5ad1924a9dbc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TicketCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"ad-listing-list mt-20\">\r\n    <div class=\"row p-lg-3 p-sm-5 p-4\">\r\n        <div class=\"col-lg-4 align-self-center\">\r\n            <a href=\"#\" class=\"lightbox\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 208, "\"", 229, 1);
#nullable restore
#line 7 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Shared\_TicketCategory.cshtml"
WriteAttributeValue("", 214, Model.ImageUrl, 214, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 248, "\"", 254, 0);
            EndWriteAttribute();
            WriteLiteral(" data-img=\"");
#nullable restore
#line 7 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Shared\_TicketCategory.cshtml"
                                                                         Write(Model.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
            </a>
        </div>
        <div class=""col-lg-8"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-10"">
                    <div class=""ad-listing-content"">
                        <div>
                            <a class=""font-weight-bold"">");
#nullable restore
#line 15 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Shared\_TicketCategory.cshtml"
                                                   Write(_common.ConvertEToMNumber(@Model.OpenTime.ToString("N0")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ကြိမ်မြောက်</a>\r\n                        </div>\r\n                        <ul class=\"list-inline mt-2 mb-3\">\r\n                            <li class=\"list-inline-item\"><a> <i class=\"fas fa-ticket-alt\"></i> (");
#nullable restore
#line 18 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Shared\_TicketCategory.cshtml"
                                                                                           Write(Model.GroupSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></li>\r\n                            <li class=\"list-inline-item\"><a><i class=\"fas fa-money-bill-alt\"></i> ");
#nullable restore
#line 19 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Shared\_TicketCategory.cshtml"
                                                                                             Write(_common.ConvertEToMNumber(@Model.Price.ToString("N0")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ကျပ် </a></li>\r\n                        </ul>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-12\">\r\n");
#nullable restore
#line 23 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Shared\_TicketCategory.cshtml"
                                 if (Model.SubCategories.Count > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>\r\n                                        ");
#nullable restore
#line 26 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Shared\_TicketCategory.cshtml"
                                   Write(String.Join("၊ ", Model.SubCategories.Select(p => p.TicketNo).ToArray()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>                                    \r\n");
#nullable restore
#line 28 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Shared\_TicketCategory.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-lg-6 align-self-center\">            \r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0db20b802b02a0e3869ff8f65084230f626991e48609", async() => {
                WriteLiteral("<i class=\"fas fa-shopping-cart\"></i> ဈေးခြင်းတောင်းထဲထည့်မည်");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ticketId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Shared\_TicketCategory.cshtml"
                       WriteLiteral(Model.TicketId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ticketId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ticketId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ticketId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Common _common { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591