#if CORECLR
using System.Collections;

namespace System.Runtime.Serialization
{
	internal sealed class SerializationInfo
	{
		public void AddValue(string name, object value) { }

		public void AddValue(string name, object value, Type type) { }

		public object GetValue(string name, Type type) { return null; }

		public IEnumerator GetEnumerator() { return null; }
	}
}
#endif
