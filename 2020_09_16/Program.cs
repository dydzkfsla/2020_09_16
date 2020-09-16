using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_16
{
    public class Person 
    {
        private string name;
        private int     age;
        private double hight;
        private double weight;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Hight { get => hight; set => hight = value; }
        public double Weight { get => weight; set => weight = value; }

        public Person()
        {

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3] ;

            for(int i =0; i < person.Length; i++)
            {
                Console.Write("이름을 입력하세요: ");
                person[i].Name = Console.ReadLine();
                Console.Write("나이를 입력하세요: ");
                person[i].Age = Utility.ConvertInt(Console.ReadLine());
                Console.Write("키를 입력하세요: ");
                person[i].Hight = Utility.ConvertDouble(Console.ReadLine());
                Console.Write("몸무게를 입력하세요: ");
                person[i].Weight = Utility.ConvertDouble(Console.ReadLine());
            }

            foreach (var item in person)
            {
                Console.WriteLine($"이름: {item.Name}, 나이: {item.Age}, 키: {item.Hight}, 몸무게: {item.Weight} ");
            }

        }
    }
}
