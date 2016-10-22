#if CORECLR
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	[ComVisible(true)]
	internal struct SerializationEntry
	{
		public string Name { get; }
		public Type ObjectType { get; }
		public object Value { get; }
	}
}
#endif
