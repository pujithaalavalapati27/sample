<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SELECT1.aspx.cs" Inherits="select.SELECT1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Search"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <%-- <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />--%>
             <asp:Label ID="Label2" runat="server" Text="ID" ></asp:Label>
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             <asp:Label runat="server" Text="DOB"></asp:Label>
             <asp:TextBox ID="TextBox3" runat="server" textmode="Date"></asp:TextBox>

            <asp:Button ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" />
          
          
        </div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:Label ID="lblNoResults" runat="server" ForeColor="Red" Visible="false" Text="No results found."></asp:Label>

    </form>
</body>
</html>
