using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lesson01
{
    public class myTest {
        public int num;
        public int myDouble(int _args) {
            return _args * 2;
        }
        public myTest() {
            Console.WriteLine("Создан обьект ");
        }
    }
    internal class Program//internal - модификатор доступа типа public
    {
        
        static void myConvert(string _promt,out int? a) {
            a = null;
            Console.WriteLine(_promt);
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }           
        } 
        static void Main(string[] args)
        {
            int a = 4;
            int? a1 = null;
            int[] arr = {-1, 7,0, 7, 8};
            while(a1 == null){
                myConvert("Введите число: ",out a1);
            }
            Console.WriteLine(a+a1);
            
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            var ts = new myTest();//var - это как auto в c++
            Console.WriteLine(ts.myDouble(a));
            var _list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                _list.Add(arr[i]);
            }
            _list.Add(9);
            _list.Sort();
            int counter = 0;
            foreach (var i in _list)
            {
                Console.WriteLine("Элемент {0} равен {1}",counter, i);
                Console.WriteLine($"Элемент {counter} равен {i}");
                counter++;
            }
        }
    }
}
