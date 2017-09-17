using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Лекция 10. Наследование. Полиморфизм. Абстрактные классы. Интерфейсы
// ДИаграмма наследования
// 

namespace C_Sharp_Lection_10
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClassInstanse = new BaseClass(10, 20);
            Console.WriteLine("Объект класса BaseClass : ");
            Console.WriteLine("field 1 = " + baseClassInstanse.field1);
            Console.WriteLine("field 2 = " + baseClassInstanse.field2);
            baseClassInstanse.BaseClassMethod();

            DerivedClass derivedClassInstanse = new DerivedClass(10, 20, 30);
            Console.WriteLine();
            Console.WriteLine("Объект класса DerivedClass : ");
            Console.WriteLine("field 1 = " + derivedClassInstanse.field1);
            Console.WriteLine("field 2 = " + derivedClassInstanse.field2);
            Console.WriteLine("field 3 = " + derivedClassInstanse.field3);
            derivedClassInstanse.BaseClassMethod();
            derivedClassInstanse.DerivedClassMethod();

            DerivedClass2 derivedClass2Instance = new DerivedClass2(40, 50, 60, 70, 80, 90);
            Console.WriteLine();
            Console.WriteLine("Объект класса DerivedClass2 : ");
            Console.WriteLine("field 1 = " + derivedClass2Instance.field1);
            Console.WriteLine("field 2 = " + derivedClass2Instance.field2);
            Console.WriteLine("field 3 = " + derivedClass2Instance.field3);
            Console.WriteLine("field 4 = " + derivedClass2Instance.field4);
            Console.WriteLine("field 5 = private");
            Console.WriteLine("field 6 = protected");
            derivedClass2Instance.BaseClassMethod();
            derivedClass2Instance.DerivedClassMethod();
            derivedClass2Instance.DerivedClass2Method();

            DerivedClass3 derivedClass3Instance = new DerivedClass3(10, 20, 30, 40, 50, 60, 70);
            Console.WriteLine();
            Console.WriteLine("Объект класса DerivedClass3 : ");
            Console.WriteLine("field 1 = " + derivedClass3Instance.field1);
            Console.WriteLine("field 2 = " + derivedClass3Instance.field2);
            Console.WriteLine("field 3 = " + derivedClass3Instance.field3);
            Console.WriteLine("field 4 = " + derivedClass3Instance.field4);
            Console.WriteLine("field 5 = private в базовом классе, недоступен");
            Console.WriteLine("field 6 = protected в базовом классе, доступен");
            Console.WriteLine("field 7 = " + derivedClass3Instance.field7);
            derivedClass3Instance.BaseClassMethod();
            derivedClass3Instance.DerivedClassMethod();
            derivedClass3Instance.DerivedClass2Method();
            derivedClass3Instance.DerivedClass3Method();


            // Рассматриваем собаку как животное
            // Приводим объект производного класса DerivedClass3 к объекту базового класса DerivedClass2
            DerivedClass2 derivedClass2Inst = derivedClass3Instance as DerivedClass2;
            Console.WriteLine();
            Console.WriteLine("Объект класса DerivedClass3 приведенный к род. типу DerivedClass2 : ");
            Console.WriteLine("field 1 = " + derivedClass2Inst.field1);
            Console.WriteLine("field 2 = " + derivedClass2Inst.field2);
            Console.WriteLine("field 3 = " + derivedClass2Inst.field3);
            Console.WriteLine("field 4 = " + derivedClass2Inst.field4);
            Console.WriteLine("field 5 = private");
            Console.WriteLine("field 6 = protected");
            Console.WriteLine("field 7 = совсем не достуно");
            derivedClass2Inst.BaseClassMethod();
            derivedClass2Inst.DerivedClassMethod();
            derivedClass2Inst.DerivedClass2Method();

         


            // String.substrings - возрващает подстроки
            // String.contains

            string text = "Some text about VR";
            // Приведение к нижнему регистру
            string correctText = text.ToLower();
            string key_word = "VR";

            if (text.Contains(key_word))
                Console.WriteLine("Текст содержит ключевое слово");
            else
                Console.WriteLine("Текст не содержит ключевое слово");


            Console.ReadKey();

        }
    }
}
