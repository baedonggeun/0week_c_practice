using System;

//연습문제 1
{
    //변수 만들기
    int level, count;
    float probability, speed;
    string nickname, explain;


    //변수에 데이터를 입력해주세요.
    level = 1;
    count = 1;
    
    probability = 45.0f;
    speed = 1.5f;

    nickname = "babara";
    explain = "player_1`s status";


    //형변환 - 숫자를 숫자로
    int iTen = 10;
    float fTen;
    fTen = iTen; // fTen = (float)iTen;

    float fFive = 5.5f;
    int iFive;
    iFive = (int)fFive;


    //형변환 - 숫자를 문자로
    int n = 10;
    float f = 0.5f;

    string n_string;
    string f_string;

    n_string = Convert.ToString(n);
    f_string = n.ToString();


    //형변환 - 문자를 숫자로
    string strTen = "10";
    string strSix = "6.2";

    int ten;
    float six;

    ten = int.Parse(strTen);
    ten = Convert.ToInt32(strTen);
    int.TryParse(strTen, out ten);

    six = Convert.ToSingle(strSix);
    six = float.Parse(strSix);
    float.TryParse(strSix, out six);
}




//연습문제 2
{
    //연산 연습 및 출력
    int ten = 10;

    Console.WriteLine(ten + 7);

    Console.WriteLine(ten - 3);

    Console.WriteLine(ten * 2);

    float f_ten;
    f_ten = (float)ten * 1.5f;
    Console.WriteLine(f_ten);

    Console.WriteLine(ten / 3);

    Console.WriteLine(ten % 4);


    //문자열 연산 연습 및 출력
    string name = "chad";
    int year = 2023;

    string introduce;
    string thisYear;

    introduce = "안녕하세요. 제 이름은 " + name + " 입니다.";
    thisYear = "올해는 '" + year + "'년 입니다.";

    Console.WriteLine(introduce + "\n" + thisYear);

    //논리 연산자 연습 및 출력
    int ten_1 = 10;
    bool result_1;
    bool result_2;
    bool result_3;
    bool result_4;

    result_1 = ten_1 == 10;
    result_2 = ten_1 != 11;
    result_3 = ten_1 < 20;
    result_4 = ten_1 > 5;

    Console.WriteLine(result_1 + "\n" + result_2 + "\n" + result_3 + "\n" + result_4);


}




