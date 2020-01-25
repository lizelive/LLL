using System.Collections;
using System.Collections.Generic;

namespace BGI
{
    public class Inventory : IDictionary<Resource, float>
    {

        IDictionary<Resource, float> contents;

        public ICollection<Resource> Keys => (contents).Keys;

        public ICollection<float> Values => (contents).Values;

        public int Count => (contents).Count;

        public bool IsReadOnly => (contents).IsReadOnly;

        public float this[Resource key] {
            get => contents.TryGetValue(key, out var value) ? value : 0;
            set => (contents)[key] = value;
        }


        public void Add(Resource key, float value)
        {
            (contents).Add(key, value);
        }

        public bool ContainsKey(Resource key)
        {
            return (contents).ContainsKey(key);
        }

        public bool Remove(Resource key)
        {
            return (contents).Remove(key);
        }

        public bool TryGetValue(Resource key, out float value)
        {
            return (contents).TryGetValue(key, out value);
        }

        public void Add(KeyValuePair<Resource, float> item)
        {
            (contents).Add(item);
        }

        public void Clear()
        {
            (contents).Clear();
        }

        public bool Contains(KeyValuePair<Resource, float> item)
        {
            return (contents).Contains(item);
        }

        public void CopyTo(KeyValuePair<Resource, float>[] array, int arrayIndex)
        {
            (contents).CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<Resource, float> item)
        {
            return (contents).Remove(item);
        }

        public IEnumerator<KeyValuePair<Resource, float>> GetEnumerator()
        {
            return (contents).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (contents).GetEnumerator();
        }
    }
}
