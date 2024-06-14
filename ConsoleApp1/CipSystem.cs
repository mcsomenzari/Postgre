using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Table("sist")]
    public class CipSystem : EntityBase
    {
        [Key]
        [Column("id_sist")]
        public int Id { get; set; }

        [Column("cd_sist")]        
        public string Code { get; set; }

        [Column("ds_sist")]        
        public string Description { get; set; }
    }


}