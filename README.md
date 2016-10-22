# System.Drawing for .NET Core, that really work

This is a .Net Core compatible System.Drawing implementation modified from mono project.
Works on windows and linux.

[![NuGet](https://buildstats.info/nuget/ZKWeb.System.Drawing)](http://www.nuget.org/packages/ZKWeb.System.Drawing)

These system are tested:

- Windows 8.1 64bit
- Ubuntu Server 16.04 LTS 64bit

These features should work:

- Open jpg, bmp, ico, png
- Save jpg, bmp, ico, png 
- Resize image
- Draw graphics with brush and pen
- Open font and draw string

Known issues:

- TODO

# How can I get it work?

On windows, just install package `ZKWeb.System.Drawing` from nuget, nothing else need.

On Linux, except install package `ZKWeb.System.Drawing` from nuget, you need install `libgdiplus`.<br/>

- Ubuntu: apt-get install libgdiplus
- Other distribution: see https://github.com/mono/libgdiplus

# Huh? What's the different with CoreCompat.System.Drawing?

- No fake strong name is used, will not mess up Asp.Net and OWIN.
- Copied all files from mono 4.6.1.13, you will actually compile it without seeing hundreds error
- Really tested on linux and really work
- You can actually run tests from `dotnet test`, no joke
	- .Net Core Test Count: 1857, Passed: 1517, Failed: 331, Inconclusive: 0, Skipped: 9
	- .Net Framework Test Count: 1869, Passed: 1524, Failed: 336, Inconclusive: 0, Skipped: 9
- No reference to System.Drawing.Primitive, because System.Drawing.Primitive reference original System.Drawing on .Net Framework which may cause conficts error

# Mac support

I'm a poor man doesn't have a shiny mac book now, so I can't test with macosx, somebody can please tell me.
