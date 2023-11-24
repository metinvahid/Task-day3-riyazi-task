using System.ComponentModel;

namespace Task_riyazi_emeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1 
            Console.WriteLine("Task1");
            Console.WriteLine(" 4 reqemli eded verilib. ");
            Console.WriteLine(" ");
            int a = 4233;
            Console.WriteLine(a);
            Console.WriteLine("a edenin eveline 7 reqemini , axirinada 8 reqemini artir.");
            Console.WriteLine(a * 10 + 7000008);
            Console.WriteLine(" ");


            // task2
            Console.WriteLine("Task2");
            Console.WriteLine(" 3 reqemli eded verilib.");
            int b = 972;
            Console.WriteLine(b);
            Console.WriteLine("b ededinin axirina hemin ededdin ozunu yapishdir");
            Console.WriteLine(b+ 972000);
            Console.WriteLine(" ");

            //task3
            Console.WriteLine("Task3");
            Console.WriteLine("5 reqemli eded verilib");
            int c = 88888;
            Console.WriteLine(c);
            Console.WriteLine("indi ise bu reqemin 18 faizini tap ");
            Console.WriteLine((c*18)/100);
            Console.WriteLine(" ");
            Console.WriteLine("daha sonra biz hemin e ededinin 3 faizinide tapmaliyiq");
            Console.WriteLine((c*3)/100);
            Console.WriteLine(" ");

            //task4
            Console.WriteLine("Task4");
            Console.WriteLine(" 3 reqemli eded verilib");
            int d = 789;
            Console.WriteLine(d);
            Console.WriteLine("z ededinin axirina 7 artir. Sonra cavabin 7% tap");
            Console.WriteLine(((d*10+7)*7)/100);
            Console.WriteLine(" ");

            //task5
            Console.WriteLine("Task5");
            Console.WriteLine("4 reqemli eded verilib");
            int e = 1000;
            Console.WriteLine("e=1000");
            Console.WriteLine("e ededinin evveline 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap ");
            Console.WriteLine(e * 100 + 4000044);
            Console.WriteLine(" ");

           //task6
           Console.WriteLine("Task6");
           Console.WriteLine("4 reqemli eded verilib");
           int f = 2000;
           Console.WriteLine("f=2000");
           Console.WriteLine(" ");
           Console.WriteLine("f ededinin evvel 20 faizini ni sonra ise cavabin 10 faizini tap.Alinan cavabin kvadratini tap.");
           Console.WriteLine((f*20)/100);
           Console.WriteLine(" ");
           Console.WriteLine("20 faizi tapdiqdan sonra ise aldigimiz cavabin 10 faizini tapaq ");
           Console.WriteLine((((f*20)/100)*10)/100);
           Console.WriteLine(" ");
           Console.WriteLine("10 faizini tapdiqdan sonra son olaraq aldigimiz cavabin kvadratini tapaq");
           Console.WriteLine(((((f * 20) / 100) * 10) / 100) * (((f * 20) / 100) * 10) / 100);
           Console.WriteLine(" ");    

            //task7
            Console.WriteLine("Task7");
            Console.WriteLine("2 dene 5 reqemli eded verilib.Bu ededleri toplayib, alinan cavabin evveline ve axirina 5 artir ve neticenin 5 % tap");
            Console.WriteLine(" ");
            int m = 55555;
            int n = 33333;
            Console.WriteLine("1)birinci eded->m, m=55555 2)ikinci eded->n, n=33333");
            Console.WriteLine("l ve s ededlerini toplayaq");
            Console.Write("m+n="); Console.Write(m+n);
            Console.WriteLine(" ");
            Console.WriteLine((((m + n) * 10 + 5000005) * 5) / 100);
            Console.WriteLine(" ");

            //task8
            Console.WriteLine("Task8");
            Console.WriteLine("2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.\r\n I ededin 4%-ni tap.Sonra II ededin 9% ni tap.\r\nSonra Cavalari toplayib 10 %ni tap.");
            Console.WriteLine(" ");

            Console.WriteLine("1)I ededin 4%-ni tap.");
            Console.WriteLine("r->1 ci ededimiz");
            int r = 6782;
            Console.WriteLine("r=6782");
            int u=(r*4)/100;
            Console.WriteLine("1ci ededin 4 faizini u herfi ile ifade edek");
            Console.Write("u="); Console.Write(u);
            Console.WriteLine("  ");
            Console.WriteLine(" ");
            Console.WriteLine("2)II eded 7 reqemlidir.");
            int l = 1234567;
            Console.WriteLine("l->1 ci ededimiz");
            Console.Write("l=");Console.Write(l);
            Console.WriteLine("II ededin 9% ni tap.");
            Console.WriteLine(" ");
            int x= (l*9)/100;
            Console.WriteLine("2 ci ededin 9 faizini x herfi ile ifade edek");
            Console.Write("x=");Console.Write(x);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Sonra Cavalari toplayib 10 %ni tap.");
            int z=(((u+x)*10)/100);
            Console.WriteLine("Biz cavablarin ceminin 10 faizini z herfi ile ifade edek ");
            Console.Write("z=");Console.Write(z);
            Console.WriteLine(" ");

            //task8.1
            Console.WriteLine("Task8.1");
            Console.WriteLine("Task8 amma yalniz 1 defe int etmekle");
            Console.WriteLine("2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.\r\n I ededin 4%-ni tap.Sonra II ededin 9% ni tap.\r\nSonra Cavalari toplayib 10 %ni tap.");
            Console.WriteLine(" ");
            Console.WriteLine("I eded 4 reqemlidir");
            Console.WriteLine("1)I ededin 4%-ni tap.");
            Console.WriteLine("t->1 ci ededimiz");
            int t = 6782;
            Console.WriteLine("t=6782");
            Console.WriteLine((t*4)/100);
            Console.WriteLine("birinci ededin 4 faizini tapdiq");
            Console.WriteLine(" ");
            Console.WriteLine("2)II eded 7 reqemlidir.");
            Console.WriteLine("II ededin 9% ni tap.");
            Console.WriteLine("p->2 ci ededimiz");
            int p = 1234567;
            Console.Write("p="); Console.Write(p);
            Console.WriteLine(" ");
            Console.WriteLine((p*9)/100);
            Console.WriteLine("ikinci ededin 9 faizini tapdiq");
            Console.WriteLine(" ");
            Console.WriteLine("Sonra Cavalari toplayib 10 %ni tap.");
            Console.WriteLine((((((t * 4) / 100) + ((p * 9) / 100))) * 10) / 100);
            Console.WriteLine(" ");

            //task9
            Console.WriteLine("Task9");
            Console.WriteLine("3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.");
            int i = 123456, j = 654321, k = 123654;
            int v = ((i * 10)/100)+ ((j * 10)/100) + ((k * 10)/100);
            Console.WriteLine(v);
            Console.WriteLine("v ile her uc herifin 10 faizini ifade etdik");
            Console.WriteLine(" ");
            Console.WriteLine("indi ise alinan cavabinda 10 faizini tapaq-> 2 yolnan edek");
            Console.WriteLine((v*10)*100);
            Console.WriteLine(" ");
            int v1= ((v * 10) * 100);
            Console.WriteLine(v1);
            Console.WriteLine(" ");

            //task10
            Console.WriteLine("Task10");
            Console.WriteLine(" ");
            Console.WriteLine("3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.\r\nNeticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel");
            Console.WriteLine(" ");
            int a1 = 4556, a2 = 1001, a3 = 3456;
            Console.Write("a1=" + a1);
            Console.WriteLine((a1*1)/100);
            Console.WriteLine("bununla a1 edenin 1 faizini ifade etdik");
            Console.WriteLine(" ");
            int b1 = ((a2 * 2) / 100);
            Console.WriteLine("b1=" + a2);
            Console.WriteLine("b1 ile a2 nin 2 faizinin cavabini ifade etdik");
            Console.WriteLine(" ");
            int c1 =((a3*3) / 100);
            Console.WriteLine("c1 ile a3 un 3 faizini ifade edek");
            Console.WriteLine("c1="+c1);
            Console.WriteLine(" ");
            Console.WriteLine(((a1 * 1)/100)-b1-c1);
            Console.WriteLine("bununla da biz 3 her uc ededin faiz nisbetlerinin neticesinin ferqini ifade etdik");
            Console.WriteLine(" ");
             Console.WriteLine("indi ise bunu ikinci yol ile edek");
            Console.WriteLine((a3*7)/100);
            int b2 =(a3 * 7)/100;
            Console.WriteLine("b2="+b2);
            Console.WriteLine(" ");
            Console.WriteLine((((a1 * 1) / 100) - b1 - c1) +b2);
            Console.WriteLine("ve ya 2 ci yol ile");
            Console.WriteLine(" ");
            int d4 = ((((a1 * 1) / 100) - b1 -c1) + b2);
            Console.WriteLine(d4);
            Console.WriteLine("d4 ile int yolu vasitesile ifade etdik ");
            Console.Write(" ");

            Console.WriteLine("SON");
            Console.WriteLine("Task by Metin Vahid");


            






































































            Console.ReadKey();

        }
    }
}
