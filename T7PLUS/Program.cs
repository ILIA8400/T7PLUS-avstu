


//           ایلیا اصغرحری
//            تمرین 7 پلاس




using System.Collections.Generic;

List<Student> students = new List<Student>();


StreamReader Name = new StreamReader(@"C:\Users\ILIA\source\name.txt");



while (!Name.EndOfStream)
{
    string line = Name.ReadLine();

    Student st = new Student();

    st.fname = line.Split(',')[0];

    st.pishrafte1 = Convert.ToDouble(line.Split(',')[1]);
    st.tafsir = Convert.ToDouble(line.Split(',')[2]);
    st.riazi = Convert.ToDouble(line.Split(',')[3]);
    st.karrah = Convert.ToDouble(line.Split(',')[4]);
    st.zaban = Convert.ToDouble(line.Split(',')[5]);
    st.pishrafte2 = Convert.ToDouble(line.Split(',')[6]);
    st.sheygara = Convert.ToDouble(line.Split(',')[7]);
    st.tarbiat = Convert.ToDouble(line.Split(',')[8]);
    st.systemamel = Convert.ToDouble(line.Split(',')[9]);
    st.algoritm = Convert.ToDouble(line.Split(',')[10]);


    students.Add(st);


}


var sort1 = students.OrderByDescending(s => s.Averagekol()).ToList();
var sort2 = students.OrderByDescending(s => s.Averagest0()).ToList();
var sort3 = students.OrderByDescending(s => s.Averagest1()).ToList();
var sort4 = students.OrderByDescending(s => s.Averagest2()).ToList();


Console.WriteLine("Hello, dear student");
string yn;
do
{
    try
    { 
        Console.WriteLine();
        Console.WriteLine("You have 7 modes to choose from. Please choose one:");
        Console.WriteLine("( Just enter the number )");
        Console.WriteLine();
        Console.WriteLine("1-Total Average");
        Console.WriteLine();
        Console.WriteLine("2-Total Average No stars");
        Console.WriteLine();
        Console.WriteLine("3-Total Average single stars");
        Console.WriteLine();
        Console.WriteLine("4-Total Average two stars");
        Console.WriteLine();
        Console.WriteLine("5-Determining the prime numbers of all student course grades");
        Console.WriteLine();
        Console.WriteLine("6-Display based on name and four types of Total Average");
        Console.WriteLine();
        Console.WriteLine("7-Display based on grading (abcdefg)");
        Console.WriteLine();
        Console.WriteLine("8-Exit");
        Console.WriteLine();
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switchc(x);


    }
    catch (System.ArgumentOutOfRangeException) 
    {
         Console.WriteLine("You entered the wrong number, please enter the desired number again...");
          int x = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine();
          switchc(x);
    }
    finally
    {
 
        Console.WriteLine("Do you want to continue? y/n");
          yn = Console.ReadLine();

    }


}
while (yn == "y");



