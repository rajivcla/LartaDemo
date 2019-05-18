using System;

namespace LartaDemo
{
    class DifferenceFactory
    {
        public static T GetInstance<T>(string[] s)
        {
            return (T)Activator.CreateInstance(typeof(T), s);
        }
    }
}
