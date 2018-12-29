using System;
using Microsoft.AspNetCore.Mvc;

namespace cs_backend_test.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class TimerController : ControllerBase
  {
    [HttpGet]
    public ActionResult<uint> Get()
    {
      return cs_backend_test.Models.Timer.getTime();
    }

    [HttpPut]
    public void Put([FromBody] string content) {
      int result;
      Boolean success = System.Int32.TryParse(content, out result);

      if (success & result >= 0)
      {
        cs_backend_test.Models.Timer.setTime((uint)result);
      }
    }
  }
}
