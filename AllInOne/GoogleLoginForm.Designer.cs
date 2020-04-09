namespace AllInOne
{
    partial class GoogleLoginForm
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
            this.labelLoginToContinue = new System.Windows.Forms.Label();
            this.btnLoginWithGoogle = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelCheckLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPleaseWait = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoginWithGoogle)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelCheckLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoginToContinue
            // 
            this.labelLoginToContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoginToContinue.AutoSize = true;
            this.labelLoginToContinue.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginToContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginToContinue.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLoginToContinue.Location = new System.Drawing.Point(302, 267);
            this.labelLoginToContinue.Name = "labelLoginToContinue";
            this.labelLoginToContinue.Size = new System.Drawing.Size(262, 36);
            this.labelLoginToContinue.TabIndex = 1;
            this.labelLoginToContinue.Text = "Login to continue";
            // 
            // btnLoginWithGoogle
            // 
            this.btnLoginWithGoogle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoginWithGoogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginWithGoogle.Image = global::AllInOne.Properties.Resources.signin_google_button;
            this.btnLoginWithGoogle.Location = new System.Drawing.Point(258, 306);
            this.btnLoginWithGoogle.Name = "btnLoginWithGoogle";
            this.btnLoginWithGoogle.Size = new System.Drawing.Size(306, 74);
            this.btnLoginWithGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoginWithGoogle.TabIndex = 0;
            this.btnLoginWithGoogle.TabStop = false;
            this.btnLoginWithGoogle.Click += new System.EventHandler(this.btnLoginWithGoogle_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btnLoginWithGoogle);
            this.panelLogin.Controls.Add(this.labelLoginToContinue);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(825, 654);
            this.panelLogin.TabIndex = 4;
            // 
            // panelCheckLogin
            // 
            this.panelCheckLogin.Controls.Add(this.pictureBox1);
            this.panelCheckLogin.Controls.Add(this.txtPleaseWait);
            this.panelCheckLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCheckLogin.Location = new System.Drawing.Point(0, 0);
            this.panelCheckLogin.Name = "panelCheckLogin";
            this.panelCheckLogin.Size = new System.Drawing.Size(825, 654);
            this.panelCheckLogin.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::AllInOne.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(258, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtPleaseWait
            // 
            this.txtPleaseWait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPleaseWait.AutoSize = true;
            this.txtPleaseWait.BackColor = System.Drawing.Color.Transparent;
            this.txtPleaseWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPleaseWait.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPleaseWait.Location = new System.Drawing.Point(339, 267);
            this.txtPleaseWait.Name = "txtPleaseWait";
            this.txtPleaseWait.Size = new System.Drawing.Size(204, 36);
            this.txtPleaseWait.TabIndex = 1;
            this.txtPleaseWait.Text = "Please wait...";
            // 
            // GoogleLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(825, 654);
            this.Controls.Add(this.panelCheckLogin);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoogleLoginForm";
            this.Text = "GoogleLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnLoginWithGoogle)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelCheckLogin.ResumeLayout(false);
            this.panelCheckLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnLoginWithGoogle;
        private System.Windows.Forms.Label labelLoginToContinue;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelCheckLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtPleaseWait;
    }
}