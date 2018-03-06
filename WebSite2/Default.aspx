<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript"> 
        function validEntry() {
            if (document.getElementById("firstNameTextBox").value == "" || document.getElementById("lastNameTextBox") == "" ||
                document.getElementById("emailTextBox") == "" || document.getElementById("phoneTextBox") == "") {
                alert("Please add in values");
            }
        }
    </script>
    <title>Default</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Please add in a contact as you wish</p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"  Text="Contact List" />
            <br />
            <p>Enter first name</p>
            <asp:TextBox ID="firstNameTextBox" Text="" runat="server" />
            <p>Enter last name</p>
            <asp:TextBox ID="lastNameTextBox" Text="" runat="server" />
            <p>Enter email</p>
            <asp:TextBox ID="emailTextBox" Text="" runat="server" />
            <p>Enter phone number</p>
            <asp:TextBox ID="phoneTextBox" Text="" runat="server" />

            <br />
            <asp:Button ID="registerButton" Text="SAVE" onclientclick="validEntry()" runat="server" OnClick="registerEventMethod" />
            <br />
            <br />
            <br />

        </div>
    </form>
</body>
</html>
