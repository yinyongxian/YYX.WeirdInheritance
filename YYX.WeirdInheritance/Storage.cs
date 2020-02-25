using System.Collections.Generic;
using System.IO;

namespace YYX.WeirdInheritance
{
    abstract class Storage: IStorage
    {
        private readonly Dictionary<string, object> dictionary = new Dictionary<string, object>();

        public void SetValue(string key, object value)
        {
            dictionary[key] = value;
        }

        public virtual object GetValue(string key)
        {
            var containsKey = dictionary.ContainsKey(key);
            if (containsKey)
            {
                var value = dictionary[key];
                return value;
            }

            var message = string.Format("未找到key:{0}对应的值的", key);
            throw new DirectoryNotFoundException(message);
        }
    }
}
