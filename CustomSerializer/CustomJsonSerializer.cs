﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CustomSerializer
{
    public class CustomJsonSerializer
    {
        public static string Serialize<T>(T t)
        {
            if (t is IEnumerable)
            {
                string values = "[";
                foreach (var list in t as IEnumerable)
                    values += GetPropertyValues(list) + ",";
                return values.Remove(values.Length - 1) + "]";
            }
            else
                return GetPropertyValues(t);
        }


        private static string GetPropertyValues<T>(T t)
        {
            Type type = t.GetType();
            PropertyInfo[] props = type.GetProperties();
            string str = "{";
            foreach (var prop in props)
            {
                var val = prop.GetValue(t) is String ? "\"" + prop.GetValue(t) + "\"" : prop.GetValue(t);
                str += ("\"" + prop.Name + "\":" + val) + ",";
            }
            return str.Remove(str.Length - 1) + "}";
        }
    }
}
