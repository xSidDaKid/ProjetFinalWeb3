#pragma checksum "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aad33fb96a71b5ecf9f383980796365a38d904d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\_ViewImports.cshtml"
using ProjetSessionAppWeb3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\_ViewImports.cshtml"
using ProjetSessionAppWeb3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad33fb96a71b5ecf9f383980796365a38d904d9", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae25626b5c1ac6a46931894e67e0ddfd6e318fa2", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetSessionAppWeb3.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border border-dark rounded p-5 d-none mb-3 col-md-12 col-lg-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddChat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addChat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Room", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form d-none mt-3 border border-dark p-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
  
    ViewData["Title"] = "Chat";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"p-5 \">\r\n");
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"p-2 row justify-content-begin pb-2\">\r\n            <div class=\"col-2\">\r\n                <h4>Chats</h4>\r\n            </div>\r\n            <div class=\"offset-8 offset-lg-7\" col-2\">\r\n");
            WriteLiteral("                <button class=\" btn btn-primary\" id=\"buttonAddChat\" onclick=\"toggleAddChat()\">Add chat</button>\r\n            </div>\r\n        </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aad33fb96a71b5ecf9f383980796365a38d904d97063", async() => {
                WriteLiteral("\r\n            <div class=\"mb-3\">\r\n                <div class=\"mb-3\">\r\n                    <h3 class=\"text-center\">Add Chat</h3>\r\n                </div>\r\n");
#nullable restore
#line 30 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
                 if (ViewData["errorMessageCreateChat"] != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"mb-3 alert alert-danger text-white\">\r\n                        ");
#nullable restore
#line 33 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
                   Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 35 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"mb-3\">\r\n                    <label class=\"form-label \" type=\"text\">Chat Name:</label>\r\n                    <input type=\"text\" name=\"chatName\" id=\"chatName\" class=\"form-control\" />\r\n                </div>\r\n            </div>\r\n");
                WriteLiteral("            <div class=\" btn-group mb-3 float-right\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Create Chat</button>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 51 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
             foreach (var Chat in (IEnumerable<Chat>)ViewData["chats"])
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\" col-sm-12 col-lg-5 border border-primary rounded p-lg-4 p-3 mb-3 mr-2\"");
            BeginWriteAttribute("id", " id=\"", 2342, "\"", 2364, 2);
            WriteAttributeValue("", 2347, "chat_", 2347, 5, true);
#nullable restore
#line 53 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
WriteAttributeValue("", 2352, Chat.IdChat, 2352, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" >
                    <div class=""row"">
                        <div class=""text-begin col-3"">
                            <p>ID Chat:</p>
                        </div>
                        <div class=""text-begin col-1"">
                            ");
#nullable restore
#line 59 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
                       Write(Chat.IdChat);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"btn-group offset-4 col-4 float-right \">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aad33fb96a71b5ecf9f383980796365a38d904d912374", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aad33fb96a71b5ecf9f383980796365a38d904d912665", async() => {
                    WriteLiteral("\r\n                                    <i class=\"bi bi-box-arrow-in-right\"></i>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
                                                                                                          WriteLiteral(Chat.IdChat);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <button class=\"btn btn-primary\"");
            BeginWriteAttribute("id", " id=\"", 3151, "\"", 3179, 1);
#nullable restore
#line 68 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
WriteAttributeValue("", 3156, "button"+Chat.IdChat, 3156, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3180, "\"", 3223, 3);
            WriteAttributeValue("", 3190, "toggleAddUserToChat(", 3190, 20, true);
#nullable restore
#line 68 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
WriteAttributeValue("", 3210, Chat.IdChat, 3210, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3222, ")", 3222, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"bi bi-person-plus-fill\"></i>\r\n                            </button>\r\n");
            WriteLiteral("                        <button class=\"btn btn-sm btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3537, "\"", 3571, 3);
            WriteAttributeValue("", 3547, "deleteChat(", 3547, 11, true);
#nullable restore
#line 74 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
WriteAttributeValue("", 3558, Chat.IdChat, 3558, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3570, ")", 3570, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"bi-x\"></i>\r\n                        </button>\r\n                            \r\n");
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""text-begin col-6"">
                            <p>Nom du Chat:</p>
                        </div>
                        <div class=""text-right col-6"">
                            ");
#nullable restore
#line 88 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
                       Write(Chat.ChatName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""text-begin col-6"">
                            <p>ID du createur du chat:</p>
                        </div>
                        <div class=""text-right col-6"">
                            ");
#nullable restore
#line 96 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
                       Write(Chat.IdCreator);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""text-begin col-6"">
                            <p>Chat Creator Name:</p>
                        </div>
                        <div class=""text-right col-6"">
                            ");
#nullable restore
#line 104 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
                       Write(ViewBag.userSession.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row justify-content-center \">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aad33fb96a71b5ecf9f383980796365a38d904d920668", async() => {
                WriteLiteral("\r\n                            <div class=\"mb-3\">\r\n                                <h5 class=\"text-center\">Add a user to Chat ");
#nullable restore
#line 110 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
                                                                      Write(Chat.ChatName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            </div>\r\n                            <div class=\"mb-3\">\r\n                                <label class=\"form-label \" type=\"text\">User Id:</label>\r\n                                <input type=\"text\" name=\"userId\"");
                BeginWriteAttribute("id", " id=\"", 5470, "\"", 5499, 1);
#nullable restore
#line 114 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
WriteAttributeValue("", 5475, "addUser"+Chat.IdChat, 5475, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n                            </div>\r\n                            <div class=\" mb-3 float-right\">\r\n                                <button type=\"submit\" class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5700, "\"", 5737, 3);
                WriteAttributeValue("", 5710, "addUserToChat(", 5710, 14, true);
#nullable restore
#line 117 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
WriteAttributeValue("", 5724, Chat.IdChat, 5724, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5736, ")", 5736, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Create Chat</button>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 108 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
AddHtmlAttributeValue("", 5073, Chat.IdChat, 5073, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 122 "E:\Cégep\Session 9 - Rosemont\1 - Applications Web 3\Backups\AppWeb3SessionProject\ProjetSessionAppWeb3\Views\Chat\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            WriteLiteral(@"
<script>
    function toggleAddChat() {
        console.log('test');

        document.getElementById(""addChat"").classList.toggle('d-none');
        if (!document.getElementById(""addChat"").classList.contains('d-none')) {
            document.getElementById(""buttonAddChat"").classList.remove('btn-primary');
            document.getElementById(""buttonAddChat"").classList.add('btn-danger');
            document.getElementById(""buttonAddChat"").innerHTML = ""Close"";
        } else {
            document.getElementById(""buttonAddChat"").classList.remove('btn-danger');
            document.getElementById(""buttonAddChat"").classList.add('btn-primary');
            document.getElementById(""buttonAddChat"").innerHTML = ""Add Chat"";
        }
    }

    function toggleAddUserToChat(idChat) {
        document.getElementById(idChat).classList.toggle('d-none');
        if (!document.getElementById(idChat).classList.contains('d-none')) {
            document.getElementById(""button""+idChat).classList.remove('bt");
            WriteLiteral(@"n-primary');
            document.getElementById(""button""+idChat).classList.add('btn-danger');
        } else {
            document.getElementById(""button"" + idChat).classList.remove('btn-danger');
            document.getElementById(""button""+idChat).classList.add('btn-primary');
        }
    }

    function addUserToChat(idChat) {
        const xhr = new XMLHttpRequest();
        var idUser = document.getElementById(""addUser"" + idChat).value;
        console.log(idUser);
        console.log(idChat);
        const url = ""https://localhost:44384/Chat/AddUserToChat?idChat="" + idChat+""&idUser=""+idUser;
        xhr.open(""POST"", url, true);
        xhr.send(idChat, idUser);
    }

    function deleteChat(idChat) {
        console.log(idChat);
        const url = ""https://localhost:44384/Chat/DeleteChat?idChat="" + idChat;
        const xhr = new XMLHttpRequest();

        xhr.open(""DELETE"", url, true);
        xhr.send(idChat);
        var row = document.getElementById(""chat_"" + idChat);");
            WriteLiteral(@"
        row.parentNode.removeChild(row);
    }
    function buttonRoom(id) {
        //console.log(idChat);
        const url = ""https://localhost:44384/Chat/Room"";
        const xhr = new XMLHttpRequest();
        xhr.onload = function () { // listen for state changes
            if (this.status == 200) { // when completed we can move away
                window.location = ""Chat/Room/"" + id;
            }
        }
        xhr.open(""GET"", url, true);
        xhr.send();

    }


    //function createChat() {
    //    console.log(""test"");
    //    let xhr = new XMLHttpRequest();
    //    let chatname = document.getElementById(""chatName"").value;

    //    /*console.log(chatname.value + ""here"");*/
    //    if (chatname.value == undefined || chatname.value == null) {
    //        console.log(""closing chat here"");
    //        toggleAddChat();
    //    }
    //    else if (chatname.value != undefined || chatname.value != null) {

    //        console.log(chatname);

    //");
            WriteLiteral("        xhr.open(\"POST\", \'https://localhost:44384/Chat/Chat\');\r\n    //        xhr.setRequestHeader(\"Content-type\", \"application/x-www-form-urlencoded\");\r\n    //        xhr.send(\"chatName=\" + chatname.value);\r\n    //    }\r\n    //}\r\n\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetSessionAppWeb3.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
