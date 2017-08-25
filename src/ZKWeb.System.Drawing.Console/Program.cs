using MonoTests.System.Drawing;
using NUnitLite;
using System;
using System.Reflection;

namespace ZKWeb.System.Drawing.Console {
	public class Program {
		static void Main(string[] args) {
			new AutoRun(typeof(PenTest).GetTypeInfo().Assembly).Execute(args);
		}
	}
}