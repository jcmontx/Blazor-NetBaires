#pragma checksum "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\BlazorApp\BlazorApp.Client\Shared\ToDoList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06c23be729df710f75257d4ec523738b7e6c3d61"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using BlazorApp.Client;
    using BlazorApp.Client.Shared;
    using BlazorApp.Shared;
    public class ToDoList : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "ul");
            builder.AddContent(1, "\n");
#line 3 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\BlazorApp\BlazorApp.Client\Shared\ToDoList.cshtml"
     foreach (var item in ToDos)
	{

#line default
#line hidden
            builder.AddContent(2, "\t\t");
            builder.OpenElement(3, "li");
            builder.AddContent(4, item.Name);
            builder.AddContent(5, " (");
            builder.AddContent(6, item.Status);
            builder.AddContent(7, ")  ");
            builder.OpenElement(8, "button");
            builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(() => Remove(item)));
            builder.AddContent(10, "-");
            builder.CloseElement();
            builder.AddContent(11, "q");
            builder.CloseElement();
            builder.AddContent(12, "\n");
#line 6 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\BlazorApp\BlazorApp.Client\Shared\ToDoList.cshtml"
	}

#line default
#line hidden
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\BlazorApp\BlazorApp.Client\Shared\ToDoList.cshtml"
           
	[Parameter]
	List<ToDoItem> ToDos { get; set; }

	[Parameter]
	Action<ToDoItem> Remove { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
