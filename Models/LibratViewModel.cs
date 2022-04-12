using System;
using System.ComponentModel.DataAnnotations;
namespace Menaxhimi_Biblotekes.Models
{
    public class LibratViewModel
    {
        [Key]
        public int Id { get; set; }
        public int KategoriaId { get; set; }
        public string Titulli { get; set; }
        public string ISBN { get; set; }
        public string ShtepiaBotuese { get; set; }
        public int VitiBotimit { get; set; }
        public int NrKopjeve { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastUpdatedByUserID { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
