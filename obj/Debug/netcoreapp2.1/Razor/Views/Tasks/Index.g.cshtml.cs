#pragma checksum "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfff52bded64e6de8d26beed40486dd26ad36b32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_Index), @"mvc.1.0.view", @"/Views/Tasks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tasks/Index.cshtml", typeof(AspNetCore.Views_Tasks_Index))]
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
#line 1 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\_ViewImports.cshtml"
using ToDoTaskApp;

#line default
#line hidden
#line 2 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\_ViewImports.cshtml"
using ToDoTaskApp.Models;

#line default
#line hidden
#line 2 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfff52bded64e6de8d26beed40486dd26ad36b32", @"/Views/Tasks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48af03e3b2375eaff950a7130d8f3eb04a87bc34", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ToDoTaskApp.Models.Task>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(183, 87, true);
            WriteLiteral("\r\n<h1 class=\"text-success\">To Do Task List</h1>\r\n\r\n<nav aria-label=\"Task Paging\">\r\n    ");
            EndContext();
            BeginContext(271, 74, false);
#line 12 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model }));

#line default
#line hidden
            EndContext();
            BeginContext(345, 21, true);
            WriteLiteral("\r\n</nav>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(366, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b61bd7952bd41ee9d806196737138e1", async() => {
                BeginContext(389, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(403, 639, true);
            WriteLiteral(@"
</p>
<table class=""table table-striped table-bordered table-hover"">
    <thead>
        <tr>
            <th class=""text-center text-primary"">
                Task Title
            </th>
            <th class=""text-center text-primary"">
                Task Comment
            </th>
            <th class=""text-center text-primary"">
                Task Date
            </th>
            <th class=""text-center text-primary"">
                Task Status
            </th>
            <th class=""text-center text-primary"">
                Update or Remove
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 39 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1091, 42, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n");
            EndContext();
#line 44 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                     if ((item.TaskStatus == "done") || (item.TaskStatus == "Done") || (item.TaskStatus == "DONE"))
                    {

#line default
#line hidden
            BeginContext(1273, 53, true);
            WriteLiteral("                        <strike class=\"text-danger\"> ");
            EndContext();
            BeginContext(1327, 44, false);
#line 46 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                Write(Html.DisplayFor(modelItem => item.TaskTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 12, true);
            WriteLiteral(" </strike>\r\n");
            EndContext();
#line 47 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"

                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(1482, 44, false);
#line 51 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TaskTitle));

#line default
#line hidden
            EndContext();
#line 51 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                                     
                    }

#line default
#line hidden
            BeginContext(1551, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 55 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                     if ((item.TaskStatus == "done") || (item.TaskStatus == "Done") || (item.TaskStatus == "DONE"))
                    {

#line default
#line hidden
            BeginContext(1736, 53, true);
            WriteLiteral("                        <strike class=\"text-danger\"> ");
            EndContext();
            BeginContext(1790, 46, false);
#line 57 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                Write(Html.DisplayFor(modelItem => item.TaskComment));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 12, true);
            WriteLiteral(" </strike>\r\n");
            EndContext();
#line 58 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"

                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(1947, 46, false);
#line 62 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TaskComment));

#line default
#line hidden
            EndContext();
#line 62 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                                       
                    }

#line default
#line hidden
            BeginContext(2018, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 66 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                     if ((item.TaskStatus == "done") || (item.TaskStatus == "Done") || (item.TaskStatus == "DONE"))
                    {

#line default
#line hidden
            BeginContext(2203, 53, true);
            WriteLiteral("                        <strike class=\"text-danger\"> ");
            EndContext();
            BeginContext(2257, 43, false);
#line 68 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                Write(Html.DisplayFor(modelItem => item.TaskDate));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 12, true);
            WriteLiteral(" </strike>\r\n");
            EndContext();
#line 69 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"

                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(2411, 43, false);
#line 73 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TaskDate));

#line default
#line hidden
            EndContext();
#line 73 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                                    
                    }

#line default
#line hidden
            BeginContext(2479, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 77 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                     if ((item.TaskStatus == "done") || (item.TaskStatus == "Done") || (item.TaskStatus == "DONE"))
                    {

#line default
#line hidden
            BeginContext(2664, 53, true);
            WriteLiteral("                        <strike class=\"text-danger\"> ");
            EndContext();
            BeginContext(2718, 45, false);
#line 79 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                Write(Html.DisplayFor(modelItem => item.TaskStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2763, 12, true);
            WriteLiteral(" </strike>\r\n");
            EndContext();
#line 80 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"

                    }
                    else
                    {

                        

#line default
#line hidden
            BeginContext(2876, 45, false);
#line 85 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TaskStatus));

#line default
#line hidden
            EndContext();
#line 85 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                                      
                    }

#line default
#line hidden
            BeginContext(2946, 69, true);
            WriteLiteral("                </td>\r\n\r\n                <td>\r\n\r\n                    ");
            EndContext();
            BeginContext(3015, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d4b931c6d6541a6a12d3716a7af6f32", async() => {
                BeginContext(3064, 40, true);
                WriteLiteral("<span class=\"text-success\">Update</span>");
                EndContext();
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
#line 91 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                           WriteLiteral(item.TaskId);

#line default
#line hidden
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
            EndContext();
            BeginContext(3108, 29, true);
            WriteLiteral(" <br />\r\n                    ");
            EndContext();
            BeginContext(3137, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d59d62ea6ea476686eef66da72df1a9", async() => {
                BeginContext(3188, 39, true);
                WriteLiteral("<span class=\"text-danger\">Remove</span>");
                EndContext();
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
#line 92 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                             WriteLiteral(item.TaskId);

#line default
#line hidden
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
            EndContext();
            BeginContext(3231, 48, true);
            WriteLiteral("\r\n\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 97 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(3292, 64, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<nav aria-label=\"Task Paging\">\r\n    ");
            EndContext();
            BeginContext(3357, 74, false);
#line 104 "C:\Users\kabor\Desktop\Projects\ToDoTaskApp\Views\Tasks\Index.cshtml"
Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model }));

#line default
#line hidden
            EndContext();
            BeginContext(3431, 8, true);
            WriteLiteral("\r\n</nav>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ToDoTaskApp.Models.Task>> Html { get; private set; }
    }
}
#pragma warning restore 1591
