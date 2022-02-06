using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLogger
{
    public class TypeLogger
    {
        public string FullName  { get; set; }
        public string Name { get; set; }
        public Type[] types { get; set; }
        public Type BaseType { get; set; }
        public bool IsEnum { get; set; }
        public bool IsAbstract { get; set; }
        public bool IsInterface { get; set; }
        public bool IsPrimitive { get; set; }
        public bool IsValueType { get; set; }
        public bool IsClass { get; set; }
       

        public StringBuilder DisplayInfo<T>()
        {
            var stringBuilder = new StringBuilder();
            Type type = typeof(T);
            this.IsEnum = type.IsEnum;
            this.IsAbstract = type.IsAbstract;
            this.IsInterface = type.IsInterface;
            this.IsPrimitive = type.IsPrimitive;
            this.IsValueType = type.IsValueType;
            this.IsClass = type.IsClass;
            types = type.GetInterfaces();
            this.FullName = type.FullName;
            this.Name = type.Name;
            this.BaseType = type.BaseType;


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

            return stringBuilder;
            
            

        }

    }
}
