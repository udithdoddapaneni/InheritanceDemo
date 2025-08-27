// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance;
public class Helicopter : FlyingVehicle, Vehicle
{
    public Helicopter()
    {
        Console.WriteLine("Helicopter created");
    }

    public override string Fly()
    {
        string message = LiftOff();
        Console.WriteLine(message);
        return message;
    }
    public string LiftOff()
    {
        return "Lifting off";
    }
}
