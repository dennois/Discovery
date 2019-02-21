namespace DiscoveryVA
{
    partial class VA
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
            this.btnVA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVA
            // 
            this.btnVA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(23)))), ((int)(((byte)(188)))));
            this.btnVA.FlatAppearance.BorderSize = 0;
            this.btnVA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVA.Image = global::DiscoveryVA.Properties.Resources.discovery_icon;
            this.btnVA.Location = new System.Drawing.Point(0, 0);
            this.btnVA.Name = "btnVA";
            this.btnVA.Size = new System.Drawing.Size(90, 90);
            this.btnVA.TabIndex = 0;
            this.btnVA.UseVisualStyleBackColor = true;
            this.btnVA.Click += new System.EventHandler(this.btnVA_Click);
            // 
            // VA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(23)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(90, 90);
            this.ControlBox = false;
            this.Controls.Add(this.btnVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VA";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Atento";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(23)))), ((int)(((byte)(188)))));
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVA;
    }
}

