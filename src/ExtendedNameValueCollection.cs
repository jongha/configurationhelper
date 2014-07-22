using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Reflection;

namespace ConfigurationHelper
{
    public class ExtendedNameValueCollection<T>
    {
        private NameValueCollection collection = null;

        public static explicit operator ExtendedNameValueCollection<T>(NameValueCollection collection)
        {
            ExtendedNameValueCollection<T> extendedCollection = new ExtendedNameValueCollection<T>();
            extendedCollection.collection = collection;

            return extendedCollection;
        }

        public T this[int index]
        {
            get
            {
                return (T)typeof(T).GetMethod("Parse", new[] { typeof(T) }).Invoke(null, new Object[] { collection[index] });
            }
        }

        public T this[string name]
        {
            get
            {
                return (T)typeof(T).GetMethod(
                    "Parse", 
                    new Type[] { typeof(string) }
                    ).Invoke(null, new Object[] { collection[name] });
            }

            set
            {
                collection[name] = value.ToString();
            }
        }
    }
}