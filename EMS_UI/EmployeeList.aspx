<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="EMS_UI.EmployeeList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Employees List</h2>
    <p>
        <asp:GridView ID="GridViewEmpList" runat="server" BackColor="black" BorderColor="#000099" BorderStyle="Dashed" CssClass="bg-primary"
            EmptyDataText="No employees Found" DataKeyNames="Number"  OnRowDeleting="GridViewEmpList_RowDeleting"
            >
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </p>
    <script>
        $(document).on("click", "a", function () {
            if (this.innerHTML.indexOf("Delete") == 0) {
                return confirm("Are you sure you want to delete");
            }
        });
    </script>
</asp:Content>
