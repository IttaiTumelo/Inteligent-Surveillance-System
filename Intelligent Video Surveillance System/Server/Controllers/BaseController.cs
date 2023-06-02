namespace Intelligent_Video_Surveillance_System.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        public readonly DataContext _dataContext;

        public BaseController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
