using System;
using System.ComponentModel.DataAnnotations;
namespace Menaxhimi_Biblotekes.Models
{
    public class PjesmarresitViewModel

    {
        [Key]
        public int Id { get ; set; }
        public int RoletId { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public string Perdoruesi { get; set; }
        public string Fjalekalimi { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastUpdatedByUserID { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
