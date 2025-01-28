<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .border-style {
    border-width: 3px;
    border-style: solid; 
    border-color: #0073e6;
}  .header{
     color:brown;
     font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
    text-align :center;
    text-decoration:none;
    text-decoration-color:black;
 }
 .caption_header{
     color:black;
     font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
     
     font-weight:bold;
     font-size:30px;
 }

    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
      <h1 class="header">Employee Management</h1>
            <div class="border-style">
               <div align ="center">
                <table>
                      <caption class="caption_header"> Managment</caption>

                    <tr>
                <td><asp:Label ID="Label1" runat="server">ID</asp:Label> </td>
                <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /> </td> </tr>
               <tr>
               <td> <asp:Label ID="Label2" runat="server">  Name</asp:Label></td>
               <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /> </td></tr>
               <tr> 
                <td> <asp:Label ID="Label3" runat="server">Email</asp:Label></td>
                <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /> </td> </tr>
                <tr> 
                <td><asp:Label ID="Label4" runat="server">Country</asp:Label></td>
                <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br /> </td> </tr>
                <tr> 
               <td><asp:Label ID="Label5" runat="server">ProjectID</asp:Label></td>
               <td> <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br /></td> </tr>
                <tr>
               <td><asp:Label ID="Label6" runat="server">  ManagerName</asp:Label></td>
               <td> <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td><br />
               
                   </tr>
                <tr>
               <td> <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" /></td>
                <td><asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" /></td>

                </tr>
                    </table>
                   </div>
            </div>
                </div>
            
            <div>
                <h2>Employee List</h2>
                <asp:GridView ID="gvEmployees" runat="server" AutoGenerateColumns="true" OnRowEditing="gvEmployees_RowEditing" OnRowDeleting="gvEmployees_RowDeleting" DataKeyNames="ID">
                    <Columns>
                           <asp:CommandField ShowDeleteButton="true" />
                    </Columns>
                </asp:GridView>
            </div>
      </form>
   
</body>
</html>
