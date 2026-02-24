
using PREVEBSAPlanSettingsClassLibrary.Interfaces;
using System.ComponentModel.DataAnnotations;


namespace PREVEBSAPlanSettingsClassLibrary.Entities.Settings
{
    public class PreliminaryQuestion : IEntityDelete
    {
        [Key]
        [Display(Name = "Id")]
        public Guid ID { get; set; }

        [Display(Name = "Pregunta preliminar")]
        [MaxLength(1000, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string PREGUNTA { get; set; }

        [Display(Name = "Id Tipo de pregunta")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Guid QUESTIONTYPEID { get; set; }

        [Display(Name = "Soporte")]
        public bool SOPORTE { get; set; }

        [Display(Name = "Habilitado")]
        public bool ESTADO { get; set; }

        [Display (Name = "Codigo")]
        public int CODIGO { get; set; }
    }
}
