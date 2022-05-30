using System;
using System.IO;

class CreateFileName
{
    static void Main()
    {
        FileStream file = new FileStream("Names.txt", 
            FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(file);

        string[] names =
        {
            "Anthony   ",
            "Belle     ",
            "Carolyn   ",
            "David     ",
            "Edwin     ",
            "Frannie   ",
            "Gina      ",
            "Hannah    ",
            "Inez      ",
            "Juan      "
        };

    }
}