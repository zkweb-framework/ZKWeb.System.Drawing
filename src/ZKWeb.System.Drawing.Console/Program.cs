using MonoTests.System.DrawingCore;
using NUnitLite;
using System;
using System.Reflection;

namespace ZKWeb.System.DrawingCore.Console {
	public class Program {
		static void Main(string[] args) {
			new AutoRun(typeof(PenTest).GetTypeInfo().Assembly).Execute(args);
		}
	}
}
