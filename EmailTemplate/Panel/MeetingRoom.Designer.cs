namespace EmailTemplate.Panel
{
    partial class MeetingRoom
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
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroButton14 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroButton12
            // 
            this.metroButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.metroButton12.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton12.ForeColor = System.Drawing.Color.White;
            this.metroButton12.Location = new System.Drawing.Point(294, 141);
            this.metroButton12.Name = "metroButton12";
            this.metroButton12.Size = new System.Drawing.Size(226, 87);
            this.metroButton12.TabIndex = 17;
            this.metroButton12.Text = "Meeting Room \r\nModification And Acces";
            this.metroButton12.UseCustomBackColor = true;
            this.metroButton12.UseCustomForeColor = true;
            this.metroButton12.UseSelectable = true;
            // 
            // metroButton14
            // 
            this.metroButton14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.metroButton14.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton14.ForeColor = System.Drawing.Color.White;
            this.metroButton14.Location = new System.Drawing.Point(62, 141);
            this.metroButton14.Name = "metroButton14";
            this.metroButton14.Size = new System.Drawing.Size(226, 87);
            this.metroButton14.TabIndex = 15;
            this.metroButton14.Text = "Create Meeting Room";
            this.metroButton14.UseCustomBackColor = true;
            this.metroButton14.UseCustomForeColor = true;
            this.metroButton14.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "MEETING ROOM";
            // 
            // MeetingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton12);
            this.Controls.Add(this.metroButton14);
            this.Name = "MeetingRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton12;
        private MetroFramework.Controls.MetroButton metroButton14;
        private System.Windows.Forms.Label label1;
    }
}
