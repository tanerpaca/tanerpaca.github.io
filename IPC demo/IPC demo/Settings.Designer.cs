namespace IPC_demo
{
    partial class Settings
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
            this.IP_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IP_address
            // 
            this.IP_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::IPC_demo.Properties.Settings.Default, "PeerIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IP_address.Location = new System.Drawing.Point(83, 42);
            this.IP_address.Name = "IP_address";
            this.IP_address.Size = new System.Drawing.Size(253, 20);
            this.IP_address.TabIndex = 0;
            this.IP_address.Text = global::IPC_demo.Properties.Settings.Default.PeerIP;
            this.IP_address.TextChanged += new System.EventHandler(this.IP_address_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Controller IP";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP_address);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP_address;
        private System.Windows.Forms.Label label1;
    }
}