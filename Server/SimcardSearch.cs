using ServiceStack.ServiceHost;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace marcus.simonline.dk
{
    [Route("/simcardsearch")]
    [DataContract]
    public class SimcardSearch
    {
        [DataMember]
        public string global { get; set; }
        [DataMember]
        public List<string> filters { get; set; }

    }
}