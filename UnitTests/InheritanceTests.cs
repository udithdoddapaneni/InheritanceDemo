// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using VehicleInheritance;

namespace UnitTests;

[TestClass]
public sealed class InheritanceTests
{
    [TestMethod]
    public void TestCarInheritance()
    {
        Vehicle toyota = new Car("Toyota");
        Assert.AreEqual(toyota.Start(), "Staring the engine of the car named Toyota");
        Vehicle audi = new Car("Audi");
        Assert.AreEqual(audi.Start(), "Staring the engine of the car named Audi");
    }
    [TestMethod]
    public void TestAeroplaneInhertiance()
    {
        Vehicle aircraft1 = new Aeroplane();
        Assert.AreEqual(aircraft1.Start(), "Taking off");
        FlyingVehicle aircraft2 = new Aeroplane();
        Assert.AreEqual(aircraft2.Start(), "Taking off");
    }
    [TestMethod]
    public void TestHelicopterInhertiance()
    {
        Vehicle heli1 = new Helicopter();
        Assert.AreEqual(heli1.Start(), "Lifting off");
        FlyingVehicle heli2 = new Helicopter();
        Assert.AreEqual(heli2.Start(), "Lifting off");
    }
}
