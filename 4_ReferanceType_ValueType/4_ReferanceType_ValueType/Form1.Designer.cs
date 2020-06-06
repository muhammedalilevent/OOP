namespace _4_ReferanceType_ValueType
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
            this.btnReferance = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReferance
            // 
            this.btnReferance.Location = new System.Drawing.Point(12, 12);
            this.btnReferance.Name = "btnReferance";
            this.btnReferance.Size = new System.Drawing.Size(381, 127);
            this.btnReferance.TabIndex = 0;
            this.btnReferance.Text = "Referance Type";
            this.btnReferance.UseVisualStyleBackColor = true;
            this.btnReferance.Click += new System.EventHandler(this.btnReferance_Click);
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(12, 145);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(381, 127);
            this.btnValue.TabIndex = 0;
            this.btnValue.Text = "ValueType";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 283);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnReferance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReferance;
        private System.Windows.Forms.Button btnValue;
    }
}

