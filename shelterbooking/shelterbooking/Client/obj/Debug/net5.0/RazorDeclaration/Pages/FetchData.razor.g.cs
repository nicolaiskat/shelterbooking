// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace shelterbooking.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using shelterbooking.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using shelterbooking.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\FetchData.razor"
       
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
