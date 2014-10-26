using System.Collections.Generic;
using System.Linq;

namespace LLS_ListView_RT81.Models
{
    public class GroupedCollection<T> : List<T>
    {
        /// <summary>
        /// The delegate that will be used to obtain the key information.
        /// </summary>
        /// <param name="item">An object of type T</param>
        /// <returns>The key value to use for this object</returns>
        public delegate string GetKeyDelegate(T item);

        /// <summary>
        /// The Key of this group.
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// </summary>
        /// <param name="key">The key for this group.</param>
        public GroupedCollection(string key)
        {
            Key = key;
        }

        /// <summary>
        /// Public ctor.
        /// </summary>
        /// <param name="grouping">The Linq grouping. N.B. this will enumerate all items.</param>
        public GroupedCollection(IGrouping<string, T> grouping)
        {
            Key = grouping.Key;
            this.AddRange(grouping);
        }
    }
}
