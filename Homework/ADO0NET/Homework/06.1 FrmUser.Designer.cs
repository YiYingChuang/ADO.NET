namespace ADO0NET.Homework
{
    partial class FrmUser
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
            this.components = new System.ComponentModel.Container();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.CreatUser_button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(110, 50);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(100, 22);
            this.UserNametextBox.TabIndex = 0;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(110, 89);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordtextBox.TabIndex = 1;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(58, 137);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 4;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Location = new System.Drawing.Point(149, 137);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // CreatUser_button
            // 
            this.CreatUser_button.Location = new System.Drawing.Point(149, 177);
            this.CreatUser_button.Name = "CreatUser_button";
            this.CreatUser_button.Size = new System.Drawing.Size(75, 23);
            this.CreatUser_button.TabIndex = 6;
            this.CreatUser_button.Text = "Creat User";
            this.CreatUser_button.UseVisualStyleBackColor = true;
            this.CreatUser_button.Click += new System.EventHandler(this.CreatUser_button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.CreatUser_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UserNametextBox);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button CreatUser_button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}