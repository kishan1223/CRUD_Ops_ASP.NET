<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUD_Ops._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div style="font-size:x-large" align="center"> Student Info Manage Form</div>
        <br />


        <table class="w-100">
            <tr>
                <td style="width: 534px">Student ID</td>
                <td>
                    <asp:TextBox ID="Student_ID" runat="server" Font-Size="Medium" Width="363px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Student_ID" ErrorMessage="Mandatory Field"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 534px; height: 41px;">Student Name</td>
                <td style="height: 41px">
                    <asp:TextBox ID="Student_Name" runat="server" Font-Size="Medium" Width="363px"></asp:TextBox>
                &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 534px">Address</td>
                <td>
                    <asp:DropDownList ID="Student_Address" runat="server" Width="118px">
                        <asp:ListItem Selected="True"></asp:ListItem>
                        <asp:ListItem>U.K.</asp:ListItem>
                        <asp:ListItem>India</asp:ListItem>
                    </asp:DropDownList>
                &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 534px">Age</td>
                <td>
                    <asp:TextBox ID="Student_Age" runat="server" Font-Size="Medium" Width="363px"></asp:TextBox>
                &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 534px">Contact</td>
                <td>
                    <asp:TextBox ID="Student_Contact" runat="server" Font-Size="Medium" Width="363px"></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Student_Contact" ErrorMessage="It Should Be 10 Digits" ValidationExpression="^\d{10}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 534px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="#9933FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button1_Click" Text="INSERT" />
                &nbsp;<asp:Button ID="Button2" runat="server" BackColor="#9933FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button2_Click" Text="UPDATE" />
                &nbsp;<asp:Button ID="Button3" runat="server" BackColor="#9933FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button3_Click" Text="DELETE" />
                &nbsp;<asp:Button ID="Button4" runat="server" BackColor="#9933FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Button4_Click" Text="SEARCH" />
                </td>
            </tr>
        </table>

    </div>
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" HorizontalAlign="center">
    </asp:GridView>
</asp:Content>
