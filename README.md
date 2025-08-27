\# Vehicle Inheritance Demo



This project demonstrates the use of \*\*Interfaces\*\*, \*\*Abstract Classes\*\*, and \*\*Inheritance\*\* in C# using a simple vehicle hierarchy.



---



\# Vehicle Inheritance Demonstration



This project demonstrates \*\*interfaces\*\*, \*\*abstract classes\*\*, and \*\*inheritance\*\* in C# using different types of vehicles.



---



\## How to Run

Navigate to the build output directory:

```

cd Executive/bin/Debug/net8.0

./Executive.exe

```

Alternatively you can double click on Executive.exe to run it



\## Class Hierarchy:


&nbsp;          Vehicle (interface)

&nbsp;                 |

&nbsp;      --------------------------

&nbsp;      |                        |

FlyingVehicle (abstract)      Car

&nbsp;      |

&nbsp; ---------------------

&nbsp; |                   |

Aeroplane         Helicopter



I intentionally didn't make any abstract class like LandVehicles for Car for demonstration purposes

## Changes I have made in the given interface template:


In the given template you have given the function `Start` with return type `void`, in mine I just changed it to `string`



\## Unit Tests

In total I have written 13 unit tests checking every single functionality.

You can find the unit test file under ```UnitTests/InheritanceTests.cs```





