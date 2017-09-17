using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lection_10
{
    // В определенном контексте символ ":" - означает наследование

    class DerivedClass : BaseClass
    {
        // Открытое поле
        public int field3;

        // Пользовательский конструктор
        public DerivedClass(int field1, int field2, int field3)
        {
            // Инициализируем поля базового класса
            this.field1 = field1;
            this.field2 = field2;
            // Инициализируем поле производного(текущего) класса
            this.field3 = field3;
        }

        // Конструктор по-умолчанию
        public DerivedClass() {
        }

        // Методы
        public void DerivedClassMethod()
        {
            Console.WriteLine("Метод производного класса");
        }
    }
}
