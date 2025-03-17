namespace StudentDiary
{
    partial class AddEditStudent
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
            tbId = new TextBox();
            tbName = new TextBox();
            tbSurname = new TextBox();
            tbMath = new TextBox();
            tbPolish = new TextBox();
            tbEnglish = new TextBox();
            tbTechnology = new TextBox();
            tbPsysics = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            rtbComments = new RichTextBox();
            label9 = new Label();
            btnApply = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tbId
            // 
            tbId.BackColor = SystemColors.GrayText;
            tbId.Location = new Point(93, 6);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(265, 23);
            tbId.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.MenuBar;
            tbName.Location = new Point(93, 35);
            tbName.Name = "tbName";
            tbName.Size = new Size(265, 23);
            tbName.TabIndex = 1;
            // 
            // tbSurname
            // 
            tbSurname.BackColor = SystemColors.MenuBar;
            tbSurname.Location = new Point(93, 64);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(265, 23);
            tbSurname.TabIndex = 2;
            // 
            // tbMath
            // 
            tbMath.BackColor = SystemColors.MenuBar;
            tbMath.Location = new Point(93, 93);
            tbMath.Name = "tbMath";
            tbMath.Size = new Size(265, 23);
            tbMath.TabIndex = 3;
            // 
            // tbPolish
            // 
            tbPolish.BackColor = SystemColors.MenuBar;
            tbPolish.Location = new Point(93, 122);
            tbPolish.Name = "tbPolish";
            tbPolish.Size = new Size(265, 23);
            tbPolish.TabIndex = 4;
            // 
            // tbEnglish
            // 
            tbEnglish.BackColor = SystemColors.MenuBar;
            tbEnglish.Location = new Point(93, 151);
            tbEnglish.Name = "tbEnglish";
            tbEnglish.Size = new Size(265, 23);
            tbEnglish.TabIndex = 5;
            // 
            // tbTechnology
            // 
            tbTechnology.BackColor = SystemColors.MenuBar;
            tbTechnology.Location = new Point(93, 180);
            tbTechnology.Name = "tbTechnology";
            tbTechnology.Size = new Size(265, 23);
            tbTechnology.TabIndex = 6;
            // 
            // tbPsysics
            // 
            tbPsysics.BackColor = SystemColors.MenuBar;
            tbPsysics.Location = new Point(93, 209);
            tbPsysics.Name = "tbPsysics";
            tbPsysics.Size = new Size(265, 23);
            tbPsysics.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 43);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 14);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 10;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 72);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 11;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 101);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 12;
            label4.Text = "Math";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 130);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 13;
            label5.Text = "Polish";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 159);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 14;
            label6.Text = "English";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 188);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 15;
            label7.Text = "Technology";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 219);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 16;
            label8.Text = "Psysics";
            // 
            // rtbComments
            // 
            rtbComments.BackColor = Color.Gainsboro;
            rtbComments.Location = new Point(93, 251);
            rtbComments.Name = "rtbComments";
            rtbComments.Size = new Size(265, 108);
            rtbComments.TabIndex = 17;
            rtbComments.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 254);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 18;
            label9.Text = "Comments";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(283, 382);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 19;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(93, 382);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(393, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(label9);
            Controls.Add(rtbComments);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPsysics);
            Controls.Add(tbTechnology);
            Controls.Add(tbEnglish);
            Controls.Add(tbPolish);
            Controls.Add(tbMath);
            Controls.Add(tbSurname);
            Controls.Add(tbName);
            Controls.Add(tbId);
            MaximumSize = new Size(409, 489);
            MinimumSize = new Size(409, 489);
            Name = "AddEditStudent";
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbId;
        private TextBox tbName;
        private TextBox tbSurname;
        private TextBox tbMath;
        private TextBox tbPolish;
        private TextBox tbEnglish;
        private TextBox tbTechnology;
        private TextBox tbPsysics;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RichTextBox rtbComments;
        private Label label9;
        private Button btnApply;
        private Button btnCancel;
    }
}