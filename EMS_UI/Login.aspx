<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EMS_UI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
<h4 style="font-size: medium">Log In</h4>
         <hr />
         <asp:PlaceHolder runat="server" ID="LoginStatus" Visible="false">
            <p>
               <asp:Literal runat="server" ID="StatusText" />
            </p>
         </asp:PlaceHolder>
         <asp:PlaceHolder runat="server" ID="LoginForm">
            <div style="margin-bottom: 10px">
               <asp:Label runat="server" AssociatedControlID="UserName">User name</asp:Label>
               <div>
                  <asp:TextBox runat="server" ID="UserName"/>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" ControlToValidate="UserName" runat="server" ErrorMessage=" UserName Required"></asp:RequiredFieldValidator>
               </div>
            </div>
            <div style="margin-bottom: 10px">
               <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" ControlToValidate="Password" runat="server" ErrorMessage="Password RequiredField" ></asp:RequiredFieldValidator>
                <div>
                  <asp:TextBox runat="server" ID="Password" TextMode="Password" />
               </div>
            </div>
            <div style="margin-bottom: 10px">
               <div>
                  <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="Log in" />
               </div>
                <div>
                  <asp:Button ID="ButtonRegister" runat="server"  CausesValidation="false" OnClick="ButtonRegister_Click" Text="Register" />
               </div>
            </div>
         </asp:PlaceHolder>
      </div>
</asp:Content>
