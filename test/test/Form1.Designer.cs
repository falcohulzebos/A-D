namespace TestForm
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
            this.turnInTest = new System.Windows.Forms.Button();
            this.ShowStudents = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // turnInTest
            // 
            this.turnInTest.Location = new System.Drawing.Point(112, 54);
            this.turnInTest.Name = "turnInTest";
            this.turnInTest.Size = new System.Drawing.Size(97, 30);
            this.turnInTest.TabIndex = 0;
            this.turnInTest.Text = "turn test in";
            this.turnInTest.UseVisualStyleBackColor = true;
            this.turnInTest.Click += new System.EventHandler(this.turnInTest_Click);
            // 
            // ShowStudents
            // 
            this.ShowStudents.Location = new System.Drawing.Point(340, 54);
            this.ShowStudents.Name = "ShowStudents";
            this.ShowStudents.Size = new System.Drawing.Size(97, 30);
            this.ShowStudents.TabIndex = 1;
            this.ShowStudents.Text = "Show students";
            this.ShowStudents.UseVisualStyleBackColor = true;
            this.ShowStudents.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(-1, 54);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(97, 30);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search Student";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(470, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(92, 107);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(101, 20);
            this.nameBox.TabIndex = 4;
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(92, 133);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(101, 20);
            this.numberBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 42);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 358);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ShowStudents);
            this.Controls.Add(this.turnInTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button turnInTest;
        private System.Windows.Forms.Button ShowStudents;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

