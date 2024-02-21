using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Data
{
    public partial class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; } 
        public DateTime? DateModified { get; set; } 
    }
}
