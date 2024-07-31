using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Receta
    {
        [Key]
        public int RecetaID { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Comentarios { get; set; }
    }
}
