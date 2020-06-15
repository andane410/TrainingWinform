using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    public class SimpleGeneric<T> //제네릭 사용 <T>를 제일 많이 사용
    {
        private T[] values; //무슨 값이 들어가든 배열로 만듬
        private int index;

        // alt enter -> 생성자 생성
        public SimpleGeneric( int len)
        {
            values = new T[len];//T이므로 무슨 자료형이 들어가든 생성된다.
            index = 0; //배열의 인덱스는 0부터 시작
        }

        public void Add(params T[] args)
        {
            //for까지 치고 탭두번하면 자동 완성
            foreach (var item in args)//var은 T나 마찬가지이다.
            {
                values[index++] = item;
            }
        }
        public void Print()
        {
            foreach (var item in values)
                Console.Write(item + " ");
            Console.WriteLine();
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGeneric<Int32> gInteger = new SimpleGeneric<int>(10); //배열 개수 10개
            SimpleGeneric<Double> gDouble = new SimpleGeneric<double>(10);//배열 개수 10개
            //ctrl+space 하면 자동완성
            gInteger.Add(1, 2); 
            gInteger.Add(1, 2, 3, 4, 5, 6, 7);
            gInteger.Add(0);
            gInteger.Print();

            gDouble.Add(10.0, 20.0, 30.0);
            gDouble.Print();
        }
    }
}
