using Lift;

namespace LiftTests
{
    public class LiftTests
    {
        [Test]
        public void FitPeopleOnTheLiftAndGetResult_TheLiftHas1EmptySpot()
        {
            var waitingPeopleCount = 15;
            int[] inputLiftState = {0, 0, 0, 0};

            var liftSimulator = new LiftSimulator();
            var liftState = liftSimulator.FitPeopleOnTheLiftAndGetResult(waitingPeopleCount, inputLiftState);

            Assert.That(liftState.ToString, Is.EqualTo("The lift has 1 empty spots!\r\n4 4 4 3"));
        }

        [Test]
        public void FitPeopleOnTheLiftAndGetResult_NotEnoughSpace()
        {
            var waitingPeopleCount = 20;
            int[] inputLiftState = { 0, 2, 0 };

            var liftSimulator = new LiftSimulator();
            var liftState = liftSimulator.FitPeopleOnTheLiftAndGetResult(waitingPeopleCount, inputLiftState);

            Assert.That(liftState.ToString, Is.EqualTo("There isn't enough space! 10 people in a queue!\r\n4 4 4"));
        }

        [Test]
        public void FitPeopleOnTheLiftAndGetResult_LiftIsFull()
        {
            var waitingPeopleCount = 3;
            int[] inputLiftState = {2, 4, 3};

            var liftSimulator = new LiftSimulator();
            var liftState = liftSimulator.FitPeopleOnTheLiftAndGetResult(waitingPeopleCount, inputLiftState);

            Assert.That(liftState.ToString, Is.EqualTo("All people placed and the lift if full.\r\n4 4 4"));
        }

        [Test]
        public void FitPeopleOnTheLift_ValidInput()
        {
            var waitingPeopleCount = 3;
            int[] inputLiftState = { 2, 4, 3 };

            var liftSimulator = new LiftSimulator();
            var liftState = liftSimulator.FitPeopleOnTheLift(waitingPeopleCount, inputLiftState);
            //Console.WriteLine(liftState.ToString());
            Assert.That(liftState.ToString(), Is.EqualTo("4, 4, 0"));
        }

        [Test]
        public void FitPeopleOnTheLift_InvalidPeopleCount()
        {
            var waitingPeopleCount = 0;
            int[] inputLiftState = { 2, 4, 3 };

            var liftSimulator = new LiftSimulator();
            
            Assert.That(() => liftSimulator.FitPeopleOnTheLift(waitingPeopleCount, inputLiftState), Throws.InstanceOf<ArgumentException>());
        }

        [Test]
        public void FitPeopleOnTheLift_InvalidLiftSize()
        {
            var waitingPeopleCount = 3;
            int[] inputLiftState = { 2, 4, 5 };

            var liftSimulator = new LiftSimulator();

            Assert.That(() => liftSimulator.FitPeopleOnTheLift(waitingPeopleCount, inputLiftState), Throws.InstanceOf<ArgumentException>());
        }

        [Test]
        public void FitPeopleOnTheLift_InvalidLiftState()
        {
            var waitingPeopleCount = 3;
            int[] inputLiftState = null;

            var liftSimulator = new LiftSimulator();
            //var liftState = liftSimulator.FitPeopleOnTheLift(waitingPeopleCount, inputLiftState);

            Assert.That(() => liftSimulator.FitPeopleOnTheLift(waitingPeopleCount, inputLiftState), Throws.InstanceOf<ArgumentException>());
        }



    }
}