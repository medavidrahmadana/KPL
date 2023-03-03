namespace Modul3_1302213079
{
    partial class Form1
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
            this.submit = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.Highlight;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.Window;
            this.submit.Location = new System.Drawing.Point(290, 74);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "KIRIM";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.HotTrack;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.SystemColors.Window;
            this.input.Location = new System.Drawing.Point(37, 74);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(225, 24);
            this.input.TabIndex = 1;
            this.input.Text = "Masukkan Nama Kamu!";
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Highlight;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(33, 156);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(221, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Output Akan Muncul Disini";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.input);
            this.Controls.Add(this.submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label;
    }
}

