<<<<<<< HEAD
#pragma checksum "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "457ab5d2943d43c801108914ce5cd4d0e0b987bf"
=======
#pragma checksum "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "088e15392ba3e1e8c032cfa391428dc0563a8048"
>>>>>>> f085d83f84ce4c00fcfdc3706952241dd0249374
// <auto-generated/>
#pragma warning disable 1591
namespace shelterbooking.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using shelterbooking.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using shelterbooking.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
using shelterbooking.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Shelterbooking i Aarhus, Skanderborg og Silkeborg</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    Se det skønne udvalg over Shelters i Aarhus, Skanderborg og Silkeborg kommune.\r\n    Her kan du se ledige shelters og booke shelters.\r\n</p>");
#nullable restore
#line 12 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
 if (shelters == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p><b>Søgekriterier: </b></p>\r\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddMarkupContent(5, "<b>Navn: </b>");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "placeholder", "Shelter plads");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
                                                              shelternavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shelternavn = __value, shelternavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "p");
            __builder.AddMarkupContent(12, "<b>Antal pladser: </b>");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "placeholder", "Antal pladser min");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
                                                                           antal_min

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => antal_min = __value, antal_min));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(17, " - ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "placeholder", "Antal pladser max");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
                                                                                                                                        antal_max

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => antal_max = __value, antal_max));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "p");
            __builder.AddMarkupContent(24, "<b>Kommunenavn: </b>");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "placeholder", "Kommunenavn");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
                                                                   kom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => kom = __value, kom));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "<br>\r\n    <br>");
            __builder.OpenElement(30, "table");
            __builder.AddAttribute(31, "class", "table");
            __builder.AddMarkupContent(32, "<thead><tr><th>Shelterplads</th>\r\n                <th>Book nu</th></tr></thead>\r\n        ");
            __builder.OpenElement(33, "tbody");
