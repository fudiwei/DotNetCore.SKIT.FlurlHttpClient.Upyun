# SKIT.FlurlHttpClient.Upyun.Uss

基于 `Flurl.Http` 的[又拍云云存储服务](https://www.upyun.com/products/sms/) HTTP API SDK。

---

## 功能

-   基于又拍云云存储服务 API 封装。
-   支持 REST API、FORM API 两种上传模式。
-   请求时自动生成认证签名，无需开发者手动干预。
-   提供了又拍云云存储所需的 MD5、HMAC-SHA-1 等算法工具类。

---

## 快速入门

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Upyun.Uss

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Upyun.Uss
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Upyun;
using SKIT.FlurlHttpClient.Upyun.Uss;

var options = new UpyunUssClientOptions()
{
    OperatorName = "又拍云操作员名",
    OperatorPassword = "又拍云操作员密码"
};
var client = new UpyunUssClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Upyun.Sms;
using SKIT.FlurlHttpClient.Upyun.Sms.Models;

/* 以复制文件接口为例 */
var request = new CopyFileRequest()
{
    BucketName = "mybucket",
    SourceFilePath = "myfolder/oldfile.txt",
    TargetFilePath = "myfolder/newfile.txt"
};
var response = await client.ExecuteCopyFileAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("HTTP 状态：" + response.RawStatus);
}
else
{
    Console.WriteLine("HTTP 状态：" + response.RawStatus);
    Console.WriteLine("错误代码：" + response.ErrorCode);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 基础用法

-   [如何快速找到需要调用的 API 模型类名 / 方法名（附完整 API 对照表）？](./Basic_ModelDefinition.md)

---

## 高级技巧

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)
