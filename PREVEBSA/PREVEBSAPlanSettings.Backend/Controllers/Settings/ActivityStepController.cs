using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PREVEBSAPlanSettingBackend.Controllers;
using PREVEBSAPlanSettingBackend.UnitsOfWork.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PREVEBSAPlanSettings.ClassLibrary.Entities.Settings;
namespace PREVEBSAPlanSettings.Backend.Controllers.Settings
{ 


    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ActivityStepController : GenericController<ActivityStep>
    {
        public ActivityStepController(IGenericUnitOfWork<ActivityStep> unitOfWork) : base(unitOfWork)
        {

        }
    }
}
