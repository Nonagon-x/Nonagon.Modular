using System;

namespace Nonagon.Modular.DynamicForm.Service
{
	//[Route("/forms?skip={Skip}&take={Take}")]
	public class GetForms
	{
		public Int32 Skip { get; set; }
		public Int32 Take { get; set; }
	}
}

