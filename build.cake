var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  DotNetCoreRestore("./src");
  DotNetCoreRestore("./test");
  DotNetCoreBuild("./src/Aodag.Todolist");
  DotNetCoreBuild("./test/Aodag.Todolist.Test");
  DotNetCoreTest("./test/Aodag.Todolist.Test");
});

RunTarget(target);