<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditEmployee.aspx.cs" Inherits="EMS_UI.EditEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit Employee</h2>
    <p>Enter Employee ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxEmpID" runat="server" TextMode="Number" ValidationGroup="SearchGroup"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonGetEmpID" runat="server" OnClick="ButtonGetEmpID_Click" Text="search" CausesValidation="False" ValidationGroup="SearchGroup" />
    </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBoxEmpID" ErrorMessage="RequiredFieldValidator" ForeColor="Red">ID Required</asp:RequiredFieldValidator>
    </p>
    <table>
        <tr>
            <td>Name </td>
            <td>
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox> </td>
            <td style="width: 173px"> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxName" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="UpdateGroup">Name is required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td> Email</td>
            <td> 
                <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            </td>
            <td style="width: 173px"> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="UpdateGroup">email is required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td> Gender</td>
            <td> 
                <asp:RadioButtonList ID="RadioButtonListGender" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>TransGender</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td style="width: 173px"> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="RadioButtonListGender" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="UpdateGroup">Select gender </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Department</td>
            <td> 
                <asp:DropDownList ID="DropDownListDepartment" runat="server" DataTextField="name" DataValueField="Departmentid">
                </asp:DropDownList>
            </td>
            <td style="width: 173px"> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownListDepartment" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="UpdateGroup">Select a Depaetment</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td> Date Of Birth</td>
            <td> 
                <asp:TextBox ID="TextBoxDateOfBirth" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td style="width: 173px"> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxDateOfBirth" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="UpdateGroup">dob required</asp:RequiredFieldValidator>
                <br />
                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBoxDateOfBirth" ErrorMessage="RangeValidator" ForeColor="Red" Type="Date" ValidationGroup="UpdateGroup">should be in past</asp:RangeValidator>
                <br />
            </td>
        </tr>
        <tr>
            <td> Date Of Joining</td>
            <td> 
                <asp:TextBox ID="TextBoxDateOfJoining" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td style="width: 173px"> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxDateOfJoining" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="UpdateGroup">doj required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Manager</td>
            <td> 
                <asp:DropDownList ID="DropDownListManager" runat="server" DataTextField="name" DataValueField="Number">
                </asp:DropDownList>
            </td>
            <td style="width: 173px"> &nbsp;</td>
        </tr>
        <tr>
            <td> Phone</td>
            <td> <asp:TextBox ID="TextBoxPhone" runat="server" TextMode="Phone"></asp:TextBox></td>
            <td style="width: 173px"> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="UpdateGroup">phone is required</asp:RequiredFieldValidator>
                <br />
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="9999999999" MinimumValue="1000000000" Type="Double" ValidationGroup="UpdateGroup">should be 10 digits</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td> Salary</td>
            <td> 
                <asp:TextBox ID="TextBoxSalary" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td style="width: 173px"> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBoxSalary" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="UpdateGroup">Salary required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td> Commission</td>
            <td> 
                <asp:TextBox ID="TextBoxCommission" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td style="width: 173px"> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBoxCommission" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="UpdateGroup">commission required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td> JobTitle</td>
            <td> 
                <asp:DropDownList ID="DropDownListJobtitle" runat="server">
                    <asp:ListItem>Manager</asp:ListItem>
                    <asp:ListItem>Developer</asp:ListItem>
                    <asp:ListItem>Analyst</asp:ListItem>
                    <asp:ListItem>Salesman</asp:ListItem>
                    <asp:ListItem>Tester</asp:ListItem>
                    <asp:ListItem>senior developer </asp:ListItem>
                    <asp:ListItem>accountant</asp:ListItem>
                    <asp:ListItem>cashier</asp:ListItem>
                    <asp:ListItem>head</asp:ListItem>
                    <asp:ListItem>CEO</asp:ListItem>
                    <asp:ListItem>president</asp:ListItem>
                    <asp:ListItem>COO</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 173px"> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="DropDownListJobtitle" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="UpdateGroup">Select Jobtitle</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td> </td>
            <td> 
                <asp:Button ID="ButtonUpdate" runat="server" Text="Update"  ValidationGroup="UpdateGroup" OnClick="ButtonUpdate_Click" />
            </td>
            <td style="width: 173px"> 
                <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" CausesValidation="False"  />
            </td>
        </tr>
    </table>

</asp:Content>
