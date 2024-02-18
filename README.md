# SKIT.FlurlHttpClient.Upyun

[![Gitee Stars](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun/badge/star.svg?title=Stars)](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun)
[![Gitee Forks](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun/badge/fork.svg?title=Forks)](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun)
[![GitHub Stars](https://img.shields.io/github/stars/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun?logo=github&label=Stars)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun)
[![GitHub Forks](https://img.shields.io/github/forks/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun?logo=github&label=Forks)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun)
[![Vistors](https://visitor-badge.laobi.icu/badge?page_id=fudiwei.DotNetCore.SKIT.FlurlHttpClient.Upyun&title=Visitors)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun)
[![License](https://img.shields.io/github/license/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun?label=License)](https://mit-license.org/)

基于 `Flurl.Http` 的又拍云 HTTP API SDK，目前已包含文件存储、短信服务（SMS）、一键登录服务（SIM）、服务管理后台等模块。

> 更多 SKIT.FlurlHttpClient 系列开发工具包请[点此查看](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient)。

---

## 特性

-   基于 `Flurl.Http`。
-   支持 .NET Framework 4.6.2+、.NET Standard 2.0+、.NET Core 2.0+、.NET 5.0+ 多目标框架。
-   支持 Windows / Linux / macOS 多平台部署。
-   支持 `System.Text.Json`（默认）和 `Newtonsoft.Json` 两种序列化方式。
-   强类型接口模型。
-   全异步式编程。
-   提供 SourceLink 调试符号文件。
-   完整、完善、完全的又拍云 HTTP API 封装。

---

## 模块

|        名称         |                                                                                                                                                                                   NuGet                                                                                                                                                                                    |                 其他                 |
| :-----------------: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :----------------------------------: |
|  云存储服务（USS）  |         [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Upyun.Uss.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Upyun.Uss) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Upyun.Uss.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Upyun.Uss)         |   [开发文档](./docs/Uss/README.md)   |
|   短信服务（SMS）   |         [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Upyun.Sms.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Upyun.Sms) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Upyun.Sms.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Upyun.Sms)         |   [开发文档](./docs/Sms/README.md)   |
| 一键登录服务（SIM） |         [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Upyun.Sim.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Upyun.Sim) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Upyun.Sim.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Upyun.Sim)         |   [开发文档](./docs/Sim/README.md)   |
|    服务管理后台     | [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Upyun.Console.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Upyun.Console) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Upyun.Console.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Upyun.Console) | [开发文档](./docs/Console/README.md) |

---

## 参与贡献

-   GitHub Repo：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun.git
-   Gitee Repo：https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Upyun.git

以上仓库地址同步更新，均可接受 Issue 或 Pull Request。

如何参与贡献请参阅 [CONTRIBUTING](./CONTRIBUTING.md)。

---

## 更新日志

详细更新说明请参阅 [CHANGELOG](./CHANGELOG.md)。
