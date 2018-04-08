namespace BitemporalBasicApp
{
    partial class frm_Main
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
            this.btn_frmperson = new System.Windows.Forms.Button();
            this.btn_frmBook = new System.Windows.Forms.Button();
            this.btn_frmPersonRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Commit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_frmperson
            // 
            this.btn_frmperson.Location = new System.Drawing.Point(67, 84);
            this.btn_frmperson.Name = "btn_frmperson";
            this.btn_frmperson.Size = new System.Drawing.Size(210, 23);
            this.btn_frmperson.TabIndex = 0;
            this.btn_frmperson.Text = "Person Data";
            this.btn_frmperson.UseVisualStyleBackColor = true;
            this.btn_frmperson.Click += new System.EventHandler(this.btn_frmperson_Click);
            // 
            // btn_frmBook
            // 
            this.btn_frmBook.Location = new System.Drawing.Point(69, 134);
            this.btn_frmBook.Name = "btn_frmBook";
            this.btn_frmBook.Size = new System.Drawing.Size(210, 23);
            this.btn_frmBook.TabIndex = 1;
            this.btn_frmBook.Text = "Book Data";
            this.btn_frmBook.UseVisualStyleBackColor = true;
            this.btn_frmBook.Click += new System.EventHandler(this.btn_frmBook_Click);
            // 
            // btn_frmPersonRead
            // 
            this.btn_frmPersonRead.Location = new System.Drawing.Point(67, 178);
            this.btn_frmPersonRead.Name = "btn_frmPersonRead";
            this.btn_frmPersonRead.Size = new System.Drawing.Size(210, 23);
            this.btn_frmPersonRead.TabIndex = 2;
            this.btn_frmPersonRead.Text = "Person\'s Books";
            this.btn_frmPersonRead.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAIN PAGE";
            // 
            // btn_Commit
            // 
            this.btn_Commit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Commit.Location = new System.Drawing.Point(67, 234);
            this.btn_Commit.Name = "btn_Commit";
            this.btn_Commit.Size = new System.Drawing.Size(212, 45);
            this.btn_Commit.TabIndex = 4;
            this.btn_Commit.Text = "Commit";
            this.btn_Commit.UseVisualStyleBackColor = false;
            this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(67, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Commit History";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Commit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_frmPersonRead);
            this.Controls.Add(this.btn_frmBook);
            this.Controls.Add(this.btn_frmperson);
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_frmperson;
        private System.Windows.Forms.Button btn_frmBook;
        private System.Windows.Forms.Button btn_frmPersonRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Commit;
        private System.Windows.Forms.Button button1;
    }
}