>  **Archive Notice:**
> This repository (**QuickLook.Common**) has been merged into the [QuickLook repository](https://github.com/QL-Win/QuickLook).

[![GitHub license](https://img.shields.io/github/license/QL-Win/QuickLook.Common)](https://github.com/QL-Win/QuickLook/blob/master/QuickLook.Common/LICENSE) [![NuGet](https://img.shields.io/nuget/v/QuickLook.Common.svg)](https://nuget.org/packages/QuickLook.Common)

# QuickLook.Common

This repository holds the common library of QuickLook. The library is shared among all QuickLook projects.

## Plugin development update

QuickLook.Common no longer requires submodule-based development for QuickLook plugins.

If your plugin project previously used this repository as a git submodule, remove it with:

```bash
git submodule deinit -f QuickLook.Common
git rm -f QuickLook.Common
```

Then switch to NuGet dependency:

```xml
<PackageReference Include="QuickLook.Common" Version="x.y.z" />
```
