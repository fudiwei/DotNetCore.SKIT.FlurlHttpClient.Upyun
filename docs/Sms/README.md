# SKIT.FlurlHttpClient.Upyun.Sms

基于 `Flurl.Http` 的[又拍云短信服务](https://www.upyun.com/products/sms/) API 客户端。

---

## 功能

-   基于又拍云短信服务 API 封装。

---

## 基础用法

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Upyun.Sms

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Upyun.Sms
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Upyun;
using SKIT.FlurlHttpClient.Upyun.Sms;

var options = new UpyunSmsClientOptions()
{
    Token = "又拍云短信服务 API Token"
};
var client = new UpyunSmsClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Upyun.Sms;
using SKIT.FlurlHttpClient.Upyun.Sms.Models;

/* 以发送短信接口为例 */
var request = new SendMessageRequest()
{
    MobileNumberList = new List<string>() { "18912345678" },
    TemplateId = 2022
};
var response = await client.ExecuteSendMessageAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("短信消息记录：" + response.MessageList);
}
else
{
    Console.WriteLine("HTTP 状态：" + response.RawStatus);
    Console.WriteLine("一级返回码：" + response.ReturnCode);
}
```

---

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名（附完整 API 对照表）？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)
