using Bowling.Models;
using Bowling.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling.Services
{
    public class BowlingService : IBowlingService
    {
        private IScoreService _scoreService;
        public BowlingService(IScoreService scoreService) 
        {
            _scoreService = scoreService;   
        }

        public int GetFinalScore(List<Frame> frames)
        {
            return _scoreService.Calculate(frames);
        }
    }
}
