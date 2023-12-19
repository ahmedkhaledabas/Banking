using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ExceptionHandling
{
    enum Names{
        First,
        Middle,
        Last

    }
    internal class Test
    {
      

        public void CheckDublicate(int[] arr)
        {
            List<int> newNums = new List<int>();
            //foreach (var item in arr)
            //{
            //    if (newNums.Contains(item))
            //    {
            //        throw new Exception($"{item} : Dublicated");
            //    }
            //    else
            //    {
            //        newNums.Add(item);
            //    }
                
            //}
            for(int i = 0; i < arr.Length; i++)
            {
                if (newNums.Contains(arr[i]))
                {
                    throw new Exception($"Exception : Dublicated : {arr[i]}   ");
                }
                else
                {
                    newNums.Add(arr[i]);
                }
            }
        }

        public void Exception(int[]arr)
        {
            try
            {
                CheckDublicate(arr);
                Console.WriteLine("No Dublicated");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }

        public void CheckVowels(string s )
        {
            s = s.ToLower();
            string x = "";
            foreach (char c in s)
            {
                x = "";
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    //Console.WriteLine($"{c} Is Vowel ");
                    Console.WriteLine($"Contains Vowel ");
                    return;
                }

            }

            throw new Exception($"Exception : String Doesn't Contain Vowel");
        }

        public void Exception(string s)
        {
            try
            {
                CheckVowels(s);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
