// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.WriteLine("Hello, World!");

string baseDir = @"C:\Temp";

var appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

string codeExe = Path.Combine(appData, @"Programs\Microsoft VS Code\Code.exe");

if (args.Length > 0)
{
    baseDir = args[0];
}

var createdDir = CreateTempDirectory(baseDir);

string CreateTempDirectory(string baseDir)
{
    var dateTimeFolder = DryLib.DateTimeHelper.GetDateTimeNowForFilesystem();
    var srcDir = Path.Combine(baseDir, dateTimeFolder, "src/ConsoleApp");
    Directory.CreateDirectory(srcDir);
    return srcDir;
}

Directory.SetCurrentDirectory(createdDir);

Process.Start("dotnet", "new console").WaitForExit();

var programcs = Path.Combine(createdDir, "Program.cs");

Process.Start(codeExe, $"{createdDir} {programcs}");
