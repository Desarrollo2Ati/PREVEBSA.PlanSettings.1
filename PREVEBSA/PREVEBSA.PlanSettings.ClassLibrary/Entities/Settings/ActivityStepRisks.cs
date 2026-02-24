using PREVEBSAPlanSettingsClassLibrary.Interfaces;
using System.ComponentModel.DataAnnotations;


namespace PREVEBSAPlanSettings.ClassLibrary.Entities.Settings
{
    public class ActivityStepRisks : IEntityDelete
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "PASOID")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int PASOID { get; set; }

        [Display(Name = "RIESGOID")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int RIESGOID { get; set; }

        [Display(Name = "Orden")]
        public int ORDEN { get; set; }
    }
}
