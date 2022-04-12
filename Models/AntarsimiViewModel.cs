using System;
using System.ComponentModel.DataAnnotations;

namespace Menaxhimi_Biblotekes.Models
{
    public class AntarsimiViewModel
    {
        [Key]
        public int AntarsimiID { get; set; }
        public int PjesmarrsitID { get; set; }
        public DateTime DataRegjistrimit { get; set; }
        public DateTime DataSkadimit { get; set; }

        //public bool Aktive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastUpdatedByUserID { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
