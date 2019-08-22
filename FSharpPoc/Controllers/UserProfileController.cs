using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.UserProfile;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FSharpPoc.Controllers
{
    [Route("api/[controller]")]
    public class UserProfileController : Controller
    {
        private readonly IUserProfileService _userProfileService;

        public UserProfileController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [HttpGet("{userId}/address")]
        [ProducesResponseType(typeof(UserAddressOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetUserAddress(long userId)
        {
            var result = _userProfileService.GetUserAddress(userId);
            if (result.IsOk)
                return Ok(result.ResultValue);
            return BadRequest(result.ErrorValue);
        }
    }
}
