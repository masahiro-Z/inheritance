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

    public class Program
    {
        /* ①演算*******************************************************************/
        static void Main(string[] args)

        {   // 定義
            int num1 = 7;
            int num2 = 3;

            // ・変数と足し算を行い「7 + 3 = 10」
            int result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");

            //変数と引き算を行い「7 – 3 = 4」
            int result2 = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result2}");

            // 変数と掛け算を行い「7 * 3 = 21」
            int result3 = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result3}");

            // 変数と割り算・剰余算を行い「7 / 3 = 2余り1」
            int result4 = num1 / num2;
            int remainder = num1 % num2;
            Console.WriteLine($"{num1} / {num2} = {result4}余り{remainder}");

            /*②型変換*************************************************************************/

            // 宣言
            int IntTest = 1;
            string StringTest = "01";

            // IntTestをstring型に変換
            string String = IntTest.ToString();
            Console.WriteLine("String" + String);


            // StringTestをint型に変換して、1をインクリメント
            int Int = int.Parse(StringTest);
            Int++;
            Console.WriteLine(Int); // 1






        }






    }























































}


