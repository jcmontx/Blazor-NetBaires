#pragma checksum "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9f2846c72e8b85680b5922a755e77305edce239"
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
    public class SearchResults : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "px-4");
            builder.AddContent(2, "\n");
#line 2 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\SearchResults.cshtml"
     if (Itineraries != null)
    {

#line default
#line hidden
            builder.AddContent(3, "        ");
            builder.OpenElement(4, "div");
            builder.AddAttribute(5, "class", "title");
            builder.AddContent(6, "\n            ");
            builder.OpenElement(7, "h2");
            builder.AddAttribute(8, "class", "my-3");
            builder.AddContent(9, Itineraries.Count);
            builder.AddContent(10, " results");
            builder.CloseElement();
            builder.AddContent(11, "\n            ");
            builder.OpenElement(12, "select");
            builder.AddAttribute(13, "class", "custom-select");
            builder.AddAttribute(14, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(chosenSortOrder));
            builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => chosenSortOrder = __value, chosenSortOrder));
            builder.AddContent(16, "\n                ");
            builder.OpenElement(17, "option");
            builder.AddAttribute(18, "value", SortOrder.Price);
            builder.AddContent(19, "Cheapest");
            builder.CloseElement();
            builder.AddContent(20, "\n                ");
            builder.OpenElement(21, "option");
            builder.AddAttribute(22, "value", SortOrder.Duration);
            builder.AddContent(23, "Quickest");
            builder.CloseElement();
            builder.AddContent(24, "\n            ");
            builder.CloseElement();
            builder.AddContent(25, "\n        ");
            builder.CloseElement();
            builder.AddContent(26, "\n");
#line 12 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\SearchResults.cshtml"
         foreach (var item in sortedItineraries)
        {

#line default
#line hidden
            builder.AddContent(27, "            ");
            builder.OpenElement(28, "div");
            builder.AddAttribute(29, "class", "mb-4 d-flex align-items-center");
            builder.AddContent(30, "\n                ");
            builder.OpenElement(31, "ul");
            builder.AddAttribute(32, "class", "list-group");
            builder.AddContent(33, "\n                    ");
            builder.OpenElement(34, "li");
            builder.AddAttribute(35, "class", "list-group-item d-flex align-items-center");
            builder.AddContent(36, "\n                        ");
            builder.OpenComponent<FlightFinder.Client.Components.SearchResultFlightSegment>(37);
            builder.AddAttribute(38, "Symbol", "▶");
            builder.AddAttribute(39, "Flight", item.Outbound);
            builder.CloseComponent();
            builder.AddContent(40, "\n                    ");
            builder.CloseElement();
            builder.AddContent(41, "\n                    ");
            builder.OpenElement(42, "li");
            builder.AddAttribute(43, "class", "list-group-item d-flex align-items-center");
            builder.AddContent(44, "\n                        ");
            builder.OpenComponent<FlightFinder.Client.Components.SearchResultFlightSegment>(45);
            builder.AddAttribute(46, "Symbol", "◀");
            builder.AddAttribute(47, "Flight", item.Return);
            builder.CloseComponent();
            builder.AddContent(48, "\n                    ");
            builder.CloseElement();
            builder.AddContent(49, "\n                ");
            builder.CloseElement();
            builder.AddContent(50, "\n                ");
            builder.OpenElement(51, "div");
            builder.AddAttribute(52, "class", "price ml-3");
            builder.AddContent(53, "\n                    ");
            builder.OpenElement(54, "h3");
            builder.AddContent(55, item.Price.ToString("$0"));
            builder.CloseElement();
            builder.AddContent(56, "\n                    ");
            builder.OpenElement(57, "button");
            builder.AddAttribute(58, "class", "btn");
            builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(() => OnAddItinerary(item)));
            builder.AddContent(60, "Add");
            builder.CloseElement();
            builder.AddContent(61, "\n                ");
            builder.CloseElement();
            builder.AddContent(62, "\n            ");
            builder.CloseElement();
            builder.AddContent(63, "\n");
#line 28 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\SearchResults.cshtml"
        }

#line default
#line hidden
#line 28 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\SearchResults.cshtml"
         
    }

#line default
#line hidden
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 33 "C:\Users\Juan Cruz\Desktop\Presentación\Blazor\otros\FlightSearch\FlightFinder.Client\Components\SearchResults.cshtml"
 
    // Parameters
    [Parameter] ICollection<Itinerary> Itineraries { get; set; }
    [Parameter] Action<Itinerary> OnAddItinerary { get; set; }

    // Private state
    private SortOrder chosenSortOrder;
    private IEnumerable<Itinerary> sortedItineraries
        => chosenSortOrder == SortOrder.Price
        ? Itineraries.OrderBy(x => x.Price)
        : Itineraries.OrderBy(x => x.TotalDurationHours);

    enum SortOrder { Price, Duration }

#line default
#line hidden
    }
}
#pragma warning restore 1591
