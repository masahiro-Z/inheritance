using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        class TestPerson
        {// 基底クラス
            public string Name { get; set; }
            public int Age { get; set; }

            public TestPerson(string name, int age)
            {
                Name = name;
                Age = age;

                // コンソール出力処理1
                Console.WriteLine("基底クラス");
                Console.WriteLine($"名前:{Name},年齢:{Age}");
            }
        }

        // 派生クラス
        class TestInfo : TestPerson
        {
            public int Height { get; set; }
            public int Weight { get; set; }

            public TestInfo(string name, int age, int height, int weight)
                : base(name, age)
            {
                Height = height;
                Weight = weight;

                Console.WriteLine("派生クラス");
                Console.WriteLine($"身長:{Height},体重:{Weight}");
            }
        }




        class s
        {
            static void Main(string[] args)
            {
                // 派生クラスのインスタンス生成
                TestInfo s = new TestInfo("山田", 20, 170, 60);

                // メソッド呼び出し

            }
        }

    }


