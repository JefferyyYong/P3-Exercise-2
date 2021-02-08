<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="P3E2.aspx.cs" Inherits="P3_Exercise_2.P3E2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            width: 92px;
        }
        .auto-style3 {
            width: 121px;
        }
        .auto-style4 {
            width: 214px;
        }
        .auto-style6 {
            width: 85px;
        }
        .auto-style7 {
            width: 98px;
        }
        .auto-style8 {
            width: 107px;
        }
        .auto-style13 {
            height: 51px;
        }
        .auto-style14 {
            height: 51px;
            width: 83px;
        }
        .auto-style15 {
            width: 83px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <table>
            <tr>
                <td class="auto-style1">

                    <strong>FLYING BREAKFAST.COM</strong></td>
            </tr>

           <tr>
               <td>
                   
                   Order your breakfast online. Online order starts 2.00am - 11am everyday.</td>
           </tr>
       </table>
        <table>
            <tr>
                <td class="auto-style2">Breakfast Set</td>
                <td class="auto-style3">
                    <asp:RadioButtonList ID="rblSet" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rblSet_SelectedIndexChanged">
                        <asp:ListItem Value="1">Set 1</asp:ListItem>
                        <asp:ListItem Value="2">Set 2</asp:ListItem>
                        <asp:ListItem Value="3">Set 3</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>

        </table>
        <table>
            <tr>
                <td class="auto-style4">

                    <asp:Label ID="lblDetail" runat="server"></asp:Label>

                </td>
            </tr>
            <tr>
                <td>

                </td>
            </tr>
        </table>

        <table style="border:1px solid">
            <tr >
                <td class="auto-style8" style="border:1px solid"></td>
                <td class="auto-style6" style="border:1px solid">Quantity</td>
                <td class="auto-style7"style="border:1px solid">Total (RM)</td>
            </tr>

             <tr>
                <td class="auto-style8" style="border:1px solid">
                    <asp:CheckBox ID="set1" runat="server" Text="Set 1" AutoPostBack="True" OnCheckedChanged="set1_CheckedChanged" />
                 </td>
                <td class="auto-style6" style="border:1px solid">
                    <asp:TextBox ID="qs1" runat="server" Width="29px" AutoPostBack="True" OnTextChanged="qs1_TextChanged"></asp:TextBox>
                 </td>
                <td class="auto-style7" style="border:1px solid">
                    <asp:Label ID="lblPriceSet1" runat="server"></asp:Label>
                 </td>
            </tr>

             <tr>
                <td class="auto-style8" style="border:1px solid">
                    <asp:CheckBox ID="set2" runat="server" Text="Set 2" AutoPostBack="True" OnCheckedChanged="set2_CheckedChanged" />
                 </td>
                <td class="auto-style6" style="border:1px solid">
                    <asp:TextBox ID="qs2" runat="server" Width="29px" AutoPostBack="True" OnTextChanged="qs2_TextChanged"></asp:TextBox>
                 </td>
                <td class="auto-style7" style="border:1px solid">
                    <asp:Label ID="lblPriceSet2" runat="server"></asp:Label>
                 </td>
            </tr>
             <tr>
                <td class="auto-style8" style="border:1px solid">
                    <asp:CheckBox ID="set3" runat="server" Text="Set 3" AutoPostBack="True" OnCheckedChanged="set3_CheckedChanged" />
                 </td>
                <td class="auto-style6" style="border:1px solid">
                    <asp:TextBox ID="qs3" runat="server" Width="29px" AutoPostBack="True" OnTextChanged="qs3_TextChanged"></asp:TextBox>
                 </td>
                <td class="auto-style7" style="border:1px solid">
                    <asp:Label ID="lblPriceSet3" runat="server"></asp:Label>
                 </td>
            </tr>

            <tr>
                <td style="border:1px solid"></td>
                <td style="border:1px solid">

                    Total (RM)</td>
                <td style="border:1px solid">

                    <asp:Label ID="lblTotalPrice" runat="server"></asp:Label>

                </td>
            </tr>

           
        </table>
        <table>
             <tr>
                <td >


                    <asp:Button ID="calcBTN" runat="server" Text="Caculate" Width="80px" OnClick="calcBTN_Click" />

                </td>

                 <td >

                     <asp:Button ID="cancBTN" runat="server" Height="26px" Text="Cancel" OnClick="cancBTN_Click" />

                 </td>
            </tr>

            <tr>
                <td class="auto-style15"></td>
            </tr>
            

                  

                
            
        </table>
          <asp:Button ID="cOBTN" runat="server" Text="Confirm Order" OnClick="cOBTN_Click" PostBackUrl="~/ConfirmOrder.aspx" />
    </form>
</body>
</html>
