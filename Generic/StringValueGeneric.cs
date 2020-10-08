using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class StringValueGeneric
    {
        public static string ToString<T>(T t)
        {
            return t.ToString();
        }
    }
}
