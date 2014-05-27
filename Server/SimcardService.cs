using ServiceStack.ServiceInterface;
using System.Collections.Generic;

namespace marcus.simonline.dk
{
    public class SimcardService : Service
    {

        public SimcardSearchResponse Any(SimcardSearch request)
        {
            return new SimcardSearchResponse { msisdn = new List<int>(){22334455, 91130000} };
        }

    }
}