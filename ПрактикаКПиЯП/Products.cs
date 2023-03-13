using System;
using System.Collections.Generic;
using System.Text;

namespace ПрактикаКПиЯП
{
    class Products
    {
        public string name = " ";
        public string cipher = " ";
        public int count = 0;

        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Шифровка: {cipher} счётчик{count}");
        }
    }
}
