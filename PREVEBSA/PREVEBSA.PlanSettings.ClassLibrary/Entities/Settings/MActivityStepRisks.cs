using PREVEBSAPlanSettingsClassLibrary.Interfaces;
using System.ComponentModel.DataAnnotations;


namespace PREVEBSAPlanSettingsClassLibrary.Entities.Settings
{
    public class MActivityStepRisk : IEntityDelete
    {
        [Key]
        [Display(Name = "ID")]
        public Guid ID { get; set; }

        [Display(Name = "PASOID")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Guid PASOID { get; set; }

        public int? PASO_INT_ID { get; set; }

        [Display(Name = "RIESGOID")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Guid RIESGOID { get; set; }

        public int? RIESGO_INT_ID { get; set; }

        [Display(Name = "Orden")]
        public int ORDEN { get; set; }
    }
}
