using System;
using System.ComponentModel.DataAnnotations;

namespace Menaxhimi_Biblotekes.Models
{
    public class HuazimetViewModel
    {
        [Key]
        public int HuazimetID { get; set; }
        public int LibratID { get; set; }
        public int PjesmarrsitID { get; set; }
        public DateTime DataHuazimit { get; set; }
        public DateTime AfatiKthimit { get; set; }
        public DateTime DataKthimit { get; set; }
        public string Vrejtje { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastUpdatedByUserID { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
