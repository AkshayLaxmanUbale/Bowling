using Bowling.Models;
using Bowling.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.ServicesTests
{
    public class ScoreServiceTests
    {
        private ScoreService scoreService;

        [SetUp]
        public void SetUp()
        {
            scoreService = new ScoreService();
        }

        [Test]
        public void GivenBowlingFrameData1_Returns_FinalScore()
        {
            //Arrange
            var frames = new List<Frame>()
            {
                new Frame(){FirstRoll = 1, SecondRoll= 1},
                new Frame(){FirstRoll = 2, SecondRoll= 1},
                new Frame(){FirstRoll = 2, SecondRoll= 3},
                new Frame(){FirstRoll = 4, SecondRoll= 5},
                new Frame(){FirstRoll = 4, SecondRoll= 3},
                new Frame(){FirstRoll = 6, SecondRoll= 1},
                new Frame(){FirstRoll = 4, SecondRoll= 5},
                new Frame(){FirstRoll = 4, SecondRoll= 5},
                new Frame(){FirstRoll = 3, SecondRoll= 2},
                new Frame(){FirstRoll = 3, SecondRoll= 4,ThirdRoll= 0}
            };

            //Act
            var result = scoreService.Calculate(frames);

            //Assert
            Assert.AreEqual(63, result);
        }

        [Test]
        public void GivenBowlingFrameData2_Returns_FinalScore()
        {
            //Arrange
            var frames = new List<Frame>()
            {
                new Frame(){FirstRoll = 4, SecondRoll= 3},
                new Frame(){FirstRoll = 5, SecondRoll= 5},
                new Frame(){FirstRoll = 4, SecondRoll= 3},
                new Frame(){FirstRoll = 6, SecondRoll= 4},
                new Frame(){FirstRoll = 10, SecondRoll= 0},
                new Frame(){FirstRoll = 10, SecondRoll= 0},
                new Frame(){FirstRoll = 10, SecondRoll= 0},
                new Frame(){FirstRoll = 8, SecondRoll= 2},
                new Frame(){FirstRoll = 4, SecondRoll= 4},
                new Frame(){FirstRoll = 3, SecondRoll= 5,ThirdRoll= 0}
            };

            //Act
            var result = scoreService.Calculate(frames);

            //Assert
            Assert.AreEqual(156, result);
        }

        [Test]
        public void GivenBowlingFrameData3_Returns_FinalScore()
        {
            //Arrange
            var frames = new List<Frame>()
            {
                new Frame(){FirstRoll = 3, SecondRoll= 2},
                new Frame(){FirstRoll = 1, SecondRoll= 1},
                new Frame(){FirstRoll = 3, SecondRoll= 5},
                new Frame(){FirstRoll = 3, SecondRoll= 7},
                new Frame(){FirstRoll = 5, SecondRoll= 5},
                new Frame(){FirstRoll = 4, SecondRoll= 5},
                new Frame(){FirstRoll = 10, SecondRoll= 0},
                new Frame(){FirstRoll = 8, SecondRoll= 2},
                new Frame(){FirstRoll = 10, SecondRoll= 0},
                new Frame(){FirstRoll = 10, SecondRoll= 10,ThirdRoll= 10}
            };

            //Act
            var result = scoreService.Calculate(frames);

            //Assert
            Assert.AreEqual(153, result);
        }
    }
}
