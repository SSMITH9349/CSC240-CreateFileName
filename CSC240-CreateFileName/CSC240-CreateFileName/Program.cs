using System;
using System.IO;

class CreateFileName
{
    static void Main()
    {
        FileStream file = new FileStream("Names.txt", 
            FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(file);

    }
}