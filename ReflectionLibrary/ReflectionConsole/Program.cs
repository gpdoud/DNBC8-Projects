using System;
using System.Reflection;

namespace ReflectionConsole {
    class Program {
        static void Main(string[] args) {
            var assembly = Assembly.LoadFile(@"C:\repos\dnbc8\ReflectionLibrary\ReflectionLibrary\bin\Debug\netcoreapp3.1\ReflectionLibrary.dll");
            var type = assembly.GetType("ReflectionLibrary.ReflectionTutorial");
            var methodInfo = type.GetMethod("GetMessage");
            var instance = Activator.CreateInstance(type, null);
            var parms = new object[0];
            var message = methodInfo.Invoke(instance, null);
            
        }
    }
}
