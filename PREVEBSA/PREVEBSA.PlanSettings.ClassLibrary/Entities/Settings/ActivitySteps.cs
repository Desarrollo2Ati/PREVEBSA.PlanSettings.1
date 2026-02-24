using PREVEBSAPlanSettingsClassLibrary.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace PREVEBSAPlanSettingsClassLibrary.Entities.Settings
{
    public class ActivitySteps : IEntityDelete
    {
        [Key]
        [Display(Name = "Id")]
        public int ID { get; set; }

        [Display(Name = "Id Actividad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int ACTIVIDADID { get; set; }

        [Display(Name = "Regla de oro")]
        public bool REGLAORO { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string DESCRIPCION { get; set; } = null!;

        [Display(Name = "Trabajo en alturas")]
        public bool ALTURAS { get; set; }

        [Display(Name = "Habilitado")]
        public bool ESTADO { get; set; }

        [Display(Name = "Orden")]
        public int ORDEN { get; set; }
    }
}
