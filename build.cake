var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
});

Task("Build")
  .Does(() =>
{
  DotNetCoreRestore("./src");
  DotNetCoreRestore("./test");
  DotNetCoreBuild("./src/Aodag.Todolist");
  DotNetCoreBuild("./test/Aodag.Todolist.Test");
});

Task("Test")
  .IsDependentOn("Build")
  .Does(() =>
{
  DotNetCoreTest("./test/Aodag.Todolist.Test");
});

RunTarget(target);