using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lection_10
{
    class BaseClass
    {
        // Открытые поля
        public int field1;
        public int field2;

        // Конструктор пользовательский
        public BaseClass(int field1, int field2) {
            this.field1 = field1;
            this.field2 = field2;
        }

        // Конструктор по-умолчанию
        public BaseClass() {

        }

        // Метод
        public void BaseClassMethod() {
            Console.WriteLine("Метод базового класса");
        }
    }
}
