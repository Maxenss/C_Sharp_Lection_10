using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lection_10
{
    class DerivedClass2 : DerivedClass
    {
        // Для объектов данного класса по-умолчанию 
        // будут доступны члены класса BaseClass : 
        //   field1, field2, метод BaseClassMethod
        // А также члены класса DerivedClass : 
        //   field3, метод DerivedClassMethod

        // Открытое поле
        public int field4;
        // Закрытое поле
        private int field5;
        // Закрытое поле, доступное, для наследования
        protected int field6;

     // Конструктор по-умолчанию
     public DerivedClass2()
     {
    
     }

        // Пользовательский конструктор
        public DerivedClass2(int field1,
            int field2,
            int field3, int field4, int field5, int field6)
            // Вызоов конструктора родительского класса
            : base(field1, field2, field3)
        {
            this.field4 = field4;
            this.field5 = field5;
            this.field6 = field6;
        }

        // Метод класса DerrivedClass2
        public void DerivedClass2Method()
        {
            Console.WriteLine("Метод класса DerivedClass2Method");
        }
    }
}
