
namespace CustomMessageBox
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
            this.Demo_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Demo_btn
            // 
            this.Demo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Demo_btn.Location = new System.Drawing.Point(50, 84);
            this.Demo_btn.Name = "Demo_btn";
            this.Demo_btn.Size = new System.Drawing.Size(135, 38);
            this.Demo_btn.TabIndex = 0;
            this.Demo_btn.Text = "Demo";
            this.Demo_btn.UseVisualStyleBackColor = true;
            this.Demo_btn.Click += new System.EventHandler(this.Demo_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 192);
            this.Controls.Add(this.Demo_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Demo_btn;
    }
}

