using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DiagnosticoGeneralEnfermedades
    {
        [Key]
        public int DiagnosticoGeneraEnfermedadesID { get; set; }
        public string Nombre { get; set; }
    }
}
