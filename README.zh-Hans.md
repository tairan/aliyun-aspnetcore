# Aliyun OSS SDK for ASP.NET Core

本项目是对阿里云官方OSS SDK的扩展

+ 支持ASP.NET Core的依赖注入
+ 为异步方法提供async/await支持，将SDK中的APM模型通过扩展方法以支持TAP模型。

## 使用说明

参考`samples`目录下的示例项目，在`Startup.cs`中配置，然后就可以通过依赖注入的方式在`ASP.NET Core`中使用。

## License

[MIT License](LICENSE)

