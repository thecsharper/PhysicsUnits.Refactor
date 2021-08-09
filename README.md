Taking Your Brain To Another Dimension - A C# library for Physical Units
========================================================================

## Introduction

The initial inspiration for this project is the loss of NASA's Mars Climate Orbiter in 1999.
This failed to enter Mars orbit due to a mix up between metric (SI) and United States Customary Units.
One sub-system was supplying measurements in pound-force seconds to another sub-system expecting them
in Newton Seconds.  As the probe braked to enter orbit it travelled too close to the planet's atmosphere and either burned up or ricocheted off into solar orbit.

So I have tried to build a code library in which this kind of error should be ruled out by design.  So it has the
following features:
* It can be used to perform many standard calculations from physics and engineering.
* It is based on dimensional analysis, so all quantities have a corresponding physical dimension, such as Length or Mass.
* It is strongly typed, so quantities of different dimension can only be combined in scientifically valid ways.
* Internally all values are stored in S.I. (metric) units.
* Values are only converted to a particular system of units at its external interfaces, for example when 
converting to and from strings.

It is written using C# version 9 and utilises the .Net 5.0 framework.

Here is an example of the library in use:
```C#
        // Tsiolkovsky rocket equation
        Mass EmptyMass = 120000.Kilograms();
        Mass PropellantMass = 1200000.Kilograms();
        Mass WetMass = EmptyMass + PropellantMass;
        Velocity ExhaustVelocity = 3700.MetresPerSecond();
        Velocity DeltaV = ExhaustVelocity * Math.Log(WetMass / EmptyMass);
        // DeltaV = 8872.21251 m/s
```

Throughout this article, and in the sample code and unit tests, I have used examples from my old grammar school physics textbook - *Nelkon and Parker Advanced Level Physics*.  This was the standard sixth form physics book in Britain throughout the sixties and seventies.

## Background
The library is based on the concepts of _dimensions_ and _units_.
### Dimensions

The *Dimension* of a physical quantity determines how it is related to a set of fundamental quantities such as mass, length and time.  These are usually abbreviated to M, L, T etc.  New dimensions can be derived by combining these fundamental ones using multiplication and division.  So 
- Area = Length x Length = L²
- Volume  = Length x Length x Length = L³
- Density = Mass / Volume = M/L³ = ML⁻³
- Velocity = Length / Time = L/T = LT⁻¹
- Acceleration = velocity / Time = LT⁻²
- Force = Mass * Acceleration = MLT⁻²

And so on.

The dimension of any particular quantity can be represented as a sequence of powers of the fundamental dimensions (e.g. Force = MLT⁻² above). It is invalid to try to add or subtract quantities if their dimensions do not match.  So it is invalid to **add** a mass to a volume for instance.

The International System of Units (S.I.) uses the following basic dimensions:

|Dimension|Symbol|Unit|Unit Symbol|
|---------|------|----|-----------|
|Mass|M|kilogramme|kg|
|Length|L|metre|m|
|Time|T|second|s|
|Electric Current|I|ampere|A|
|Thermodynamic Temperature|Θ|kelvin|K|
|Amount of Substance|N|mole|mol|
|Luminous Intensity|J|candela|cd|

The library defines these basic dimensions, and many derived ones.
### Units

A unit system can define different basic units to correspond to the various dimensions.  So whereas the S.I. system has a unit of kilogrammes for mass, the American and British systems use the pound. Similarly we have the foot in place of the metre as the unit of length.  There are also differences between the American and British systems when it comes to measurement of volume.  Thankfully the units for the other basic dimensions are the same in all three systems.

Although the library has definitions for both the S.I., American and British systems it is possible to create and use new ones.  For example you could create a system using the Japanese shakkanho system, with the shaku (尺) as the unit of length and the kan (貫) as the unit of mass.

## Using the Code

The supplied code in the attached ZIP consists of a Visual Studio Solution with two projects: the library itself and a command line programme which tests and demonstrates the library features.  To use the library in your own project add the library project file in "\KMB.Library.Units\KMB.Library.Units.csproj" then add the following using statements to your code:
```C#
using KMB.Library.Units;
using KMB.Library.Units.Metric;
using KMB.Library.Units.TimeUnits;      // for hours, minutes etc.
using KMB.Library.Units.British;        // For feet and pounds.  Or use USA if you prefer
```

