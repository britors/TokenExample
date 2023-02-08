using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TokenExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] UserAuth user)
        {
            var userInfo = new UserInfo {
                Email = user.Email,
                Id = Guid.NewGuid(),
                Name = "User Name",
                Applications = new UserApplcation[] {
                    
                    new UserApplcation {
                        Profile = Profile.User,
                        Application = new Application {
                            Code = "APP1",
                            Description = "Application 1",
                            Name = "Application 1"
                        }
                    },
                    new UserApplcation {
                        Profile = Profile.Admin,
                        Application = new Application {
                            Code = "APP2",
                            Description = "Application 2",
                            Name = "Application 2"
                        }
                    }
                }
            };
            var token = TokenHelper.GenerateToken(userInfo);
            return Ok(token);
        }
    }
}
