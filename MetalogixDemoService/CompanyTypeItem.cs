using System.Runtime.Serialization;

namespace MetalogixDemoService
{
    [DataContract]
    public class CompanyWcfTypeItem
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

    }
}