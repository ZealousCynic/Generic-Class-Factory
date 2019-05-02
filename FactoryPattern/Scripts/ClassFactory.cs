using System;

namespace FactoryPattern.Scripts
{
    //Generic class factory.
    //NOT good for performance.
    public class ClassFactory<T>
        where T : class
    {
        public static object CreateInstance(Type type, params object[] args)
        {
            return (T)Activator.CreateInstance(typeof(T), args);           
        }

    }
}
