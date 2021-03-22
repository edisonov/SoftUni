using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type[] allType = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in allType)
            {
                PrintAllMethodAttributes(type);

                if (!type.GetCustomAttributes().Any(t => t.GetType() == typeof(AuthorAttribute)))
                {
                    continue;
                }

                AuthorAttribute[] attributes = type.GetCustomAttributes()
                    .Where(t => t.GetType() == typeof(AuthorAttribute))
                    .Select(t => (AuthorAttribute)t)
                    .ToArray();

                foreach (var attr in attributes)
                {
                    Console.WriteLine(attr.Name);
                }
            }
        }

        private void PrintAllMethodAttributes(Type type)
        {
            MethodInfo[] methods = type.GetMethods();

            foreach (var method in methods)
            {
                if (!method.GetCustomAttributes().Any(a => a.GetType() == typeof(AuthorAttribute)))
                {
                    continue;
                }

                Attribute[] attributes = method.GetCustomAttributes().ToArray();

                foreach (var attr in attributes)
                {
                    if (attr is AuthorAttribute)
                    {
                        AuthorAttribute author = (AuthorAttribute)attr;
                        Console.WriteLine($"{method.Name} is writte by {author.Name}");
                    }
                }
            }
        }
    }
}
