namespace testApp
{
    partial class EditForm
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
            this.AuthButton = new System.Windows.Forms.Button();
            this.UserPasswordField = new System.Windows.Forms.TextBox();
            this.UserEmailField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthButton
            // 
            this.AuthButton.BackColor = System.Drawing.Color.IndianRed;
            this.AuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButton.ForeColor = System.Drawing.Color.White;
            this.AuthButton.Location = new System.Drawing.Point(83, 236);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(218, 31);
            this.AuthButton.TabIndex = 13;
            this.AuthButton.Text = "Изменить";
            this.AuthButton.UseVisualStyleBackColor = false;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.ForeColor = System.Drawing.Color.Gray;
            this.UserPasswordField.Location = new System.Drawing.Point(83, 185);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(218, 20);
            this.UserPasswordField.TabIndex = 12;
            this.UserPasswordField.TextChanged += new System.EventHandler(this.UserPasswordField_TextChanged);
            this.UserPasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserPasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserEmailField
            // 
            this.UserEmailField.ForeColor = System.Drawing.Color.Gray;
            this.UserEmailField.Location = new System.Drawing.Point(83, 138);
            this.UserEmailField.Name = "UserEmailField";
            this.UserEmailField.Size = new System.Drawing.Size(218, 20);
            this.UserEmailField.TabIndex = 11;
            this.UserEmailField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserEmailField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Панель пользователя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Редактировать пользователя с логином \"Admin\"";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.UserEmailField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.TextBox UserEmailField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}