using System;
using System.Collections.Generic;
using System.Text;

namespace С_Sharp_DZ_6
{
   public interface Icalc
    {
        int Less(int valueToCompare );
        int Greater(int valueToCompare);
    }
    public interface IOUtput2
    {
        void ShowEven(int [] arr , int size);
        void ShowOdd(int[] arr, int size);
    }



}
