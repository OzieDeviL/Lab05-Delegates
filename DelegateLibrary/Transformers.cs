using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateLibrary
{
    // Declare a generic delegate
    public delegate T Transform<T>(T value);
    
    public class Transformers
    {

        // Generic method operates on arrays of type
        // T, requiring Transformer delegate of same
        // type.
        public static void Transform<T>(T[] arg, Transform<T> del)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                arg[i] = del(arg[i]);
            }
        }

        public static void TransformFunc<T>(T[] arg, Func<T, T> func)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                arg[i] = func(arg[i]);
            }
        }
    }







}
