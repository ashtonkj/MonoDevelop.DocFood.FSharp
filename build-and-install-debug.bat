
@echo off
set MSBUILD=%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe
%MSBUILD% MonoDevelop.DocFood.FSharp\MonoDevelop.DocFood.FSharp.windows.fsproj /p:Configuration=Debug
set MDROOT="C:\Program Files (x86)\Xamarin Studio"
rmdir /s /q pack
mkdir pack\windows\Debug
%MDROOT%\bin\mdtool.exe setup pack bin\windows\Debug\MonoDevelop.DocFood.FSharp -d:pack\windows\Debug
%MDROOT%\bin\mdtool.exe setup install -y pack\windows\Debug\MonoDevelop.DocFood.FSharp_0.0.1.mpack 
