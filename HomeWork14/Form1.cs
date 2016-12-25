using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynArray;
using Array;

namespace HomeWork14
{
    public partial class Form1 : Form
    {

        MyStack<int> stackArray;
        MyQueue<int> queueArray;
        DynArray.Stack<int> stackDynArray;
        DynArray.Queue<int> queueDynArray;
        LinkedList.Stack<int> stackLinkedList;
        LinkedList.Queue<int> queueLinkedList;
        TestPerformance testPerformance = new TestPerformance();

        public Form1()
        {
            InitializeComponent();
            stackDynArray = new DynArray.Stack<int>();
            queueDynArray = new DynArray.Queue<int>();
            stackLinkedList = new LinkedList.Stack<int>();
            queueLinkedList = new LinkedList.Queue<int>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn_Run_Click(object sender, EventArgs e)
        {
            try
            {
                testPerformance.NumberIteractions = Convert.ToInt32(txt_InputNumberIteractions.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            stackArray = new MyStack<int>(new int[testPerformance.NumberIteractions]);
            queueArray = new MyQueue<int>(new int[testPerformance.NumberIteractions]);
            string StackTime ="";
            string QueueTime="";

            testPerformance.MeasureTime(stackArray, queueArray, ref StackTime, ref QueueTime);
            lbl_EllapsedTimeArrayStack.Text = StackTime;
            lbl_EllapsedTimeArrayQueue.Text = QueueTime;

            testPerformance.MeasureTime(stackDynArray, queueDynArray, ref StackTime, ref QueueTime);
            lbl_EllapsedTimeDynArrayStack.Text = StackTime;
            lbl_EllapsedTimeDynArrayQueue.Text = QueueTime;

            testPerformance.MeasureTime(stackLinkedList, queueLinkedList, ref StackTime, ref QueueTime);
            lbl_EllapsedTimeLinkedListStack.Text = StackTime;
            lbl_EllapsedTimeLinkedListQueue.Text = QueueTime;

            testPerformance.MeasureTime(ref StackTime, ref QueueTime);
            lbl_EllapsedTimeNativeStack.Text = StackTime;
            lbl_EllapsedTimeNativeQueue.Text = QueueTime;

        }

        private void txt_InputNumberIteractions_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
