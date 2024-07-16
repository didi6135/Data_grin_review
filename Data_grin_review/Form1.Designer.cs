namespace Data_grin_review
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
            dataGridUsers = new DataGridView();
            Users = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridUsers
            // 
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.Location = new Point(116, 101);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.RowHeadersWidth = 51;
            dataGridUsers.Size = new Size(584, 279);
            dataGridUsers.TabIndex = 0;
            // 
            // Users
            // 
            Users.AutoSize = true;
            Users.Location = new Point(383, 43);
            Users.Name = "Users";
            Users.Size = new Size(50, 20);
            Users.TabIndex = 1;
            Users.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Users);
            Controls.Add(dataGridUsers);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridUsers;
        private Label Users;
    }
}
