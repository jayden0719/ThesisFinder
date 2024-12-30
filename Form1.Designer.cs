namespace ThesisFinder
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
            label1 = new Label();
            textBox1 = new TextBox();
            sortChk = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            pubchk = new ComboBox();
            label7 = new Label();
            catechk = new ComboBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 24);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "검색명 : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 1;
            // 
            // sortChk
            // 
            sortChk.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sortChk.FormattingEnabled = true;
            sortChk.Items.AddRange(new object[] { "유사도순", "발행일순", "인기도순" });
            sortChk.Location = new Point(474, 22);
            sortChk.Name = "sortChk";
            sortChk.Size = new Size(90, 28);
            sortChk.TabIndex = 2;
            sortChk.Text = "유사도순";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(315, 26);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 3;
            label2.Text = "검색개수 : ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(403, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(65, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(275, 170);
            button1.Name = "button1";
            button1.Size = new Size(109, 45);
            button1.TabIndex = 5;
            button1.Text = "검색";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(pubchk);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(catechk);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(sortChk);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 221);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "검색조건";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(297, 134);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(58, 23);
            textBox7.TabIndex = 21;
            textBox7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(275, 137);
            label8.Name = "label8";
            label8.Size = new Size(20, 20);
            label8.TabIndex = 20;
            label8.Text = "~";
            label8.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(216, 134);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(58, 23);
            textBox6.TabIndex = 19;
            textBox6.Visible = false;
            // 
            // pubchk
            // 
            pubchk.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pubchk.FormattingEnabled = true;
            pubchk.Items.AddRange(new object[] { "최근 1년", "최근 3년", "직접지정" });
            pubchk.Location = new Point(118, 131);
            pubchk.Name = "pubchk";
            pubchk.Size = new Size(90, 28);
            pubchk.TabIndex = 17;
            pubchk.Text = "최근 1년";
            pubchk.SelectedIndexChanged += pubchk_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(35, 134);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 16;
            label7.Text = "발행연도 :";
            // 
            // catechk
            // 
            catechk.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            catechk.FormattingEnabled = true;
            catechk.Items.AddRange(new object[] { "인문학", "사회과학", "자연과학", "공학", "의약학", "농수해양", "예술체육", "복합학", "교양" });
            catechk.Location = new Point(408, 97);
            catechk.Name = "catechk";
            catechk.Size = new Size(91, 28);
            catechk.TabIndex = 15;
            catechk.Text = "인문학";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(315, 100);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 14;
            label6.Text = "주제분류 :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(408, 61);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 23);
            textBox5.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(315, 61);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 12;
            label5.Text = "발행기관명 : ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(114, 97);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 23);
            textBox4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 97);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 10;
            label4.Text = "간행물명 : ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 23);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 61);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 8;
            label3.Text = "저자명 : ";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(503, 170);
            button3.Name = "button3";
            button3.Size = new Size(109, 45);
            button3.TabIndex = 7;
            button3.Text = "조회";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(390, 170);
            button2.Name = "button2";
            button2.Size = new Size(109, 45);
            button2.TabIndex = 6;
            button2.Text = "저장";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(9, 22);
            listView1.Name = "listView1";
            listView1.OwnerDraw = true;
            listView1.Size = new Size(894, 360);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ColumnClick += listview1_ColumnClick;
            listView1.DrawColumnHeader += listview1_DrawColumnHeader;
            listView1.DrawItem += listview1_DrawItem;
            listView1.DrawSubItem += listview1_DrawSubItem;
            listView1.DoubleClick += listview1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "No.";
            columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "논문명";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 450;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "저자명";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "무료여부";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "상세링크";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 180;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(6, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(909, 407);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "검색결과";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 674);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "논문 검색 엔진";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox sortChk;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private ComboBox pubchk;
        private Label label7;
        private ComboBox catechk;
        private Label label6;
        private ListView listView1;
        private GroupBox groupBox2;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
