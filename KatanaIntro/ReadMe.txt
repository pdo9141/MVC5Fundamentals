OWIN (Open Web Interface for .NET) defines a standard interface between .NET web servers and web applications.
The goal of the OWIN interface is to decouple server and application, encourage the development of simple modules for .NET web development.
Katana is Microsoft's implementation of the OWIN standard

00) Turn console application to small web server
01) Install NuGet package Microsoft.Owin.Hosting
02) Install NuGet package Microsoft.Owin.Host.HttpListener
03) Install NuGet package Microsoft.Owin.Diagnostics (helps build Katana application, get Welcome page)
04) The AppFunc, Func<IDictionary<string, object>, Task>, represents request environment, headers, request, response, cookies, etc.
05) OWIN components are also known as middleware
06) Install NuGet package Microsoft.AspNet.WebApi.OwinSelfHost (add Web.API middleware)
07) Install NuGet package Microsoft.Owin.Host.SystemWeb (move to IIS)
08) Go into project properties and change Output type from Console Application to Class Library in Application section
09) Go into project properties and change Output path from bin\Debug to bin in Build section
10) Run cmd as administrator, type "c:\Program Files\IIS Express\iisexpress.exe" /path:"C:\Users\Phillip\Documents\Visual Studio 2015\Projects\MVC5Fundamentals\KatanaIntro"
11) You need to make copy of App.config and name it Web.config to get IISExpress to work