namespace Intelligent_Video_Surveillance_System.Server.Controllers
{
    public class UserController : BaseController
    {
        public UserController(DataContext dataContext) : base(dataContext) {}

        [HttpGet("{number}")]
        public string getUser(string number)
        {
            return number;
        }

        [HttpPost]
        public ActionResult<UserEntity> Post(UserEntity entity)
        {
            _dataContext.Users.Add(entity);
            _dataContext.SaveChanges();

            return Ok(entity);
        }

        [HttpGet("get_all")]
        public ActionResult<List<UserEntity>> GetAllUsers() 
        {
            return Ok(_dataContext.Users.ToList());
        }
    }
}
