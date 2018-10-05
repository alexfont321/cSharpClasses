namespace classes 
{

// Base class
public class Automobile {

    public string Break() {
        SqueezeBreakPads();
        return "skuuuuuur";
    }

    public string SqueezeBreakPads() {
        return "something";
    }


}

// Derived class
public class Car : Automobile {

    public string UseEmergencyBreak() {
        SqueezeBreakPads();
        return "skreeech!";
    }
}


}