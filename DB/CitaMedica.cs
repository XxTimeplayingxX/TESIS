using System.ComponentModel.DataAnnotations;

namespace DB
{
    public class CitaMedica
    {
        [Key]
        public int CitaMedicaID { get; set; }
        public DateTime Fecha { get; set; }
        public int MedicoID { get; set; }
        public int PacienteID { get; set; }
        public int Estado { get; set; }
        public int RecetaID { get; set; }
        public int CitaMedicaDiagnosticoID { get; set; }

        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public Receta Receta { get; set; }
        public CitaMedicaDiagnostico CitaMedicaDiagnostico { get; set; }
    }
}
