using System;

public class Name : IHomework05
{
    public string DisplayLEDOnScreen(string ledNo)
    {
        throw new NotImplementedException();
    }
    public void Main1()
    {
        int x = 0;
        string[] array1 = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        int[] array2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        string num = (" 1  2  3  4  5  6  7  8  9  A");
        var on = "[!]";
        var off = "[ ]";
        while (x < 10)
        {
            int input = int.Parse(Console.ReadLine());
            int y = 1;
            y = input - ys;
            if (1 == array2[b])
            {
                array1[b] = on;
                Console.WriteLine(array1[0] + array1[1] + array1[2] + array1[3] + array1[4] + array1[5] + array1[6] + array1[7] + array1[8] + array1[9]);
                Console.WriteLine(num);
                array2[b] = 0;
            }else
            {
                array1[b] = off;
                Console.WriteLine(array1[0] + array1[1] + array1[2] + array1[3] + array1[4] + array1[5] + array1[6] + array1[7] + array1[8] + array1[9]);
                Console.WriteLine(num);
                array2[b] = 1;
            }
        }
    }
}