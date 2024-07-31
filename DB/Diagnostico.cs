using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Diagnostico
    {
        [Key]
        public int DiagnosticoID { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Severidad { get; set; }
        public string Recomendaciones { get; set; }
        public int DiagnosticoGeneralEnfermedadesID { get; set; }

        public DiagnosticoGeneralEnfermedades DiagnosticoGeneralEnfermedades { get; set; }
    }
}
