using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace ConsoleApp1
{
    public abstract class EntityBase
    {
        [Column("ic_sit")]
        public string Active { get; set; }

        [Column("nm_usu_incl")]
        [Required]
        public string CreationUser { get; set; }

        [Column("dh_incl")]
        [Required]
        public DateTime CreationTime { get; set; }

        [Column("nm_usu_ult_alt")]
        public string ModificationUser { get; set; }

        [Column("dh_ult_alt")]
        public DateTime? ModificationTime { get; set; }
    }
}