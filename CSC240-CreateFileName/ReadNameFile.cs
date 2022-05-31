using System;
using static System.Console;
using System.IO;

public class ReadNameFile
{
	public ReadNameFile
	{
		FileStream file = new FileStream("Names.txt",
				FileMode.Open, FileAccess.Read);
	StreamReader reader = new StreamReader(file);
	}
}
