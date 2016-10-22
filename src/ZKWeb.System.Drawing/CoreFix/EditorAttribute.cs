//------------------------------------------------------------------------------
// <copyright file="EditorAttribute.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

/*
 */
#if NETCORE
namespace System.ComponentModel
{
	using System.Diagnostics;
	using System.Globalization;
	using System.Security.Permissions;

	/// <devdoc>
	///    <para>Specifies the editor to use to change a property. This class cannot be inherited.</para>
	/// </devdoc>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	internal sealed class EditorAttribute : Attribute
	{

		private string baseTypeName;
		private string typeName;
		private string typeId;

		/// <devdoc>
		/// <para>Initializes a new instance of the <see cref='System.ComponentModel.EditorAttribute'/> class with the default editor, which is
		///    no editor.</para>
		/// </devdoc>
		public EditorAttribute()
		{
			this.typeName = string.Empty;
			this.baseTypeName = string.Empty;
		}

		/// <devdoc>
		/// <para>Initializes a new instance of the <see cref='System.ComponentModel.EditorAttribute'/> class with the type name and base type
		///    name of the editor.</para>
		/// </devdoc>
		public EditorAttribute(string typeName, string baseTypeName)
		{
			string temp = typeName.ToUpper();
			Debug.Assert(temp.IndexOf(".DLL") == -1, "Came across: " + typeName + " . Please remove the .dll extension");
			this.typeName = typeName;
			this.baseTypeName = baseTypeName;
		}

		/// <devdoc>
		/// <para>Initializes a new instance of the <see cref='System.ComponentModel.EditorAttribute'/> class.</para>
		/// </devdoc>
		public EditorAttribute(string typeName, Type baseType)
		{
			string temp = typeName.ToUpper();
			Debug.Assert(temp.IndexOf(".DLL") == -1, "Came across: " + typeName + " . Please remove the .dll extension");
			this.typeName = typeName;
			this.baseTypeName = baseType.AssemblyQualifiedName;
		}

		/// <devdoc>
		/// <para>Initializes a new instance of the <see cref='System.ComponentModel.EditorAttribute'/>
		/// class.</para>
		/// </devdoc>
		public EditorAttribute(Type type, Type baseType)
		{
			this.typeName = type.AssemblyQualifiedName;
			this.baseTypeName = baseType.AssemblyQualifiedName;
		}

		/// <devdoc>
		///    <para>Gets the name of the base class or interface serving as a lookup key for this editor.</para>
		/// </devdoc>
		public string EditorBaseTypeName
		{
			get
			{
				return baseTypeName;
			}
		}

		/// <devdoc>
		///    <para>Gets the name of the editor class.</para>
		/// </devdoc>
		public string EditorTypeName
		{
			get
			{
				return typeName;
			}
		}

		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}

			EditorAttribute other = obj as EditorAttribute;

			return (other != null) && other.typeName == typeName && other.baseTypeName == baseTypeName;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
#endif
