using Microsoft.AspNetCore.Mvc;
using Mission.Services.IServices;
using Mission.Entities;
using Mission.Entities.Models;


namespace Mission.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientMissionController(IMissionService missionService) : ControllerBase
    {
        private readonly IMissionService _missionService = missionService;
        [HttpGet]
        [Route("ClientSideMissionList/{userId:int}")]
        public async Task<IActionResult> GetClientSideMissionList(int userId)
        {
            var res = await _missionService.GetClientSideMissionList(userId);
            return Ok(new ResponseResult() { Data = res, Result = ResponseStatus.Success, Message = "" });
        }

        [HttpPost]
        [Route("ApplyMission")]
        public async Task<IActionResult> ApplyMission(ApplyMissionRequestModel model)
        {
            var res = await _missionService.ApplyMission(model);
            return Ok(new ResponseResult() { Data = res, Result = ResponseStatus.Success, Message = "" });
        }

    }
}
