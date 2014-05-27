using Funq;
using ServiceStack.WebHost.Endpoints;
using marcus.simonline.dk.App_Start;

namespace marcus.simonline.dk
{
	public class AppHost : AppHostBase
	{
		public AppHost() : base("Simservice with ServiceStack", typeof (AppHost).Assembly)
		{
		}

		public override void Configure(Container container)
		{
			SetConfig(new EndpointHostConfig
				{
					ServiceStackHandlerFactoryPath = "api",
                    WsdlServiceNamespace = "http://schemas.datacontract.org/2004/07/marcus.simonline.dk",
                    WsdlSoapActionNamespace = "http://schemas.datacontract.org/2004/07/marcus.simonline.dk",
                    DebugMode = true
                    
				});
		}
	}
}