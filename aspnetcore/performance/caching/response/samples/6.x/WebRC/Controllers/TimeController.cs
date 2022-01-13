﻿using Microsoft.AspNetCore.Mvc;

namespace WebRC.Controllers;
#region snippet
[ApiController]
public class TimeController : ControllerBase
{
    [Route("api/[controller]")]
    [HttpGet]
    [ResponseCache(VaryByHeader = "User-Agent", Duration = 30)]
    public ContentResult GetTime() => Content(
                      DateTime.Now.Millisecond.ToString());
    #endregion

    #region snippet2
    [Route("api/[controller]/ticks")]
    [HttpGet]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public ContentResult GetTimeTicks() => Content(
                      DateTime.Now.Ticks.ToString());
    #endregion

    #region snippet3
    [Route("api/[controller]/ms")]
    [HttpGet]
    [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any, NoStore = false)]
    public ContentResult GetTimeMS() => Content(
                      DateTime.Now.Millisecond.ToString());
#endregion
}

