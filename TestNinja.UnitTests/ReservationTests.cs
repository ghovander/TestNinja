using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        //Naming Convention for Unit Tests: <Method Under Test>_<Execution Path/Scenario>_<ExpectedBehavior>
        //All test methods should be public void
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            //Arrange (prepare objects under test)
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            //Arrange (prepare objects under test)
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };

            //Act (method under test)
            var result = reservation.CanBeCancelledBy(user);

            //Assert (assertion)
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            //Arrange (prepare objects under test)
            var reservation = new Reservation() { MadeBy = new User() };

            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            Assert.That(result, Is.False);
        }

        //TDD: Test-Driven Development
        //How It Works: Write Failing Tests, Write Enough Code To Make Test Pass, Refactor
        //Benefits of TDD: Testable Source Code, Full Coverage by Tests, Simpler Implementation

        //Good Unit Tests
        //They are:
        //First-Class citizens (just as important as production code)
        //Clean, readable and maintainable: Each test method has a single responsibility and is less than 10 lines of code
        //No logic in the test: Just call method and make assertion
        //Isolated: Test method should be independent and there should not be a state
        //Not too general or specific

        //What To Test
        //Testable code is clean, Clean code is testable
        //Test the outcome of the method
        //2 Types of Functions:
        //-Queries: Returns a value depending upon executing path
        //-Commands: Performs action and may return a value

        //Don't Test (Assume First and Third-Party Libraries Have Been Properly Tested So That Focus Can Be Set Upon Your Code)
        //Language Features
        //3rd-party code

        //Unit Tests - Run During Development (Refactoring, New Features)
        //Integration Tests - Run Before Commit To Repository

        //In Associated Unit Test Project. For each class in target project, create test class
        //that has appended <Class>Tests to the end of name.

        //Number of Tests >= Number of Execution Paths

        //Standard Naming Convention: <Class>_<Scenario>_<ExpectedBehavior>

        //Name of Test should clearly specify business rule being tested

        //If tests are going to polute test class, create class specifically for that test method
        //and use the naming convention <Class>_<Method>Tests
    }
}
