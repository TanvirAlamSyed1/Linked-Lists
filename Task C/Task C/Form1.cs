using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book;
using LinkedListGens;
using LinkGens;

namespace Task_C
{
    public partial class Form1 : Form

    {
        LinkListGen<Books> mylist = new LinkListGen<Books>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            mylist.AddItem(new Books(isbntxtbx.Text,titletxtbx.Text,authortxtbx.Text));
            addtolistbox();
            titletxtbx.Text = "";
            authortxtbx.Text = "";
            isbntxtbx.Text = "";
        }
        private void sortbtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear ();
            mylist.Sort();
            addtolistbox();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void addtolistbox()// this adds all the items names (by title) into the listbox
        {
            int listsize = mylist.NumberOfItems();//gets the length of the linked list
            LinkGen<Books> temp = mylist.getlist;//gets the linked list from the class
            while(listsize > 0)
            {
                listBox1.Items.Add(temp.Data.GetSummary());
                temp = temp.Next;//moves to next link
                listsize--;
                
            }
        }
        private void removebtn_Click(object sender, EventArgs e)//Works
        {
            listBox1.Items.Clear();
            Books b = new Books(isbntxtbx.Text, titletxtbx.Text, authortxtbx.Text);
            mylist.RemoveItem(b);
/*            Console.WriteLine(mylist.DisplayList());*/
            addtolistbox();
        }

    }
}
