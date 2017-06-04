using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Attributes
{
    public class AttributesContainer : Dictionary<Type, IEnumerable>
    {
        private readonly Dictionary<Type, IEnumerable> _data =
    new Dictionary<Type, IEnumerable>();

        public void Add<T>(IEnumerable<T> value)
        {
            _data.Add(typeof(T), value);
        }

        public bool TryGet<T>(out IEnumerable<T> value)
        {
            IEnumerable enumerable;
            if (_data.TryGetValue(typeof(T), out enumerable))
            {
                value = (IEnumerable<T>)enumerable;
                return true;
            }
            value = null;
            return false;
        }
    }
}
