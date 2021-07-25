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
        private IScoreService _scoreService;
        public BowlingController(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        [HttpPost("score")]
        public IActionResult GetScore(List<Frame> frames)
        {
            if(frames.Count <= 0 || frames.Count > 10)
            {
                throw new InvalidOperationException("Frame Count should be greater than 0 and less than or equal to 10.");
            }

            int score = _scoreService.Calculate(frames);
            return Ok(score);
        }
    }
}
