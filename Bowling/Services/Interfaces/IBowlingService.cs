using Bowling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling.Services.Interfaces
{
    public interface IBowlingService
    {
        public int GetFinalScore(List<Frame> frames);
    }
}