The Units library defines various classes and interfaces.  The primary ones are discussed here:

### class *Dimensions*

This class is used to represent a physical dimension or combination of them. It has a read-only field for the power of each dimension:

```C#
        public readonly short M; // Mass
        public readonly short L; // Length
        public readonly short T; // Time
        public readonly short I; // Current
        public readonly short Θ; // Temperature
        public readonly short N; // Amount of Substance
        public readonly short J; // Luminous Intensity
        public readonly short A; // Angle. 
```
Note the value for angle.  Strictly angles are dimensionless, but it is convenient to treat them as having a distinct dimension.  This way we can distinguish angles from dimensionless quantities, when converting to a string, for example.

The class has various constructors, and also defines operators for multiplication and division:

```C#
       public static Dimensions operator *(Dimensions d1, Dimensions d2)...

       public static Dimensions operator /(Dimensions d1, Dimensions d2)...
```

Using this class we can define the basic dimensions:

```C#
        public static readonly Dimensions Dimensionless = new Dimensions(0, 0, 0);
        public static readonly Dimensions Mass = new Dimensions(1, 0, 0);
        public static readonly Dimensions Length = new Dimensions(0, 1, 0);
        public static readonly Dimensions Time = new Dimensions(0, 0, 1);
                :
```

And define any derived dimensions:

```C#
        public static readonly Dimensions Area = Length * Length;
        public static readonly Dimensions Volume = Area * Length;
        public static readonly Dimensions Density = Mass / Volume;
        public static readonly Dimensions Velocity = Length / Time;
        public static readonly Dimensions AngularVelocity = Angle / Time;
                :
```
The overloaded `ToString()` method of `Dimensions` outputs the powers of each dimension:

```C#
        Dimensions.Pressure.ToString()  // returns "M1 L-1 T-2"
        Dimensions.Resistivity.ToString()  // returns "M1 L3 T-3 I-2"
```

### Interface *IPhysicalQuantity*

This interface is the basis for all physical quantitities in the system.  It has two properties:

```C#
        double Value { get; }
        Dimensions Dimensions { get; }
```
For each defined value of `Dimensions` there will be a corresponding structure which implements the `IPhysicalQuantity` interface.  For example *Length*, *Area*, *Mass* and so on.

### Example Physical Quantity - *Length*

The `Length` structure implements the `IPhysicalQuantity` interface:

```C#
        public readonly partial struct Length: IPhysicalQuantity
```
It has a read-only `Value` property:
```C#
        public readonly double Value { get; init; }
```
And a `Dimensions` property:
```C#
        public readonly Dimensions Dimensions { get { return Dimensions.Length; } }
```
Notice how the `Dimensions` property returns the corresponding statically defined `Dimensions` value.

So given this structure we can now define a variable to represent a particular length:
```C#
        Length l0 = new Length(3.4);        // 3.4 metres
```
The struct defines lots of operators.  For example you can add a length to another one:
```C#
        public static Length operator+(Length v1, Length v2)
        {
            return new Length(v1.Value + v2.Value);
        }
```
Or compare two lengths:
```C#
       public static bool operator >(Length v1, Length v2)
        {
            return Compare(v1, v2) > 0;
        }
```
Or you can create an Area by multiplying two lengths together:
```C#
        public static Area operator*(Length v1, Length v2)
        {
            return new Area(v1.Value * v2.Value);
        }
```
Or a Velocity by dividing a length by a time:
```C#
        public static Velocity operator/(Length v1, Time v2)
        {
            return new Velocity(v1.Value / v2.Value);
        }
```
Here's this divide operator in use:
 ```C#
        Length l = 100.Metres();
        Time t = 9.58.Seconds();
        Velocity v = l / t;         // v = 10.43 m/s
```
There are also various `ToString()` and `Parse()` methods:
```C#
        public override string ToString();
        public string ToString(UnitsSystem.FormatOption option);
        public string ToString(UnitsSystem system, UnitsSystem.FormatOption option);
        public string ToString(params Unit[] units);
        public static Length Parse(string s);
        public static Length Parse(string s, UnitsSystem system);
 ```
