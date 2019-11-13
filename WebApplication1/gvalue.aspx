<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gvalue.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<!DOCTYPE html>
<html lang="tw">
    <head>
        <title></title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <script>
        function oAuth2() {
            var URL = 'https://notify-bot.line.me/oauth/authorize?';
            URL += 'response_type=code';
            URL += '&client_id=	FVtNJ2Jr8LxnCUQRk4lmOO'; //[YOUR_CLIENT_ID]
            URL += '&redirect_uri=https://ubot.liontravel.com.tw';  //[YOUR_CALLBACK_URL]
            URL += '&scope=notify';
            URL += '&state=NO_STATE';
            window.location.href = URL;
        }
    </script>
    </head>
    <body>
        <button onclick="oAuth2();"> 連結到 LineNotify 按鈕 </button>
    </body>
</html>
