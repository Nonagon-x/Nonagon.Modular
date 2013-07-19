using ServiceStack.ServiceHost;
using Nonagon.Modular.DynamicForm.Operations;

namespace Nonagon.Modular.DynamicForm.Service
{
	[Route("/form/save")]
	public class StoreForm : StoreFormOperation.Param {}
}