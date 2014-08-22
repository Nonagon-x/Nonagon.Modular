using System;

namespace Nonagon.Modular
{
	/// <summary>
	/// Module not loaded exception.
	/// </summary>
	public class ModuleNotLoadedException : Exception
	{
		public ModuleNotLoadedException (Type moduleType) :
			base(String.Format("The module was not yet loaded. Value: {0}", 
			                   moduleType.FullName)) { }
	}
}

