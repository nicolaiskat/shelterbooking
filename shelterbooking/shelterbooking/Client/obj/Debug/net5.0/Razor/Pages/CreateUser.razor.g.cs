<<<<<<< HEAD
<<<<<<< HEAD
#pragma checksum "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46e2d997ae3a17c9bf02537278ae69173f8e548f"
=======
#pragma checksum "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee6ddb60a6e73bb28134e0f166f587e39afa6583"
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)
=======
#pragma checksum "C:\Users\Nicolai Skat\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\CreateUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c91c3c433633b063d88db5eb117dc67f68a2557"
>>>>>>> parent of f085d83 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)
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
#line 1 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using shelterbooking.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/_Imports.razor"
using shelterbooking.Client.Shared;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
#nullable restore
#line 5 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
using shelterbooking.Shared;

#line default
#line hidden
#nullable disable
=======
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)
    [Microsoft.AspNetCore.Components.RouteAttribute("/createuser")]
    public partial class CreateUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
<<<<<<< HEAD
            __builder.AddMarkupContent(0, "<h3>CreateUser</h3>\n\n");
=======
            __builder.AddMarkupContent(0, "<h3>CreateUser</h3>\n\n ");
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\n    Fornavn:\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "placeholder", "Fornavn");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
<<<<<<< HEAD
#line 11 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                        user.fornavn
=======
#line 6 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                         fornavn
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fornavn = __value, fornavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    <br>\n    Efternavn:\n    ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "placeholder", "Efternavn");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
<<<<<<< HEAD
#line 14 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                          user.efternavn
=======
#line 9 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                           efternavn
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => efternavn = __value, efternavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    <br>\n    Mobil:\n    ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "placeholder", "Mobilnummer");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
<<<<<<< HEAD
#line 17 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                            user.mobil
=======
#line 12 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                             mobil
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mobil = __value, mobil));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n    <br>\n    Email:\n    ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "placeholder", "Email");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
<<<<<<< HEAD
#line 20 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                      user.email
=======
#line 15 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                       email
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
<<<<<<< HEAD
            __builder.AddMarkupContent(22, "\n    <br>\n    Password:\n    ");
=======
            __builder.AddMarkupContent(22, "\n    <br>\n    Password: \n     ");
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "placeholder", "Password");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
<<<<<<< HEAD
#line 23 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                         user.password
=======
#line 18 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                           password
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
<<<<<<< HEAD
            __builder.AddMarkupContent(27, "\n    <br>\n    ");
<<<<<<< HEAD
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                         CreateBruger
=======
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-success");
=======
            __builder.AddMarkupContent(27, "\r\n    <br>\r\n    ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "class", "btn btn-primary");
>>>>>>> parent of f085d83 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
                                              getUser
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Create");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 28 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
=======
#line 23 "/Users/nicolaiskat/Projects/miniprojekt/projekt/shelterbooking/shelterbooking/Client/Pages/CreateUser.razor"
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)
       

    public string fornavn;
    public string efternavn;
    public string mobil;
    public string email;
    public string password;
    public void getUser() { }

<<<<<<< HEAD
    async Task CreateBruger()
    {
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to create user {user.fornavn}?"))
        {
            await Http.PostAsJsonAsync("api/users", new Bruger(user.fornavn, user.efternavn, user.mobil, user.email, user.password, user.level));
            await js.InvokeVoidAsync("alert", $"Created successfully!");
            uriHelper.NavigateTo("/");
        }
    }
=======
>>>>>>> parent of b7b4e38 (Merge branch 'main' of https://github.com/nicolaiskat/shelterbooking)

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
