using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary["a"] = "Abricot, Airplane, Artist";
        dictionary["b"] = "Banana, Boat, Bee";
        dictionary["c"] = "Cherry, Coat, Cacao";
        dictionary.Remove("c");
    }
}
