static class Functions
{
    /// unit is a kind of void in csharp but you can't use it as parameter.. 
    public static void ignore<T>(T x) { return; }
}

Functions.ignore(1); //ok

// /!\ This code does not compile and this is why void could not be used as unit.
Functions.ignore(1); == Functions.ignore(1);