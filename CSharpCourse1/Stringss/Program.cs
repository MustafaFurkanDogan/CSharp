using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringss
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Furkan Doğan";
            var result = sentence.Length;//cümlenin kaç karakterden oluştuğunu bulmak için 
            var result2 = sentence.Clone();//yeni bir değişken oluşturmak için
            sentence = "My name is Berra Doğan";
            bool result3 = sentence.EndsWith("n");//cümlenin sonu bu harfle bitiyor mu
            bool result4 = sentence.StartsWith("M");//cümlenin başı bu harfle başlıyor mu 

            var result5 = sentence.IndexOf("name");//belirli bir karakteri veya ifadeyi aramak için kulllanılır
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" "); // burada aramaya sondan başlar   
            var result8 = sentence.Insert(0, "Hello ,"); // cümleye bir şey eklemek için kullanılır
            var result9 = sentence.Substring(3, 4);// belirli bir yerden sonrasını göstermek için kullanılır
            var result10 = sentence.ToLower(); // bütün karakterleri küçük harfe çevirmeye yarar
            var result11 = sentence.ToUpper();// bütün karakterleri büyük harfle yazdırmak için kullanılır
            var result12 = sentence.Replace(" ", "-");// bir metin içerisinde belirli karakterleri değiştirmek için kullanırız
            var result13 = sentence.Remove(0, 1);//Bir metinde belirli bir yeri atmak için kullanırız   


            Console.WriteLine(sentence);
            Console.ReadLine();
        }

        private static void İntro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);  

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
