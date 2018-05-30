using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningQueueAndStackV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Stack<string> myStack = new Stack<string>();
            myStack.Push("pierwszy w rzędzie");
            myStack.Push("drugi w rzędzie");
            myStack.Push("trzeci w rzędzie");
            myStack.Push("czwarty w rzędzie");

            Queue<string> myQueue = new Queue<string>(myStack); // becuse list/queue/stack implement IEnumerable interface we can change them beetwen themself and we can use foreach on all of them.
            List<string> myList = new List<string>(myQueue);
            Stack<string> anotherStack = new Stack<string>(myList);
            MessageBox.Show ("myQueue ma " + myQueue.Count + " elementy \n" + "myList ma " + myList.Count + " elementy \n" + "anotherStack ma " + anotherStack.Count + " elementy \n");
        }
    }
}
