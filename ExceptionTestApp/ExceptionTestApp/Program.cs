using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTestApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, value;
            x = 100;
            y = 0;
            value = 0;

            try //
            {
                value = x / y;
               //   Console.WriteLine("{0} / {1} = {2}", x, y, value);
                Console.WriteLine($"{x} / {y} = {value}");
                throw new Exception(" 사용자 에러"); //throw는 catch로 떨어진다.
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" 2. y의 값을 0보다 크게 입력하세요");
            }
            catch (Exception ex)
            {
                //Debug.WriteLine 디버깅 할때만 출력할 수 있다.
                //Debug.WriteLine(ex.ToString()); //Message , ToString, Stacktrace를 제일 많이씀
                Console.WriteLine("3."+ex.Message); 
                //Console.WriteLine(ex.StackTrace);
                throw;
            }
            finally //이 부분은 무조건 실행 에러가 나면 catch로 안나면 그냥 try에서 넘어온다.
            {
                Console.WriteLine("4. 프로그램이 종료했습니다.");
            }
            
        }
    }
}
