using System.ComponentModel.DataAnnotations;


namespace PREVEBSAPlanSettingsClassLibrary.Interfaces
{
    public class IEntityDelete : IEntity
    {
        [Display(Name = "Eliminado")]
        public DateTime? Deleted { get; set; } = null;
    }
}
