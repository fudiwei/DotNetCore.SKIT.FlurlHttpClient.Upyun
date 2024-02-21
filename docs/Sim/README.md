# SKIT.FlurlHttpClient.Upyun.Sim

基于 `Flurl.Http` 的[又拍云一键登录服务](https://www.upyun.com/products/one-click-login/) HTTP API SDK。

---

## 功能

-   基于又拍云一键登录服务 API 封装。

---

## 快速入门

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Upyun.Sim

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Upyun.Sim
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Upyun;
using SKIT.FlurlHttpClient.Upyun.Sim;

var options = new UpyunSimClientOptions()
{
    AppKey = "又拍云一键登录服务 AppKey",
    AppSecret = "又拍云一键登录服务 AppSecret"
};
var client = UpyunSimClientBuilder.Create(options).Build();
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Upyun.Sim;
using SKIT.FlurlHttpClient.Upyun.Sim.Models;

var request = new LoginTokenVerifyRequest()
{
    LoginToken = "认证 SDK 获取到的 LoginToken"
};
var response = await client.ExecuteLoginTokenVerifyAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("手机号码：" + response.EncryptedPhoneNumber);
}
else
{
    Console.WriteLine("返回码：" + response.Code);
    Console.WriteLine("返回说明：" + response.Content);
}
```

---

## 高级技巧

-   [如何销毁客户端？](./Advanced_Dispose.md)

-   [如何与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何配置 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)
