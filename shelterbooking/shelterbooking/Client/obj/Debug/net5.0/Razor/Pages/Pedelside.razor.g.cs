<<<<<<< HEAD
#pragma checksum "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33eedc9aae2014db55abdd35b0c7f1c73666f3e7"
=======
#pragma checksum "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e8147d02d9005238dcdd57aab3e82a439b27880"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
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
#line 2 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
using shelterbooking.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
using System.Globalization;

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
<<<<<<< HEAD
#line 12 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 13 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
 if (shelters == null || bookings == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
<<<<<<< HEAD
#line 15 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 16 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
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
<<<<<<< HEAD
#line 18 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 19 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                              getSheltersList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Se Shelters");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
<<<<<<< HEAD
#line 19 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 20 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                              getBookingsList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Se bookings");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    <br>");
#nullable restore
<<<<<<< HEAD
#line 21 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 22 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
    if (typeList == 1)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<h2>Liste af alle shelters</h2>\r\n        ");
            __builder.AddMarkupContent(13, "<a href=\"https://localhost:5001/shelter/create\">Opret shelter</a>\r\n        ");
            __builder.AddMarkupContent(14, "<p><b>Søgekriterier: </b></p>\r\n        ");
            __builder.OpenElement(15, "p");
            __builder.AddMarkupContent(16, "<b>Navn: </b>");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "placeholder", "Shelter plads");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
<<<<<<< HEAD
#line 28 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 29 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                                  shelternavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shelternavn = __value, shelternavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "p");
            __builder.AddMarkupContent(23, "<b>Antal pladser: </b>");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "placeholder", "Antal pladser min");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
<<<<<<< HEAD
#line 29 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 30 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                                               antal_min

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => antal_min = __value, antal_min));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(28, " - ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "placeholder", "Antal pladser max");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
<<<<<<< HEAD
#line 29 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 30 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                                                                                                             antal_max

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => antal_max = __value, antal_max));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "p");
            __builder.AddMarkupContent(35, "<b>Kommunenavn: </b>");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "placeholder", "Kommunenavn");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
<<<<<<< HEAD
#line 30 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 31 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                                       kom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => kom = __value, kom));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(40, "table");
            __builder.AddAttribute(41, "class", "table");
            __builder.AddMarkupContent(42, "<thead><tr><th>Shelterplads</th>\r\n                    <th>Funktioner</th></tr></thead>\r\n            ");
            __builder.OpenElement(43, "tbody");
            __builder.AddMarkupContent(44, "<tr><td></td></tr>");
