using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Найти самое длинное слово из пяти введенных с клавиатуры.
            //string st = "";
            //int L = st.Length;
            //string s = "";
            //for(int i=0; i<5;i++)
            //{
            //    Console.WriteLine($"введ {i + 1} ");
            //    string st1 = Console.ReadLine();
            //    if (st1.Length>L)
            //    {
            //        L = st1.Length;
            //        s = st1;
            //    }              
            //}
            //Console.WriteLine($"самое длинное слово {s} имеет{L}");


            //Задача 2. Составьте программу, удаляющую букву «е» («Е») из предложения.
            //Console.Write("Введите слово: ");
            //string word = Console.ReadLine();
            //int count = 0;
            //foreach (char e in word)
            //{
            //    if (e == 'е')
            //    { count++; }
            //    if (e == 'Е')
            //    { count++; }
            //}
            //string custom = word.Replace("е","") ;
            //string custom_night = custom.Replace("Е","");
            //Console.WriteLine($"Количество удаленных символов е в слове = {count}, итоговое слово {custom_night}");

            //Задача 3. Составьте программу вычисления количества букв «а» («А») в предложении.
            //Console.Write("Введите слово: ");
            //string word = Console.ReadLine();
            //int count = 0;
            //foreach (char a in word)
            //{
            //    if (a == 'а')
            //    { count++; }
            //    if (a == 'А')
            //    { count++; }
            //}
            //Console.WriteLine($"Количество символов а в слове = {count}");

            //Задача 4. Составьте программу, определяющую длину первого слова в предложении.
            //Console.WriteLine("Введте предложение: ");
            //string sentence = Console.ReadLine();
            //string[] sent = sentence.Split(' ');
            //int i = sent[0].Length;
            //Console.WriteLine($"Длина первого слова {i}");

            //Задача 5. Составьте программу, определяющую длину последнего слова в предложении.
            //Console.WriteLine("Введте 5 слов: ");
            //string sentence = Console.ReadLine();
            //string[] sent = sentence.Split(' ');
            //int i = sent.Length;
            //Console.WriteLine($"Длина последнего слова {sent[i-1].Length}");

            //Задача 6. Составьте программу, заменяющую букву «а» («А») на «о» («О») в предложении.
            //Console.Write("Введите слово: ");
            //string word = Console.ReadLine();
            //string word1 = word.Replace('а', 'о');
            //string word2 = word1.Replace('А', 'О');
            //Console.WriteLine(word2);

            //Задача 7. Написать программу для получения реверсированной строки.
            Console.WriteLine("Введите строчку: ");
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            Console.WriteLine("Строчка наоборот: ");
            for (int i = str.Length; i >=0; i--)
            {
                Console.Write(chars[i]);
            }
            Console.ReadKey();
        }
    }
}
