
namespace _20210404_ProJect2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.subj5 = new System.Windows.Forms.NumericUpDown();
            this.subj4 = new System.Windows.Forms.NumericUpDown();
            this.subj3 = new System.Windows.Forms.NumericUpDown();
            this.subj2 = new System.Windows.Forms.NumericUpDown();
            this.subj1 = new System.Windows.Forms.NumericUpDown();
            this.rbFm = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subj5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subj4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subj3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subj2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.listView);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.subj5);
            this.groupBox1.Controls.Add(this.subj4);
            this.groupBox1.Controls.Add(this.subj3);
            this.groupBox1.Controls.Add(this.subj2);
            this.groupBox1.Controls.Add(this.subj1);
            this.groupBox1.Controls.Add(this.rbFm);
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.num);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "학생 성적관리 시스템";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 28);
            this.button3.TabIndex = 20;
            this.button3.Text = "수정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(195, 35);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(563, 289);
            this.listView.TabIndex = 18;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "성별";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "언어";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "수리";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "사탐";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "과탐";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "외국어";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subj5
            // 
            this.subj5.Location = new System.Drawing.Point(62, 288);
            this.subj5.Name = "subj5";
            this.subj5.Size = new System.Drawing.Size(103, 23);
            this.subj5.TabIndex = 16;
            // 
            // subj4
            // 
            this.subj4.Location = new System.Drawing.Point(62, 255);
            this.subj4.Name = "subj4";
            this.subj4.Size = new System.Drawing.Size(103, 23);
            this.subj4.TabIndex = 15;
            // 
            // subj3
            // 
            this.subj3.Location = new System.Drawing.Point(62, 220);
            this.subj3.Name = "subj3";
            this.subj3.Size = new System.Drawing.Size(103, 23);
            this.subj3.TabIndex = 14;
            // 
            // subj2
            // 
            this.subj2.Location = new System.Drawing.Point(62, 186);
            this.subj2.Name = "subj2";
            this.subj2.Size = new System.Drawing.Size(103, 23);
            this.subj2.TabIndex = 13;
            // 
            // subj1
            // 
            this.subj1.Location = new System.Drawing.Point(62, 152);
            this.subj1.Name = "subj1";
            this.subj1.Size = new System.Drawing.Size(103, 23);
            this.subj1.TabIndex = 12;
            // 
            // rbFm
            // 
            this.rbFm.AutoSize = true;
            this.rbFm.Location = new System.Drawing.Point(105, 118);
            this.rbFm.Name = "rbFm";
            this.rbFm.Size = new System.Drawing.Size(37, 19);
            this.rbFm.TabIndex = 11;
            this.rbFm.Text = "여";
            this.rbFm.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Checked = true;
            this.rbM.Location = new System.Drawing.Point(62, 118);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(37, 19);
            this.rbM.TabIndex = 10;
            this.rbM.TabStop = true;
            this.rbM.Text = "남";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 23);
            this.textBox1.TabIndex = 9;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(62, 46);
            this.num.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(103, 23);
            this.num.TabIndex = 8;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "외국어";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "과탐";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "사탐";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "수리";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "언어";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "성별";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "번호";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 488);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subj5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subj4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subj3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subj2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown subj5;
        private System.Windows.Forms.NumericUpDown subj4;
        private System.Windows.Forms.NumericUpDown subj3;
        private System.Windows.Forms.NumericUpDown subj2;
        private System.Windows.Forms.NumericUpDown subj1;
        private System.Windows.Forms.RadioButton rbFm;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

