## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，获取证书详情的请求是 `GetHttpsCertificateInfoRequest`，响应是 `GetHttpsCertificateInfoResponse`，接口是 `ExecuteGetHttpsCertificateInfoAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的获取证书详情，它的接口地址是 `[POST] /https/certificate/info`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。

另外，以 `Query` 开头的一般表示列表查询；以 `Get` 开头的一般表示获取详情；以 `Create` 开头的一般表示发起或新建操作；以 `Update` 开头的一般表示修改操作；以 `Set` 开头的一般表示为设置操作。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Upyun.Console/Models_ 目录。
