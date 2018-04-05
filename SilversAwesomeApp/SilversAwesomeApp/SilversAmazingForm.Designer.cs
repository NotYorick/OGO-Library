namespace SilversAwesomeApp
{
    partial class SilversAmazingForm
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
            this.tabUser = new System.Windows.Forms.Button();
            this.tabAdmin = new System.Windows.Forms.Button();
            this.tabAccount = new System.Windows.Forms.Button();
            this.tabUserLbl = new System.Windows.Forms.Label();
            this.tabAdminlbl = new System.Windows.Forms.Label();
            this.tabAccountLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.boughtLbl = new System.Windows.Forms.Label();
            this.availableLbl = new System.Windows.Forms.Label();
            this.availableTxt = new System.Windows.Forms.Label();
            this.boughtTxt = new System.Windows.Forms.Label();
            this.typeTxt = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.Label();
            this.libraryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabUser.Location = new System.Drawing.Point(8, 12);
            this.tabUser.Name = "tabUser";
            this.tabUser.Size = new System.Drawing.Size(75, 23);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "tabUser";
            this.tabUser.UseVisualStyleBackColor = true;
            this.tabUser.Click += new System.EventHandler(this.tabUser_Click);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Location = new System.Drawing.Point(117, 12);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Size = new System.Drawing.Size(75, 23);
            this.tabAdmin.TabIndex = 1;
            this.tabAdmin.Text = "tabAdmin";
            this.tabAdmin.UseVisualStyleBackColor = true;
            this.tabAdmin.Click += new System.EventHandler(this.tabAdmin_Click);
            // 
            // tabAccount
            // 
            this.tabAccount.Location = new System.Drawing.Point(230, 12);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(75, 23);
            this.tabAccount.TabIndex = 2;
            this.tabAccount.Text = "tabAccount";
            this.tabAccount.UseVisualStyleBackColor = true;
            this.tabAccount.Click += new System.EventHandler(this.tabAccount_Click);
            // 
            // tabUserLbl
            // 
            this.tabUserLbl.AutoSize = true;
            this.tabUserLbl.Location = new System.Drawing.Point(5, 47);
            this.tabUserLbl.Name = "tabUserLbl";
            this.tabUserLbl.Size = new System.Drawing.Size(63, 13);
            this.tabUserLbl.TabIndex = 3;
            this.tabUserLbl.Text = "Unchanged";
            // 
            // tabAdminlbl
            // 
            this.tabAdminlbl.AutoSize = true;
            this.tabAdminlbl.Location = new System.Drawing.Point(114, 47);
            this.tabAdminlbl.Name = "tabAdminlbl";
            this.tabAdminlbl.Size = new System.Drawing.Size(63, 13);
            this.tabAdminlbl.TabIndex = 4;
            this.tabAdminlbl.Text = "Unchanged";
            // 
            // tabAccountLbl
            // 
            this.tabAccountLbl.AutoSize = true;
            this.tabAccountLbl.Location = new System.Drawing.Point(227, 47);
            this.tabAccountLbl.Name = "tabAccountLbl";
            this.tabAccountLbl.Size = new System.Drawing.Size(63, 13);
            this.tabAccountLbl.TabIndex = 5;
            this.tabAccountLbl.Text = "Unchanged";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 95);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(63, 201);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(16, 13);
            this.idLbl.TabIndex = 7;
            this.idLbl.Text = "Id";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(48, 214);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 8;
            this.nameLbl.Text = "Name";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(29, 227);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(54, 13);
            this.typeLbl.TabIndex = 9;
            this.typeLbl.Text = "Item Type";
            // 
            // boughtLbl
            // 
            this.boughtLbl.AutoSize = true;
            this.boughtLbl.Location = new System.Drawing.Point(42, 240);
            this.boughtLbl.Name = "boughtLbl";
            this.boughtLbl.Size = new System.Drawing.Size(41, 13);
            this.boughtLbl.TabIndex = 10;
            this.boughtLbl.Text = "Bought";
            // 
            // availableLbl
            // 
            this.availableLbl.AutoSize = true;
            this.availableLbl.Location = new System.Drawing.Point(33, 253);
            this.availableLbl.Name = "availableLbl";
            this.availableLbl.Size = new System.Drawing.Size(50, 13);
            this.availableLbl.TabIndex = 11;
            this.availableLbl.Text = "Available";
            // 
            // availableTxt
            // 
            this.availableTxt.AutoSize = true;
            this.availableTxt.Location = new System.Drawing.Point(89, 253);
            this.availableTxt.Name = "availableTxt";
            this.availableTxt.Size = new System.Drawing.Size(0, 13);
            this.availableTxt.TabIndex = 16;
            // 
            // boughtTxt
            // 
            this.boughtTxt.AutoSize = true;
            this.boughtTxt.Location = new System.Drawing.Point(90, 240);
            this.boughtTxt.Name = "boughtTxt";
            this.boughtTxt.Size = new System.Drawing.Size(0, 13);
            this.boughtTxt.TabIndex = 15;
            // 
            // typeTxt
            // 
            this.typeTxt.AutoSize = true;
            this.typeTxt.Location = new System.Drawing.Point(90, 227);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(0, 13);
            this.typeTxt.TabIndex = 14;
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.Location = new System.Drawing.Point(90, 214);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(0, 13);
            this.nameTxt.TabIndex = 13;
            // 
            // idTxt
            // 
            this.idTxt.AutoSize = true;
            this.idTxt.Location = new System.Drawing.Point(90, 201);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(0, 13);
            this.idTxt.TabIndex = 12;
            // 
            // libraryBtn
            // 
            this.libraryBtn.Location = new System.Drawing.Point(51, 286);
            this.libraryBtn.Name = "libraryBtn";
            this.libraryBtn.Size = new System.Drawing.Size(166, 23);
            this.libraryBtn.TabIndex = 17;
            this.libraryBtn.Text = "Borrow or return";
            this.libraryBtn.UseVisualStyleBackColor = true;
            this.libraryBtn.Click += new System.EventHandler(this.libraryBtn_Click);
            // 
            // SilversAmazingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 523);
            this.Controls.Add(this.libraryBtn);
            this.Controls.Add(this.availableTxt);
            this.Controls.Add(this.boughtTxt);
            this.Controls.Add(this.typeTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.availableLbl);
            this.Controls.Add(this.boughtLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabAccountLbl);
            this.Controls.Add(this.tabAdminlbl);
            this.Controls.Add(this.tabUserLbl);
            this.Controls.Add(this.tabAccount);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.tabUser);
            this.Name = "SilversAmazingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tabUser;
        private System.Windows.Forms.Button tabAdmin;
        private System.Windows.Forms.Button tabAccount;
        private System.Windows.Forms.Label tabUserLbl;
        private System.Windows.Forms.Label tabAdminlbl;
        private System.Windows.Forms.Label tabAccountLbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label boughtLbl;
        private System.Windows.Forms.Label availableLbl;
        private System.Windows.Forms.Label availableTxt;
        private System.Windows.Forms.Label boughtTxt;
        private System.Windows.Forms.Label typeTxt;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.Label idTxt;
        private System.Windows.Forms.Button libraryBtn;
    }
}

