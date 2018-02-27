using System;

namespace ISEN.DotNet.Library
{
    public class Hello
    {
        public static string World {get;set;} = "Hello, World";

        /* 
        private static string _world = "Hello, World";*
        public static string World{
            get {return _world;}
            set {_world = value;}
        }
        */
       

        public static string Greet(string name)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            var oldMessage = String.Format("Hello {0}, it is {1}.", name, time);
            var message = $"Salut BG {name}, il est {time}.";
            return message;
        }

        public static string GreetUpper(string name)
            => Greet(name.ToUpper());
        
    }
}
