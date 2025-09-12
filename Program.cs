using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{ 
// 基底クラス
class TestPerson
   {
        protected string name;
        protected int age;

        public TestPerson(string name, int age)
        {
            this.name = name;
            this.age = age;

            Console.WriteLine("基底クラス");
            Console.WriteLine($"名前：{this.name},年齢：{this.age}");
        
        }

    }
    // 派生クラス
    class TestInfo : TestPerson
    {
        private int height;
        private int weight;

        public TestInfo(string name, int age, int height, int weight)
        : base(name, age)
        { 
        this.height = height;
            this.weight = weight;

            Console.WriteLine("派生クラス");
            Console.WriteLine($"身長：{this.height}、体重：{this.weight}");        
        }    
    }
    class program
    {// エントリーポイント
        static void Main(string[] args)
        { TestInfo info = new TestInfo("山田", 20, 170, 60);}
    
    
    }

























































}


