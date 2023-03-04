using NZWalks.Api.Models.Domain;

namespace NZWalks.Api.Models.DTO
{
    public class Regions
    {
        public Guid Id { get; set; }
        public string code { get; set; }
        public string Name { get; set; }

        public double Area { get; set; }
        public double lat { get; set; }
        public double Long { get; set; }

        public long population { get; set; }

        //Navigation properties 
        public IEnumerable<Walk> Walks { get; set; }
    }
}
