#pragma checksum "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75f43689dfe23c4957694f9d0364e57f8d5dd375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderCancel), @"mvc.1.0.view", @"/Views/Order/OrderCancel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f43689dfe23c4957694f9d0364e57f8d5dd375", @"/Views/Order/OrderCancel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368e07dbb380cb2526a319a88db5ad1924a9dbc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderCancel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderCancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
  
    Layout = "~/Views/Shared/_CartLayout.cshtml";
    var message = TempData["notice"] ?? string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"shopping-cart section\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <!-- Shopping Summery -->\r\n");
#nullable restore
#line 14 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                 if (Model.ToList().Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <h4 class=""header"">အမှာစာရင်း : မှာယူထားသောထီလက်မှတ် စာရင်း</h4>
                    <table class=""table shopping-summery"">
                        <thead>
                            <tr class=""main-hading"">
                                <th>အမည်</th>
                                <th>ဖုန်းနံပါတ်</th>
                                <th class=""text-center"">မှာယူသည့်နေ့</th>
                                <th class=""text-center"">အချက်အလက်</th>
                                <th class=""text-center"">စုစုပေါင်း</th>
                                <th class=""text-center"">အော်ဒါဖျက်သိမ်းမည်</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 29 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                             foreach (var order in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"price\" data-title=\"အမည်\"><span>");
#nullable restore
#line 32 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                                                         Write(order.OrderDetailList.ToList()[0].Order.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                    <td class=\"price\" data-title=\"ဖုန်းနံပါတ်\"><span>");
#nullable restore
#line 33 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                                                                Write(order.OrderDetailList.ToList()[0].Order.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                    <td class=\"price\" data-title=\"မှာယူသည့်နေ့\"><span>");
#nullable restore
#line 34 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                                                                 Write(order.OrderDetailList.ToList()[0].Order.OrderTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                    <td class=\"product-des\" data-title=\"အချက်အလက်\">\r\n                                        <p class=\"product-name\">\r\n                                            ");
#nullable restore
#line 37 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                       Write(order.OrderDetailList.ToList()[0].Order.OrderDetails.ToList()[0].Ticket.OpenTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ကြိမ်မြောက် ၊\r\n                                            ");
#nullable restore
#line 38 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                       Write(order.OrderDetailList.ToList()[0].Order.OrderDetails.ToList()[0].Ticket.GroupSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <p class=\"product-des\">\r\n");
#nullable restore
#line 41 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                             if (order.OrderDetailList.ToList()[0].Order.OrderDetails.Count > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <table>\r\n");
#nullable restore
#line 44 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                                     foreach (var od in order.OrderDetailList.ToList()[0].Order.OrderDetails)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
#nullable restore
#line 47 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                                           Write(od.Ticket.TicketGroupNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 48 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                                           Write(od.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 50 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </table>\r\n");
#nullable restore
#line 52 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </p>\r\n                                    </td>\r\n                                    <td class=\"price\" data-title=\"စုစုပေါင်း\"><span>");
#nullable restore
#line 55 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                                                               Write(order.OrderDetailList.ToList()[0].Order.OrderTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                    <td class=\"action\" data-title=\"အော်ဒါဖျက်သိမ်းမည်\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f43689dfe23c4957694f9d0364e57f8d5dd37511654", async() => {
                WriteLiteral("အော်ဒါဖျက်သိမ်းမည်");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                                                  WriteLiteral(order.OrderDetailList.ToList()[0].Order.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 62 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 66 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"header\">ထီလက်မှတ် မှာယူထားခြင်းမရှိသေးပါ။</h4>\r\n");
#nullable restore
#line 70 "D:\Own Sample Projects\Development\Lottery\OnlineLottery\OnlineLottery\Views\Order\OrderCancel.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!--/ End Shopping Summery -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
