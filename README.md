# MultitargetingDependencies

The solution consists of two projects:

* `LibA` is a class library multitargeting `.netstandard20` and `.net35` (using the `TargetFrameworks` project element).
* `LibB` is a class library targeting just `.netstandard20`, it has a project reference to `LibA` and also has `GeneratePackageOnBuild` set 
to `True`.

However, the NuGet package built from `LibB` (`LibB.1.0.0.nupkg`) contains only `LibB.dll` and **no** `LibA.dll`.

How can I ensure that the built `LibB.1.0.0.nupkg` NuGet package contains build outputs of all of the referenced projects
(preferably including transitive ones)?

