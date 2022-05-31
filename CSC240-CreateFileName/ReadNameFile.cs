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

	const int END = 999;
	int count = 0;
	int num;
	int size;
	string name;

	name = reader.ReadLine();
		while(name !=null)
		{
			++count;
			name= reader.ReadLine();
		}
	size = (int)File.Length / count;

	Write("\nWith Which number do you want to start? >> ");
	num = Convert.ToInt32(ReadLine());

	}
}