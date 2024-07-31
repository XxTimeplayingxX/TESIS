using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DetalleReceta
    {
        [Key]
        public int DetalleRecetaID { get; set; }
        public int RecetaID { get; set; }
        public string Medicamento { get; set; }
        public string Dosis { get; set; }
        public string Frecuencia { get; set; }
        public string Duracion { get; set; }
        public string Instrucciones { get; set; }
        public Receta Receta { get; set; }

    }
}