The formatting and parsing of strings is actually delegated to the current unit system.  See below.

Here are some examples to demonstrate the various options for `ToString()` and `Parse()`:
```C#
        Length l = 1234.567.Metres();
        string s = l.ToString();    // s = "1.234567 km" (same as BestFit)
        // Formatting options:
        s = l.ToString(UnitsSystem.FormatOption.Standard);    // s = "1234.567 m" (force to metres)
        s = l.ToString(UnitsSystem.FormatOption.BestFit);     // s = "1.234567 km"
        s = l.ToString(UnitsSystem.FormatOption.Multiple);    // s = "1 km 234 m 56 cm 7 mm"
        // Specify the units:
        s = l.ToString(MetricUnits.Metres, MetricUnits.Centimetres);    // s = "1234 m 56.7 cm" 
        // British units:
        s = l.ToString(BritishUnits.System, UnitsSystem.FormatOption.Standard);     // s = "4050.41667 ft"
        s = l.ToString(BritishUnits.System, UnitsSystem.FormatOption.BestFit);      // s = "1350.13889 yd"
        s = l.ToString(BritishUnits.System, UnitsSystem.FormatOption.Multiple);     // s = "1350 yd 5 in"
        // Specified British units:
        s = l.ToString(BritishUnits.Miles, BritishUnits.Feet, BritishUnits.Inches); // s = "4050 ft 5 in"

        l = Length.Parse("42 m");    // l = 42 m
        l = Length.Parse("42 m 76 cm"); // l = 42.76 m
        l = Length.Parse("5 ft 4 in", BritishUnits.System); // l = 1.6256 m
        // This will throw an exception
        l = Length.Parse("42 m 76 kg");
```
Because there are so many classes, operators and methods required for the quantities these classes are generated using the T4 Template processor.  See the Code Generation section.

### Temperatures
The library contains two classes for dealing with temperatures - `AbsoluteTemperature` and `TemperatureChange`.  The first is used
for absolute temperatures, as you would read from a thermometer:
```C#
        AbsoluteTemperature t3 = 600.65.Kelvin();       // melting point of lead
        AbsoluteTemperature c2 = 60.Celsius();          // c2 = 333.15 K
```
The second is used in many formulae where it is the temperature change that is important:
```C#
        TemperatureChange deltaT = 100.Celsius() - 20.Celsius();
        ThermalCapacity tcKettle = 100.CaloriesPerDegreeKelvin();
        SpecificHeat shWater = 4184.JoulesPerKilogramPerDegreeKelvin();
        Mass mWater = 1.Kilograms();
        ThermalCapacity tcWater = mWater * shWater;
        ThermalCapacity tcTotal = tcKettle + tcWater;
        Energy e = tcTotal * deltaT;    // e = 368208 J
```
### struct PhysicalQuantity
This is the get out of jail card for cases when the strongly typed quantities won't do.  It is weakly typed so has its own member to represent the dimensions:
```C#
    public readonly partial struct PhysicalQuantity: IPhysicalQuantity
    {
        public double Value { get; init; }
        public Dimensions Dimensions { get; init; }
```
Like the strongly typed quantities it has operators for addition etc, but these are checked at run time instead of preventing compilation.  So it is possible to do this:
 ```C#
        PhysicalQuantity l1 = new PhysicalQuantity(2.632, Dimensions.Length);
        PhysicalQuantity l2 = new PhysicalQuantity(2.632, Dimensions.Length);
        PhysicalQuantity sum = l1 + l2;
```
But this will throw an exception:
```C#
        PhysicalQuantity m = new PhysicalQuantity(65, Dimensions.Mass);
        sum = l1 + m;
```
But multiplication and division will correctly calculate the correct dimensions:
```C#
        PhysicalQuantity product = l1 * m;
        string s = product.ToString(); // s = "171.08 kg⋅m"
```
### class *UnitsSystem*

