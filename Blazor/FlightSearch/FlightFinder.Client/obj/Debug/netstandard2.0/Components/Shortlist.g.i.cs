#pragma checksum "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\Shortlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aca880df08ec21ceab03f17ac16c91bd889d3da"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public class Shortlist : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 29 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\Shortlist.cshtml"
 
    [Parameter] ICollection<Itinerary> Itineraries { get; set; }

    [Parameter] Action<Itinerary> OnRemoveItinerary { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
