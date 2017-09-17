using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lection_10
{
    class DerivedClass3 : DerivedClass2
    {
        public int field7;

        public DerivedClass3(int field1, int field2, int field3, int field4, int field5, int field6, int field7)
            // Вызов конструктора базового класса (DerivedClass2) 
            : base(field1, field2, field3, field4, field5, field6)
        {
            this.field7 = field7;
        }

        public DerivedClass3()
        {
            
        }

        public void DerivedClass3Method()
        {
            Console.WriteLine("Метод из DerivedClass3");
        }
    }
}
