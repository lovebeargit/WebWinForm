<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mainpage.aspx.cs" Inherits="webwinform.Mainpage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<%--<script type="text/javascript">
    function OpenOrderPopup(D, B) 
    {
        var F = document.URL;

        var A = window.open(F + "?OpenMode=" + D + "&StudentId=" + B, "Winform","width=1040,height=700,top=0,left=0,toolbar=no,status=no,menubar=no,scrollbars=no,resizable=yes");
        A.focus()
    } 
</script>--%>
<body>
    <form id="form1" runat="server">
    <div>
        <%--<asp:HyperLink ID="h_add" runat="server" NavigateUrl="javascript:OpenOrderPopup('CreationModeManual', -1);" >Add</asp:HyperLink> the student name.
    --%>
    
    </div>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
