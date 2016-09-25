01) To add XML documentation to Web.Api help screens, add your XML comments to actions, go to properties > builds
    Enable XML documentation file checkbox, go to Areas/HelpPage/App_Start/HelpPageConfig.cs and uncomment config.SetDocumentationProvider
02) To enable CORS (Cross Orgin Resource Sharing), get Microsoft ASP.NET Web API Cross-Origin NuGet package
	Add config.EnableCors into the App_Start/WebApiConfig file