#nullable restore
#line 38 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
             foreach (var shelter in GetFilteretItems(shelternavn, antal_min, antal_max, kom))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "tr");
            __builder.OpenElement(35, "td");
            __builder.AddMarkupContent(36, "<b>Navn: </b>");
            __builder.AddContent(37, 
#nullable restore
#line 42 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
                                      shelter.properties.navn

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "\r\n                        <br>\r\n                        ");
            __builder.AddMarkupContent(39, "<b>Antal pladser: </b>");
            __builder.AddContent(40, 
#nullable restore
#line 44 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
                                               shelter.properties.antal_pl

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(41, "\r\n                        <br>\r\n                        ");
            __builder.AddMarkupContent(42, "<b>Kommune: </b>");
            __builder.AddContent(43, 
#nullable restore
#line 46 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
                                         shelter.properties.cvr_navn

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "\r\n                        <br>\r\n                        ");
            __builder.AddMarkupContent(45, "<b>Beskrivelse: </b>");
            __builder.AddContent(46, 
#nullable restore
#line 48 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
                                             shelter.properties.beskrivels

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "class", "btn btn-success");
            __builder.AddAttribute(51, "href", 
#nullable restore
#line 51 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
                                                          string.Format("https://localhost:5001/booking/create/{0}", shelter._id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, "Book");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"

   
             
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
       
    private Shelter[] shelters;

    protected override async Task OnInitializedAsync()
    {
        shelters = await Http.GetFromJsonAsync<Shelter[]>("SheltersList");
    }

    public string shelternavn;
    public string kom;
    public string antal_min;
    public string antal_max;

    public List<Shelter> shelterToList()
    {
        List<Shelter> items = new();
        foreach (var shelter in shelters)
        {
            items.Add(shelter);
        };
        return items;
    }


    private List<Shelter> GetFilteretItems(string name, string antal_pl_min_s, string antal_pl_max_s, string kommune)
    {
        List<Shelter> unfilteretItems = shelterToList();
        List<Shelter> filteretItems = shelterToList();
        int antal_pl_min = 0;
        int antal_pl_max = 0;
        if (!string.IsNullOrEmpty(antal_pl_min_s))
        {
            antal_pl_min = int.Parse(antal_pl_min_s);
        }
        if (!string.IsNullOrEmpty(antal_pl_max_s))
        {
            antal_pl_max = int.Parse(antal_pl_max_s);
        }

        if (!string.IsNullOrEmpty(name) && antal_pl_min > 0 && antal_pl_max > 0 && !string.IsNullOrEmpty(kommune))
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.navn.ToLower().Contains(name.ToLower()) &&
                item.properties.antal_pl >= antal_pl_min &&
                item.properties.antal_pl <= antal_pl_max &&
                item.properties.cvr_navn.ToLower().Contains(kommune.ToLower())
                );
        }
        else if (!string.IsNullOrEmpty(name) && antal_pl_min > 0 && antal_pl_max > 0)
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.navn.ToLower().Contains(name.ToLower()) &&
                item.properties.antal_pl >= antal_pl_min &&
                item.properties.antal_pl <= antal_pl_max
                );
        }
        else if (!string.IsNullOrEmpty(name) && antal_pl_min > 0 && !string.IsNullOrEmpty(kommune))
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.navn.ToLower().Contains(name.ToLower()) &&
                item.properties.antal_pl >= antal_pl_min &&
                item.properties.cvr_navn.ToLower().Contains(kommune.ToLower())
                );
        }
        else if (!string.IsNullOrEmpty(name) && antal_pl_max > 0 && !string.IsNullOrEmpty(kommune))
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.navn.ToLower().Contains(name.ToLower()) &&
                item.properties.antal_pl <= antal_pl_max &&
                item.properties.cvr_navn.ToLower().Contains(kommune.ToLower())
                );
        }
        else if (antal_pl_min > 0 && antal_pl_max > 0 && !string.IsNullOrEmpty(kommune))
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.antal_pl >= antal_pl_min &&
                item.properties.antal_pl <= antal_pl_max &&
                item.properties.cvr_navn.ToLower().Contains(kommune.ToLower())
                );
        }
        else if (!string.IsNullOrEmpty(name) && antal_pl_min > 0)
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.navn.ToLower().Contains(name.ToLower()) &&
                item.properties.antal_pl >= antal_pl_min
                );
        }
        else if (!string.IsNullOrEmpty(name) && antal_pl_max > 0)
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.navn.ToLower().Contains(name.ToLower()) &&
                item.properties.antal_pl <= antal_pl_max
                );
        }
        else if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(kommune))
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.navn.ToLower().Contains(name.ToLower()) &&
                item.properties.cvr_navn.ToLower().Contains(kommune.ToLower())
                );
        }
        else if (antal_pl_min > 0 && antal_pl_max > 0)
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.antal_pl >= antal_pl_min &&
                item.properties.antal_pl <= antal_pl_max
                );
        }
        else if (antal_pl_min > 0 && !string.IsNullOrEmpty(kommune))
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.antal_pl >= antal_pl_min &&
                item.properties.cvr_navn.ToLower().Contains(kommune.ToLower())
                );
        }
        else if (antal_pl_max > 0 && !string.IsNullOrEmpty(kommune))
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.antal_pl <= antal_pl_max &&
                item.properties.cvr_navn.ToLower().Contains(kommune.ToLower())
                );
        }
        else if (!string.IsNullOrEmpty(name))
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.navn.ToLower().Contains(name.ToLower())
                );
        }
        else if (antal_pl_min > 0)
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.antal_pl >= antal_pl_min
                );
        }
        else if (antal_pl_max > 0)
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.antal_pl <= antal_pl_max
                );
        }
        else if (!string.IsNullOrEmpty(kommune))
        {
            filteretItems = unfilteretItems.FindAll(
                item =>
                item.properties.cvr_navn.ToLower().Contains(kommune.ToLower())
                );
        }
        return filteretItems;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
