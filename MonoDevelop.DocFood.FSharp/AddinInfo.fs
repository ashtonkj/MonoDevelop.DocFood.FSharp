module MonoDevelop.DocFood.FSharp.AddInInfo

open System;
open Mono.Addins;

[<Addin ("DocFood.FSharp", 
                 Namespace = "MonoDevelop",
                 Version = "0.0.1",
                 Category = "IDE extensions")>]

[<AddinName ("DocFood.FSharp")>]
[<AddinDescription ("DocFood is an automated comment generator")>]

[<AddinDependency ("Core", "5.3")>]
[<AddinDependency ("Ide", "5.3")>]
[<AddinDependency ("Refactoring", "5.3")>]
()
