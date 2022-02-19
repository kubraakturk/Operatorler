using System;

namespace Oparatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Atama ve İşlemli Atama Oparatorleri***");
            int x =3;
            int y =3;
            y=y+2;
            Console.WriteLine(y);
            y +=2;
            y /=1;
            Console.WriteLine(y);
            x +=6;
            Console.WriteLine(x);

            Console.WriteLine("***Mantıksal Oparatorler***");
            // || , && , !
            bool isSuccess = true;
            bool isComplated=false;

            if(isSuccess && isComplated)
                Console.WriteLine("Perfect!");

            if(isSuccess || isComplated)
                Console.WriteLine("Great!");

            if(isSuccess && !isComplated)
                Console.WriteLine("Fine!");


            Console.WriteLine("***İlişkisel Oparatorleri***");
            //< , > , <= , >= , == , !=

            int a = 2;
            int b = 5;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a<=b;

            Console.WriteLine(sonuc);
            sonuc = a>b;

            Console.WriteLine(sonuc);
            sonuc = a==b;

            Console.WriteLine(sonuc);
            sonuc = a!=b;

            Console.WriteLine(sonuc);


            Console.WriteLine("***Aritmatik Oparatorler***");
            // + , - , * , /

            int sayi1 =10;
            int sayi2 =5;
            int sonuc1 = sayi1 / sayi2 ;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2 ;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2 ;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2 ;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            sonuc1 = 20%3 ; // mod alır
            Console.WriteLine(sonuc1);
        }
    }
}
