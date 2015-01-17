using System;

namespace Nonagon.Modular
{
	public interface IOperationListener
	{
		Type OperationType { get; }
		Action<Object> OnPreExecute { get; }
		Action<Object, Object> OnPostExecute { get; }
	}
}

