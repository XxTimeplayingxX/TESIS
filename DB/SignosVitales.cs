using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class SignosVitales
    {
        [Key]
        public int SignosVitalesID { get; set; }
        public string Temperatura { get; set; }
        public string Pulso { get; set; }
        public string FrecuenciaCardiaca { get; set; }
        public string PresionArterial { get; set; }
        public int PacienteID { get; set; }
        public Paciente Paciente { get; set; }
    }
}
