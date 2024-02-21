using DataInterface.Data;

namespace TechSysDigitalApi.Models
{
    public class Musician : BaseEntity
    {
        public string Name { get; set; }
        public string StageName { get; set; }
        public string Bio { get; set; }
        public string Genre { get; set; }
       
    }

}
