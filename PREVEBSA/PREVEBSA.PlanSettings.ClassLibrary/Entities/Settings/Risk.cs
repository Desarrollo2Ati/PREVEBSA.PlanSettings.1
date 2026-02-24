using PREVEBSAPlanSettingsClassLibrary.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace PREVEBSAPlanSettingsClassLibrary.Entities.Settings
{
    public class MRisk : IEntityDelete
    {
        [Key]
        [Display(Name = "Id")]
        public int ID { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        public string DESCRIPCION { get; set; } = null!;

        [Display(Name = "Habilitado")]
        public bool ESTADO { get; set; }

        [Display(Name = "Orden")]
        public int ORDEN { get; set; }
    }
}
