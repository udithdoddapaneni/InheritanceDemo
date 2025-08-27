// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance;
public class Aeroplane : FlyingVehicle, Vehicle
{
    public Aeroplane()
    {
        Console.WriteLine("Aeroplane created");
    }

    public override string Fly()
    {
        string message = Takeoff();
        Console.WriteLine(message);
        return message;
    }
    private string Takeoff()
    {
        return "Taking off";
    }
}
