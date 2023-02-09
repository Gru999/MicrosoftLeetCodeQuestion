using System;

int[] myArray = {1, 4, 6, 2, 1, 7, 4, 6, 2, 8 };

static int FirstUniqIterativ(int[] myArray) {

    ////basis solution
    //int index = 0;
    //for (int i = 0; i < myArray.Length; i++) {
    //    int counter = 0;
    //    for (int j = 0; j < myArray.Length; j++) {
    //        if (myArray[i] == myArray[j]) {
    //            counter++;
    //        }
    //        if (counter.Equals(2)) {
    //            break;
    //        }
    //    }
    //    if (counter == 1 /*&& result.Equals(int.MinValue)*/) {
    //        index = Array.IndexOf(myArray, myArray[i]);
    //        return index;
    //    }
    //}
    //return -1;


    int res = 0; Array.Sort(myArray);
    foreach (int i in myArray) {
        res = res ^ i;
        if (res != 0 && res != i) {
            return 15 - i;
        }
        //if (res != 0 && res != i) {
        //    res = ~i;
        //    return res = Array.IndexOf(myArray, res);
        //} 
    }
    return res;
}

Console.WriteLine(FirstUniqIterativ(myArray));
//Console.WriteLine(myArray[FirstUniqIterativ(myArray)]);
Console.ReadLine();