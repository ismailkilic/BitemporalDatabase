namespace BitemporalBasicApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataGrid_locationArchive = new System.Windows.Forms.DataGridView();
            this.btn_add_new_person = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refresh_valid = new System.Windows.Forms.Button();
            this.btn_Commit = new System.Windows.Forms.Button();
            this.btn_refresh_valid_on_branch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmb_commits = new System.Windows.Forms.ComboBox();
            this.btn_addBookToPerson = new System.Windows.Forms.Button();
            this.btn_deleteBookToPerson = new System.Windows.Forms.Button();
            this.btn_ShowBooksSelectedPerson = new System.Windows.Forms.Button();
            this.lbl_branch = new System.Windows.Forms.Label();
            this.lbl_commit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_locationArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location Archive";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(566, 467);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(162, 23);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh Grid for All Data";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dataGrid_locationArchive
            // 
            this.dataGrid_locationArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_locationArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_locationArchive.Location = new System.Drawing.Point(12, 37);
            this.dataGrid_locationArchive.Name = "dataGrid_locationArchive";
            this.dataGrid_locationArchive.Size = new System.Drawing.Size(715, 308);
            this.dataGrid_locationArchive.TabIndex = 2;
            // 
            // btn_add_new_person
            // 
            this.btn_add_new_person.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_new_person.Location = new System.Drawing.Point(12, 351);
            this.btn_add_new_person.Name = "btn_add_new_person";
            this.btn_add_new_person.Size = new System.Drawing.Size(114, 23);
            this.btn_add_new_person.TabIndex = 3;
            this.btn_add_new_person.Text = "Add New Person";
            this.btn_add_new_person.UseVisualStyleBackColor = true;
            this.btn_add_new_person.Click += new System.EventHandler(this.btn_add_new_person_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Location = new System.Drawing.Point(135, 351);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(114, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit Selected Person";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(266, 351);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete Selected Person";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_refresh_valid
            // 
            this.btn_refresh_valid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh_valid.Location = new System.Drawing.Point(398, 467);
            this.btn_refresh_valid.Name = "btn_refresh_valid";
            this.btn_refresh_valid.Size = new System.Drawing.Size(162, 23);
            this.btn_refresh_valid.TabIndex = 6;
            this.btn_refresh_valid.Text = "Refresh Grid for Valid Data";
            this.btn_refresh_valid.UseVisualStyleBackColor = true;
            this.btn_refresh_valid.Visible = false;
            this.btn_refresh_valid.Click += new System.EventHandler(this.btn_refresh_valid_Click);
            // 
            // btn_Commit
            // 
            this.btn_Commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Commit.Location = new System.Drawing.Point(149, 438);
            this.btn_Commit.Name = "btn_Commit";
            this.btn_Commit.Size = new System.Drawing.Size(114, 23);
            this.btn_Commit.TabIndex = 7;
            this.btn_Commit.Text = "Commit";
            this.btn_Commit.UseVisualStyleBackColor = true;
            this.btn_Commit.Visible = false;
            this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
            // 
            // btn_refresh_valid_on_branch
            // 
            this.btn_refresh_valid_on_branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh_valid_on_branch.Location = new System.Drawing.Point(566, 409);
            this.btn_refresh_valid_on_branch.Name = "btn_refresh_valid_on_branch";
            this.btn_refresh_valid_on_branch.Size = new System.Drawing.Size(162, 52);
            this.btn_refresh_valid_on_branch.TabIndex = 8;
            this.btn_refresh_valid_on_branch.Text = "Refresh Grid for All Data on Selected branch";
            this.btn_refresh_valid_on_branch.UseVisualStyleBackColor = true;
            this.btn_refresh_valid_on_branch.Click += new System.EventHandler(this.btn_refresh_valid_on_branch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(573, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmb_commits
            // 
            this.cmb_commits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_commits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_commits.FormattingEnabled = true;
            this.cmb_commits.Location = new System.Drawing.Point(573, 378);
            this.cmb_commits.Name = "cmb_commits";
            this.cmb_commits.Size = new System.Drawing.Size(139, 21);
            this.cmb_commits.TabIndex = 10;
            // 
            // btn_addBookToPerson
            // 
            this.btn_addBookToPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addBookToPerson.Location = new System.Drawing.Point(12, 380);
            this.btn_addBookToPerson.Name = "btn_addBookToPerson";
            this.btn_addBookToPerson.Size = new System.Drawing.Size(114, 48);
            this.btn_addBookToPerson.TabIndex = 11;
            this.btn_addBookToPerson.Text = "Sell Book to Selected Person";
            this.btn_addBookToPerson.UseVisualStyleBackColor = true;
            // 
            // btn_deleteBookToPerson
            // 
            this.btn_deleteBookToPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteBookToPerson.Location = new System.Drawing.Point(135, 380);
            this.btn_deleteBookToPerson.Name = "btn_deleteBookToPerson";
            this.btn_deleteBookToPerson.Size = new System.Drawing.Size(114, 48);
            this.btn_deleteBookToPerson.TabIndex = 12;
            this.btn_deleteBookToPerson.Text = "Delete Book from Selected Person";
            this.btn_deleteBookToPerson.UseVisualStyleBackColor = true;
            // 
            // btn_ShowBooksSelectedPerson
            // 
            this.btn_ShowBooksSelectedPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ShowBooksSelectedPerson.Location = new System.Drawing.Point(266, 380);
            this.btn_ShowBooksSelectedPerson.Name = "btn_ShowBooksSelectedPerson";
            this.btn_ShowBooksSelectedPerson.Size = new System.Drawing.Size(132, 48);
            this.btn_ShowBooksSelectedPerson.TabIndex = 13;
            this.btn_ShowBooksSelectedPerson.Text = "Show Book Selected Person";
            this.btn_ShowBooksSelectedPerson.UseVisualStyleBackColor = true;
            // 
            // lbl_branch
            // 
            this.lbl_branch.AutoSize = true;
            this.lbl_branch.Location = new System.Drawing.Point(93, 480);
            this.lbl_branch.Name = "lbl_branch";
            this.lbl_branch.Size = new System.Drawing.Size(10, 13);
            this.lbl_branch.TabIndex = 29;
            this.lbl_branch.Text = "-";
            // 
            // lbl_commit
            // 
            this.lbl_commit.AutoSize = true;
            this.lbl_commit.Location = new System.Drawing.Point(93, 460);
            this.lbl_commit.Name = "lbl_commit";
            this.lbl_commit.Size = new System.Drawing.Size(10, 13);
            this.lbl_commit.TabIndex = 28;
            this.lbl_commit.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Current Branch :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Current Commit :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 502);
            this.Controls.Add(this.lbl_branch);
            this.Controls.Add(this.lbl_commit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ShowBooksSelectedPerson);
            this.Controls.Add(this.btn_deleteBookToPerson);
            this.Controls.Add(this.btn_addBookToPerson);
            this.Controls.Add(this.cmb_commits);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_refresh_valid_on_branch);
            this.Controls.Add(this.btn_Commit);
            this.Controls.Add(this.btn_refresh_valid);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add_new_person);
            this.Controls.Add(this.dataGrid_locationArchive);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_locationArchive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dataGrid_locationArchive;
        private System.Windows.Forms.Button btn_add_new_person;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh_valid;
        private System.Windows.Forms.Button btn_Commit;
        private System.Windows.Forms.Button btn_refresh_valid_on_branch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmb_commits;
        private System.Windows.Forms.Button btn_addBookToPerson;
        private System.Windows.Forms.Button btn_deleteBookToPerson;
        private System.Windows.Forms.Button btn_ShowBooksSelectedPerson;
        private System.Windows.Forms.Label lbl_branch;
        private System.Windows.Forms.Label lbl_commit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

