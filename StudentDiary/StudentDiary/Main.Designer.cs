namespace StudentDiary
{
    partial class Main
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvDiary = new DataGridView();
            cmbSelectClass = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDiary).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Orange;
            btnAdd.Location = new Point(17, 20);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightGreen;
            btnEdit.Location = new Point(200, 20);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 38);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.MenuHighlight;
            btnDelete.Location = new Point(379, 20);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.IndianRed;
            btnRefresh.Location = new Point(556, 20);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 38);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvDiary
            // 
            dgvDiary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDiary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiary.BackgroundColor = Color.White;
            dgvDiary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiary.Location = new Point(4, 92);
            dgvDiary.Margin = new Padding(4, 5, 4, 5);
            dgvDiary.Name = "dgvDiary";
            dgvDiary.RowHeadersVisible = false;
            dgvDiary.RowHeadersWidth = 62;
            dgvDiary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiary.Size = new Size(1430, 657);
            dgvDiary.TabIndex = 4;
            // 
            // cmbSelectClass
            // 
            cmbSelectClass.FormattingEnabled = true;
            cmbSelectClass.Items.AddRange(new object[] { "All", "1", "2", "3" });
            cmbSelectClass.Location = new Point(844, 25);
            cmbSelectClass.Name = "cmbSelectClass";
            cmbSelectClass.Size = new Size(182, 33);
            cmbSelectClass.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1053, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 6;
            label1.Text = "Class ";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1436, 750);
            Controls.Add(label1);
            Controls.Add(cmbSelectClass);
            Controls.Add(dgvDiary);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            Text = "Student Diary";
            FormClosed += Main_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvDiary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridView dgvDiary;
        private ComboBox cmbSelectClass;
        private Label label1;
    }
}
