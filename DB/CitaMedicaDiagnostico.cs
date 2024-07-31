using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class CitaMedicaDiagnostico
    {
        [Key]
        public int CitaMedicaDiagnosticoID { get; set; }
        public int CitaMedicaID { get; set; }
        public int DiagnosticoID { get; set; }

        public CitaMedica CitaMedica { get; set; }
        public Diagnostico Diagnostico { get; set; }
    }
}
