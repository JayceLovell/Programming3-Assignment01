namespace Assignment01
{
    partial class Mainform
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
            this.ManageSubscriptionsbtn = new System.Windows.Forms.Button();
            this.PublishNotificationbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageSubscriptionsbtn
            // 
            this.ManageSubscriptionsbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ManageSubscriptionsbtn.Location = new System.Drawing.Point(13, 13);
            this.ManageSubscriptionsbtn.Name = "ManageSubscriptionsbtn";
            this.ManageSubscriptionsbtn.Size = new System.Drawing.Size(197, 43);
            this.ManageSubscriptionsbtn.TabIndex = 0;
            this.ManageSubscriptionsbtn.Text = "Manage Subscriptions";
            this.ManageSubscriptionsbtn.UseVisualStyleBackColor = false;
            this.ManageSubscriptionsbtn.Click += new System.EventHandler(this.ManageSubscriptionsbtn_Click);
            // 
            // PublishNotificationbtn
            // 
            this.PublishNotificationbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PublishNotificationbtn.Location = new System.Drawing.Point(216, 13);
            this.PublishNotificationbtn.Name = "PublishNotificationbtn";
            this.PublishNotificationbtn.Size = new System.Drawing.Size(169, 43);
            this.PublishNotificationbtn.TabIndex = 1;
            this.PublishNotificationbtn.Text = "Publish Notification";
            this.PublishNotificationbtn.UseVisualStyleBackColor = false;
            this.PublishNotificationbtn.Click += new System.EventHandler(this.PublishNotificationbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Exitbtn.Location = new System.Drawing.Point(391, 13);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(100, 43);
            this.Exitbtn.TabIndex = 2;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(505, 68);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.PublishNotificationbtn);
            this.Controls.Add(this.ManageSubscriptionsbtn);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification Manager";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageSubscriptionsbtn;
        private System.Windows.Forms.Button PublishNotificationbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}

