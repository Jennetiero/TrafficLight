<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrafficLight.aspx.cs" Inherits="TrafficLight.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 377px;
            width: 628px;
            display: flex;
        }
        #form1 > div {
            padding-right: 5px;
        }
        #RedLight, #YellowLight, #GreenLight {
            height: 79px;
            width: 80px;
            margin: 5px 0;
        }
    </style>
</head>
<body style="height: 555px">
    <form id="form1" runat="server">
     <div runat="server" id="myDiv">
        </div>        
    </form>
</body>
</html>
