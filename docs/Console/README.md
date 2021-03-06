# SKIT.FlurlHttpClient.Upyun.Console

基于 `Flurl.Http` 的[又拍云服务管理后台](https://api.upyun.com/doc/) API 客户端。

---

## 功能

-   基于又拍云服务管理后台开放接口 API 封装。

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
using SKIT.FlurlHttpClient.Upyun.Console;

var options = new UpyunConsoleClientOptions()
{
    Username = "又拍云登录用户名",
    Password = "又拍云登录密码"
};
var client = new UpyunConsoleClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Upyun.Console;
using SKIT.FlurlHttpClient.Upyun.Console.Models;

/* 以创建存储桶接口为例 */
var request = new CreateBucketRequest()
{
    BucketName = "MyBucketName",
    Type = "file"
};
var response = await client.ExecuteCreateBucketAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("操作结果：" + response.Result);
}
else
{
    Console.WriteLine("HTTP 状态：" + response.RawStatus);
    Console.WriteLine("错误码：" + response.ErrorCode);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)
