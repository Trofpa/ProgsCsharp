/*
Given an array of integers, find the one that appears an odd number of times.

There will always be only one integer that appears an odd number of times.
Examples

[7] should return 7, because it occurs 1 time (which is odd).
[0] should return 0, because it occurs 1 time (which is odd).
[1,1,2] should return 2, because it occurs 1 time (which is odd).
[0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).

*/
using System.Linq;


int find_it(int[] seq) 
{
    int count = 0;
    for (int k = seq.Min(); k <= seq.Max(); k++)
    {
        for (int i = 0; i < seq.GetLength(0); i++)
        {
            if (seq[i] == k)
            {
                count += 1;
            } 
        }
        if (count % 2 == 1)
        {
            return k;
        }
    }
return -1;
}       

Console.Clear();

int[] array = {1,2,2,3,3,3,4,3,3,3,2,2,1,4,-20};

Console.WriteLine("[{0}]", string.Join(",", array));

Console.WriteLine(find_it(array));