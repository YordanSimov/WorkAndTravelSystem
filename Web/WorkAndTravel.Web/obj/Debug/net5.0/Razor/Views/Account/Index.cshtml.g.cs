#pragma checksum "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0476aead919ec7ee14e5d70725ce41f87da1ebc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\_ViewImports.cshtml"
using WorkAndTravel.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\_ViewImports.cshtml"
using WorkAndTravel.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0476aead919ec7ee14e5d70725ce41f87da1ebc0", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f07a232f8f80f704f40e36f01c62462aa9b868fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkAndTravel.Web.ViewModels.Account.ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-2 float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-2 float-right mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyPosts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml"
  
    this.ViewData["Title"] = "Profile page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml"
 if (this.User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0476aead919ec7ee14e5d70725ce41f87da1ebc05781", async() => {
                WriteLiteral("Profile Settings");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0476aead919ec7ee14e5d70725ce41f87da1ebc07231", async() => {
                WriteLiteral("My posts");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h1>");
#nullable restore
#line 10 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml"
   Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <hr />
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-4"">
                <div class=""text-center card-box"">
                    <div class=""member-card"">
                        <ul>
                            <li class=""thumb-xl member-thumb m-b-10 center-block"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 785, "\"", 815, 1);
#nullable restore
#line 19 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 791, Model.ProfilePictureUrl, 791, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle img-thumbnail"" alt=""profile-image"">
                            </li>

                            <li class=""col-lg-12 mt-md-5 w-100"">
                                <a class=""btn btn-secondary"">Edit</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <ul>
                <li>
                    <div class=""text-center card-box"">
                        <strong class=""text-black"">Full Name: </strong>
                        ");
#nullable restore
#line 33 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml"
                                    Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </li>\r\n                <li>\r\n                    <div class=\"text-center\">\r\n                        <strong class=\"text-black\">Username: </strong>\r\n                        ");
#nullable restore
#line 39 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml"
                   Write(this.User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </li>\r\n                <li>\r\n                    <div class=\"text-center\">\r\n                        <strong class=\"text-black\">Age: </strong>\r\n                        ");
#nullable restore
#line 45 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml"
                   Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </li>\r\n                <li>\r\n                    <div class=\"text-center\">\r\n                        <strong class=\"text-black\">Email: </strong>\r\n                        ");
#nullable restore
#line 51 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml"
                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </li>\r\n                <li>\r\n                    <div class=\"text-center\">\r\n                        <strong class=\"text-black\"> Created on: </strong><time");
            BeginWriteAttribute("datetime", " datetime=\"", 2301, "\"", 2342, 1);
#nullable restore
#line 56 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 2312, Model.CreatedOn.ToString("O"), 2312, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></time>\r\n                    </div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 62 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Account\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkAndTravel.Web.ViewModels.Account.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
