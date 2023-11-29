using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Models
{
    internal class M_Data_SKPI
    {
        [Key]
        public int id_skpi { get; set; }
        [Required]
        public int poin_minimal { get; set; }
        public DateTime tahun { get; set; }
        [ForeignKey("M_Tim_SKPI")]
        public string tim_skpi_username { get; set; }

    }
}
