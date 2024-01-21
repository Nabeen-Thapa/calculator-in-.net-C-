<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator_aspx.aspx.cs" Inherits="Calculator_Asp.Calculator_aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <link href="Calculatoraspx_css.css" rel="stylesheet" />
    <style>
        body {
    margin:0px;
    padding: 0px;
    align-content:center;
}

#calculator {
    padding:20px;
    background-color:deepskyblue;
    height:220px;
    width:15%;
    margin-left:300px;
}
#firstnum{
    margin-top:10px;
   background-color:white;
    Border:1px solid blue;
    width:80%;   
}
#secondnum {
    margin-top: 30px;
    background-color: white;
    Border: 1px solid blue;
    width: 80%;
   margin-bottom:10px;
}
#idoutput1 {
    margin-top:20px;
    margin-bottom:20px;
    display:block;
    
}
#idbutton, #idbutton1 {
    display: block;
    margin-top:10px;
}
#idadd, #idsub, #iddiv, #idmul
{
   
    width:90px;  
    margin:5px;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div runat="server" id="calculator">
           <asp:TextBox runat="server" id="firstnum"/>
           <asp:TextBox runat="server" id="secondnum"/>
                <span runat="server" id="idoutput1"></span> 
           <div runat="server" id="idbutton">
               <asp:Button Text="Add" runat="server" id="idadd" OnClick="add_click"/>
                <asp:Button Text="Subtract" runat="server" id="idsub" OnClick="sub_click"/>
            </div>
            <div runat="server" id="idbutton1">
               <asp:Button Text="Divide" runat="server" id="iddiv" OnClick="div_click"/>
               <asp:Button Text="Multiply" runat="server" id="idmul" OnClick="mul_click"/>
           </div><br />
           
       </div>
    </form>
    
</body>
</html>