void switchc(int x)
{
    switch (x)
    {
        case 1:
            {
                Console.WriteLine("Total Average:");
                Console.WriteLine("____________________________");

                foreach (var student in sort1)
                {
                    Console.WriteLine(student.fname + ":");
                    Console.WriteLine(student.Averagekol());
                    Console.WriteLine("____________________________");
                }

            }
            break;
        case 2:
            {
                Console.WriteLine("Total Average No stars:");
                Console.WriteLine("____________________________");

                foreach (var student in sort2)
                {
                    Console.WriteLine(student.fname + ":");
                    Console.WriteLine(student.Averagest0());
                    Console.WriteLine("____________________________");
                }
            }
            break;
        case 3:
            {
                Console.WriteLine("Total Average single stars:");
                Console.WriteLine("____________________________");

                foreach (var student in sort3)
                {
                    Console.WriteLine(student.fname + ":");
                    Console.WriteLine(student.Averagest1());
                    Console.WriteLine("____________________________");
                }
            }
            break;
        case 4:
            {
                Console.WriteLine("Total Average two stars:");
                Console.WriteLine("____________________________");

                foreach (var student in sort4)
                {
                    Console.WriteLine(student.fname + ":");
                    Console.WriteLine(student.Averagest2());
                    Console.WriteLine("____________________________");
                }
            }
            break;
        case 5:
            {
                Console.WriteLine("Prime numbre:");
                Console.WriteLine("____________________________");

                foreach (var student in students)
                {
                    Console.WriteLine(student.fname + ":");
                    Console.WriteLine();

                    if (student.PrimeNum(student.pishrafte1) == true)
                    { Console.WriteLine("pishrafte1:" + " " + student.pishrafte1); }

                    if (student.PrimeNum(student.tafsir) == true)
                    { Console.WriteLine("tafsir:" + " " + student.tafsir); }

                    if (student.PrimeNum(student.riazi) == true)
                    { Console.WriteLine("riazi:" + " " + student.riazi); }

                    if (student.PrimeNum(student.karrah) == true)
                    { Console.WriteLine("kargah:" + " " + student.karrah); }

                    if (student.PrimeNum(student.zaban) == true)
                    { Console.WriteLine("zaban:" + " " + student.zaban); }

                    if (student.PrimeNum(student.pishrafte2) == true)
                    { Console.WriteLine("pishrafte2:" + " " + student.pishrafte2); }

                    if (student.PrimeNum(student.sheygara) == true)
                    { Console.WriteLine("sheygarayi:" + " " + student.sheygara); }

                    if (student.PrimeNum(student.tarbiat) == true)
                    { Console.WriteLine("tarbiat badani:" + " " + student.tarbiat); }

                    if (student.PrimeNum(student.systemamel) == true)
                    { Console.WriteLine("system amel:" + " " + student.systemamel); }

                    if (student.PrimeNum(student.algoritm) == true)
                    { Console.WriteLine("algoritm:" + " " + student.algoritm); }
                    Console.WriteLine("____________________________");
                }
            }
            break;
        case 6:
            {
                Console.WriteLine("Display based on name and four types of Total Average:");
                Console.WriteLine("____________________________");

                foreach (var student in students)
                {
                    Console.WriteLine(student.fname + ":");
                    Console.WriteLine();
                    Console.WriteLine("Total Average:" + " " + student.Averagekol());
                    Console.WriteLine("Total Average No stars:" + " " + student.Averagest0());
                    Console.WriteLine("Total Average single stars:" + " " + student.Averagest1());
                    Console.WriteLine("Total Average two stars:" + " " + student.Averagest2());
                    Console.WriteLine("____________________________");
                }
            }
            break;
        case 7:
            {
                Console.WriteLine("Display based on grading (abcdefg):");
                Console.WriteLine("____________________________");
                foreach (var student in sort1)
                {
                    Console.WriteLine(student.fname + ":");
                    Console.WriteLine();
                    double kol = student.Averagekol();
                    student.grade(kol);
                    Console.WriteLine("____________________________");
                }
            }
            break;
        case 8:
            {
                Console.WriteLine("<> Thank you for using this program <>");
            }
            break;
        default:
            {
                throw new ArgumentOutOfRangeException();
            }
            break;



    }
}



class Student
{
    public string fname;

    public double pishrafte1;
    public double tafsir;
    public double riazi;
    public double karrah;
    public double zaban;
    public double pishrafte2;
    public double sheygara;
    public double tarbiat;
    public double systemamel;
    public double algoritm;

    public double Averagekol()
    {
        double x = (pishrafte1 * 3 + tafsir + riazi * 2 + karrah + zaban * 2 + pishrafte2 * 3 + sheygara * 3 + tarbiat + systemamel * 3 + algoritm * 3) / 22;
        x = Math.Round(x, 2);
        return x;
    }

    public double Averagest0()
    {
        double x = (tafsir + riazi * 2 + karrah + zaban * 2 + tarbiat) / 7;
        x = Math.Round(x, 2);
        return x;
    }

    public double Averagest1()
    {
        double x = (systemamel * 3 + algoritm * 3) / 6;
        x = Math.Round(x, 2);
        return x;
    }

    public double Averagest2()
    {
        double x = (pishrafte1 * 3 + pishrafte2 * 3 + sheygara * 3) / 9;
        x = Math.Round(x, 2);
        return x;
    }

    public bool PrimeNum(double num)
    {
        int sum = 0;
        if (num == 0) return false;
        else
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + 1;
                }
            }
            if (sum == 2) return true;
            else return false;
        }

    }

    public void grade(double a)
    {
        switch (a)
        {
            case >= 17:
                {
                    Console.WriteLine("moadel >> A");
                    Console.WriteLine(a);
                }
                break;
            case >= 15:
                {
                    Console.WriteLine("moadel >> B");
                    Console.WriteLine(a);
                }
                break;
            case >= 13:
                {
                    Console.WriteLine("moadel >> C");
                    Console.WriteLine(a);
                }
                break;
            case >= 10:
                {
                    Console.WriteLine("moadel >> D");
                    Console.WriteLine(a);
                }
                break;
            case >= 7:
                {
                    Console.WriteLine("moadel >> E");
                    Console.WriteLine(a);
                }
                break;
            case >= 3:
                {
                    Console.WriteLine("moadel >> F");
                    Console.WriteLine(a);
                }
                break;
            default:
                {
                    Console.WriteLine("moadel >> G");
                    Console.WriteLine(a);
                }
                break;
        }


    }


}


    