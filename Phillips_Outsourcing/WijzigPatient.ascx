<%@ Control Language="C#" ClassName="WijzigPatient" %>
<style>
    #container {
        font-family: Arial;
    }

    .formItem {
        width: 550px;
    }

    .itemText {
        font-size: 16px;
        float: left;
        margin: 6px 0 0 35px;
        text-align: right;
        width: 150px;
    }

    .itemTb {
        float: right;
        margin: 0 0 0 10px;
        height: 30px;
        width: 350px;
        border: 1px solid blue;
    }

    .blocked {
        background-color: #808080;
    }
</style>
<div id="container" style="width: 1280px;">
    <div id="left-column" style="float: left; width: 600px; height: 600px;">
        <div class="formItem">
            <div class="itemText">ID: </div>
            <div class="itemTb">
                <asp:TextBox class="blocked" ID="IdTb" runat="server" Height="16px"></asp:TextBox>
            </div>
        </div>
        <div class="formItem">
            <div class="itemText">Voornaam: </div>
            <div class="itemTb">
                <asp:TextBox class="blocked" ID="FirstNameTb" runat="server" Height="16px"></asp:TextBox>
            </div>
        </div>
        <div class="formItem">
            <div class="itemText">Achternaam: </div>
            <div class="itemTb">
                <asp:TextBox class="blocked" ID="SurNameTb" runat="server" Height="16px"></asp:TextBox>
            </div>
        </div>
        <div class="formItem">
            <div class="itemText">Geslacht: </div>
            <div class="itemTb">
                <asp:TextBox class="blocked" ID="GenderTb" runat="server" Height="16px"></asp:TextBox>
            </div>
        </div>
        <div class="formItem">
            <div class="itemText">Lengte: </div>
            <div class="itemTb">
                <asp:TextBox class="blocked" ID="LengthTb" runat="server" Height="16px"></asp:TextBox>
            </div>
        </div>
        <div class="formItem">
            <div class="itemText">Gewicht: </div>
            <div class="itemTb">
                <asp:TextBox class="blocked" ID="WeightTb" runat="server" Height="16px"></asp:TextBox>
            </div>
        </div>
        <div class="formItem">
            <div class="itemText">Insuline Sensitivity: </div>
            <div class="itemTb">
                <asp:TextBox class="blocked" ID="InsulineTb" runat="server" Height="16px"></asp:TextBox>
            </div>
        </div>
        <div class="formItem">
            <div class="itemText">Adres: </div>
            <div class="itemTb">
                <asp:TextBox class="blocked" ID="AddressTb" runat="server" Height="16px"></asp:TextBox>
            </div>
        </div>
        <div class="formItem">
            <div class="itemText">Postcode: </div>
            <div class="itemTb">
                <asp:TextBox class="blocked" ID="ZipCodeTb" runat="server" Height="16px"></asp:TextBox>
            </div>
        </div>
        <div class="formItem">
            <div class="itemText">Tel. Nr: </div>
            <div class="itemTb">
                <asp:TextBox class="blocked" ID="PhoneTb" runat="server" Height="16px" OnLoad="PhoneTb_Load" OnTextChanged="PhoneTb_TextChanged"></asp:TextBox>
            </div>
        </div>
    </div>
    <div id="right-column" style="margin-left: 1px; float: left; width: 350px; height: 600px;">
        <asp:Image ID="ProfileImage" runat="server" />
    </div>
</div>
<% 
    
%>