using System;

namespace Variable
{
    class Variable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int age;
            string name;

            age = 30;
            name = "배동건";

            Console.WriteLine(name);
            Console.WriteLine(age);

            name = "bae dong geun";

            Console.WriteLine("name");

            float exp = 5.5f;
            double speed = 5.5;
            double speed2 = 5.5d;
            //float exp = 5.5; <<< 안 됨 그냥 소수는 double로 인식

            char name_part1 = '배';
            char name_part2 = '동';
            char name_part3 = '건';


            /*
             * 자료형의 기본값
             * string -> ""
             * int, float, double -> 0
             * bool -> false
            */


            //형 변환

            int x = 10;
            float y = 10.0f;

            //숫자 -> 숫자

            int z_1 = x + (int)y;
            float z_2 = (float)x + y;
            /*
             데이터 손실 없을 경우 (자료형)없어도 형 변환 가능
             int z_1 = x + y;
             float z_2 = x + y;
             */


            //다른 자료형 -> 문자

            string xStr = x.ToString(); //xStr = "10"
            string yStr = y.ToString(); //yStr = "10.0"

            bool TorF = true;

            string TorFStr = TorF.ToString(); //TorFStr = "true"


            //문자 -> 다른 자료형
            //convert 함수, parse 함수, tryparse 함수

            string iStr_1 = "10";
            int p;
            p = Convert.ToInt32(iStr_1); // x = 10

            string bStr_1 = "true";
            bool b_1;
            b_1 = Convert.ToBoolean(bStr_1); // b_1 = true


            /*
             형 변환 리스트
                ToDouble -> 실수 형태로 변환
                ToInt32 -> 32비트 부호 있는 정수 형태로 변환
                ToString -> 문자열 형태로 변환
             */


            string iStr_2 = "10";
            int q;
            q = int.Parse(iStr_2); // q = 10;

            string bStr_2 = "true";
            bool b_2;
            b_2 = bool.Parse(bStr_2); //b_2 = true

            /*
             변환 할 수 없는 값일 경우 에러 발생
             iStr_2 = "10xxxxx"
             bStr = "testtest"
            */

            string iStr_3 = "10";
            int r;
            int.TryParse(iStr_3, out r); // r = 10

            string bStr_3 = "true";
            bool b_3;
            bool.TryParse(bStr_3, out b_3); // b_3 = true

            bool isSuccess;
            isSuccess = int.TryParse(iStr_3, out x); //isSuccess = true

            string bStr_4 = "test";
            bool b_4;
            isSuccess = bool.TryParse(bStr_4, out b_4); //isSuccess = false

            //convert 함수나 parse 함수의 경우 반환값으로 캐스팅 값을 받음
            //tryparse 함수의 경우 함수 내부에서 캐스팅
            //tryparse 함수의 반환값으로 캐스팅 성공 여부인 bool값만 받음



            //제어문
            if(3 > 1)
            {
                Console.WriteLine("3은 1보다 크다!");
                //if 조건 만족ㅇ 실행ㅇ
            }

            if (0 > 1) 
            {
                Console.WriteLine("0은 1보다 크다!");
                //if 조건 만족x 실행x
            }

            int s = 20;
            if(s > 10)
            {
                Console.WriteLine("s는 10보다 크다!");
            }
            else if(s > 5)
            {
                Console.WriteLine("s는 10 보다는 작지만 5 보다는 크다!");
            }
            else
            {
                Console.WriteLine("s는 5보다 작다!");
            }

            switch(s)
            {
                case 1:
                    Console.WriteLine("치킨 주문");
                    break;

                case 2:
                    Console.WriteLine("피자 주문");
                    break;

                case 3:
                    Console.WriteLine("햄버거 주문");
                    break;

                default:
                    Console.WriteLine("집 밥 먹 기");
                    break;
            }

            bool isArrive_A = true;
            bool isArrive_B = false;

            if (isArrive_A && isArrive_B)
            {
                Console.WriteLine("식당 ㄱㄱ");
            }    
            else
            {
                Console.WriteLine("기다리기");
            }

            if (isArrive_A || isArrive_B)
            {
                Console.WriteLine("식당 ㄱㄱ");
            }
            else
            {
                Console.WriteLine("기다리기");
            }