//연습문제 3
{
    //입력 받은 데이터가 숫자인지 문자열인지 판단
    Console.WriteLine("값을 입력하십시오.");

    string input = Console.ReadLine();
    
    double output;
    bool isNum = double.TryParse(input, out output);

    bool b;
    bool isBool = bool.TryParse(input, out b);

    if(isBool)
    {
        Console.WriteLine(input + "은 bool 값입니다.");
    }
    else if(isNum)
    {
        Console.WriteLine(input + "은 숫자입니다.");
    }
    else
    {
        Console.WriteLine(input + "은 문자열입니다.");
    }


    //입력 받은 데이터가 숫자라면 100보다 큰지 작은지 알려주는 프로그램
    Console.WriteLine("값을 입력하십시오.");
    string input_1 = Console.ReadLine();

    isNum = double.TryParse(input_1, out output);
    
    if(isNum)
    {
       if(output < 100)
        {
            Console.WriteLine("100보다 작음");
        }
       else if(output == 100)
        {
            Console.WriteLine("100과 같음");
        }
       else
        {
            Console.WriteLine("100보다 큼");
        }
    }
    else
    {
        Console.WriteLine(input_1 + "은 문자열");
    }

    //입력받은 데이터가 숫자라면 짝수인지 홀수인지 알려주는 프로그램
    Console.WriteLine("값을 입력하십시오.");
    string input_2 = Console.ReadLine();

    isNum = double.TryParse(input_2, out output);

    if(isNum)
    {
        if(output % 2 == 0)
        {
            Console.WriteLine(input_2 + "의 값은 짝수");
        }
        else
        {
            Console.WriteLine(input_2 + "의 값은 홀수");
        }
    }
    else
    {
        Console.WriteLine(input_2 + "은 문자열");
    }

    //숫자를 두 번 입력받아서 두 번 다 숫자인지 확인 및 크기 비교
    Console.WriteLine("값을 2번 입력하십시오.");
    string input_3_1 = Console.ReadLine();
    string input_3_2 = Console.ReadLine();

    double output_1, output_2;

    bool isNum_1 = double.TryParse(input_3_1, out output_1);
    bool isNum_2 = double.TryParse(input_3_2, out output_2);

    if(isNum_1 == false || isNum_2 == false)
    {
        Console.WriteLine("입력된 값 중 문자열이 존재합니다.");
    }
    else
    {
        if(output_1 < output_2 == true)
        {
            Console.WriteLine(input_3_1 + " < " + input_3_2);
        }
        else if((output_1 == output_2) == true)
        {
            Console.WriteLine(input_3_1 + " = " + input_3_2);
        }
        else
        {
            Console.WriteLine(input_3_1 + " > " + input_3_2);
        }
    }

    //퀴즈의 정답 맞추는 프로그램 작성
    Console.WriteLine("대한 민국의 수도는 어디인가요?");
    Console.WriteLine("1. 인천  2. 평창  3. 서울  4. 부산  5. 원주");

    string input_4 = Console.ReadLine();
    double output_4;
    
    isNum = double.TryParse(input_4, out output_4);

    if(isNum)
    {
        if (output_4 < 1 || output_4 > 5)
        {
            Console.WriteLine("1~5의 숫자를 입력해주세요.");
        }
        else
        {
            switch (output_4)
            {
                case 1:
                    Console.WriteLine("오답!");
                    break;
                case 2:
                    Console.WriteLine("오답!");
                    break;
                case 3:
                    Console.WriteLine("정답!");
                    break;
                case 4:
                    Console.WriteLine("오답!");
                    break;
                case 5:
                    Console.WriteLine("오답!");
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("숫자를 입력해주세요.");
    }


    //주어진 보기를 선택하면 해당하는 메시지 출력
    Console.WriteLine("정보를 알고싶은 여행지를 입력해주세요.");
    Console.WriteLine("1. 제주도  2. 코타키나발루  3. 싱가포르  4. 태국");

    string input_5 = Console.ReadLine();

    isNum = double.TryParse(input_5, out output);

    if(isNum)
    {
        if (output < 1 || output > 4)
        {
            Console.WriteLine("1~4의 숫자를 입력해주세요.");
        }
        else
        {
            switch (output)
            {
                case 1:
                    Console.WriteLine("제주도는 한국의 섬으로 비교적 방문이 쉽고 다양한 놀거리/먹거리가 준비되어 있습니다.");
                    break;
                case 2:
                    Console.WriteLine("코타키나발루는 말레이시아 사바주의 주도로, 말레이시아 동부 보르네오섬 최대의 도시입니다.");
                    break;
                case 3:
                    Console.WriteLine("싱가포르는 동남아시아, 말레이 반도의 끝에 위치한 섬나라이자 항구 도시로 이루어진 도시 국가입니다.");
                    break;
                case 4:
                    Console.WriteLine("태국은 중국문화, 말레이문화, 불교문화, 힌두문화, 이슬람 문화가 혼재되어 있습니다." +
                        " 불교적인 모습을 많이 띄지만, 문화 자체는 색다르고 스펙트럼이 넓은 형태를 띄고 있어요.");
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("숫자를 입력해주세요");
    }

}



//연습문제 4
{
    //구구단 만들기
    for(int i = 0; i<10; i++)
    {
        for(int j = 0; j<10; j++)
        {
            Console.WriteLine((i + 1) + " x " + (j + 1) + " = " + ((i + 1) * (j + 1)));
        }

        Console.WriteLine();
    }

    //입력받은 단으로 구구단 만들기
    Console.WriteLine("구구단의 단을 입력하십시오.");

    string dan = Console.ReadLine();

    int danN = Convert.ToInt32(dan);

    for(int i = 1; i <= danN; i++)
    {
        Console.WriteLine(danN + " x " + i + " = " + danN * i);
    }

    //피보나치 수열 구하기
    Console.WriteLine("피보나치 수열의 항을 입력하시오.(3이상)");

    string hang = Console.ReadLine();

    int hangN;

    int.TryParse(hang, out hangN);

    bool TorF = int.TryParse(hang, out hangN);

    if(TorF == false)
    {
        Console.WriteLine("숫자를 입력해 주세요.");
    }
    else if(TorF == true && hangN < 3)
    {
        Console.WriteLine("3 이상의 숫자를 입력해주세요.");
    }
    else
    {
        Console.WriteLine(1);
        Console.WriteLine(1);

        int num_1 = 1, num_2 = 1;
        int num_3;

        for (int i = 3; i <= hangN; i++)
        {
            num_3 = num_1 + num_2;

            Console.WriteLine(num_3);

            num_1 = num_2;
            num_2 = num_3;
        }
    }


    //이름 입력하기
    Console.WriteLine("이름을 입력해주세요.(2~10글자)");

    string name_1 = Console.ReadLine();

    if(name_1.Length <= 2 || name_1.Length >= 10)
    {
        Console.WriteLine("이름을 확인해 주세요.");
    }
    else
    {
        Console.WriteLine("안녕하세요. 제 이름은 " + name_1 + " 입니다.");
    }


    //조건에 맞을 때까지 이름 입력 + 반복 시 기존 내용 지우기
    bool TorF_1;

    do
    {
        Console.Clear();

        Console.WriteLine("이름을 입력해주세요.(2~10글자)");

        string name_2 = Console.ReadLine();

        if(name_2.Length <= 2 || name_2.Length >= 10)
        {
            Console.WriteLine("이름을 확인해 주세요.");
        }
        else
        {
            Console.WriteLine("안녕하세요. 제 이름은 " + name_2 + " 입니다.");
        }

        TorF_1 = name_2.Length >= 2 && name_2.Length <= 10;

    }while (!TorF_1);



    

}