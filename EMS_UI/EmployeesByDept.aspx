<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeesByDept.aspx.cs" Inherits="EMS_UI.EmployeesByDept" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Employees By Department</h2>
    <div>

        Select Department&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListDepts" runat="server" DataTextField="name" DataValueField="Departmentid">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonSearch" runat="server" OnClick="ButtonSearch_Click" Text="Search" />
        <br />
        <br />
        <asp:Label ID="LabelDeptName" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridViewEmployees" runat="server" EmptyDataText="no employees found">
        </asp:GridView>

    </div>
</asp:Content>