#nullable restore
<<<<<<< HEAD
#line 45 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 46 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                 foreach (var shelter in GetFilteretItems(shelternavn, antal_min, antal_max, kom))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "tr");
            __builder.OpenElement(46, "td");
            __builder.AddMarkupContent(47, "<b>Navn:</b> ");
            __builder.AddContent(48, 
#nullable restore
<<<<<<< HEAD
#line 49 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 50 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                          shelter.properties.navn

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(49, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(50, "<b>Beskrivelse:</b> ");
            __builder.AddContent(51, 
#nullable restore
<<<<<<< HEAD
#line 51 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 52 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                 shelter.properties.beskrivels

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(52, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(53, "<b>Kommune:</b> ");
            __builder.AddContent(54, 
#nullable restore
<<<<<<< HEAD
#line 53 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 54 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                             shelter.properties.cvr_navn

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(55, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(56, "<b>Antal pladser:</b> ");
            __builder.AddContent(57, 
#nullable restore
<<<<<<< HEAD
#line 55 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 56 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                   shelter.properties.antal_pl

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(58, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(59, "<b>Ledig:</b> Yes\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(60, "<b>Ansvarlig:</b> ");
            __builder.AddContent(61, 
#nullable restore
<<<<<<< HEAD
#line 59 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 60 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                               shelter.properties.ansva_v

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "td");
            __builder.AddMarkupContent(64, "<button class=\"btn btn-primary\">Se bookings</button>\r\n                            <br>\r\n                            ");
            __builder.OpenElement(65, "a");
            __builder.AddAttribute(66, "class", "btn btn-primary");
            __builder.AddAttribute(67, "href", 
#nullable restore
<<<<<<< HEAD
#line 64 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 65 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                              string.Format("https://localhost:5001/shelter/edit/{0}", shelter._id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(68, "Ret shelter");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                            <br>\r\n                            ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "btn btn-primary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
<<<<<<< HEAD
#line 66 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 67 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                                      () => ShelDelete(shelter._id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, "Slet shelter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
<<<<<<< HEAD
#line 69 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 70 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
<<<<<<< HEAD
#line 72 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 73 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
    }
    else if (typeList == 2)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(74, "<h2>Liste af alle bookings</h2>");
            __builder.OpenElement(75, "table");
            __builder.AddAttribute(76, "class", "table");
            __builder.AddMarkupContent(77, "<thead><tr><th>Booking</th>\r\n                    <th>Funktioner</th></tr></thead>\r\n            ");
            __builder.OpenElement(78, "tbody");
            __builder.AddMarkupContent(79, "<tr><td></td></tr>");
#nullable restore
<<<<<<< HEAD
#line 89 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 90 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                 foreach (var booking in bookings)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(80, "tr");
            __builder.OpenElement(81, "td");
            __builder.AddMarkupContent(82, "<b>Booking id:</b> ");
            __builder.AddContent(83, 
#nullable restore
<<<<<<< HEAD
#line 93 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 94 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                booking._id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(84, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(85, "<b>Shelter navn:</b> ");
            __builder.AddContent(86, 
#nullable restore
<<<<<<< HEAD
#line 95 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 96 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                  getShelterNavn(booking.shelter_id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(87, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(88, "<b>Fulde navn:</b> ");
            __builder.AddContent(89, 
#nullable restore
<<<<<<< HEAD
#line 97 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 98 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                booking.fuldenavn

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(90, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(91, "<b>Telefon:</b> ");
            __builder.AddContent(92, 
#nullable restore
<<<<<<< HEAD
#line 99 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 100 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                             booking.telefon

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(93, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(94, "<b>Kommentare:</b> ");
            __builder.AddContent(95, 
#nullable restore
<<<<<<< HEAD
#line 101 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 102 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                booking.kommentar

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(96, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(97, "<b>Start dato:</b> ");
            __builder.AddContent(98, 
#nullable restore
<<<<<<< HEAD
#line 103 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 104 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                booking.startdato

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(99, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(100, "<b>Slut dato:</b> ");
            __builder.AddContent(101, 
#nullable restore
<<<<<<< HEAD
#line 105 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 106 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                               booking.slutdato

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.OpenElement(103, "td");
            __builder.OpenElement(104, "a");
            __builder.AddAttribute(105, "class", "btn btn-primary");
            __builder.AddAttribute(106, "href", 
#nullable restore
<<<<<<< HEAD
#line 108 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 109 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                              string.Format("https://localhost:5001/booking/edit/{0}", booking._id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(107, "Ret booking");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                            <br>\r\n                            ");
            __builder.OpenElement(109, "button");
            __builder.AddAttribute(110, "class", "btn btn-primary");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
<<<<<<< HEAD
#line 110 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 111 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                                                                      () => BookDelete(booking._id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(112, "Slet booking");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
<<<<<<< HEAD
#line 113 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 114 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
<<<<<<< HEAD
#line 116 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 117 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 119 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\Pedelside.razor"
=======
#line 120 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/Pedelside.razor"
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
       
    private Shelter[] shelters;
    private Booking[] bookings;

    protected override async Task OnInitializedAsync()
    {
        shelters = await Http.GetFromJsonAsync<Shelter[]>("SheltersList");
        bookings = await Http.GetFromJsonAsync<Booking[]>("BookingsList");
    }

    async Task ShelDelete(string shelId)
    {
        var shel = shelters.First(x => x._id == shelId);
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete shelter {shel.properties.navn}?"))
        {
            await Http.DeleteAsync($"api/shelters/{shelId}");
            await OnInitializedAsync();
        }
    }
    async Task BookDelete(string bookId)
    {
        var book = bookings.First(x => x._id == bookId);
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete this booking {book._id} for {book.fuldenavn}?"))
        {
            await Http.DeleteAsync($"api/bookings/{bookId}");
            await OnInitializedAsync();
        }
    }
    public void findBookings(Shelter shel)
    {
        foreach(var booking in bookings)
        {
            if(booking.shelter_id == shel._id)
            {
                DateTime start = DateTime.ParseExact(booking.startdato, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime slut = DateTime.ParseExact(booking.slutdato, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (start == DateTime.Now)
                {

                    shel.properties.ledighed = false;
                }
                else
                {
                    shel.properties.ledighed = true;

                }
            }
        }
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
    public string updateShelter(string id)
    {
        return id;
    }
    public string getShelterNavn(string id)
    {
        foreach (var shel in shelters)
        {
            if(shel._id == id)
            {
                return shel.properties.navn;
            }
        }
        return "ukendt navn";
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
