using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using GMERPData.DataStorage;
using GMERPData.Hubs;
using GMERPData.TimerFeatures;

namespace GMERPService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private IHubContext<ChartHub> _hub;

        public ChartController(IHubContext<ChartHub> hub)
        {
            _hub = hub;
        }
     
        [HttpGet]
        public IActionResult Get()
        {
            var timerManager = new TimerManager(
                () => _hub.Clients.All.SendAsync("receivechartdata", DataManager.GetData())
                );
            
            return Ok(new { Message = "Request Completed" });
        }
    }
}