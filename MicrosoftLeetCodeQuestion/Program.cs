using System;

int[] myArray = { 1, 4, 6, 2, 1, 7, 4, 6, 2, 8 };

static int FirstUniqIterativ(int[] myArray) {

    ////Løsning 1: basis solution
    //int index = 0;
    //for (int i = 0; i < myArray.Length; i++)
    //{
    //    int counter = 0;
    //    for (int j = 0; j < myArray.Length; j++)
    //    {
    //        if (myArray[i] == myArray[j])
    //        {
    //            counter++;
    //        }
    //        if (counter.Equals(2))
    //        {
    //            break;
    //        }
    //    }
    //    if (counter == 1)
    //    {
    //        index = Array.IndexOf(myArray, myArray[i]);
    //        return index;
    //    }
    //}
    //return index;


    ////Løsning 2: Bitwise XOR implementering
    //int res = 0; Array.Sort(myArray);
    //foreach (int i in myArray)
    //{
    //    res = res ^ i;
    //    if (res != 0 && res != i)
    //    {
    //        res = res ^ i;
    //        return res = Array.IndexOf(myArray, res);
    //    }
    //}
    //return res;
}

Console.WriteLine(myArray[FirstUniqIterativ(myArray)]);
Console.ReadLine();