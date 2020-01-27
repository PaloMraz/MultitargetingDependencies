# MultitargetingDependencies

The solution consists of two projects:

* `LibA` is a class library multitargeting `.netstandard20` and `.net35` (using the `TargetFrameworks` project element).
* `LibANetstandard20` is a class library targeting just `.netstandard20`.
* `LibB` is a class library targeting `.netstandard20`, it has project references to `LibA` and `LibANetstandard20` and also has `GeneratePackageOnBuild` set 
to `True`.

However, the NuGet package built from `LibB` (`LibB.1.0.0.nupkg`) contains only `LibB.dll` and **neither** `LibA.dll` nor `LibANetstandard20.dll`.

How can I ensure that the built `LibB.1.0.0.nupkg` NuGet package contains build outputs of all of the referenced projects
(preferably including transitive ones)?

