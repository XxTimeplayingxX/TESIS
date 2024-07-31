using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class Medico
    {
        [Key]
        public int MedicoID { get; set; }
        public int PersonaID { get; set; }
        public string Especialidad { get; set; }
        public string Cargo { get; set; }

        public Persona Persona { get; set; }

    }
}
