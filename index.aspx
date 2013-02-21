<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Salary Calculator</title>
    <link rel="stylesheet" type="text/css" href="styleSheet.css" />
</head>
<body>

    <h1>Salary Calculator</h1> 
    <form id="form1" runat="server">
    <div>
    
        <br />
        Hourly Wage:<br />
        <asp:TextBox ID="hourlyWage" runat="server"></asp:TextBox>
        <br />
        <br />
        Numbers of Hours for this week:<br />
        <asp:TextBox ID="numberOfHours" runat="server"></asp:TextBox>
        <br />
        <br />
        Pre-tax Deductions:<br />
        <asp:TextBox ID="pretaxDeduction" runat="server"></asp:TextBox>
        <br />
        <br />
        After-tax Deductions:<br />
        <asp:TextBox ID="aftertaxDeduction" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="calculate" runat="server" Text="Calculate" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Clear" runat="server" Text="Clear" />
        <br />
        <br />
        <asp:Label ID="resultLable" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
