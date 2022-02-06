using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLogger
{
    public class TypeLogger
    {
        public bool IsEnum { get; set; }
        public bool IsAbstract { get; set; }
        public bool IsInterface { get; set; }
        public bool IsPrimitive { get; set; }
        public bool IsValueType { get; set; }
        public bool IsClass { get; set; }
       

        public void DisplayInfo<T>()
        {
            var stringBuilder = new StringBuilder();
            Type type = typeof(T);
            this.IsEnum = type.IsEnum;
            this.IsAbstract = type.IsAbstract;
            this.IsInterface = type.IsInterface;
            this.IsPrimitive = type.IsPrimitive;
            this.IsValueType = type.IsValueType;
            this.IsClass = type.IsClass;


            stringBuilder.AppendLine($"FullName ={type.FullName},");
            stringBuilder.AppendLine($"Name ={type.Name},");
            stringBuilder.AppendLine($"BaseType ={type.BaseType},");
            stringBuilder.AppendLine($"Interfaces:");
            foreach (var item in type.GetInterfaces())
            {
                stringBuilder.Append($"{item.Name},");
            }
            stringBuilder.AppendLine($"{type.BaseType},");
            stringBuilder.AppendLine($"Is Abstract? {type.IsAbstract},");
            stringBuilder.AppendLine($"Is Enum? {type.IsEnum},");
            stringBuilder.AppendLine($"Is Interface? {type.IsInterface},");
            stringBuilder.AppendLine($"Is Primitive? {type.IsPrimitive},");
            stringBuilder.AppendLine($"Is Value Type? {type.IsValueType},");
            stringBuilder.AppendLine($"Is Class? {type.IsClass},");

            Console.WriteLine(stringBuilder.ToString());
            
            

        }

    }
}
