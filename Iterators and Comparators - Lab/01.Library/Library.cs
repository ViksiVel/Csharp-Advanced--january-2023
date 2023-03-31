using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books) //tyk da ochakva mnojestvo elementi, za tova e params
        {
            Books = books.ToList();
        }
        public Library()
        {
            Books = new List<Book>(); 
        }
        public List<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return Books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
