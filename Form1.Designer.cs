namespace ParallelSort
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Sorttab = new TabPage();
            listView4 = new ListView();
            listView3 = new ListView();
            listView2 = new ListView();
            listView1 = new ListView();
            button1 = new Button();
            InsertLabelTime = new Label();
            QuickLabelTime = new Label();
            BubbleLabelTime = new Label();
            InsertLabel = new Label();
            QuickLabel = new Label();
            BubbleLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            Matrix = new TabPage();
            label12 = new Label();
            button3 = new Button();
            richTextBoxResult = new RichTextBox();
            button2 = new Button();
            richTextBoxB = new RichTextBox();
            richTextBoxA = new RichTextBox();
            matrixBnumeric2 = new NumericUpDown();
            label10 = new Label();
            matrixBnumeric1 = new NumericUpDown();
            label11 = new Label();
            matrixAnumeric2 = new NumericUpDown();
            label9 = new Label();
            matrixAnumeric1 = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tabControl1.SuspendLayout();
            Sorttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            Matrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matrixBnumeric2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrixBnumeric1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrixAnumeric2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrixAnumeric1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Sorttab);
            tabControl1.Controls.Add(Matrix);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1094, 651);
            tabControl1.TabIndex = 21;
            // 
            // Sorttab
            // 
            Sorttab.Controls.Add(listView4);
            Sorttab.Controls.Add(listView3);
            Sorttab.Controls.Add(listView2);
            Sorttab.Controls.Add(listView1);
            Sorttab.Controls.Add(button1);
            Sorttab.Controls.Add(InsertLabelTime);
            Sorttab.Controls.Add(QuickLabelTime);
            Sorttab.Controls.Add(BubbleLabelTime);
            Sorttab.Controls.Add(InsertLabel);
            Sorttab.Controls.Add(QuickLabel);
            Sorttab.Controls.Add(BubbleLabel);
            Sorttab.Controls.Add(label5);
            Sorttab.Controls.Add(label4);
            Sorttab.Controls.Add(label3);
            Sorttab.Controls.Add(label2);
            Sorttab.Controls.Add(numericUpDown1);
            Sorttab.Controls.Add(label1);
            Sorttab.Location = new Point(4, 24);
            Sorttab.Name = "Sorttab";
            Sorttab.Padding = new Padding(3);
            Sorttab.Size = new Size(1086, 623);
            Sorttab.TabIndex = 0;
            Sorttab.Text = "Сортировка";
            Sorttab.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            listView4.Location = new Point(6, 486);
            listView4.Name = "listView4";
            listView4.Size = new Size(1074, 109);
            listView4.TabIndex = 37;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.Location = new Point(6, 330);
            listView3.Name = "listView3";
            listView3.Size = new Size(1074, 109);
            listView3.TabIndex = 36;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(6, 173);
            listView2.Name = "listView2";
            listView2.Size = new Size(1074, 109);
            listView2.TabIndex = 35;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 44);
            listView1.Name = "listView1";
            listView1.Size = new Size(1074, 109);
            listView1.TabIndex = 34;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(237, 1);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            button1.Text = "Запуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // InsertLabelTime
            // 
            InsertLabelTime.AutoSize = true;
            InsertLabelTime.Location = new Point(241, 598);
            InsertLabelTime.Name = "InsertLabelTime";
            InsertLabelTime.Size = new Size(118, 15);
            InsertLabelTime.TabIndex = 32;
            InsertLabelTime.Text = "Затраченное время:";
            // 
            // QuickLabelTime
            // 
            QuickLabelTime.AutoSize = true;
            QuickLabelTime.Location = new Point(239, 442);
            QuickLabelTime.Name = "QuickLabelTime";
            QuickLabelTime.Size = new Size(118, 15);
            QuickLabelTime.TabIndex = 31;
            QuickLabelTime.Text = "Затраченное время:";
            // 
            // BubbleLabelTime
            // 
            BubbleLabelTime.AutoSize = true;
            BubbleLabelTime.Location = new Point(239, 285);
            BubbleLabelTime.Name = "BubbleLabelTime";
            BubbleLabelTime.Size = new Size(118, 15);
            BubbleLabelTime.TabIndex = 30;
            BubbleLabelTime.Text = "Затраченное время:";
            // 
            // InsertLabel
            // 
            InsertLabel.AutoSize = true;
            InsertLabel.Location = new Point(6, 598);
            InsertLabel.Name = "InsertLabel";
            InsertLabel.Size = new Size(229, 15);
            InsertLabel.TabIndex = 29;
            InsertLabel.Text = "Количество сравнений и перестановок: ";
            // 
            // QuickLabel
            // 
            QuickLabel.AutoSize = true;
            QuickLabel.Location = new Point(6, 442);
            QuickLabel.Name = "QuickLabel";
            QuickLabel.Size = new Size(229, 15);
            QuickLabel.TabIndex = 28;
            QuickLabel.Text = "Количество сравнений и перестановок: ";
            // 
            // BubbleLabel
            // 
            BubbleLabel.AutoSize = true;
            BubbleLabel.Location = new Point(6, 285);
            BubbleLabel.Name = "BubbleLabel";
            BubbleLabel.Size = new Size(229, 15);
            BubbleLabel.TabIndex = 27;
            BubbleLabel.Text = "Количество сравнений и перестановок: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 468);
            label5.Name = "label5";
            label5.Size = new Size(133, 15);
            label5.TabIndex = 26;
            label5.Text = "Сортировка вставками";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 312);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 25;
            label4.Text = "Бытрая сортировка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 156);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 24;
            label3.Text = "Сортировка пузырьком";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 26);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 23;
            label2.Text = "Первоначальный массив";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(111, 0);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 22;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 21;
            label1.Text = "Размер  массива";
            // 
            // Matrix
            // 
            Matrix.Controls.Add(label12);
            Matrix.Controls.Add(button3);
            Matrix.Controls.Add(richTextBoxResult);
            Matrix.Controls.Add(button2);
            Matrix.Controls.Add(richTextBoxB);
            Matrix.Controls.Add(richTextBoxA);
            Matrix.Controls.Add(matrixBnumeric2);
            Matrix.Controls.Add(label10);
            Matrix.Controls.Add(matrixBnumeric1);
            Matrix.Controls.Add(label11);
            Matrix.Controls.Add(matrixAnumeric2);
            Matrix.Controls.Add(label9);
            Matrix.Controls.Add(matrixAnumeric1);
            Matrix.Controls.Add(label8);
            Matrix.Controls.Add(label7);
            Matrix.Controls.Add(label6);
            Matrix.Location = new Point(4, 24);
            Matrix.Name = "Matrix";
            Matrix.Padding = new Padding(3);
            Matrix.Size = new Size(1086, 623);
            Matrix.TabIndex = 1;
            Matrix.Text = "Перемножение матриц";
            Matrix.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(598, 341);
            label12.Name = "label12";
            label12.Size = new Size(121, 15);
            label12.TabIndex = 36;
            label12.Text = "Потраченное время ";
            // 
            // button3
            // 
            button3.Location = new Point(493, 337);
            button3.Name = "button3";
            button3.Size = new Size(99, 23);
            button3.TabIndex = 35;
            button3.Text = "Перемножить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.Location = new Point(8, 366);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.Size = new Size(1070, 249);
            richTextBoxResult.TabIndex = 34;
            richTextBoxResult.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(493, 52);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 33;
            button2.Text = "Сгенерировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBoxB
            // 
            richTextBoxB.Location = new Point(598, 63);
            richTextBoxB.Name = "richTextBoxB";
            richTextBoxB.Size = new Size(480, 261);
            richTextBoxB.TabIndex = 32;
            richTextBoxB.Text = "";
            // 
            // richTextBoxA
            // 
            richTextBoxA.Location = new Point(8, 63);
            richTextBoxA.Name = "richTextBoxA";
            richTextBoxA.Size = new Size(479, 261);
            richTextBoxA.TabIndex = 31;
            richTextBoxA.Text = "";
            // 
            // matrixBnumeric2
            // 
            matrixBnumeric2.Location = new Point(887, 34);
            matrixBnumeric2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            matrixBnumeric2.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            matrixBnumeric2.Name = "matrixBnumeric2";
            matrixBnumeric2.Size = new Size(55, 23);
            matrixBnumeric2.TabIndex = 30;
            matrixBnumeric2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(861, 36);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 29;
            label10.Text = "на";
            // 
            // matrixBnumeric1
            // 
            matrixBnumeric1.Location = new Point(800, 34);
            matrixBnumeric1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            matrixBnumeric1.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            matrixBnumeric1.Name = "matrixBnumeric1";
            matrixBnumeric1.Size = new Size(55, 23);
            matrixBnumeric1.TabIndex = 28;
            matrixBnumeric1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(695, 39);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 27;
            label11.Text = "Размер  матрицы";
            // 
            // matrixAnumeric2
            // 
            matrixAnumeric2.Location = new Point(344, 34);
            matrixAnumeric2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            matrixAnumeric2.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            matrixAnumeric2.Name = "matrixAnumeric2";
            matrixAnumeric2.Size = new Size(55, 23);
            matrixAnumeric2.TabIndex = 26;
            matrixAnumeric2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(318, 36);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 25;
            label9.Text = "на";
            // 
            // matrixAnumeric1
            // 
            matrixAnumeric1.Location = new Point(257, 34);
            matrixAnumeric1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            matrixAnumeric1.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            matrixAnumeric1.Name = "matrixAnumeric1";
            matrixAnumeric1.Size = new Size(55, 23);
            matrixAnumeric1.TabIndex = 24;
            matrixAnumeric1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(152, 39);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 23;
            label8.Text = "Размер  матрицы";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(797, 9);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 1;
            label7.Text = "Матрица B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 9);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 0;
            label6.Text = "Матрица А";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 651);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Sorttab.ResumeLayout(false);
            Sorttab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            Matrix.ResumeLayout(false);
            Matrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matrixBnumeric2).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrixBnumeric1).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrixAnumeric2).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrixAnumeric1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Sorttab;
        private ListView listView4;
        private ListView listView3;
        private ListView listView2;
        private ListView listView1;
        private Button button1;
        private Label InsertLabelTime;
        private Label QuickLabelTime;
        private Label BubbleLabelTime;
        private Label InsertLabel;
        private Label QuickLabel;
        private Label BubbleLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private TabPage Matrix;
        private Label label7;
        private Label label6;
        private NumericUpDown matrixAnumeric1;
        private Label label8;
        private NumericUpDown matrixAnumeric2;
        private Label label9;
        private RichTextBox richTextBoxB;
        private RichTextBox richTextBoxA;
        private NumericUpDown matrixBnumeric2;
        private Label label10;
        private NumericUpDown matrixBnumeric1;
        private Label label11;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBoxResult;
        private Label label12;
    }
}