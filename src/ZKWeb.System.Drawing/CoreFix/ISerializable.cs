#if CORECLR
namespace System.Runtime.Serialization
{
	using System.Runtime.Serialization;
	using System;
	using System.Reflection;

	[System.Runtime.InteropServices.ComVisible(true)]
	internal interface ISerializable
	{
		[System.Security.SecurityCritical]  // auto-generated_required
		void GetObjectData(SerializationInfo info, StreamingContext context);
	}
}
#endif
