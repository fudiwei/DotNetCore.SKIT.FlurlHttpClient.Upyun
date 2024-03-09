# SKIT.FlurlHttpClient.Upyun.Console

基于 `Flurl.Http` 的[又拍云服务管理后台](https://api.upyun.com/doc/) HTTP API SDK。

---

## 功能

-   基于又拍云服务管理后台开放接口 API 封装。

---

## 快速入门

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
var client = UpyunConsoleClientBuilder.Create(options).Build();
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

## 基础用法

-   ⭐ [如何快速找到需要调用的 API 模型类名 / 方法名？](./Basic_ModelDefinition.md)

---

## 高级技巧

-   [配置 JSON 序列化器](./Advanced_JsonSerializer.md)

-   [配置 HttpClient](./Advanced_HttpClient.md)

-   [使用拦截器](./Advanced_Interceptor.md)

-   [避免内存泄漏](./Advanced_Dispose.md)

-   [与 `IHttpClientFactory` 集成](./Advanced_HttpClientFactory.md)
