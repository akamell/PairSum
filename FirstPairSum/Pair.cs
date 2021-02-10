using System;

namespace FirstPairSum
{
    public class Pair
    {
        public static int[] Get(int target, int[] arrayList)
        {
            bool sw = false;
            int i = 0;
            int j = 1;
            int[] result = { 0, 0 };

            if (arrayList.Length < 2)
                return result;

            while (i < arrayList.Length && sw == false)
            {
                while (j < arrayList.Length && sw == false)
                {
                    Console.WriteLine(arrayList[i] + " + " + arrayList[j] + " = " + target);
                    if (arrayList[i] + arrayList[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        sw = true;
                    }
                    j++;
                }
                i++;
                if (i == arrayList.Length)
                    sw = true;
                else
                    j = i + 1;
            }
            Console.WriteLine("compadre");
            Console.WriteLine(result[0] + " - " + result[1]);
            return result;
        }
    }
}