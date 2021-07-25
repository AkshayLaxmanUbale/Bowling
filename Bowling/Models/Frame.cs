using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling.Models
{
    public class Frame
    {
        public int FirstRoll { get; set; }
        public int SecondRoll { get; set; }
        public int ThirdRoll { get; set; }

        public bool IsSpare => FirstRoll != Constants.TOTAL_BALLS && FirstRoll + SecondRoll == Constants.TOTAL_BALLS;
        public bool IsStrike => FirstRoll == Constants.TOTAL_BALLS;
        public int FrameScore => FirstRoll + SecondRoll + ThirdRoll;
    }
}
