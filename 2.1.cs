using System;
using System.Collections.Generic;
using ppp;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {

        IEnumerable<int> oop = null;
        string nums = null;
        string myString = null;
        int myInt;
        Console.WriteLine("จำนวนรอบรับค่า");
        int max = int.Parse(Console.ReadLine());
        string[] numbersinput = new string[max];
        String[] sumnum = new string[max];
        // string joined;
        // var item = null;

        for (int i = 0; i < numbersinput.Length; i++)
        {
            Console.WriteLine("ค่าที่รับ");
            myString = Console.ReadLine();
            var array = myString.ToCharArray().Where(x => int.TryParse(x.ToString(), out myInt)).Select(x => int.Parse(x.ToString())).ToArray();  //แปลง string to array
            word2 input = new word2();
            oop = input.Homework13(array);

            foreach (var item in oop)
                nums += item;
                nums+="\n";

        }

        // joined = string.Join(" ",nums);
        
        Console.WriteLine("ค่าที่มีเลข 99 ต่อกัน 2 ตัว");
        Console.WriteLine(nums);
    }
}