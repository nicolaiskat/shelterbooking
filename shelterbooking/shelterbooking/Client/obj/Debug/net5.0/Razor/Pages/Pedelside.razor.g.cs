#pragma checksum "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "329490bc969cdf819c182247e253be5a48260e38"
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
#line 2 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
using shelterbooking.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pedelside")]
    public partial class Pedelside : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Pedel side</h1>");
#nullable restore
#line 9 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
     if (shelters == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                  getSheltersList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Se Shelters");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                  getBookingsList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Se bookings");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        <br>");
#nullable restore
#line 18 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
        if (typeList == 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<h2>Liste af alle shelters</h2>");
            __builder.AddMarkupContent(13, "<p><b>Søgekriterier: </b></p>\r\n            ");
            __builder.OpenElement(14, "p");
            __builder.AddMarkupContent(15, "<b>Navn: </b>");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "placeholder", "Shelter plads");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                                      shelternavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shelternavn = __value, shelternavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "p");
            __builder.AddMarkupContent(22, "<b>Antal pladser: </b>");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "placeholder", "Antal pladser min");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                                                   antal_min

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => antal_min = __value, antal_min));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(27, " - ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "placeholder", "Antal pladser max");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                                                                                                                 antal_max

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => antal_max = __value, antal_max));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "p");
            __builder.AddMarkupContent(34, "<b>Kommunenavn: </b>");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "placeholder", "Kommunenavn");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                                           kom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => kom = __value, kom));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table");
            __builder.AddMarkupContent(41, "<thead><tr><th>Shelterplads</th>\r\n                        <th>Funktioner</th></tr></thead>\r\n                ");
            __builder.OpenElement(42, "tbody");
            __builder.AddMarkupContent(43, "<tr><td></td></tr>");
#nullable restore
#line 42 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                     foreach (var shelter in GetFilteretItems(shelternavn, antal_min, antal_max, kom))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "tr");
            __builder.OpenElement(45, "td");
            __builder.AddMarkupContent(46, "<b>Navn:</b> ");
#nullable restore
#line 46 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
__builder.AddContent(47, shelter.properties.navn);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, "\r\n                                <br>\r\n                                ");
            __builder.AddMarkupContent(49, "<b>Beskrivelse:</b> ");
#nullable restore
#line 48 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
__builder.AddContent(50, shelter.properties.beskrivels);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "\r\n                                <br>\r\n                                ");
            __builder.AddMarkupContent(52, "<b>Kommune:</b> ");
#nullable restore
#line 50 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
__builder.AddContent(53, shelter.properties.cvr_navn);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "\r\n                                <br>\r\n                                ");
            __builder.AddMarkupContent(55, "<b>Antal pladser:</b> ");
#nullable restore
#line 52 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
__builder.AddContent(56, shelter.properties.antal_pl);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(57, "\r\n                                <br>\r\n                                ");
            __builder.AddMarkupContent(58, "<b>Ledig:</b> Yes\r\n                                <br>\r\n                                ");
            __builder.AddMarkupContent(59, "<b>Ansvarlig:</b> ");
#nullable restore
#line 56 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
__builder.AddContent(60, shelter.properties.ansva_v);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                            ");
            __builder.OpenElement(62, "td");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "class", "btn btn-primary");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                                          () => getBookings(shelter._id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, "Se bookings");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "class", "btn btn-primary");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                                          () => updateShelter(shelter._id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(71, "Ret shelter");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "class", "btn btn-primary");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                                          () => deleteShelter(shelter._id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "Slet shelter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
        }
        else if (typeList == 2)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(77, "<h2>Liste af alle bookings</h2>");
            __builder.OpenElement(78, "table");
            __builder.AddAttribute(79, "class", "table");
            __builder.AddMarkupContent(80, "<thead><tr><th>Booking</th>\r\n                        <th>Funktioner</th></tr></thead>\r\n                ");
            __builder.OpenElement(81, "tbody");
            __builder.AddMarkupContent(82, "<tr><td></td></tr>");
#nullable restore
#line 86 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                     foreach (var booking in shelters)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "tr");
            __builder.AddMarkupContent(84, "<td>\r\n                                booking eks.\r\n                            </td>\r\n                            ");
            __builder.OpenElement(85, "td");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "class", "btn btn-primary");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                                          () => getShelter(booking._id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "Se bookings");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "class", "btn btn-primary");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                                          () => updateBooking(booking._id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(94, "Ret shelter");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(96, "button");
            __builder.AddAttribute(97, "class", "btn btn-primary");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                                          () => deleteBooking(booking._id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(99, "Slet shelter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 100 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 103 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
        }

    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
           
        private Shelter[] shelters;
        private Booking[] bookings;

        protected override async Task OnInitializedAsync()
        {
            shelters = await Http.GetFromJsonAsync<Shelter[]>("SheltersList");



            

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
                                                                              
        }

        public string shelternavn;
        public string kom;
        public string antal_min;
        public string antal_max;
        public int typeList = 1;
        public void getSheltersList()
        {
            typeList = 1;
        }
        public void getBookingsList()
        {
            typeList = 2;
        }

        public void getBookings(string id)
        {

        }
        public void updateShelter(string id)
        {

        }
        public void deleteShelter(string id)
        {

        }
        public void getShelter(string id)
        {

        }
        public void updateBooking(string id)
        {

        }
        public void deleteBooking(string id)
        {

        }

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
