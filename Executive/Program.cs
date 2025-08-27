// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using VehicleInheritance;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Hello, World!");
        Vehicle v = new Helicopter();
        v.Start();
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    }
}
