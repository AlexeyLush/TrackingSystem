#pragma checksum "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "333b8addadbc3f1bbebaa079f8f2e6fe17e51dd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonalStatics_Index), @"mvc.1.0.view", @"/Views/PersonalStatics/Index.cshtml")]
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
#line 1 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\_ViewImports.cshtml"
using WorkingTimeTracking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\_ViewImports.cshtml"
using WorkingTimeTracking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
using Domain.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"333b8addadbc3f1bbebaa079f8f2e6fe17e51dd7", @"/Views/PersonalStatics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cd9f220fbb7339feaf7f18c02461c13e15f89ac", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonalStatics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Models.TaskProject>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Redirect", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Complete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
  
    ViewData["Title"] = "Персональная статисткиа";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Список задач (персональная)</h1>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    if (Context.Users.FirstOrDefault(x => x.Email == User.Identity.Name).UserType == UserType.Admin || Context.Users.FirstOrDefault(x => x.Email == User.Identity.Name).UserType == UserType.Manager)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333b8addadbc3f1bbebaa079f8f2e6fe17e51dd77253", async() => {
                WriteLiteral("Добавить задачу");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 26 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
    }
}




#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"first\" style=\"margin-top: 50px;\">\r\n\r\n");
#nullable restore
#line 42 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
     if (SignInManager.IsSignedIn(User))
    {
        if (Context.Users.FirstOrDefault(x => x.Email == User.Identity.Name).UserType == UserType.DefaultUser)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333b8addadbc3f1bbebaa079f8f2e6fe17e51dd79120", async() => {
                WriteLiteral("Посмотреть персональную статистику");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n<table class=\"table\" style=\"margin-top: 10px;\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Статус\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 83 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
         foreach (var item in Model)
        {
            var taskStatus = "table-primary";
            if ((item.EndDate - DateTime.Now).TotalDays < 3)
            {
                taskStatus = "table-warning";
            }
            if ((item.EndDate - DateTime.Now).TotalDays < 1)
            {
                taskStatus = "deadline__soon";
            }
            if ((item.EndDate - DateTime.Now).TotalDays < 0)
            {
                taskStatus = "table-danger";
            }
            if (item.isEnd)
            {
                taskStatus = "table-success";
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 104 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => Context.Projects.FirstOrDefault(x => x.Id == item.ProjectId).Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 107 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {
                        if (Context.Users.FirstOrDefault(x => x.Email == User.Identity.Name).UserType == UserType.Admin || Context.Users.FirstOrDefault(x => x.Email == User.Identity.Name).UserType == UserType.Manager)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333b8addadbc3f1bbebaa079f8f2e6fe17e51dd714799", async() => {
#nullable restore
#line 111 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 112 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a>");
#nullable restore
#line 115 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 116 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>");
#nullable restore
#line 120 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 121 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 125 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => Context.Users.FirstOrDefault(x => x.Id == item.UserId.ToString()).Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 128 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
               Write(item.StartDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 131 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
               Write(item.EndDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 134 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                     if (item.TaskType == TaskType.Analytics)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Аналитика</span>\r\n");
#nullable restore
#line 137 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                    }
                    else if (item.TaskType == TaskType.Documenting)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Документирование</span>\r\n");
#nullable restore
#line 141 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                    }
                    else if (item.TaskType == TaskType.Programming)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Программирование</span>\r\n");
#nullable restore
#line 145 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n\r\n");
#nullable restore
#line 148 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {
                    if (Context.Users.FirstOrDefault(x => x.Email == User.Identity.Name).UserType == UserType.Admin || Context.Users.FirstOrDefault(x => x.Email == User.Identity.Name).UserType == UserType.Manager)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333b8addadbc3f1bbebaa079f8f2e6fe17e51dd721798", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
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
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 155 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td");
            BeginWriteAttribute("class", " class=\"", 5250, "\"", 5269, 1);
#nullable restore
#line 157 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
WriteAttributeValue("", 5258, taskStatus, 5258, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 158 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                     if (taskStatus == "table-primary")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Активно</span>\r\n");
#nullable restore
#line 161 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                    }
                    else if (taskStatus == "table-danger")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Просрочено</span>\r\n");
#nullable restore
#line 165 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"

                    }
                    else if (taskStatus == "table-warning")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Менее 3 дней</span>\r\n");
#nullable restore
#line 170 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                    }
                    else if (taskStatus == "deadline__soon")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Менее дня</span>\r\n");
#nullable restore
#line 174 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                    }
                    else if (taskStatus == "table-success")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Выполнено</span>\r\n");
#nullable restore
#line 178 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 181 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                     if (!item.isEnd)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333b8addadbc3f1bbebaa079f8f2e6fe17e51dd727062", async() => {
                WriteLiteral("Выполнено");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 183 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
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
            WriteLiteral("\r\n");
#nullable restore
#line 184 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 188 "C:\Users\Alex\Source\Repos\TrackingSystem\WorkingTimeTracking\Views\PersonalStatics\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public TrackingDb Context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Models.TaskProject>> Html { get; private set; }
    }
}
#pragma warning restore 1591
