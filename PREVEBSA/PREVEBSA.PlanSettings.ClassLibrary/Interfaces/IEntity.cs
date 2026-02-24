using System.ComponentModel.DataAnnotations;

namespace PREVEBSAPlanSettingsClassLibrary.Interfaces
{
    public class IEntity
    {
        [Display(Name = "Habilitado")]
        public bool Status { get; set; } = true;

        [Display(Name = "Creado")]
        public DateTime Created { get; set; } = DateTime.Now;

        [Display(Name = "Modificado")]
        public DateTime Updated { get; set; } = default(DateTime);

        [Display(Name = "Tenant")]
        public Guid TenantId { get; set; }
    }
}
