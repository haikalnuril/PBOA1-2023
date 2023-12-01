using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Models
{
    internal class M_Komentar
    {
        [Key]
        public int id_komentar { get; set; }
        [Required]
        public string komentar { get; set; }
        [ForeignKey("M_Aktivitas")]
        public int aktivitas_id_aktivitas { get; set; }
        [ForeignKey("M_Tim_SKPI")]
        public string tim_skpi_username { get; set; }
    }
}
