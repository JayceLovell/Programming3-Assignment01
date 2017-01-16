namespace Assignment01
{
    partial class SubscribeForm
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
            this.MessageEmailChk = new System.Windows.Forms.CheckBox();
            this.MessagePhoneChk = new System.Windows.Forms.CheckBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.BtnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageEmailChk
            // 
            this.MessageEmailChk.AutoSize = true;
            this.MessageEmailChk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageEmailChk.FlatAppearance.BorderSize = 15;
            this.MessageEmailChk.Location = new System.Drawing.Point(12, 18);
            this.MessageEmailChk.Name = "MessageEmailChk";
            this.MessageEmailChk.Size = new System.Drawing.Size(202, 25);
            this.MessageEmailChk.TabIndex = 0;
            this.MessageEmailChk.Text = "Message Sent by Email";
            this.MessageEmailChk.UseVisualStyleBackColor = true;
            // 
            // MessagePhoneChk
            // 
            this.MessagePhoneChk.AutoSize = true;
            this.MessagePhoneChk.Location = new System.Drawing.Point(12, 49);
            this.MessagePhoneChk.Name = "MessagePhoneChk";
            this.MessagePhoneChk.Size = new System.Drawing.Size(208, 25);
            this.MessagePhoneChk.TabIndex = 3;
            this.MessagePhoneChk.Text = "Message Sent by Phone";
            this.MessagePhoneChk.UseVisualStyleBackColor = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(222, 13);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(239, 29);
            this.TxtEmail.TabIndex = 2;
            this.TxtEmail.Text = "example@example.com";
            this.TxtEmail.WordWrap = false;
            this.TxtEmail.Click += new System.EventHandler(this.TxtEmail_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(222, 45);
            this.txtPhoneNumber.MaxLength = 14;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(239, 29);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.Text = "#-###-###-####";
            this.txtPhoneNumber.Click += new System.EventHandler(this.txtPhoneNumber_Click);
            // 
            // BtnSubscribe
            // 
            this.BtnSubscribe.Location = new System.Drawing.Point(12, 81);
            this.BtnSubscribe.Name = "BtnSubscribe";
            this.BtnSubscribe.Size = new System.Drawing.Size(100, 43);
            this.BtnSubscribe.TabIndex = 5;
            this.BtnSubscribe.Text = "Subscribe";
            this.BtnSubscribe.UseVisualStyleBackColor = true;
            this.BtnSubscribe.Click += new System.EventHandler(this.Subscribe);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Location = new System.Drawing.Point(174, 80);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(117, 43);
            this.btnUnsubscribe.TabIndex = 6;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.Unsubscribe);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(351, 81);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 43);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(473, 134);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.BtnSubscribe);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.MessagePhoneChk);
            this.Controls.Add(this.MessageEmailChk);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "SubscribeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subscribe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubscribeForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubscribeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox MessageEmailChk;
        private System.Windows.Forms.CheckBox MessagePhoneChk;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button BtnSubscribe;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button Cancel;
    }
}