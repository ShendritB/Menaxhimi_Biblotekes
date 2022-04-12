using System;

namespace Menaxhimi_Biblotekes.Models
{
    public class AntarsimiViewModel
    {
              
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastUpdatedByUserID { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
