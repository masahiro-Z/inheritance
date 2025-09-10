using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {

// 基底クラス
class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"名前: {Name}, 年齢: {Age}");
        }
    }

    // 派生クラス
    class Student : Person
    {
        public int Height { get; set; }
        public int Weight { get; set; }

        public Student(string name, int age, int height, int weight)
            : base(name, age)
        {
            Height = height;
            Weight = weight;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"名前: {Name}, 年齢: {Age}, 身長: {Height}, 体重: {Weight}");
        }
    }

    class inheritance
        {
        static void Main(string[] args)
        {
            // 派生クラスのインスタンス生成
            Student s = new Student("山田", 20, 170, 60);

            // メソッド呼び出し
            s.ShowInfo();
        }
    }

}
}
