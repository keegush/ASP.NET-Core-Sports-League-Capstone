#pragma checksum "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca8aba7e5faf2a663af1c81e76863d8630ce32f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(League.Pages.Teams.Pages_Teams_Team), @"mvc.1.0.razor-page", @"/Pages/Teams/Team.cshtml")]
namespace League.Pages.Teams
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
#line 1 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\_ViewImports.cshtml"
using League;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\_ViewImports.cshtml"
using League.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca8aba7e5faf2a663af1c81e76863d8630ce32f8", @"/Pages/Teams/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e3ff45e0845b767ce2e91c14cb4035fde88f59", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Teams_Team : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Players/Player", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
  
    ViewData["Title"] = "NFL Team - " + @Html.DisplayFor(model => model.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron p-2 d-flex justify-content-between\">\r\n    <h1 class=\"display-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca8aba7e5faf2a663af1c81e76863d8630ce32f84912", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 234, "~/image/nfl/logo/", 234, 17, true);
#nullable restore
#line 10 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
AddHtmlAttributeValue("", 251, Model.Team.TeamId, 251, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 271, ".png", 271, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n        ");
#nullable restore
#line 11 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
   Write(Model.Team.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
   Write(Model.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n</div>\r\n<div class=\"d-flex justify-content-between\">\r\n    <div>\r\n        <div>\r\n            <div>");
#nullable restore
#line 18 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
             Write(Model.Team.Division.ConferenceId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                                   Write(Model.Team.Division.DivisionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>Record: ");
#nullable restore
#line 19 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                     Write(Model.Team.Win);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 19 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                       Write(Model.Team.Loss);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 19 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                                          Write(Model.Team.Tie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <hr />\r\n            <div>");
#nullable restore
#line 21 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
             Write(Model.Team.Stadium);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Stadium</div>\r\n            <div>Capacity: ");
#nullable restore
#line 22 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                       Write(Model.Team.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <hr />\r\n            <div>");
#nullable restore
#line 24 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
             Write(Model.Team.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>");
#nullable restore
#line 25 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
             Write(Model.Team.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 25 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                 Write(Model.Team.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                                     Write(Model.Team.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca8aba7e5faf2a663af1c81e76863d8630ce32f810652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 933, "~/image/nfl/stadium/", 933, 20, true);
#nullable restore
#line 26 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
AddHtmlAttributeValue("", 953, Model.Team.TeamId, 953, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 973, ".jpg", 973, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca8aba7e5faf2a663af1c81e76863d8630ce32f812370", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1025, "~/image/nfl/seating/", 1025, 20, true);
#nullable restore
#line 29 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
AddHtmlAttributeValue("", 1045, Model.Team.TeamId, 1045, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1065, ".png", 1065, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<section class=""grid container mt-3"">
    <div class=""d-flex bg-header"">
        <div class=""p-1"" style=""flex:0 0 10%"">Number</div>
        <div class=""p-1"" style=""flex:0 0 25%"">Name</div>
        <div class=""p-1"" style=""flex:0 0 10%"">Position</div>
        <div class=""p-1"" style=""flex:0 0 20%"">Experience</div>
        <div class=""p-1"" style=""flex:0 0 25%"">College</div>
        <div class=""p-1"" style=""flex:0 0 10%"">Depth</div>
    </div>
");
#nullable restore
#line 40 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
     foreach(Player player in Model.Team.Players)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca8aba7e5faf2a663af1c81e76863d8630ce32f814756", async() => {
                WriteLiteral("\r\n            <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 43 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(player.Number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 25%\">");
#nullable restore
#line 44 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(player.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 45 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(player.Position);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 20%\">");
#nullable restore
#line 46 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(player.Experience);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 25%\">");
#nullable restore
#line 47 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(player.College);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 48 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(player.Depth);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
AddHtmlAttributeValue("", 1610, player.Depth == 1 ? "d-flex starter" : "d-flex", 1610, 50, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 1660, "", 1661, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
                                                                                                    WriteLiteral(player.PlayerId);

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
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\keeganu\Desktop\Codecademy_ASPNetCore_Capstone_Project\League-Starter\LeagueStarter\Pages\Teams\Team.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TeamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TeamModel>)PageContext?.ViewData;
        public TeamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
