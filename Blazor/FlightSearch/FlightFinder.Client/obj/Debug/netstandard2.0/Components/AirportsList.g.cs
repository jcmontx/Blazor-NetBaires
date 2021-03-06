#pragma checksum "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\AirportsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c7bd3270878f2c2be14cb638cc77de7663e2fe4"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightFinder.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using FlightFinder.Client.Services;
    using FlightFinder.Client.Components;
    using FlightFinder.Shared;
    public class AirportsList : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "datalist");
            builder.AddAttribute(1, "id", "airports");
            builder.AddContent(2, "\n");
#line 4 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\AirportsList.cshtml"
     foreach (var airport in airports)
    {

#line default
#line hidden
            builder.AddContent(3, "        ");
            builder.OpenElement(4, "option");
            builder.AddAttribute(5, "value", airport.Code);
            builder.AddContent(6, airport.DisplayName);
            builder.AddContent(7, " (");
            builder.AddContent(8, airport.Code);
            builder.AddContent(9, ")");
            builder.CloseElement();
            builder.AddContent(10, "\n");
#line 7 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\AirportsList.cshtml"
    }

#line default
#line hidden
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 11 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\AirportsList.cshtml"
 
    private Airport[] airports = Array.Empty<Airport>();

    protected override async Task OnInitAsync()
    {
        airports = await Http.GetJsonAsync<Airport[]>("/api/airports");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
