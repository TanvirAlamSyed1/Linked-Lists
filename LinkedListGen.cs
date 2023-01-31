using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkGens;

namespace LinkedListGens
{

    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list;


        public LinkListGen()
        {
        }

        public LinkGen<T> getlist
        {
            get { return list; }
            set { list = value; }
        }

        public void AddItem(T item)//works
        {
            list = new LinkGen<T>(item, list);
        }

        public int NumberOfItems()//works
        {
            LinkGen<T> temp = list;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                count++;
                temp = temp.Next;
            }
            return (count);
        }


        public bool IsPresentItem(T item)//works
        {
            LinkGen<T> temp = list;
            bool ans = false;
            while (temp != null) // move one link and add 1 to count
            {
                if (temp.Data.CompareTo(item) == 0)
                {
                    ans = true;
                }
                temp = temp.Next; // this moves to the next link
            }
            return ans;
        }
        public void RemoveItem(T item)// remove occurrences of item from the list
        {
            LinkGen<T> temp = list; //linked list
            LinkListGen<T> newlist = new LinkListGen<T>();//new list


            while (temp != null) // whilst the list isn't empty
            {
                if (item.CompareTo(temp.Data) != 0)
                {
                    newlist.AddItem(temp.Data);//add to the new list
                }
                temp = temp.Next;//move to the next item

            }
            list = newlist.list;

        }
       
        public void Sort()// fully works!!!!!
        {
            LinkGen<T> current = list, index = null;//takes the list and creates an empty list
            T temp_obj;//this will hold the temporary data

            if (list.Next == null)
            {
                return;//if list is empty, return nothing
            }
            else
            {
                while (current != null)//whilst list  isn't null
                {
                    index = current.Next;//index is the next link
                    while (index != null) //whilst that link hasn't been compared to every item in the list
                    {
                        if (current.Data.CompareTo(index.Data) > 0)//see if that item is bigger than the one in front of it
                        {
                            temp_obj = current.Data;//switches the data between the two links around
                            current.Data = index.Data;
                            index.Data = temp_obj;
                        }
                        index = index.Next;
                    }
                    current = current.Next;
                }
            }
        }

    }
}