The library defines an abstract base class for unit systems:
```C#
        public abstract class UnitsSystem
```
Subclasses of `UnitsSystem` are responsible for converting quantities to and from strings.  So there are various `ToString()` and
`Parse()` methods.  There is also a static reference to the current units system, which defaults to Metric.
```C#
        public static UnitsSystem Current = Metric;
```
By default the ToString() and Parse() methods will use the current unit system.
```C#
        internal static string ToString(IPhysicalQuantity qty)
        {
            return Current.DoToString(qty);
        }
```
```C#
        internal static PhysicalQuantity Parse(string s)
        {
            return Current.DoParse(s);
        }
```
Or you can specify which system to use:
```C#
        internal static string ToString(IPhysicalQuantity qty, UnitsSystem system)
        {
            return system.DoToString(qty);
        }
```
```C#
        public static PhysicalQuantity Parse(string s, UnitsSystem system)
        {
            return system.DoParse(s);
        }
```
By default the unit system will perform the string conversion using a lookup table of unit definitions.  The unit definition uses this class:
```C#
    public class Unit
    {
        public string Name;
        public string ShortName;
        public Dimensions Dimensions;
        public double ConversionFactor; //to convert from ISO units
                        :
```
So for example here are some of the definitions for the metric system:
```C#
	public static Unit Metres = new Unit("metres", "m", Dimensions.Length, 1.0, Unit.DisplayOption.Standard);
	public static Unit SquareMetres = new Unit("squaremetres", "m²", Dimensions.Area, 1.0, Unit.DisplayOption.Standard);
	public static Unit CubicMetres = new Unit("cubicmetres", "m³", Dimensions.Volume, 1.0, Unit.DisplayOption.Standard);
	public static Unit Kilograms = new Unit("kilograms", "kg", Dimensions.Mass, 1.0, Unit.DisplayOption.Standard);
	public static Unit Seconds = new Unit("seconds", "s", Dimensions.Time, 1.0, Unit.DisplayOption.Standard);
```
Or similar ones for the British units:
```C#
	public static Unit Feet = new Unit("feet", "ft", Dimensions.Length, feetToMetres, Unit.DisplayOption.Standard);
	public static Unit Inches = new Unit("inches", "in", Dimensions.Length, (feetToMetres/12.0), Unit.DisplayOption.Multi);
	public static Unit Fortnight = new Unit("fortnight", "fn", Dimensions.Time, 3600.0*24.0*14.0, Unit.DisplayOption.Explicit);
	public static Unit Pounds = new Unit("pounds", "lb", Dimensions.Mass, poundsToKilogrammes, Unit.DisplayOption.Standard);
```
The unit system also defines a set of extension methods like this:
```C#
        public static Length Metres(this double v)
        {
                return new Length(v);
        }
```
That allows easy creation of a quantity from a floating point or integer value:
```C#
        Length l1 = 4.2.Metres();
        Mass m1 = 12.Kilograms();
```

## Code Generation
As mentioned previously, because the library has a lot of repetitive code we use the T4 macro processor available in Visual studio.
This tool allows us to automate the creation of source code by creating a template file which contains a mix of C# code and the required output text.  In general we start with an XML file of definitions which we read, then use the template to generate the required C# classes and data.

For example, here is a line from the XML file defining the metric unit system:
```XML
  <unit name="Volts" shortname="volt"  dimension="ElectricPotential"  display="Standard" />
```
This template snippet will then create the static unit definitions:
```C#
<#+
	foreach(var ui in unitInfoList)
	{
#>
		public static Unit <#= ui.longName #> = new Unit("<#= ui.longName.ToLower() #>", "<#= ui.shortName #>",
                        Dimensions.<#= ui.dimension #>, <#= ui.factor #>, Unit.DisplayOption.<#= ui.displayOption #>);
<#+
	}	// end for ui
#>
```
Resulting in a line like this in the final code:
```C#
	public static Unit Volts = new Unit("volts", "volt", Dimensions.ElectricPotential, 1.0, Unit.DisplayOption.Standard);
```
This technique allows us to generate the large number of operator definitions we require for each quantity class.  For example given this definition in the Dimensions.xml file:
```XML
  <dimension name="Density"           equals="Mass / Volume" />
```
We can generate the Density class and all of the following operators:
```C#
        public static Density operator/(Mass v1, Volume v2)
        public static Volume operator/(Mass v1, Density v2)
        public static Mass operator*(Volume v1, Density v2)
```
The following XML definition files are supplied:

