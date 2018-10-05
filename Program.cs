using System;

namespace classes {
    class Program {
        static void Main (string[] args) {
    Car stella = new Car();

// UseEmergencyBreak method can use the protected SqueezeBreakPads from the Automobile class.
Console.WriteLine("Applying the break: {0}", stella.UseEmergencyBreak());
           
}
    }
}