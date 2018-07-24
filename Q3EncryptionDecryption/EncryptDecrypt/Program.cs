using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {

            string sh=string.Empty;
            Console.WriteLine("Enter Password");
            string a1 = Console.ReadLine();
            int a2=a1.Length;
            char[] a = new char[a2];
            char[] b = new char[a2];
            a =Encrypt(5,a1);
            Console.WriteLine("Encryption");
            for (int i = 0; i < a.Length; i++)
            {

               // Console.Write(a[i]);
                sh+=a[i].ToString();

            }
              Console.WriteLine(sh);

            b = Decryption(5, sh, a2);
            Console.WriteLine("\nDecryption");
            for (int i = 0; i < b.Length; i++)
            {

                Console.Write(b[i]);
            }
            Console.ReadKey();
        }
        public static char[] Encrypt(int key,string word)
        {
            char[] arr= word.ToCharArray();
            char[] arr1 = new char[5];
            for (int i = 0; i < arr.Length; i++)
            {
                   int a = Convert.ToInt32(arr[i]);
                   int b = key + a;
                    char store = Convert.ToChar(b);
                    arr1[i] = store;

            }
            return arr1;
        }
        public static char[] Decryption(int key, string word,int length)
        {

            Console.WriteLine(length);
            char[] arr2 = new char[length];
            arr2= word.ToCharArray();
            char[] arr3 = new char[length];
            for (int i = 0; i<length; i++)
            {
                if (i != arr2.Length)
                {
                 int a1 = Convert.ToInt32(arr2[i]);
                 int b1 =  a1-key;
                 char store1 = Convert.ToChar(b1);
                 arr3[i] = store1;
                }

            }
            return arr3;
        }
    }

}
