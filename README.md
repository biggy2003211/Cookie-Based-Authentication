# Cookie-Based-Authentication
使用 ASP.NET WEP API2 架構，基於 Cookie-Based-Authentication 上實現多角色權限驗證功能 。

使用 SHA256 進行雜湊加密。

使用 Dapper 套件與資料庫連線叫用預存程序取得資料。

自定義 AuthorizeAttribute 屬性以便將 Enums 型態資料當參數傳入。

![image](https://github.com/biggy2003211/Cookie-Based-Authentication/blob/master/VipMemberOrMember.png)


【參考文章】
* [C#][ASP.NET] Web API 開發心得 (4) - 使用 FormsAuthentication 進行 API 授權驗證
  
  https://ithelp.ithome.com.tw/articles/10198150
* ASP.NET Web API 2 - Enum Authorize Attribute
  
  http://jasonwatmore.com/post/2014/02/18/aspnet-web-api-2-enum-authorize-attribute
* asp.net mvc decorate [Authorize()] with multiple enums
  
  https://stackoverflow.com/questions/1148312/asp-net-mvc-decorate-authorize-with-multiple-enums
* MVC 驗證Authorize
  
  https://dotblogs.com.tw/mickey/2017/01/01/154812
* 簡介 ASP.NET 表單驗證 (FormsAuthentication) 的運作方式
  
  https://blog.miniasp.com/post/2008/02/20/Explain-Forms-Authentication-in-ASPNET-20