|File|Description|
|---------|------|
|Dimensions.xml|This defines the dimensions and the relations between them|
|MetricUnits.xml|Unit definitions for the metric system|
|BritishUnits.xml|British units like foot and pound|
|USAUnits.xml|American Units.  These overlap with the British units somewhat.|
|TimeUnits.xml|Units of time apart from the second, such as hours and days|

## More Examples
Here are some more examples using the library, based on questions from _Nelkon and Parker_.

The reckless jumper:
```C#
        // A person of mass 50 kg who is jumping from a height of 5 metres will land on the ground
        // with a velocity = √2gh = √ 2 x 9.8 x 5 = 9.9 m/s , assuming g = 9.8 m/s.
        Length h = 5.Metres();
        Acceleration g = 9.80665.MetresPerSecondSquared();
        Velocity v = Functions.Sqrt(2 * g * h); // v = 9.90285312 m/s
        // If he does not flex his knees on landing, he will be brought to rest very quickly, say in
        // 1/10th second.  The force F acting is then given by momentum change/time = 50 * 9.9 / 0.1 = 4951 N
        Momentum mm = m * v;
        Time t = 0.1.Seconds();
        Force f = mm / t; // f = 4951.42656 N
```
And the flying cricket ball:
 ```C#
        // Suppose a cricket ball was thrown straight up with an initial velocity, u, of 30 ms - 1.
        // The time taken to reach the top of its motion can be obtained from the equation
        // v = u + at.
        // The velocity, v, at the top is zero; and since u = 30 m and a = —9.8 or 10 ms^2(approx),
        // we have 30 - 10t = 0.
        // Therefore t = 30 / 10 = 3s
        // The highest distance reached is thus given by
        // d = ut + 1 / 2 at ^ 2 = 30x3 - 5x3 ^ 2 = 45 m.
        var u = 30.MetresPerSecond();
        var g = 9.80665.MetresPerSecondSquared();
        var t = u / g;  // t = 3.05914864 s
        var d = u * t + -g * t * t / 2.0;   // d = 45.8872296 m
```
## Points of Interest
### Unit Tests
The sample program also tests the library, but does not use a unit testing framework. Instead it uses a simple static class Check which allows us to write code like this:
```C#
       Check.Equal(42.0, d5, "wrong value for d5");
```
This will throw an exception if the first two arguments are not equal.
### Performance
I had hoped that by creating immutable data types and making copious use of the aggresive inlining and aggressive optimisation hints 
that the performance of the quantity classes would be comparible to the performance of 'raw' doubles.  But this has turned out not
to be the case.  To test this I implemented the same rocket simulation twice, once using plain doubles and again using the quantity
classes.  In a release build the version using doubles is around 6 times faster.  The reason can be seen by examining the code generated for some typical arithmetic.  For example this code:
```C#
        double d1 = 4.2;
        double d2 = 5.3;
        double d3 = 6.4;
        double d4 = d1 + d2 + d3;
```
Generates code for the addition like this:
```
00007FFCCC4B6A46  vmovsd      xmm3,qword ptr [rbp-8]  
00007FFCCC4B6A4B  vaddsd      xmm3,xmm3,mmword ptr [UnitTests.Program.TestDouble()+0B0h (07FFCCC4B6AC0h)]  
00007FFCCC4B6A53  vaddsd      xmm3,xmm3,mmword ptr [rbp-10h]  
00007FFCCC4B6A58  vmovsd      qword ptr [rbp-18h],xmm3  
```
Whereas the same formula using the class library:
```C#
        Dimensionless d1 = 4.2;
        Dimensionless d2 = 5.3;
        Dimensionless d3 = 6.4;
        Dimensionless d4 = d1 + d2 + d3;
```
Generates much longer code:
```
00007FFCD5726B59  mov         rcx,qword ptr [rsp+70h]  
00007FFCD5726B5E  mov         qword ptr [rsp+58h],rcx  
00007FFCD5726B63  mov         rcx,qword ptr [rsp+68h]  
00007FFCD5726B68  mov         qword ptr [rsp+50h],rcx  
00007FFCD5726B6D  vmovsd      xmm0,qword ptr [rsp+58h]  
00007FFCD5726B73  vaddsd      xmm0,xmm0,mmword ptr [rsp+50h]  
00007FFCD5726B79  vmovsd      qword ptr [rsp+48h],xmm0  
00007FFCD5726B7F  mov         rcx,qword ptr [rsp+48h]  
00007FFCD5726B84  mov         qword ptr [rsp+40h],rcx  
00007FFCD5726B89  mov         rcx,qword ptr [rsp+60h]  
00007FFCD5726B8E  mov         qword ptr [rsp+38h],rcx  
00007FFCD5726B93  vmovsd      xmm0,qword ptr [rsp+40h]  
00007FFCD5726B99  vaddsd      xmm0,xmm0,mmword ptr [rsp+38h]  
00007FFCD5726B9F  vmovsd      qword ptr [rsp+30h],xmm0  
00007FFCD5726BA5  mov         rcx,qword ptr [rsp+30h]  
00007FFCD5726BAA  mov         qword ptr [rsp+78h],rcx  
```
There are lots of superfluous move instructions.  Perhaps someone with a deeper understanding of the JIT compiler can shed some light on this.
### Comparison with F#
The F# language has built in support for units of measure, which also has the aim of preventing programming errors. So it is possible to write statements like this:
```F#
    let l1    = 12.0<m>     // define a length in metres
    let l2    = 7.0<m>      // define another length
    let l3 = l1 + l2        // add lengths together
    let a = l1 * l2         // define an area (a has type float<m^2>)
    let v = l1 * l2 * l3    // define a volume (v has type float<m^3>)
    let m1 = 5.0<kg>        // define a mass in kilogrammes
    let d = m1 / v;         // define a density (d has type float<kg/m^3>)
```
And given the above, this statement will not compile:
```F#
    let x = m1 + l1;        // !! The unit of measure 'm' does not match the unit of measure 'kg'
```
The standard library of units defines the basic S.I. unit like metre, but does not define derived units like centimetres.  You can define your own units like this:
```F#
[<Measure>] type cm     // centimetres
```
And you can use it in the same way:
```F#
    let l4 = 42.0<cm>
```
But there is no way to indicate that centimetres and metres are the same dimension.  So whereas l1 above has type `float<m>`, l4 has type `float<cm>`, and attempting to add them will not compile:
```F#
    let l5 = l1 + l4;    // !! The unit of measure 'cm' does not match the unit of measure 'm'
```
You can only get around this by defining a conversion function:
```F#
let convertcm2m (x : float<cm>) = x / 1000.0<cm/m>
```
Then using it in the expression:
```F#
    let l5 = l1 + convertcm2m(l4);
```
You also have to be careful to always use the same numeric type when using units of measure.  This is because in this definition:
```F#
    let l6 = 5<m>
```
The type of l6 is `int<m>`, and this cannot be added to a value of type `float<m>`.  So this line will not compile either:
```F#
    let l7 = l1 + l6;    // !! The type float<m> does not match the type int<m>
```
Finally, although the units of measure are checked at compile time the types do not carry through to the compiled code.  The values 
are just defined as floating point numbers.  Consequently you cannot discover at run time what the unit of measure of a value actually is.  So you can only print these types of values as floating point, like this:
```F#
    printfn "l5 = %e" l5        // outputs "l5 = 1.204200e+001" 
```
Even if you use the format specifier %O:
```F#
    printfn "l5 = %O" l5        // outputs "l5 = 12.042" 
```
So although the F# system has the same goal of preventing invalid mathematical operations it is more restrictive due to its basis on units rather than dimensions. 
## History
I've been working on this for nearly a year in my spare time.  But there hasn't been much of that - I've been busy despite the pandemic.

Currently the library has the basics in place, and can be used for equations in dynamics and some electrics.  I am continuing to add more derived dimensions and quantity classes to support more equations as I gradually work my way through _Nelkon and Parker_.
