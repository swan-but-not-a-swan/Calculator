namespace Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.clear = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.square_root = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divider = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.negative_value = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.percentage = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Trigobutton = new System.Windows.Forms.Button();
            this.trigoOption = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.60617F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.39383F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.35329F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.64671F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 410);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBox1, 2);
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 342);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(545, 65);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Tip: (-) is used to turn values into negative values, - is used for subtraction. " +
    "Note that (-) and - have different functionality\n\nEncountering some bugs? Report" +
    " it here www.hehe.com";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.clear);
            this.flowLayoutPanel3.Controls.Add(this.Del);
            this.flowLayoutPanel3.Controls.Add(this.square_root);
            this.flowLayoutPanel3.Controls.Add(this.plus);
            this.flowLayoutPanel3.Controls.Add(this.minus);
            this.flowLayoutPanel3.Controls.Add(this.multiply);
            this.flowLayoutPanel3.Controls.Add(this.divider);
            this.flowLayoutPanel3.Controls.Add(this.equal);
            this.flowLayoutPanel3.Controls.Add(this.negative_value);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(370, 82);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(178, 254);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(3, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(170, 43);
            this.clear.TabIndex = 18;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Del
            // 
            this.Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del.Location = new System.Drawing.Point(3, 52);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(82, 45);
            this.Del.TabIndex = 16;
            this.Del.Text = "Del";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // square_root
            // 
            this.square_root.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square_root.Location = new System.Drawing.Point(91, 52);
            this.square_root.Name = "square_root";
            this.square_root.Size = new System.Drawing.Size(82, 45);
            this.square_root.TabIndex = 20;
            this.square_root.Text = "√";
            this.square_root.UseVisualStyleBackColor = true;
            this.square_root.Click += new System.EventHandler(this.square_root_Click);
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(3, 103);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(82, 45);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(91, 103);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(82, 45);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(3, 154);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(82, 45);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divider
            // 
            this.divider.AutoSize = true;
            this.divider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divider.Location = new System.Drawing.Point(91, 154);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(82, 45);
            this.divider.TabIndex = 14;
            this.divider.Text = "/";
            this.divider.UseVisualStyleBackColor = true;
            this.divider.Click += new System.EventHandler(this.divider_Click);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(3, 205);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(82, 45);
            this.equal.TabIndex = 15;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // negative_value
            // 
            this.negative_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negative_value.Location = new System.Drawing.Point(91, 205);
            this.negative_value.Name = "negative_value";
            this.negative_value.Size = new System.Drawing.Size(82, 45);
            this.negative_value.TabIndex = 19;
            this.negative_value.Text = "(-)";
            this.negative_value.UseVisualStyleBackColor = true;
            this.negative_value.Click += new System.EventHandler(this.negative_value_Click);
            // 
            // label
            // 
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(361, 79);
            this.label.TabIndex = 3;
            this.label.Text = " ";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.one);
            this.flowLayoutPanel1.Controls.Add(this.two);
            this.flowLayoutPanel1.Controls.Add(this.three);
            this.flowLayoutPanel1.Controls.Add(this.four);
            this.flowLayoutPanel1.Controls.Add(this.five);
            this.flowLayoutPanel1.Controls.Add(this.six);
            this.flowLayoutPanel1.Controls.Add(this.seven);
            this.flowLayoutPanel1.Controls.Add(this.eight);
            this.flowLayoutPanel1.Controls.Add(this.nine);
            this.flowLayoutPanel1.Controls.Add(this.dot);
            this.flowLayoutPanel1.Controls.Add(this.zero);
            this.flowLayoutPanel1.Controls.Add(this.percentage);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(361, 254);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(3, 3);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(113, 55);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(122, 3);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(113, 55);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(241, 3);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(113, 55);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(3, 64);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(113, 55);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(122, 64);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(113, 55);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(241, 64);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(113, 55);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(3, 125);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(113, 55);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(122, 125);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(113, 55);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(241, 125);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(113, 55);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(3, 186);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(113, 55);
            this.dot.TabIndex = 16;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(122, 186);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(113, 55);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // percentage
            // 
            this.percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.Location = new System.Drawing.Point(241, 186);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(113, 55);
            this.percentage.TabIndex = 17;
            this.percentage.Text = "%";
            this.percentage.UseVisualStyleBackColor = true;
            this.percentage.Click += new System.EventHandler(this.percentage_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Trigobutton);
            this.flowLayoutPanel2.Controls.Add(this.trigoOption);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(370, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(178, 73);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // Trigobutton
            // 
            this.Trigobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trigobutton.Location = new System.Drawing.Point(3, 3);
            this.Trigobutton.Name = "Trigobutton";
            this.Trigobutton.Size = new System.Drawing.Size(170, 33);
            this.Trigobutton.TabIndex = 0;
            this.Trigobutton.Text = "sin";
            this.Trigobutton.UseVisualStyleBackColor = true;
            this.Trigobutton.Click += new System.EventHandler(this.Trigobutton_Click);
            // 
            // trigoOption
            // 
            this.trigoOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigoOption.FormattingEnabled = true;
            this.trigoOption.Items.AddRange(new object[] {
            "sin",
            "cos",
            "tan",
            "sin^-1",
            "cos^-1",
            "tan^-1"});
            this.trigoOption.Location = new System.Drawing.Point(3, 42);
            this.trigoOption.Name = "trigoOption";
            this.trigoOption.Size = new System.Drawing.Size(170, 28);
            this.trigoOption.TabIndex = 1;
            this.trigoOption.SelectedValueChanged += new System.EventHandler(this.Showthevalueonbutton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divider;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button negative_value;
        private System.Windows.Forms.Button square_root;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button percentage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Trigobutton;
        private System.Windows.Forms.ComboBox trigoOption;
    }
}

