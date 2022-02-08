using System;

namespace HomeWorkNew
{
    class Program
    {

        #region Task 1

        static void Main(string[] args)
        {
            Console.WriteLine("Daxil Edeceyiniz Eded Sayi");

            int.TryParse(Console.ReadLine(), out int size);

            bool check = true;

            Console.WriteLine("Ededleri daxil edin");

            for (int i = 0; i < size; i--)
            {
                
                
                    if (true)
                    {
                        int.TryParse(Console.ReadLine(), out int ededler);
                        size--;
                        
                    }
                    if (size == 0)
                    {
                        break;
                    }       

            }
           



            




        }
        static int Calc(int birinci,int ikinci,int ucuncu)
        {
            int edelerinsayi = 3;

            if (edelerinsayi == 3) ;
            {

                

                if (birinci > ikinci && ikinci > ucuncu)
                {
                    return birinci;
                }
                else if (ucuncu > birinci && birinci > ikinci)
                {
                    return ucuncu;
                }
                else if (ikinci > birinci && birinci > ucuncu)
                {
                    return ikinci;
                }
                else if (ucuncu > ikinci && ikinci > birinci)
                {
                    return ucuncu;
                }
                else
                {

                }

                return 0;

            }

            if (edelerinsayi == 4)
            {

                if (birinci > ikinci && ikinci > ucuncu)
                {
                    return birinci;
                }
                else if (ucuncu > birinci && birinci > ikinci)
                {
                    return ucuncu;
                }
                else if (ikinci > birinci && birinci > ucuncu)
                {
                    return ikinci;
                }
                else if (ucuncu > ikinci && ikinci > birinci)
                {
                    return ucuncu;
                }
                else
                {
                    
                }

                return 0;


            }
            
            
            
            }



        #endregion

        #region Task 2

        //static void Main(string[] args)
        //{

        //    int.TryParse(Console.ReadLine(), out int number);
        //    Console.WriteLine(Calc(number));



        //}

        //static int Calc(int number)
        //{

        //    int sum = 0;
        //    int axrincieded = 0;

        //    while (number > 0)
        //    {
        //        axrincieded = number % 10;
        //        number = (number - axrincieded) / 10;
        //        sum += axrincieded;
        //    }

        //    return sum;
        //}


        #endregion

        #region Taks 3

        //static void Main(string[] args)
        //{

        //    Console.WriteLine("Ilk Ededimizi Daxil Edin");
        //    double.TryParse(Console.ReadLine(), out double a);

        //    Console.WriteLine("Ikinci Ededi Daxil Edin");
        //    double.TryParse(Console.ReadLine(), out double b);

        //    Console.WriteLine("Ucuncu Ededin Daxil Edin");
        //    double.TryParse(Console.ReadLine(), out double c);

        //    Console.WriteLine(Math(a,b,c));

        //}

        //static double Math(double a,double b,double c)
        //{

        //    if (a>b && b>c)
        //    {
        //        //Console.WriteLine($"En Boyuk iksi sira ile {a},{b}");
        //        return a + b;
        //    }
        //    else if (c>a && a>b)
        //    {
        //        //Console.WriteLine($"En Boyuk iksi sira ile {c},{a}");
        //        return c + a;
        //    }
        //    else if (b>a && a>c)
        //    {
        //        //Console.WriteLine($"En Boyuk iksi sira ile {b},{a}");
        //        return b + a;
        //    }
        //    else if (c>b && b>a)
        //    {
        //       //Console.WriteLine($"En Boyuk iksi sira ile {c},{b}");
        //        return c + b;
        //    }


        //    return 0;



        //}

        #endregion

    }
}
