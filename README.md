# System.Drawing for .NET Core, that really work

This is a .Net Core compatible System.Drawing implementation modified from mono project.
Works on windows and linux.

[![NuGet](https://buildstats.info/nuget/ZKWeb.System.Drawing)](http://www.nuget.org/packages/ZKWeb.System.Drawing)

These systems are tested:

Windows 8.1 64bit
Ubuntu Server 16.04 LTS 64bit

# How can I get it work?

On windows, just install package `ZKWeb.System.Drawing` from nuget, nothing else need.

On Linux, except install package `ZKWeb.System.Drawing` from nuget, you need put `libgdiplus.so` to `/usr/lib` or `/usr/lib64`.<br/>
You can found a pre-compiled `libgdiplus.so` if you're using following distribution.

- Ubuntu Server 16.04 LTS 64bit

Otherwise you will need build `libgdiplus.so` yourself, Here is steps.

- TODO

# Huh? What's the different with CoreCompat.System.Drawing?

- No fake strong name is used, will not mess up Asp.Net and OWIN.
- Copied all files from mono 4.6.1.13, you will actually compile it without seeing hundreds error
- You can actually run tests from `dotnet test`, no joke
- Really tested on linux, if that's not work with you please fill an issue
- No reference to System.Drawing.Primitive, because System.Drawing.Primitive reference original System.Drawing on .Net Framework which may cause conficts error

# You have compiled `libgdiplus.so` for other distribution?

Please upload it, other guys will thank you.

# Mac support

I'm a poor man doesn't have a shiny mac book now, so I can't test with macosx, somebody can please tell me.
