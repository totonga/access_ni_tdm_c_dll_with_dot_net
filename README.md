# Access NI Tdm C Dll With Dot Net

NI offers two file formats for [technical data](https://www.ni.com/de-de/support/documentation/supplemental/06/the-ni-tdms-file-format.html):
- TDMS : binary file
- TDM : xml header plus binary file

For third party they offer the [NI TDM C DLL](https://www.ni.com/content/dam/web/product-documentation/c_dll_tdm.zip) which offers a
**windows** dll exporting an ANSI C interface.

The interface is described in:

``` C
#include "nilibddc.h"
```

This project contains `nilibddc.cs` that conatins a `System.Runtime.InteropServices` wrapper for the C API to be used by C#.
The wrapper is basically generated using [pinvoke-interop-assistant](https://github.com/jaredpar/pinvoke-interop-assistant) with 
some additional cleanup at the end.

## Using the wrapper

Just put `nilibddc.cs` into your project and start work with it like the C code examples suggest.

``` C#
using static nilibddc;
```

> I only created a wrapper for the 64bit version of the `nilibddc.dll`

There is no nice wrapper in this project. It is an ANSI C API.

Check `Program.cs` for an small example.
Check the [NI TDM C DLL](https://www.ni.com/content/dam/web/product-documentation/c_dll_tdm.zip) for additional help on the methods.

Make sure `nilibddc.dll` and the other files from the zip are either
- copied to the folder of your excutable
- the path is included in the PATH variable of ouyr process

You could easily integrate it into you `launchSettings.json` of you Visual Studio.

``` json
"environmentVariables": {
    "path": "%PATH%;C:\\dev\\TDM C DLL\\dev\\bin\\64-bit"
}
````

> NOTE: I did not figure out how string channels work so the generated methods might be wrong.
