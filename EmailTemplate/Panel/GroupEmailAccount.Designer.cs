namespace EmailTemplate.Panel
{
    partial class GroupEmailAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton22 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroButton22
            // 
            this.metroButton22.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.metroButton22.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton22.ForeColor = System.Drawing.Color.White;
            this.metroButton22.Location = new System.Drawing.Point(121, 143);
            this.metroButton22.Name = "metroButton22";
            this.metroButton22.Size = new System.Drawing.Size(226, 85);
            this.metroButton22.TabIndex = 23;
            this.metroButton22.Text = "Group Email Account \r\nAccess and Modification\r\n";
            this.metroButton22.UseCustomBackColor = true;
            this.metroButton22.UseCustomForeColor = true;
            this.metroButton22.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(115, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "GROUP EMAIL ACCOUNT";
            // 
            // GroupEmailAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton22);
            this.Name = "GroupEmailAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton22;
        private System.Windows.Forms.Label label1;
    }
}
