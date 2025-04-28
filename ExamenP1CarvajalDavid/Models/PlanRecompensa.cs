using System.ComponentModel.DataAnnotations;

namespace ExamenP1CarvajalDavid.Models
{
    public class PlanRecompensa
    {
     public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        public int PuntosAcumulados { get; set; }
        public string TipoRecompensa { get; set; } 
    }
}
