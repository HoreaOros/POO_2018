using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode
{
    // Singleton pattern
    class Singleton
    {
        private static Singleton instance = null;
        // constructor private ==> clasa nu poate fi instantiata din afara
        private Singleton()
        {

        }

        /// <summary>
        /// Metoda creaza la primul apel o instanta a clasei. 
        /// Apelurile ulterioare vor intoarce referinta la obiectul creat la primul apel
        /// </summary>
        /// <returns></returns>
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
