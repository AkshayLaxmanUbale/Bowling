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
        public void WhenFramesWithoutStrikeAndSpares_Returns_FinalScore()
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
        public void WhenFramesWithMultipleStrikes_Returns_FinalScore()
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
        public void WhenLastFrameIsAllStrikes_Returns_FinalScore()
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

        [Test]
        public void WhenFramesWithMultipleSpares_Returns_FinalScore()
        {
            //Arrange
            var frames = new List<Frame>()
            {
                new Frame(){FirstRoll = 2, SecondRoll= 1},
                new Frame(){FirstRoll = 5, SecondRoll= 5},
                new Frame(){FirstRoll = 4, SecondRoll= 6},
                new Frame(){FirstRoll = 7, SecondRoll= 3},
                new Frame(){FirstRoll = 2, SecondRoll= 4},
                new Frame(){FirstRoll = 7, SecondRoll= 3},
                new Frame(){FirstRoll = 2, SecondRoll= 1},
                new Frame(){FirstRoll = 5, SecondRoll= 5},
                new Frame(){FirstRoll = 4, SecondRoll= 5},
                new Frame(){FirstRoll = 6, SecondRoll= 3,ThirdRoll= 0}
            };

            //Act
            var result = scoreService.Calculate(frames);

            //Assert
            Assert.AreEqual(99, result);
        }

        [Test]
        public void WhenLastFrameHasSpare_Returns_FinalScore()
        {
            //Arrange
            var frames = new List<Frame>()
            {
                new Frame(){FirstRoll = 2, SecondRoll= 1},
                new Frame(){FirstRoll = 5, SecondRoll= 5},
                new Frame(){FirstRoll = 4, SecondRoll= 6},
                new Frame(){FirstRoll = 7, SecondRoll= 3},
                new Frame(){FirstRoll = 2, SecondRoll= 4},
                new Frame(){FirstRoll = 7, SecondRoll= 3},
                new Frame(){FirstRoll = 2, SecondRoll= 1},
                new Frame(){FirstRoll = 5, SecondRoll= 5},
                new Frame(){FirstRoll = 4, SecondRoll= 5},
                new Frame(){FirstRoll = 6, SecondRoll= 4,ThirdRoll= 5}
            };

            //Act
            var result = scoreService.Calculate(frames);

            //Assert
            Assert.AreEqual(105, result);
        }

        [Test]
        public void WhenFramesWithOnlySparesAndStrikes_Returns_FinalScore()
        {
            //Arrange
            var frames = new List<Frame>()
            {
                new Frame(){FirstRoll = 5, SecondRoll= 5},
                new Frame(){FirstRoll = 10, SecondRoll= 0},
                new Frame(){FirstRoll = 4, SecondRoll= 6},
                new Frame(){FirstRoll = 7, SecondRoll= 3},
                new Frame(){FirstRoll = 10, SecondRoll= 0},
                new Frame(){FirstRoll = 3, SecondRoll= 7},
                new Frame(){FirstRoll = 10, SecondRoll= 0},
                new Frame(){FirstRoll = 10, SecondRoll= 0},
                new Frame(){FirstRoll = 10, SecondRoll= 0},
                new Frame(){FirstRoll = 4, SecondRoll= 6,ThirdRoll= 10}
            };

            //Act
            var result = scoreService.Calculate(frames);

            //Assert
            Assert.AreEqual(211, result);
        }
    }
}
