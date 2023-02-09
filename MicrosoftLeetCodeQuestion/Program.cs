int[] myArray = { 1, 4, 9, 6, 2, 1, 7, 4, 6, 2, 8 };

static int FirstUniqIterativ(int[] myArray) {

    //basis solution
    int index = 0;
    for (int i = 0; i < myArray.Length; i++) {
        int counter = 0;
        for (int j = 0; j < myArray.Length; j++) {
            if (myArray[i] == myArray[j]) {
                counter++;
            }
            if (counter.Equals(2)) {
                break;
            }
        }
        if (counter == 1 /*&& result.Equals(int.MinValue)*/) {
            index = Array.IndexOf(myArray, myArray[i]);
            return index;
        }
    }
    return -1;

    //
    //int res = 0;
    //foreach (int i in myArray) {
    //    res = res ^ i;
    //}
}

Console.WriteLine(myArray[FirstUniqIterativ(myArray)]);
Console.ReadLine();