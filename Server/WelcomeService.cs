using ServiceStack.ServiceInterface;

namespace marcus.simonline.dk
{
	public class WelcomeService : Service
	{
		public WelcomeResponse Any(Welcome request)
		{
            var name = request.Name == null ? "" : request.Name.Replace("/", " ");
			return new WelcomeResponse {Message = string.Format("Hello {0}", name)};
		}
	}
}