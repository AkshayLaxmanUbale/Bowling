using Bowling.Models;
using Bowling.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling.Services
{
    public class ScoreService : IScoreService
    {
        public int Calculate(List<Frame> frames)
        {
            int score = 0;
            int findex = Constants.LAST_FRAME - 1;
            while (findex >= 0)
            {
                if (findex == Constants.LAST_FRAME - 1)
                {
                    score += frames[findex].FrameScore;
                }
                else
                {
                    int bonus = GetBonus(frames, findex);
                    score += frames[findex].FrameScore + bonus;
                }

                findex--;
            }
            return score;
        }

        private int GetBonus(List<Frame> frames, int findex)
        {
            if (frames[findex].IsSpare)
            {
                return frames[findex + 1].FirstRoll;
            }

            if (frames[findex].IsStrike)
            {
                findex++;
                if (findex == Constants.LAST_FRAME - 1)
                {
                    return frames[findex].FirstRoll + frames[findex].SecondRoll;
                }

                if (frames[findex].IsStrike)
                {
                    return frames[findex].FirstRoll + frames[findex + 1].FirstRoll;
                }

                return frames[findex].FirstRoll + frames[findex].SecondRoll;
            }
            return 0;
        }
    }
}
