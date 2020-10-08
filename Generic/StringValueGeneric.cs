using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class StringValueGeneric
    {
        public static string convertString<T>(T t)
        {
            return t.ToString();
        }
    }
}
