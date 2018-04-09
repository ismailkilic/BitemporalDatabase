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
            this.lbl_PersonName = new System.Windows.Forms.Label();
            this.lbl_PersonID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lsb_cart = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AddtoCart = new System.Windows.Forms.Button();
            this.btn_deletefromList = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Commit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Branch :";
            // 
            // lbl_branch
            // 
            this.lbl_branch.AutoSize = true;
            this.lbl_branch.Location = new System.Drawing.Point(105, 345);
            this.lbl_branch.Name = "lbl_branch";
            this.lbl_branch.Size = new System.Drawing.Size(10, 13);
            this.lbl_branch.TabIndex = 3;
            this.lbl_branch.Text = "-";
            // 
            // lbl_commit
            // 
            this.lbl_commit.AutoSize = true;
            this.lbl_commit.Location = new System.Drawing.Point(105, 325);
            this.lbl_commit.Name = "lbl_commit";
            this.lbl_commit.Size = new System.Drawing.Size(10, 13);
            this.lbl_commit.TabIndex = 2;
            this.lbl_commit.Text = "-";
            // 
            // lbl_PersonName
            // 
            this.lbl_PersonName.AutoSize = true;
            this.lbl_PersonName.Location = new System.Drawing.Point(143, 35);
            this.lbl_PersonName.Name = "lbl_PersonName";
            this.lbl_PersonName.Size = new System.Drawing.Size(10, 13);
            this.lbl_PersonName.TabIndex = 7;
            this.lbl_PersonName.Text = "-";
            // 
            // lbl_PersonID
            // 
            this.lbl_PersonID.AutoSize = true;
            this.lbl_PersonID.Location = new System.Drawing.Point(143, 15);
            this.lbl_PersonID.Name = "lbl_PersonID";
            this.lbl_PersonID.Size = new System.Drawing.Size(10, 13);
            this.lbl_PersonID.TabIndex = 6;
            this.lbl_PersonID.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Selected Person Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Selected Person ID:";
            // 
            // lsb_cart
            // 
            this.lsb_cart.FormattingEnabled = true;
            this.lsb_cart.Location = new System.Drawing.Point(667, 83);
            this.lsb_cart.Name = "lsb_cart";
            this.lsb_cart.Size = new System.Drawing.Size(119, 186);
            this.lsb_cart.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(13, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(532, 215);
            this.dataGridView1.TabIndex = 10;
            // 
            // btn_AddtoCart
            // 
            this.btn_AddtoCart.Location = new System.Drawing.Point(551, 107);
            this.btn_AddtoCart.Name = "btn_AddtoCart";
            this.btn_AddtoCart.Size = new System.Drawing.Size(83, 66);
            this.btn_AddtoCart.TabIndex = 11;
            this.btn_AddtoCart.Text = "Add to Shopping Cart ";
            this.btn_AddtoCart.UseVisualStyleBackColor = true;
            this.btn_AddtoCart.Click += new System.EventHandler(this.btn_AddtoCart_Click);
            // 
            // btn_deletefromList
            // 
            this.btn_deletefromList.Location = new System.Drawing.Point(667, 275);
            this.btn_deletefromList.Name = "btn_deletefromList";
            this.btn_deletefromList.Size = new System.Drawing.Size(119, 23);
            this.btn_deletefromList.TabIndex = 12;
            this.btn_deletefromList.Text = "delete book from list";
            this.btn_deletefromList.UseVisualStyleBackColor = true;
            this.btn_deletefromList.Click += new System.EventHandler(this.btn_deletefromList_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = ">>>";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(658, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 55);
            this.button3.TabIndex = 14;
            this.button3.Text = "Sell and Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_SellBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_deletefromList);
            this.Controls.Add(this.btn_AddtoCart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lsb_cart);
            this.Controls.Add(this.lbl_PersonName);
            this.Controls.Add(this.lbl_PersonID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_branch);
            this.Controls.Add(this.lbl_commit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_SellBook";
            this.Text = "frm_SellBook";
            this.Load += new System.EventHandler(this.frm_SellBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_branch;
        private System.Windows.Forms.Label lbl_commit;
        private System.Windows.Forms.Label lbl_PersonName;
        private System.Windows.Forms.Label lbl_PersonID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lsb_cart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AddtoCart;
        private System.Windows.Forms.Button btn_deletefromList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}