using NUnit.Framework;

[TestFixture]
public class AutoDrivingCarTests
{
    [Test]
    public void TestMoveForward_NorthWithinBounds_ShouldMove()
    {
        // Arrange
        var x = 1;
        var y = 1;
        var direction = 'N';
        var width = 3;
        var height = 3;

        // Act
        AutoDrivingCar.MoveForward(ref x, ref y, direction, width, height);

        // Assert
        Assert.AreEqual(1, x);
        Assert.AreEqual(2, y);
    }

    [Test]
    public void TestMoveForward_EastWithinBounds_ShouldMove()
    {
        // Arrange
        var x = 1;
        var y = 1;
        var direction = 'E';
        var width = 3;
        var height = 3;

        // Act
        AutoDrivingCar.MoveForward(ref x, ref y, direction, width, height);

        // Assert
        Assert.AreEqual(2, x);
        Assert.AreEqual(1, y);
    }

    [Test]
    public void TestMoveForward_SouthWithinBounds_ShouldMove()
    {
        // Arrange
        var x = 1;
        var y = 1;
        var direction = 'S';
        var width = 3;
        var height = 3;

        // Act
        AutoDrivingCar.MoveForward(ref x, ref y, direction, width, height);

        // Assert
        Assert.AreEqual(1, x);
        Assert.AreEqual(0, y);
    }

    [Test]
    public void TestMoveForward_WestWithinBounds_ShouldMove()
    {
        // Arrange
        var x = 1;
        var y = 1;
        var direction = 'W';
        var width = 3;
        var height = 3;

        // Act
        AutoDrivingCar.MoveForward(ref x, ref y, direction, width, height);

        // Assert
        Assert.AreEqual(0, x);
        Assert.AreEqual(1, y);
    }

    [Test]
    public void TestMoveForward_AtNorthBoundary_ShouldNotMove()
    {
        // Arrange
        var x = 1;
        var y = 2;
        var direction = 'N';
        var width = 3;
        var height = 3;

        // Act
        AutoDrivingCar.MoveForward(ref x, ref y, direction, width, height);

        // Assert
        Assert.AreEqual(1, x);
        Assert.AreEqual(2, y);
    }

    // More test cases for boundary conditions, rotations, etc.
}
