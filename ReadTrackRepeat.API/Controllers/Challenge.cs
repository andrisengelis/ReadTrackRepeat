using Microsoft.AspNetCore.Mvc;

namespace ReadTrackRepeat.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ChallengeController : ControllerBase
  {
    [HttpGet]
    public Challenge Get()
    {
      return new Challenge(2019);
    }
  }
}
