mkdir Nuget
cd RIFF.Core
..\nuget pack RIFF.Core.csproj -IncludeReferencedProjects -Symbols
cd..
cd RIFF.Console
..\nuget pack RIFF.Console.csproj -IncludeReferencedProjects -Symbols
cd..
cd RIFF.Framework
..\nuget pack RIFF.Framework.csproj -IncludeReferencedProjects -Symbols
cd..
cd RIFF.Web.Core
..\nuget pack RIFF.Web.Core.csproj -IncludeReferencedProjects -Symbols
..\nuget pack RIFF.Web.Core.nuspec
cd ..
move RIFF.Core\*.nupkg Nuget\
move RIFF.Console\*.nupkg Nuget\
move RIFF.Framework\*.nupkg Nuget\
move RIFF.Web.Core\*.nupkg Nuget\
pause