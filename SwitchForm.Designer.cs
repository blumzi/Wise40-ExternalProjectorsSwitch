namespace ExternalProjectorsSwitch
{
    partial class SwitchForm
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
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOn
            // 
            this.buttonOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOn.ForeColor = System.Drawing.Color.White;
            this.buttonOn.Location = new System.Drawing.Point(24, 2);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(269, 170);
            this.buttonOn.TabIndex = 0;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = false;
            this.buttonOn.Click += new System.EventHandler(this.onClick);
            // 
            // buttonOff
            // 
            this.buttonOff.BackColor = System.Drawing.Color.Red;
            this.buttonOff.Enabled = false;
            this.buttonOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOff.ForeColor = System.Drawing.Color.White;
            this.buttonOff.Location = new System.Drawing.Point(24, 178);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(269, 170);
            this.buttonOff.TabIndex = 1;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = false;
            this.buttonOff.Click += new System.EventHandler(this.onClick);
            // 
            // SwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 359);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Name = "SwitchForm";
            this.Text = "Projectors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
    }
}