            //반복문
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(i);
            }

            int num = 0;

            while (num < 10)
            {
                Console.WriteLine(num);
                num++;
            }

            num = 0;

            do
            {
                Console.WriteLine(num);
                num++;
            }
            while (num < 10);


            //for 문에서의 break
            for (int i = 0; i < 5; i++) // <- 멀리 있는 for문은 계속 반복됩니다.
            {
                for (int j = 0; j < 5; j++) // <- break 가 걸리면 가장 가까운 for문 종료
                {
                    if (j == 2)
                    {
                        break;
                    }
                }
            }


            //continue
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i + "번째 반복입니다.");
            }
            // "0 번째 반복입니다."
            // "1 번째 반복입니다."
            // "2 번째 반복입니다."
            // "4 번째 반복입니다."

            // 3 에서 continue 로 인해 해당 반복의 내용은 실행 안하고 다음으로 넘어갔습니다.



            //배열 생성
            string[] game;
            game = new string[3];

            //string[] game = new string[3];


            //배열 초기화와 반복문
            game[0] = "Leage of Legends";
            //초기화 하지 않은 배열은 기본값인 ""로 초기화

            string[] games = new string[3] { "League of Legends", "메이플 스토리", "디아블로" };
            //string[] games = new string[] { "League of Legends", "메이플 스토리", "디아블로" };
            //방 개수 설정 안해도 초기화를 동시에 해준다면 초기화 개수에 맞춰 설정됨


            int[] year = new int[4];
            for (int i = 0; i < 4; i++)
            {
                year[i] = 2020 + i;
                Console.WriteLine(year[i]);
            }

            int[] years = new int[4]  {1, 2, 3, 4 };

            //조건식 없이 배열을 끝까지 반복하는 함수
            foreach(string game_name in games)
            {
                Console.WriteLine(game_name);
            }

            foreach(int year_num in year)
            {
                Console.WriteLine(year_num);
            }



            //함수 -> 접근 제한자 사용 및 함수 내부의 함수 사용 x
            //반환x 매개변수x 함수
            void func ()
            {
                Console.WriteLine("함수 실행");
                return; //함수 종료(밑줄에 뭐가 있든)
            }

            func();


            //반환ㅇ 매개변수x 함수
            int func_int ()
            {
                Console.WriteLine("100 반환");
                return 100;
            }

            int num_100 = func_int();


            //반환x 매개변수ㅇ 함수
            int hp = 5;
                       
            void func_Attack(int damage)
            {
                if(hp <= 0)
                {
                    hp = 0;
                    return;
                }

                hp -= damage;

                Console.WriteLine("damage : " + damage + " hp : " + hp);
            }

            func_Attack(2);
            func_Attack(4);

            void DisplayMyInfo(int level, string name, string job)
            {
                Console.WriteLine("level : " + level + " name : " + name + " job : " + job);
            }

            DisplayMyInfo(10, "baboon", "warrior");
            //반환ㅇ 매개변수ㅇ 함수도 있음!


            //객체와 클래스
            /*
                객체의 특징 -> 재사용성 증가, 유지보수 용이, 코드 생산성 향상

             * 캡슐화
                외부에서 필요한 내용만 알 수 있게 캡슐 안에 감추기
             * 추상화
                공통적인 특징을 추려내기
             * 상속
                하위 클래스가 상위 클래스 모든 것 활용 가능하게 코딩하여 
                클래스 재사용성 증가로 반복적인 코드 감소
             * 다형성
                언어의 각 요소(상수, 변수, 식, 오브젝트, 함수, 메소드)들이
                여러 가지 타입을 가질 수 있음

             */


            string userName1 = "Chad";
            string job1 = "전사";
            int level1 = 50;

            string userName2 = "MelonG";
            string job2 = "마법사";
            int level2 = 23;

            string userName3 = "Dtail";
            string job3 = "도적";
            int level3 = 100;

           


        //객체 사용
        Character myCharacter = new Character();
            myCharacter.userName = "baboon";
            myCharacter.job = "warrior";
            myCharacter.level = "20";

            myCharacter.IntroduceCharacter();

        }
    }
}

//객체를 활용하여 공통된 부분의 추상화
//객체 생성 -> 객체 내부에선 변수 만든 이후 초기화와 로직 작성 x(변수 만들면서 초기화는 가능)
 class Character
{
    public string userName;
    public string job;
    public string level;

    //Console.WriteLine("my name is " + userName + ".");
    //클래스 내의 호출이나 계산을 불가
    //사용하려면 함수를 만들어 사용
    public void IntroduceCharacter()
    {
        Console.WriteLine("my name is " + userName + ".");
    }
}