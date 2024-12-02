using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Learning_CSharp
{
    public class Algorithms
    {
        public static bool[] SievePrime()
        {
            bool[] Prime = new bool[10000001];
            Prime[0] = true;
            Prime[1] = true;
            for(int i = 2; i <= Math.Sqrt(10000000); i++)
            {
                if (Prime[i] == false)
                {
                    for(int j = i * i; j <= 10000000; j += i)
                    {
                        Prime[j] = true;
                    }
                }
            }
            return Prime;
        }
        public static bool IsPrime(int val)
        {
            if (val < 2)
                return false;
            for(int i = 2; i <= Math.Sqrt(val); i++)
            {
                if (val % i == 0)
                    return false;
            }
            return true;
        }
        public static void Swap<T>(T val, T val2)
        {
            T temp = val;
            val = val2;
            val2 = temp;
        }
        public static void Swap<T>( ref T val,ref T val2)
        {
            T temp = val;
            val = val2;
            val2 = temp;
        }
        public static void SelectionSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap<int>(ref array[minIndex],ref array[i]);
            }
        }
        public static bool Compare(int a, int b)
        {
            int countA = 0;
            int countB = 0;
            int A = a;
            int B = b;
            while (a > 0)
            {
                int temp = a % 10;
                if(IsPrime(temp))
                {
                    countA++;
                }
                a /= 10;
            }
            while (b > 0)
            {
                int temp = b % 10;
                if (IsPrime(temp))
                {
                    countB++;
                }
                b /= 10;
            }
            if (countA > countB)
                return false;
            if(countA == countB)
            {
                if (A > B)
                    return false;
                return true;
            }
            return true;
        }
        public static void BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap<int>(ref array[j],ref array[j + 1]);
                    }
                }
            }
        }
        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length - 1; ++i)
            {
                int temp = array[i];
                int pos = i - 1;
                while(pos >= 0 && temp < array[pos])
                {
                    array[pos + 1] = array[pos];
                    pos--;
                }
                array[pos + 1] = temp;
            }
        }
        public static void CountingSort(int[] array)
        {
            int[] cnt = new int[100000000];
            int max = 0;
            int[] result = new int[array.Length];
            int length = 0;
            for(int i = 0;i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
                if(max > 100000000)
                {
                    throw new Exception("Cannot Sort An Array With Max Value > 10^8");
                }
                cnt[array[i]]++;
            }
            for(int i = 0; i <= max; i++)
            {
                while (cnt[i] > 0)
                {
                    result[length++] = i;
                    cnt[i]--;
                }
            }
            Array.Copy(result, array, length);
        }

        public static bool Search(int[] arr, int val)
        {
            foreach(var item in arr)
            {
                if(val == item)
                {
                    return true;
                }
            }
            return false;
        }
        public static int BinarySearch(int[] array, int low, int high, int val)
        {
            int mid = (high + low) / 2;
            if(high < low)
                return -1;
            if( array[mid] == val)
                return mid;
            if (val < array[mid])
                return BinarySearch(array, low, mid - 1, val);
            else
                return BinarySearch(array, mid + 1, high, val);
        }
    }
}
