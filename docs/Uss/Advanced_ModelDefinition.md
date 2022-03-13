## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，上传文件的请求是 `UploadFileRequest`，响应是 `UploadFileResponse`，接口是 `ExecuteUploadFileAsync()`。知道其中一个，其余两个就可以快速地推断出了。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Upyun.Uss/Models_ 目录。

---

### 【附】API 模型命名速查表：

注：树形结构与[又拍云文件存储文档帮助中心](https://help.upyun.com/knowledge-base/rest_api/)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   REST API

    -   上传文件：`UploadFile`

    -   并行式断点续传：

        -   初始化：`InitializeParallelPartialUploadFile`

        -   数据传输：`TransferParallelPartialUploadFile`

        -   结束：`CompleteParallelPartialUploadFile`

    -   串行式断点续传：

        -   初始化：`InitializeSerialPartialUploadFile`

        -   数据传输：`TransferSerialPartialUploadFile`

        -   结束：`CompleteSerialPartialUploadFile`

    -   复制文件：`CopyFile`

    -   移动文件：`MoveFile`

    -   下载文件：`DownloadFile`

    -   删除文件：`DeleteFile`

    -   创建目录：`CreateFolder`

    -   删除目录：`DeleteFolder`

    -   获取文件信息：`GetFileInfo`

    -   获取目录文件列表：`QueryFiles`

    -   获取服务使用量：`GetBucketUsage`

    -   Metadata：`SetFileMetadata`

-   FORM API

    -   上传小文件：`UploadFileWithForm`

-   云处理

    -   文件拉取：`CreatePretreatmentSpiderman`

    -   文件压缩：`CreatePretreatmentCompress`

    -   文件解压缩：`CreatePretreatmentDepress`

    -   文档转换：`CreatePretreatmentUConvert`

    -   图片处理：`CreatePretreatmentThumbnail`

    -   图片拼接：`CreatePretreatmentJigsaw`

    -   图片识别：`CreatePretreatmentImageAudit`

    -   视频识别：`CreatePretreatmentVideoAudit`

    -   创建直播识别任务：`CreatePretreatmentLiveAudit`

    -   取消直播识别任务：`CancelPretreatmentLiveAudit`
