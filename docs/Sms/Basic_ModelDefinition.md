## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，创建短信模板的请求是 `CreateTemplateRequest`，响应是 `CreateTemplateResponse`，接口是 `ExecuteCreateTemplateAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的发送订阅消息，它的接口地址是 `[POST] /templates`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。

另外，以 `Query` 开头的一般表示列表查询；以 `Get` 开头的一般表示获取详情；以 `Create` 开头的一般表示发起或新建操作；以 `Update` 开头的一般表示修改操作。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Upyun.Sms/Models_ 目录。

---

### 【附】API 模型命名速查表：

注：树形结构与[又拍云短信产品接口文档](https://help.upyun.com/knowledge-base/sms-api)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   平台证书：`GetUserRemain`

-   短信模板新增接口：`CreateTemplate`

-   短信模板删除接口：`DeleteTemplate`

-   短信模板修改接口：`UpdateTemplate`

-   短信模板模板接口：`QueryTemplates`

-   短信发送接口：`SendMessage`

-   短信异步批量发送接口（文件形式）：`SendMessageWithFile`

-   短信异步批量发送接口（手机号形式）：`SendMessageAsynchronously`

-   短信异步批量发送接口（不同手机号，不同内容）：`SendMessageAsynchronouslyV2`

-   短信报表查询接口：`QueryMessages`

-   国际短信报表查询接口：`QueryInternationalMessages`

-   号码检测接口：`CreateMobileDetection`
