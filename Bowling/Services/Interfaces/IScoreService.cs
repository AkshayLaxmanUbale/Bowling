using Bowling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling.Services.Interfaces
{
    public interface IScoreService
    {
        public int Calculate(List<Frame> frames);
    }
}
