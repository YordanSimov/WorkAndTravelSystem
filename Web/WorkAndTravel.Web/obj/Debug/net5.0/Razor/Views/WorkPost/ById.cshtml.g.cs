#pragma checksum "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5d3e391111264b75440e9c61b1d899dafc3cbe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkPost_ById), @"mvc.1.0.view", @"/Views/WorkPost/ById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5d3e391111264b75440e9c61b1d899dafc3cbe6", @"/Views/WorkPost/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f07a232f8f80f704f40e36f01c62462aa9b868fe", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkPost_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkAndTravel.Web.ViewModels.WorkPosts.SingleWorkPostViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddCommentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("antiForgeryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
  
    this.ViewData["Title"] = Model.Title;
    void DisplayComments(int? parentId)
    {
        var comments = this.Model.Comments.Where(x => x.ParentId == parentId);
        if (!comments.Any())
        {
            return;
        }


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
         foreach (var comment in comments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""container-fluid mt-100"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""card mb-4"">
                            <div class=""card-header"">
                                <div class=""media flex-wrap w-100 align-items-center"">
                                    <img src=""https://res.cloudinary.com/dxfq3iotg/image/upload/v1574583246/AAA/2.jpg"" class=""d-block ui-w-40 rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 857, "\"", 863, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"media-body ml-3\">\r\n                                        ");
#nullable restore
#line 23 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                   Write(comment.UserUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <div class=\"text-muted small\">\r\n                                            <time");
            BeginWriteAttribute("datetime", " datetime=\"", 1118, "\"", 1161, 1);
#nullable restore
#line 25 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
WriteAttributeValue("", 1129, comment.CreatedOn.ToString("O"), 1129, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></time>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"text-muted small ml-3\">\r\n");
#nullable restore
#line 29 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                         if (this.User.Identity.IsAuthenticated)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"px-4 pt-3\"> <button type=\"button\" class=\"btn btn-secondary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1577, "\"", 1618, 3);
            WriteAttributeValue("", 1587, "showAddCommentForm(", 1587, 19, true);
#nullable restore
#line 31 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
WriteAttributeValue("", 1606, comment.Id, 1606, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1617, ")", 1617, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-plus\"></i>&nbsp; Reply</button> </div>\r\n");
#nullable restore
#line 32 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                            <div class=""card-body"">
                                <article class=""mb-3"">
                                    ");
#nullable restore
#line 38 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                               Write(comment.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </article>\r\n");
#nullable restore
#line 40 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                   DisplayComments(comment.Id); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 46 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
         
    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"site-section\">\r\n        <div class=\"container\">\r\n            <h1 class=\"text-primary\">");
#nullable restore
#line 51 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <div class=\" row mb-4\">\r\n                <div class=\"col-xl-9 col-12\">\r\n                    <ul class=\"entry-meta\">\r\n                        <li class=\"ml-0 mr-2 mb-2\"><i class=\"fas fa-user\"></i> ");
#nullable restore
#line 55 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                                                          Write(Model.AddedByUserUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"ml-0 mr-2 mb-2\"><i class=\"fas fa-briefcase\"></i> ");
#nullable restore
#line 56 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                                                               Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"m-2\"><i class=\"fas fa-globe\"></i> ");
#nullable restore
#line 57 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                                                Write(Model.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 57 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                                                                    Write(Model.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        <li class=""single-meta"">
                            <ul class=""item-rating"">
                                <li data-rating=""1"" id=""q6-1""><i class=""fas fa-star""></i></li>
                                <li data-rating=""2"" id=""q6-2""><i class=""fas fa-star""></i></li>
                                <li data-rating=""3"" id=""q6-3""><i class=""fas fa-star""></i></li>
                                <li data-rating=""4"" id=""q6-4""><i class=""fas fa-star""></i></li>
                                <li data-rating=""5"" id=""q6-5""><i class=""fas fa-star""></i></li>
                                <li><span id=""averageRatingValue"">");
#nullable restore
#line 65 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                                             Write(Model.AverageRating.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span> / 5</span></li>\r\n                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <img class=\"img-fluid w-50 border mb-3 mt-2\"");
            BeginWriteAttribute("src", " src=\"", 3795, "\"", 3822, 1);
#nullable restore
#line 72 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
WriteAttributeValue("", 3801, Model.RemoteImageUrl, 3801, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3823, "\"", 3841, 1);
#nullable restore
#line 72 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
WriteAttributeValue("", 3829, Model.Title, 3829, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        <div class=""item-feature"">
            <div class=""col-lg-8"">
                <div class=""mb-5"">
                    <h2 class=""h4 d-flex align-items-center mb-4 text-primary"">
                        <span class=""icon-align-left mr-3"">Job Description</span>
                    </h2>
                    <p>
                        ");
#nullable restore
#line 80 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                <div class=""mb-5"">
                    <h3 class=""h5 d-flex align-items-center mb-4 text-primary""><span class=""icon-rocket mr-3"">Information about your responsibilities</span></h3>
                    <ul class=""list-unstyled m-0 p-0"">
                        <li class=""d-flex align-items-start mb-2"">
                            <span class=""icon-check_circle mr-2 text-muted""></span><span>
                                ");
#nullable restore
#line 88 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                           Write(Model.Responsibility);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </span>
                        </li>
                    </ul>
                </div>
                <div class=""mb-5"">
                    <h3 class=""h5 d-flex align-items-center mb-4 text-primary"">
                        <span class=""icon-book mr-3"">Requirements</span>
                    </h3>
                    <ul class=""list-unstyled m-0 p-0"">
                        <li class=""d-flex align-items-start mb-2"">
                            <span class=""icon-check_circle mr-2 text-muted""></span><span>
                                ");
#nullable restore
#line 100 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                           Write(Model.Requirement);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </span>
                        </li>
                    </ul>
                </div>
                <div class=""mb-5"">
                    <h3 class=""h5 d-flex align-items-center mb-4 text-primary"">
                        <span class=""icon-book mr-3"">You will get:</span>
                    </h3>
                    <ul class=""list-unstyled m-0 p-0"">
                        <li class=""d-flex align-items-start mb-2"">
                            <span class=""icon-check_circle mr-2 text-muted""></span><span>
                                ");
#nullable restore
#line 112 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                           Write(Model.Providing);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </span>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-5"">
                <div class=""bg-light p-3 border rounded mb-4"">
                    <h3 class=""text-primary  mt-3 h5 pl-3 mb-3 "">Post Summary</h3>
                    <ul class=""list-unstyled pl-3 mb-0"">
                        <li class=""mb-2"">
                        <i class=""fas fa-calendar-alt""></i><strong class=""text-black""> Published on:</strong><time");
            BeginWriteAttribute("datetime", " datetime=\"", 6479, "\"", 6520, 1);
#nullable restore
#line 123 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
WriteAttributeValue("", 6490, Model.CreatedOn.ToString("O"), 6490, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></time></li>\r\n                        <li class=\"star-fill mb-2\"><i class=\"fas fa-star\"></i><strong class=\"text-black\"> Our rating: ");
#nullable restore
#line 124 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                                                                                                 Write(Model.AverageRating.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></li>\r\n                        <li class=\"mb-2\"><i class=\"fas fa-location-arrow\"></i><strong class=\"text-black\"> Job Location:</strong>  ");
#nullable restore
#line 125 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                                                                                                             Write(Model.AddressName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"mb-2\"><i class=\"fas fa-wallet\"></i><strong class=\"text-black\"> Salary: </strong> ");
#nullable restore
#line 126 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                                                                                               Write(Model.PaymentPerDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</li>\r\n                        <li class=\"mb-2\"><i class=\"fas fa-envelope\"></i><strong class=\"text-black\"> Contact us: </strong> ");
#nullable restore
#line 127 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                                                                                                                     Write(Model.AddedByUserUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </li>
                    </ul>
                    <div>
                        <div class=""row"">
                            <div class=""col-6"">
                                <a href=""#"" class=""btn btn-block btn-primary btn-md mt-3 ml-5"">Apply Now</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 138 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                 if (this.User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"px-4 pt-3\"> <button type=\"button\" class=\"btn btn-primary float-right mb-3\" onclick=\"showAddCommentForm(0)\"><i class=\"fa fa-plus\"></i>&nbsp; Comment</button> </div>\r\n                    <div class=\"clearfix\"></div>\r\n");
#nullable restore
#line 142 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                   DisplayComments(null); 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section>\r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5d3e391111264b75440e9c61b1d899dafc3cbe623080", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"WorkPostId\"");
                BeginWriteAttribute("value", " value=\"", 8159, "\"", 8176, 1);
#nullable restore
#line 149 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
WriteAttributeValue("", 8167, Model.Id, 8167, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <input type=""hidden"" name=""ParentId"" value=""0"" />
            <div>
                <label for=""Content""></label>
                <textarea name=""Content"" id=""Content"" class=""mb-3 form-control"" rows=""4""></textarea>
            </div>
            <div>
                <input type=""submit"" class=""btn btn-primary"" value=""Add comment"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5d3e391111264b75440e9c61b1d899dafc3cbe625990", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <script>\r\n        $(\"li[data-rating]\").each(function (el) {\r\n            $(this).click(function () {\r\n                var value = $(this).attr(\"data-rating\");\r\n                var workPostId = ");
#nullable restore
#line 167 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
                            Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                var antiForgeryToken = $('#antiForgeryForm input[name=__RequestVerificationToken]').val();
                var data = { workPostId: workPostId, value: value };
                $.ajax({
                    type: ""POST"",
                    url: ""/api/Ratings"",
                    data: JSON.stringify(data),
                    headers: {
                        'X-CSRF-TOKEN': antiForgeryToken
                    },
                    success: function (data) {
                        $('#averageRatingValue').html(data.averageRating.toFixed(1));
                    },
                    contentType: 'application/json',
                });
            })
        });
        </script>
        <!--Stars colouring-->
