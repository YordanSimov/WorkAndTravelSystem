#pragma checksum "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a975a05902e0b061c36ba3a6915c66d00c2aadf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Home\Index.cshtml"
using WorkAndTravel.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a975a05902e0b061c36ba3a6915c66d00c2aadf1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f07a232f8f80f704f40e36f01c62462aa9b868fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkAndTravel.Web.ViewModels.Home.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Home\Index.cshtml"
  
    this.ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Home\Index.cshtml"
 if (this.TempData.ContainsKey("Message"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-warning alert-dismissible fade show\">\r\n    ");
#nullable restore
#line 10 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Home\Index.cshtml"
Write(this.TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n</div>\r\n");
#nullable restore
#line 15 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to ");
#nullable restore
#line 18 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Home\Index.cshtml"
                                Write(GlobalConstants.SystemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n\r\n    <div class=\"col-md-4 offset-md-4\">\r\n        <p>We provide work opportunities all over the EU: </p>\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item\">Work Posts: ");
#nullable restore
#line 23 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Home\Index.cshtml"
                                               Write(Model.WorkPostsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">Types of work: ");
#nullable restore
#line 24 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Home\Index.cshtml"
                                                  Write(Model.CategoriesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n            <li class=\"list-group-item\">Countries: ");
#nullable restore
#line 25 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Home\Index.cshtml"
                                              Write(Model.CountriesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n            <li class=\"list-group-item\">Cities: ");
#nullable restore
#line 26 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\Home\Index.cshtml"
                                           Write(Model.CitiesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkAndTravel.Web.ViewModels.Home.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
