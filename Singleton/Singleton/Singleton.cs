using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    // Нужно использовать когда необходимо, чтобы для класса существовал только 1 экземпляр
    class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {}

        public static Singleton getInstance() 
        {
            if (instance == null)
                instance = new Singleton();
            return instance;   
        }

    }
}