");
#nullable restore
#line 186 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
         if (this.User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <script>
                $(""li[data-rating]"").click(function () {
                    var rating = $(this).attr('id');
                    var res = rating.split(""-"");
                    rating = res[1];
                    for (var i = 0; i < 5; i++) {
                        if (i <= rating) {
                            $('#q6-' + i).addClass(""star-fill"");
                        }
                    }
                });
                $(""li[data-rating]"").hover(function () {
                    $(this).addClass(""star-fill"").prevUntil(""star-fill"").addClass(""star-fill"");
                }, function () {
                    $(this).nextUntil(""star-fill"").removeClass(""star-fill"");
                });
            </script>
");
#nullable restore
#line 205 "C:\Users\Simov\Desktop\WorkAndTravel-1f71601c9129b9a8ec84c1b718ee8996097b476e\Web\WorkAndTravel.Web\Views\WorkPost\ById.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <!--Comments-->
        <script>
            function showAddCommentForm(parentId) {
                $(""#AddCommentForm input[name='ParentId']"").val(parentId);
                $(""#AddCommentForm"").show();
                $([document.documentElement, document.body]).animate({
                    scrollTop: $(""#AddCommentForm"").offset().top
                }, 1000);
            }
        </script>
    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkAndTravel.Web.ViewModels.WorkPosts.SingleWorkPostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
