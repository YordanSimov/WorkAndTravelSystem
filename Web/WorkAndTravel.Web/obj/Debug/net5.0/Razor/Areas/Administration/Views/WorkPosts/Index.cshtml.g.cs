#pragma checksum "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fff6af77473f9fde1f9271eaa4335fa381543f8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_WorkPosts_Index), @"mvc.1.0.view", @"/Areas/Administration/Views/WorkPosts/Index.cshtml")]
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
#line 1 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\_ViewImports.cshtml"
using WorkAndTravel.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\_ViewImports.cshtml"
using WorkAndTravel.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff6af77473f9fde1f9271eaa4335fa381543f8a", @"/Areas/Administration/Views/WorkPosts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f07a232f8f80f704f40e36f01c62462aa9b868fe", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_WorkPosts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WorkAndTravel.Data.Models.WorkPost>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table table-bordered table-hover table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Responsibility));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Requirement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Providing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeletedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Responsibility));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Requirement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Providing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeletedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fff6af77473f9fde1f9271eaa4335fa381543f8a12670", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fff6af77473f9fde1f9271eaa4335fa381543f8a14912", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Areas\Administration\Views\WorkPosts\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WorkAndTravel.Data.Models.WorkPost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
