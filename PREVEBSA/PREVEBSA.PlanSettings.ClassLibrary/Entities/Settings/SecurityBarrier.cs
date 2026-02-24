using PREVEBSAPlanSettingsClassLibrary.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace PREVEBSAPlanSettingsClassLibrary.Entities.Settings
{
    public class MSecurityBarrier : IEntityDelete
    {
        [Key]
        [Display(Name = "Id")]
        public Guid ID { get; set; }

        [Display(Name = "Tipo")]
        public int TIPO { get; set; }

        [Display(Name = "Regla de oro")]
        public bool REGLAORO { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(1000, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        public string DESCRIPCION { get; set; } = null!;

        [Display(Name = "Habilitado")]
        public bool ESTADO { get; set; }

        [Display(Name = "Orden")]
        public int ORDEN { get; set; }
    }
}
