#addin nuget:https://api.nuget.org/v3/index.json?package=Cake.npm&version=0.17.0

var target = Argument("target", "Default");

Task("Default")
.Does(() => {
   Information("Hello Cake!");
   NpmVersion();
});


RunTarget(target);