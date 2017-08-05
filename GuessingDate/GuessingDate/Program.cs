using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 사용자에게 날짜를 입력 받아 기념일을 맞추는 프로그램
namespace GuessingDate
{
    //정답 날짜 나열하고 싶었는데...
    //public enum Days { , dd, "1999" }

    class Program
    {
        static void Main(string[] args)
        {
            // do...while 반복문: while 조건이 참일 때만 do 내용 반복 실행
            string date;

            do
            {
                Console.Write("날짜를 입력하세요! (YYYY.MM.DD)");
                date = Console.ReadLine();

                //공백 예외처리
                if (string.IsNullOrEmpty(date))
                {
                    Console.WriteLine("입력값이 없어 프로그램을 종료합니다.");
                    break;
                }

                
                if (date == "2017.08.05")
                {
                    Console.WriteLine("오늘입니다!");
                    break;
                }

                /*switch (date)
                {
                    case date.:
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;

                    default:
                        Console.WriteLine("");
                        break;
                }*/

            } while (Convert.ToInt32(date) != 0); //0이 아니면(true) 계속 실행/ 0일 때(false) 중지
        }
    }
}
