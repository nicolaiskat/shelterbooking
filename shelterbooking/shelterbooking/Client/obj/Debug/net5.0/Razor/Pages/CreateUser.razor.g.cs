<<<<<<< HEAD
#pragma checksum "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\CreateUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c91c3c433633b063d88db5eb117dc67f68a2557"
=======
#pragma checksum "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee6ddb60a6e73bb28134e0f166f587e39afa6583"
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
#line 5 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\CreateUser.razor"
using shelterbooking.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createuser")]
    public partial class CreateUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateUser</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Fornavn:\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "placeholder", "Fornavn");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\CreateUser.razor"
                                        user.fornavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.fornavn = __value, user.fornavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    <br>\r\n    Efternavn:\r\n    ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "placeholder", "Efternavn");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\CreateUser.razor"
                                          user.efternavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.efternavn = __value, user.efternavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    <br>\r\n    Mobil:\r\n    ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "placeholder", "Mobilnummer");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\CreateUser.razor"
                                            user.mobil

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.mobil = __value, user.mobil));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    <br>\r\n    Email:\r\n    ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "placeholder", "Email");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\CreateUser.razor"
                                      user.email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.email = __value, user.email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    <br>\r\n    Password:\r\n    ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "placeholder", "Password");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\CreateUser.razor"
                                         user.password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.password = __value, user.password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
<<<<<<< HEAD
            __builder.AddMarkupContent(27, "\r\n    <br>\r\n    ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "class", "btn btn-primary");
=======
            __builder.AddMarkupContent(27, "\n    <br>\n    ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-success");
>>>>>>> 6f86d78077fa1e33c46654b8590efdb803ed1c08
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\CreateUser.razor"
                                         CreateBruger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Login");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\CreateUser.razor"
       

    public Bruger user = new();

    async Task CreateBruger()
    {
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to create user {user.fornavn}?"))
        {
            await Http.PostAsJsonAsync("api/users", new Bruger(user.fornavn, user.efternavn, user.mobil, user.email, user.password, user.level));
            await js.InvokeVoidAsync("alert", $"Created successfully!");
            uriHelper.NavigateTo("login");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
    }
}
#pragma warning restore 1591
