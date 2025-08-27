// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using VehicleInheritance;

namespace UnitTests;

[TestClass]
public sealed class InheritanceTests
{
    [TestMethod]
    public void Test1()
    {
        Vehicle toyota = new Car("Toyota");
        Assert.AreEqual(toyota.Start(), "Staring the engine of the car named Toyota");
    }
    [TestMethod]
    public void Test2()
    {
        Vehicle audi = new Car("Audi");
        Assert.AreEqual(audi.Start(), "Staring the engine of the car named Audi");
    }
    [TestMethod]
    public void Test3()
    {
        Vehicle aircraft = new Aeroplane();
        Assert.AreEqual(aircraft.Start(), "Taking off");
    }
    [TestMethod]
    public void Test4()
    {
        FlyingVehicle aircraft = new Aeroplane();
        Assert.AreEqual(aircraft.Start(), "Taking off");
    }
    [TestMethod]
    public void Test5()
    {
        Vehicle heli = new Helicopter();
        Assert.AreEqual(heli.Start(), "Lifting off");
    }
    [TestMethod]
    public void Test6()
    {
        FlyingVehicle heli = new Helicopter();
        Assert.AreEqual(heli.Start(), "Lifting off");

    }
    [TestMethod]
    public void Test7()
    {
        Car toyota = new Car("Toyota");
        Assert.AreEqual(toyota.Start(), "Staring the engine of the car named Toyota");
    }
    [TestMethod]
    public void Test8()
    {
        Aeroplane aircraft = new Aeroplane();
        Assert.AreEqual(aircraft.Start(), "Taking off");
    }
    [TestMethod]
    public void Test9()
    {
        Helicopter heli = new Helicopter();
        Assert.AreEqual(heli.Start(), "Lifting off");
    }
    [TestMethod]
    public void Test10()
    {
        FlyingVehicle heli = new Helicopter();
        Assert.AreEqual(heli.Fly(), "Lifting off");
    }
    [TestMethod]
    public void Test11()
    {
        FlyingVehicle aircraft = new Aeroplane();
        Assert.AreEqual(aircraft.Fly(), "Taking off");
    }
    [TestMethod]
    public void Test12()
    {
        Aeroplane aircraft = new Aeroplane();
        Assert.AreEqual(aircraft.Fly(), "Taking off");
    }
    [TestMethod]
    public void Test13()
    {
        Car audi = new Car("Audi");
        Assert.AreEqual(audi.GetCarName(), "Audi");
    }
}
