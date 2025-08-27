// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance;
public class Car : Vehicle
{
    private string _name;
    public Car(string name)
    {
        _name = name;
        Console.WriteLine($"Car named {_name} created");
    }
    public string GetCarName()
    {
        return _name;
    }
    public string Start()
    {
        Console.WriteLine($"Staring the engine of the car named {_name}");
        return $"Staring the engine of the car named {_name}";
    }
}
