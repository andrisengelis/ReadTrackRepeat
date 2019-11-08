using Microsoft.AspNetCore.Mvc;
using ReadTrackRepeat.Data;

namespace ReadTrackRepeat.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ChallengeController : ControllerBase
  {
    [HttpGet]
    public Challenge Get()
    {
      return new Challenge();
    }
  }
}
