using System;

namespace Library
{
    public class Singleton<T> where T : new()
    {
        /// <summary>
        /// Se crea la clase singleton en donde se recibe por parametro T (tipo generico) y se
        /// construye un unico objeto del tipo T (generico) por medio del metodo Instance.
        /// Luego de creado el objeto de la clase Greeter a traves de la clase Singleton, se puede
        /// invocar el metodo SayHellowToTheWorld de la clase Greeter.
        /// La restricion de la clase Singleton permite que se pueda crear un objeto en dicha clase
        /// de otra clase que se pasa por parametro. 
        /// </summary>
        private Singleton()
        {
            // Intentionally left
        }
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }
    }
}