namespace HomeWork14
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_InputNumberIteractions = new System.Windows.Forms.TextBox();
            this.lbl_NumberIteractions = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.groupBox_ArrayBased = new System.Windows.Forms.GroupBox();
            this.lbl_ArrayStack = new System.Windows.Forms.Label();
            this.lbl_ArrayQueue = new System.Windows.Forms.Label();
            this.lbl_EllapsedTimeArrayStack = new System.Windows.Forms.Label();
            this.lbl_EllapsedTimeArrayQueue = new System.Windows.Forms.Label();
            this.groupBox_DynArrayBased = new System.Windows.Forms.GroupBox();
            this.lbl_EllapsedTimeDynArrayQueue = new System.Windows.Forms.Label();
            this.lbl_EllapsedTimeDynArrayStack = new System.Windows.Forms.Label();
            this.lbl_DynArrayQueue = new System.Windows.Forms.Label();
            this.lbl_DynArrayStack = new System.Windows.Forms.Label();
            this.groupBox_LinkedList = new System.Windows.Forms.GroupBox();
            this.lbl_EllapsedTimeLinkedListQueue = new System.Windows.Forms.Label();
            this.lbl_EllapsedTimeLinkedListStack = new System.Windows.Forms.Label();
            this.lbl_LinkedListQueue = new System.Windows.Forms.Label();
            this.lbl_LinkedListStack = new System.Windows.Forms.Label();
            this.groupBox_NativeCSharp = new System.Windows.Forms.GroupBox();
            this.lbl_EllapsedTimeNativeQueue = new System.Windows.Forms.Label();
            this.lbl_EllapsedTimeNativeStack = new System.Windows.Forms.Label();
            this.lbl_NativeQueue = new System.Windows.Forms.Label();
            this.lbl_NativeStack = new System.Windows.Forms.Label();
            this.groupBox_ArrayBased.SuspendLayout();
            this.groupBox_DynArrayBased.SuspendLayout();
            this.groupBox_LinkedList.SuspendLayout();
            this.groupBox_NativeCSharp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_InputNumberIteractions
            // 
            this.txt_InputNumberIteractions.Location = new System.Drawing.Point(138, 16);
            this.txt_InputNumberIteractions.Name = "txt_InputNumberIteractions";
            this.txt_InputNumberIteractions.Size = new System.Drawing.Size(100, 20);
            this.txt_InputNumberIteractions.TabIndex = 0;
            this.txt_InputNumberIteractions.TextChanged += new System.EventHandler(this.txt_InputNumberIteractions_TextChanged);
            // 
            // lbl_NumberIteractions
            // 
            this.lbl_NumberIteractions.AutoSize = true;
            this.lbl_NumberIteractions.Location = new System.Drawing.Point(13, 19);
            this.lbl_NumberIteractions.Name = "lbl_NumberIteractions";
            this.lbl_NumberIteractions.Size = new System.Drawing.Size(107, 13);
            this.lbl_NumberIteractions.TabIndex = 1;
            this.lbl_NumberIteractions.Text = "Number of iteractions";
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(335, 13);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 2;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // groupBox_ArrayBased
            // 
            this.groupBox_ArrayBased.Controls.Add(this.lbl_EllapsedTimeArrayQueue);
            this.groupBox_ArrayBased.Controls.Add(this.lbl_EllapsedTimeArrayStack);
            this.groupBox_ArrayBased.Controls.Add(this.lbl_ArrayQueue);
            this.groupBox_ArrayBased.Controls.Add(this.lbl_ArrayStack);
            this.groupBox_ArrayBased.Location = new System.Drawing.Point(16, 76);
            this.groupBox_ArrayBased.Name = "groupBox_ArrayBased";
            this.groupBox_ArrayBased.Size = new System.Drawing.Size(517, 92);
            this.groupBox_ArrayBased.TabIndex = 3;
            this.groupBox_ArrayBased.TabStop = false;
            this.groupBox_ArrayBased.Text = "Array Based";
            // 
            // lbl_ArrayStack
            // 
            this.lbl_ArrayStack.AutoSize = true;
            this.lbl_ArrayStack.Location = new System.Drawing.Point(7, 29);
            this.lbl_ArrayStack.Name = "lbl_ArrayStack";
            this.lbl_ArrayStack.Size = new System.Drawing.Size(38, 13);
            this.lbl_ArrayStack.TabIndex = 0;
            this.lbl_ArrayStack.Text = "Stack:";
            // 
            // lbl_ArrayQueue
            // 
            this.lbl_ArrayQueue.AutoSize = true;
            this.lbl_ArrayQueue.Location = new System.Drawing.Point(7, 59);
            this.lbl_ArrayQueue.Name = "lbl_ArrayQueue";
            this.lbl_ArrayQueue.Size = new System.Drawing.Size(42, 13);
            this.lbl_ArrayQueue.TabIndex = 0;
            this.lbl_ArrayQueue.Text = "Queue:";
            // 
            // lbl_EllapsedTimeArrayStack
            // 
            this.lbl_EllapsedTimeArrayStack.AutoSize = true;
            this.lbl_EllapsedTimeArrayStack.Location = new System.Drawing.Point(68, 29);
            this.lbl_EllapsedTimeArrayStack.Name = "lbl_EllapsedTimeArrayStack";
            this.lbl_EllapsedTimeArrayStack.Size = new System.Drawing.Size(34, 13);
            this.lbl_EllapsedTimeArrayStack.TabIndex = 1;
            this.lbl_EllapsedTimeArrayStack.Text = "00:00";
            // 
            // lbl_EllapsedTimeArrayQueue
            // 
            this.lbl_EllapsedTimeArrayQueue.AutoSize = true;
            this.lbl_EllapsedTimeArrayQueue.Location = new System.Drawing.Point(68, 59);
            this.lbl_EllapsedTimeArrayQueue.Name = "lbl_EllapsedTimeArrayQueue";
            this.lbl_EllapsedTimeArrayQueue.Size = new System.Drawing.Size(34, 13);
            this.lbl_EllapsedTimeArrayQueue.TabIndex = 1;
            this.lbl_EllapsedTimeArrayQueue.Text = "00:00";
            // 
            // groupBox_DynArrayBased
            // 
            this.groupBox_DynArrayBased.Controls.Add(this.lbl_EllapsedTimeDynArrayQueue);
            this.groupBox_DynArrayBased.Controls.Add(this.lbl_EllapsedTimeDynArrayStack);
            this.groupBox_DynArrayBased.Controls.Add(this.lbl_DynArrayQueue);
            this.groupBox_DynArrayBased.Controls.Add(this.lbl_DynArrayStack);
            this.groupBox_DynArrayBased.Location = new System.Drawing.Point(16, 187);
            this.groupBox_DynArrayBased.Name = "groupBox_DynArrayBased";
            this.groupBox_DynArrayBased.Size = new System.Drawing.Size(517, 92);
            this.groupBox_DynArrayBased.TabIndex = 3;
            this.groupBox_DynArrayBased.TabStop = false;
            this.groupBox_DynArrayBased.Text = "Dynamic Array Based";
            // 
            // lbl_EllapsedTimeDynArrayQueue
            // 
            this.lbl_EllapsedTimeDynArrayQueue.AutoSize = true;
            this.lbl_EllapsedTimeDynArrayQueue.Location = new System.Drawing.Point(68, 59);
            this.lbl_EllapsedTimeDynArrayQueue.Name = "lbl_EllapsedTimeDynArrayQueue";
            this.lbl_EllapsedTimeDynArrayQueue.Size = new System.Drawing.Size(34, 13);
            this.lbl_EllapsedTimeDynArrayQueue.TabIndex = 1;
            this.lbl_EllapsedTimeDynArrayQueue.Text = "00:00";
            // 
            // lbl_EllapsedTimeDynArrayStack
            // 
            this.lbl_EllapsedTimeDynArrayStack.AutoSize = true;
            this.lbl_EllapsedTimeDynArrayStack.Location = new System.Drawing.Point(68, 29);
            this.lbl_EllapsedTimeDynArrayStack.Name = "lbl_EllapsedTimeDynArrayStack";
            this.lbl_EllapsedTimeDynArrayStack.Size = new System.Drawing.Size(34, 13);
            this.lbl_EllapsedTimeDynArrayStack.TabIndex = 1;
            this.lbl_EllapsedTimeDynArrayStack.Text = "00:00";
            // 
            // lbl_DynArrayQueue
            // 
            this.lbl_DynArrayQueue.AutoSize = true;
            this.lbl_DynArrayQueue.Location = new System.Drawing.Point(7, 59);
            this.lbl_DynArrayQueue.Name = "lbl_DynArrayQueue";
            this.lbl_DynArrayQueue.Size = new System.Drawing.Size(42, 13);
            this.lbl_DynArrayQueue.TabIndex = 0;
            this.lbl_DynArrayQueue.Text = "Queue:";
            // 
            // lbl_DynArrayStack
            // 
            this.lbl_DynArrayStack.AutoSize = true;
            this.lbl_DynArrayStack.Location = new System.Drawing.Point(7, 29);
            this.lbl_DynArrayStack.Name = "lbl_DynArrayStack";
            this.lbl_DynArrayStack.Size = new System.Drawing.Size(38, 13);
            this.lbl_DynArrayStack.TabIndex = 0;
            this.lbl_DynArrayStack.Text = "Stack:";
            // 
            // groupBox_LinkedList
            // 
            this.groupBox_LinkedList.Controls.Add(this.lbl_EllapsedTimeLinkedListQueue);
            this.groupBox_LinkedList.Controls.Add(this.lbl_EllapsedTimeLinkedListStack);
            this.groupBox_LinkedList.Controls.Add(this.lbl_LinkedListQueue);
            this.groupBox_LinkedList.Controls.Add(this.lbl_LinkedListStack);
            this.groupBox_LinkedList.Location = new System.Drawing.Point(16, 294);
            this.groupBox_LinkedList.Name = "groupBox_LinkedList";
            this.groupBox_LinkedList.Size = new System.Drawing.Size(517, 92);
            this.groupBox_LinkedList.TabIndex = 3;
            this.groupBox_LinkedList.TabStop = false;
            this.groupBox_LinkedList.Text = "Linked List Based";
            // 
            // lbl_EllapsedTimeLinkedListQueue
            // 
            this.lbl_EllapsedTimeLinkedListQueue.AutoSize = true;
            this.lbl_EllapsedTimeLinkedListQueue.Location = new System.Drawing.Point(68, 59);
            this.lbl_EllapsedTimeLinkedListQueue.Name = "lbl_EllapsedTimeLinkedListQueue";
            this.lbl_EllapsedTimeLinkedListQueue.Size = new System.Drawing.Size(34, 13);
            this.lbl_EllapsedTimeLinkedListQueue.TabIndex = 1;
            this.lbl_EllapsedTimeLinkedListQueue.Text = "00:00";
            // 
            // lbl_EllapsedTimeLinkedListStack
            // 
            this.lbl_EllapsedTimeLinkedListStack.AutoSize = true;
            this.lbl_EllapsedTimeLinkedListStack.Location = new System.Drawing.Point(68, 29);
            this.lbl_EllapsedTimeLinkedListStack.Name = "lbl_EllapsedTimeLinkedListStack";
            this.lbl_EllapsedTimeLinkedListStack.Size = new System.Drawing.Size(34, 13);
            this.lbl_EllapsedTimeLinkedListStack.TabIndex = 1;
            this.lbl_EllapsedTimeLinkedListStack.Text = "00:00";
            // 
            // lbl_LinkedListQueue
            // 
            this.lbl_LinkedListQueue.AutoSize = true;
            this.lbl_LinkedListQueue.Location = new System.Drawing.Point(7, 59);
            this.lbl_LinkedListQueue.Name = "lbl_LinkedListQueue";
            this.lbl_LinkedListQueue.Size = new System.Drawing.Size(42, 13);
            this.lbl_LinkedListQueue.TabIndex = 0;
            this.lbl_LinkedListQueue.Text = "Queue:";
            // 
            // lbl_LinkedListStack
            // 
            this.lbl_LinkedListStack.AutoSize = true;
            this.lbl_LinkedListStack.Location = new System.Drawing.Point(7, 29);
            this.lbl_LinkedListStack.Name = "lbl_LinkedListStack";
            this.lbl_LinkedListStack.Size = new System.Drawing.Size(38, 13);
            this.lbl_LinkedListStack.TabIndex = 0;
            this.lbl_LinkedListStack.Text = "Stack:";
            // 
            // groupBox_NativeCSharp
            // 
            this.groupBox_NativeCSharp.Controls.Add(this.lbl_EllapsedTimeNativeQueue);
            this.groupBox_NativeCSharp.Controls.Add(this.lbl_EllapsedTimeNativeStack);
            this.groupBox_NativeCSharp.Controls.Add(this.lbl_NativeQueue);
            this.groupBox_NativeCSharp.Controls.Add(this.lbl_NativeStack);
            this.groupBox_NativeCSharp.Location = new System.Drawing.Point(16, 402);
            this.groupBox_NativeCSharp.Name = "groupBox_NativeCSharp";
            this.groupBox_NativeCSharp.Size = new System.Drawing.Size(517, 92);
            this.groupBox_NativeCSharp.TabIndex = 3;
            this.groupBox_NativeCSharp.TabStop = false;
            this.groupBox_NativeCSharp.Text = "Native C#";
            // 
            // lbl_EllapsedTimeNativeQueue
            // 
            this.lbl_EllapsedTimeNativeQueue.AutoSize = true;
            this.lbl_EllapsedTimeNativeQueue.Location = new System.Drawing.Point(68, 59);
            this.lbl_EllapsedTimeNativeQueue.Name = "lbl_EllapsedTimeNativeQueue";
            this.lbl_EllapsedTimeNativeQueue.Size = new System.Drawing.Size(34, 13);
            this.lbl_EllapsedTimeNativeQueue.TabIndex = 1;
            this.lbl_EllapsedTimeNativeQueue.Text = "00:00";
            // 
            // lbl_EllapsedTimeNativeStack
            // 
            this.lbl_EllapsedTimeNativeStack.AutoSize = true;
            this.lbl_EllapsedTimeNativeStack.Location = new System.Drawing.Point(68, 29);
            this.lbl_EllapsedTimeNativeStack.Name = "lbl_EllapsedTimeNativeStack";
            this.lbl_EllapsedTimeNativeStack.Size = new System.Drawing.Size(34, 13);
            this.lbl_EllapsedTimeNativeStack.TabIndex = 1;
            this.lbl_EllapsedTimeNativeStack.Text = "00:00";
            // 
            // lbl_NativeQueue
            // 
            this.lbl_NativeQueue.AutoSize = true;
            this.lbl_NativeQueue.Location = new System.Drawing.Point(7, 59);
            this.lbl_NativeQueue.Name = "lbl_NativeQueue";
            this.lbl_NativeQueue.Size = new System.Drawing.Size(42, 13);
            this.lbl_NativeQueue.TabIndex = 0;
            this.lbl_NativeQueue.Text = "Queue:";
            // 
            // lbl_NativeStack
            // 
            this.lbl_NativeStack.AutoSize = true;
            this.lbl_NativeStack.Location = new System.Drawing.Point(7, 29);
            this.lbl_NativeStack.Name = "lbl_NativeStack";
            this.lbl_NativeStack.Size = new System.Drawing.Size(38, 13);
            this.lbl_NativeStack.TabIndex = 0;
            this.lbl_NativeStack.Text = "Stack:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 518);
            this.Controls.Add(this.groupBox_NativeCSharp);
            this.Controls.Add(this.groupBox_LinkedList);
            this.Controls.Add(this.groupBox_DynArrayBased);
            this.Controls.Add(this.groupBox_ArrayBased);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.lbl_NumberIteractions);
            this.Controls.Add(this.txt_InputNumberIteractions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_ArrayBased.ResumeLayout(false);
            this.groupBox_ArrayBased.PerformLayout();
            this.groupBox_DynArrayBased.ResumeLayout(false);
            this.groupBox_DynArrayBased.PerformLayout();
            this.groupBox_LinkedList.ResumeLayout(false);
            this.groupBox_LinkedList.PerformLayout();
            this.groupBox_NativeCSharp.ResumeLayout(false);
            this.groupBox_NativeCSharp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_InputNumberIteractions;
        private System.Windows.Forms.Label lbl_NumberIteractions;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.GroupBox groupBox_ArrayBased;
        private System.Windows.Forms.Label lbl_ArrayStack;
        private System.Windows.Forms.Label lbl_EllapsedTimeArrayQueue;
        private System.Windows.Forms.Label lbl_EllapsedTimeArrayStack;
        private System.Windows.Forms.Label lbl_ArrayQueue;
        private System.Windows.Forms.GroupBox groupBox_DynArrayBased;
        private System.Windows.Forms.Label lbl_EllapsedTimeDynArrayQueue;
        private System.Windows.Forms.Label lbl_EllapsedTimeDynArrayStack;
        private System.Windows.Forms.Label lbl_DynArrayQueue;
        private System.Windows.Forms.Label lbl_DynArrayStack;
        private System.Windows.Forms.GroupBox groupBox_LinkedList;
        private System.Windows.Forms.Label lbl_EllapsedTimeLinkedListQueue;
        private System.Windows.Forms.Label lbl_EllapsedTimeLinkedListStack;
        private System.Windows.Forms.Label lbl_LinkedListQueue;
        private System.Windows.Forms.Label lbl_LinkedListStack;
        private System.Windows.Forms.GroupBox groupBox_NativeCSharp;
        private System.Windows.Forms.Label lbl_EllapsedTimeNativeQueue;
        private System.Windows.Forms.Label lbl_EllapsedTimeNativeStack;
        private System.Windows.Forms.Label lbl_NativeQueue;
        private System.Windows.Forms.Label lbl_NativeStack;
    }
}

