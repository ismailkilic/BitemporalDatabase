namespace BitemporalBasicApp
{
    partial class frm_Book
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
            this.cmb_commits = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_refresh_valid_on_branch = new System.Windows.Forms.Button();
            this.btn_Commit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add_new_person = new System.Windows.Forms.Button();
            this.dataGrid_Archive = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Archive)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_commits
            // 
            this.cmb_commits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_commits.FormattingEnabled = true;
            this.cmb_commits.Location = new System.Drawing.Point(380, 409);
            this.cmb_commits.Name = "cmb_commits";
            this.cmb_commits.Size = new System.Drawing.Size(162, 21);
            this.cmb_commits.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(380, 382);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_refresh_valid_on_branch
            // 
            this.btn_refresh_valid_on_branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh_valid_on_branch.Location = new System.Drawing.Point(380, 440);
            this.btn_refresh_valid_on_branch.Name = "btn_refresh_valid_on_branch";
            this.btn_refresh_valid_on_branch.Size = new System.Drawing.Size(162, 52);
            this.btn_refresh_valid_on_branch.TabIndex = 19;
            this.btn_refresh_valid_on_branch.Text = "Refresh Grid for All Data on Selected branch";
            this.btn_refresh_valid_on_branch.UseVisualStyleBackColor = true;
            this.btn_refresh_valid_on_branch.Click += new System.EventHandler(this.btn_refresh_valid_on_branch_Click);
            // 
            // btn_Commit
            // 
            this.btn_Commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Commit.Location = new System.Drawing.Point(140, 409);
            this.btn_Commit.Name = "btn_Commit";
            this.btn_Commit.Size = new System.Drawing.Size(114, 23);
            this.btn_Commit.TabIndex = 18;
            this.btn_Commit.Text = "Commit";
            this.btn_Commit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(380, 353);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 23);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete Selected Book";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Location = new System.Drawing.Point(260, 353);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(114, 23);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Edit Selected Book";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add_new_person
            // 
            this.btn_add_new_person.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_new_person.Location = new System.Drawing.Point(140, 353);
            this.btn_add_new_person.Name = "btn_add_new_person";
            this.btn_add_new_person.Size = new System.Drawing.Size(114, 23);
            this.btn_add_new_person.TabIndex = 14;
            this.btn_add_new_person.Text = "Add New Book";
            this.btn_add_new_person.UseVisualStyleBackColor = true;
            this.btn_add_new_person.Click += new System.EventHandler(this.btn_add_new_person_Click);
            // 
            // dataGrid_Archive
            // 
            this.dataGrid_Archive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Archive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Archive.Location = new System.Drawing.Point(12, 27);
            this.dataGrid_Archive.Name = "dataGrid_Archive";
            this.dataGrid_Archive.Size = new System.Drawing.Size(698, 320);
            this.dataGrid_Archive.TabIndex = 13;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(549, 440);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(162, 23);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "Refresh Grid for All Data";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Location Archive";
            // 
            // frm_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 494);
            this.Controls.Add(this.cmb_commits);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_refresh_valid_on_branch);
            this.Controls.Add(this.btn_Commit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add_new_person);
            this.Controls.Add(this.dataGrid_Archive);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label1);
            this.Name = "frm_Book";
            this.Text = "frm_Book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Archive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_commits;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_refresh_valid_on_branch;
        private System.Windows.Forms.Button btn_Commit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add_new_person;
        private System.Windows.Forms.DataGridView dataGrid_Archive;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label1;
    }
}