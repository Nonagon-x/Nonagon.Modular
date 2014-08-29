using System;

namespace Nonagon.Modular
{
	public class OperationListener<T> : IOperationListener where T : IModuleOperation
	{
		public Type OperationType
		{
			get {

				return typeof(T);
			}
		}

		public Action<Object> OnPreExecute { get; set; }
		public Action<Object, Object> OnPostExecute { get; set; }
	}
}

