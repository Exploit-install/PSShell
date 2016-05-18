# PSShell
PSShell gets the job done when harsh group policy restrictions are in place.

### What is it:

PSShell is an application written in C# that does not rely on powershell.exe but runs powershell commands and functions within a powershell runspace environment (.NET). It doesn't need to be "installed" so it's very portable.

Because it calls powershell directly through the .NET framework it might help bypassing security controls like GPO, SRP, App Locker.

### How to Compile it:

To compile PSShell you need to import this project within Microsoft Visual Studio or if you don't have access to a Visual Studio installation, you can compile it as follows:

To Compile as x86 binary:

```
cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319 (Or newer .NET version folder)

csc.exe /unsafe /reference:"C:\path\to\System.Management.Automation.dll" /reference:System.IO.Compression.dll /out:C:\users\username\PowerOPS_x86.exe /platform:x86 "C:\path\to\PowerOPS\PowerOPS\*.cs"
```

To Compile as x64 binary:

```
cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319 (Or newer .NET version folder)

csc.exe /unsafe /reference:"C:\path\to\System.Management.Automation.dll" /reference:System.IO.Compression.dll /out:C:\users\username\PowerOPS_x64.exe /platform:x64 "C:\path\to\PowerOPS\PowerOPS\*.cs"
```

PSShell uses the System.Management.Automation namespace, so make sure you have the System.Management.Automation.dll within your source path when compiling outside of Visual Studio.

### How to use it:

Just run the executables.

### TODO:

* Test. This hasn't been thoroughly tested, please report any issues.
