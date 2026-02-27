using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PREVEBSAPlanSettingBackend.Controllers;
using PREVEBSAPlanSettingBackend.UnitsOfWork.Interfaces;
using PREVEBSAPlanSettings.ClassLibrary.Entities.Settings;

namespace PREVEBSAPlanSettings.Backend.Controllers.Settings
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ActivityStepRisksController : GenericController<ActivityStepRisks>
    {
        public ActivityStepRisksController(IGenericUnitOfWork<ActivityStepRisks> unitOfWork) : base(unitOfWork)
        {

        }
    }
}