namespace BitemporalBasicApp
{
    partial class frm_SellBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_branch = new System.Windows.Forms.Label();
            this.lbl_commit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Commit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Branch :";
            // 
            // lbl_branch
            // 
            this.lbl_branch.AutoSize = true;
            this.lbl_branch.Location = new System.Drawing.Point(96, 320);
            this.lbl_branch.Name = "lbl_branch";
            this.lbl_branch.Size = new System.Drawing.Size(10, 13);
            this.lbl_branch.TabIndex = 3;
            this.lbl_branch.Text = "-";
            // 
            // lbl_commit
            // 
            this.lbl_commit.AutoSize = true;
            this.lbl_commit.Location = new System.Drawing.Point(96, 300);
            this.lbl_commit.Name = "lbl_commit";
            this.lbl_commit.Size = new System.Drawing.Size(10, 13);
            this.lbl_commit.TabIndex = 2;
            this.lbl_commit.Text = "-";
            // 
            // frm_SellBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 342);
            this.Controls.Add(this.lbl_branch);
            this.Controls.Add(this.lbl_commit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_SellBook";
            this.Text = "frm_SellBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_branch;
        private System.Windows.Forms.Label lbl_commit;
    }
}