using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ooo;
public class word2 : IHomework13
{
    public IEnumerable<int> Homework13(IEnumerable<int> numbers)
    {
        int[] num = numbers.ToArray();
        var List = new List<int>();
        foreach (var result in num)
            if (num[5] + num[4] == 18)
            {
                if (num[3] != 9)
                {
                    if (num[0] + num[1] + num[2] != 27)
                    {
                        List.Add(result);
                    }
                }
            }
            else if (num[4] + num[3] == 18)
            {
                if (num[5] != 9 && num[3] != 9)
                {
                    List.Add(result);
                }
            }
            else if (num[3] + num[2] == 18)
            {
                if (num[4] != 9 && num[1] != 9)
                {
                    List.Add(result);
                }
            }
            else if (num[2] + num[1] == 18)
            {
                if (num[3] != 9 && num[0] != 9)
                {
                    List.Add(result);
                }
            }
            else if (num[1] + num[0] == 18)
            {
                if (num[2] != 9)
                {
                    if (num[5] + num[4] + num[3] != 27)
                    {
                        List.Add(result);
                    }
                }
            }
        return List;
    }
    IEnumerable<int> IHomework13.Homework13(IEnumerable<int> numbers) => throw new NotImplementedException();
}