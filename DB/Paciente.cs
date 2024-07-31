using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Paciente
    {
        [Key]
        public int PacienteID { get; set; }
        public string HistorialMedico { get; set; }
        public int PersonaID { get; set; }

        public Persona Persona { get; set; } 
    }
}
