#pragma checksum "C:\Users\Simar\source\repos\ShoppingCartSample\ShoppingCartSample\Views\Home\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a4def4f7186dacc534ea8c0f5408a0ce44b3309"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetails), @"mvc.1.0.view", @"/Views/Home/ProductDetails.cshtml")]
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
#line 1 "C:\Users\Simar\source\repos\ShoppingCartSample\ShoppingCartSample\Views\_ViewImports.cshtml"
using ShoppingCartSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Simar\source\repos\ShoppingCartSample\ShoppingCartSample\Views\_ViewImports.cshtml"
using ShoppingCartSample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a4def4f7186dacc534ea8c0f5408a0ce44b3309", @"/Views/Home/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"667958f56afc56c9e906d4fc5633a682d47cac9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartSample.Models.ProductModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Simar\source\repos\ShoppingCartSample\ShoppingCartSample\Views\Home\ProductDetails.cshtml"
  
    ViewData["Title"] = "Product Details Page";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Product Details</h1>\r\n    <hr />\r\n    <table cellpadding=\"0\" cellspacing=\"0\">\r\n        <tr>\r\n            <td>Title: ");
#nullable restore
#line 11 "C:\Users\Simar\source\repos\ShoppingCartSample\ShoppingCartSample\Views\Home\ProductDetails.cshtml"
                  Write(Model.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr><tr><td>Price: ");
#nullable restore
#line 12 "C:\Users\Simar\source\repos\ShoppingCartSample\ShoppingCartSample\Views\Home\ProductDetails.cshtml"
                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n        \r\n        <tr><td>Description: ");
#nullable restore
#line 15 "C:\Users\Simar\source\repos\ShoppingCartSample\ShoppingCartSample\Views\Home\ProductDetails.cshtml"
                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> </tr>\r\n        <tr><td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a4def4f7186dacc534ea8c0f5408a0ce44b33095221", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 479, "~/productImages/", 479, 16, true);
#nullable restore
#line 16 "C:\Users\Simar\source\repos\ShoppingCartSample\ShoppingCartSample\Views\Home\ProductDetails.cshtml"
AddHtmlAttributeValue("", 495, Model.ImageName, 495, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td> </tr>\r\n        <tr>\r\n        <td><input type=\"button\" value=\"Add to Cart\"");
            BeginWriteAttribute("onclick", " onclick=\"", 593, "\"", 630, 3);
            WriteAttributeValue("", 603, "AddToCart(", 603, 10, true);
#nullable restore
#line 18 "C:\Users\Simar\source\repos\ShoppingCartSample\ShoppingCartSample\Views\Home\ProductDetails.cshtml"
WriteAttributeValue("", 613, Model.ProductId, 613, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 629, ")", 629, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" /></td></tr>
       
    </table>
    </div>
<script type=""text/javascript"">
    function AddToCart(productId) {
        debugger;
        $.ajax({
            url: ""/Home/AddToCart"",
            data: {
                ""productId"": productId
            },
            success: function (data) {
                $(""#cartCount"").text(data);
            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartSample.Models.ProductModels> Html { get; private set; }
    }
}
#pragma warning restore 1591