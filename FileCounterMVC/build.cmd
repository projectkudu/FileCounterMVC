﻿if not exist ..\artifacts mkdir ..\artifacts
"%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" FileCounterMVC.csproj /p:webpublishmethod=filesystem;PublishUrl=..\artifacts /t:WebFileSystemPublish