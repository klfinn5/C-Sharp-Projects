using System;
using System.Collections.Generic; //framework library used when creating lists


{
    class Program
    {

        //to declare an array you need [] type of variable and its name

        static void Main()
        {


        //create lists of any data types

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();


        List<int> intList = new List<int>();
        intList.Add("Hello");
        intList.Add("Jesse");
        intList.Remove("Jesse");

        Console.WriteLine(intList[0]);
        Console.ReadLine();



        //use an array with a fixed quanity that you want to group together
        //very difficult to change when set

        int[] numArray = new int[5]; //int array called numArray
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //change 600 to 650
        // [5] is its place value
        numArray2[5] = 650;

        //can target specific parts of array but are limited to whats inside it once created

        Console.WriteLine(numArray1[3]);
        Console.ReadLine();

        //storing binary info to store into database like imgs
        //very large and initate with img files
        byte[] byteArray = new byte[#]

        }
    }
}
