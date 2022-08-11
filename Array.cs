using System;



namespace С_Sharp_DZ_6
{
    

    public class Array : Icalc , IOUtput2
    {
        public int[] array { get; set; }
        public int size { get; set; }

        public Array()
        {
            array = new int[0];
            size = 0;
        }
        public Array(int[] arr)
        {
            array = arr;
            size = 0;
        }

        public int Less(int valueToCompare)
        {
            foreach(int item in array)
            {
                if(item < valueToCompare)
                {
                    size++;
                }
            }
            return size;
        }

        public int Greater(int valueToCompare)
        {
            foreach (int item in array)
            {
                if (item > valueToCompare)
                {
                    size++;
                }
            }
            return size;
        }

        public void ShowEven(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
        }

        public void ShowOdd(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
        }





    }
}
