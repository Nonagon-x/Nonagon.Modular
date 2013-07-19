using ServiceStack.ServiceHost;
using Nonagon.Modular.DynamicForm.Operations;

namespace Nonagon.Modular.DynamicForm.Service
{
	[Route("/form/{FormId}")]
	public class GetFormDetails : GetFormDetailsOperation.Param {}
}

