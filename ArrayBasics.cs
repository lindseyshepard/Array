using System;

namespace Array
{
    class ArrayBasics
    {



        //passing array as parameter and return values for a method
        public int[] ReadDate()
        {
            Console.WriteLine("How many elements?");
            string reply = Console.ReadLine();
            int numElements = int.Parse(reply);

            int[] data = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                Console.WriteLine($"Enter data for element {i}");
                reply = Console.ReadLine();
                int elementData = int.Parse(reply);
                data[i] = elementData;
            }
            return data;
        }


















    }
}
