// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.WriteLine("Hello, World!");

CreateTempDirectory(@"C:\GIT\internal\Scripts\dotnet");

void CreateTempDirectory(string baseDir)
{
    var dateTimeFolder = "";
    var srcDir = Path.Combine(baseDir, dateTimeFolder, "src/ConsoleApp");
    Directory.CreateDirectory(srcDir);
}

Process.Start("dotnet", "new console").WaitForExit();


