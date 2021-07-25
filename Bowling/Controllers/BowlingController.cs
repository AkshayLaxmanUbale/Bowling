using Bowling.Models;
using Bowling.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling.Controllers
{
    [Route("api/bowling")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingService _bowlingService;
        public BowlingController(IBowlingService bowlingService)
        {
            _bowlingService = bowlingService;
        }

        [HttpPost("score")]
        public IActionResult GetScore(List<Frame> frames)
        {
            int score = _bowlingService.GetFinalScore(frames);
            return Ok(score);
        }
    }
}
