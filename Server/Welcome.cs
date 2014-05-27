using ServiceStack.ServiceHost;

namespace marcus.simonline.dk
{
	[Route("/welcome")]
	[Route("/welcome/{Name*}")]
	public class Welcome
	{
		public string Name { get; set; }
	}
}