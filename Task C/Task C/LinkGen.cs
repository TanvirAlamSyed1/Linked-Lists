using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkGens
{
    class LinkGen<T>
    {
        private T data;
        private LinkGen<T> next; // pointer

        public LinkGen(T item)// constructor
        {
            data = item;
            next = null;
        }
        public LinkGen(T item, LinkGen<T> list)
        {
            data = item;
            next = list;
        }
        public LinkGen<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }


}

