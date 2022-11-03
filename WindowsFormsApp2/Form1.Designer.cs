namespace WindowsFormsApp2
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
            this.From_label = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.To_label = new System.Windows.Forms.TextBox();
            this.Conver_btn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Open_btn1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // From_label
            // 
            this.From_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_label.Location = new System.Drawing.Point(75, 14);
            this.From_label.Name = "From_label";
            this.From_label.ReadOnly = true;
            this.From_label.Size = new System.Drawing.Size(254, 22);
            this.From_label.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // To_label
            // 
            this.To_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_label.Location = new System.Drawing.Point(114, 67);
            this.To_label.Name = "To_label";
            this.To_label.Size = new System.Drawing.Size(285, 22);
            this.To_label.TabIndex = 3;
            // 
            // Conver_btn
            // 
            this.Conver_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conver_btn.Location = new System.Drawing.Point(143, 134);
            this.Conver_btn.Name = "Conver_btn";
            this.Conver_btn.Size = new System.Drawing.Size(175, 75);
            this.Conver_btn.TabIndex = 4;
            this.Conver_btn.Tag = "3";
            this.Conver_btn.Text = "Convert";
            this.Conver_btn.UseVisualStyleBackColor = true;
            this.Conver_btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 237);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(387, 38);
            this.progressBar1.TabIndex = 5;
            // 
            // Open_btn1
            // 
            this.Open_btn1.Location = new System.Drawing.Point(335, 17);
            this.Open_btn1.Name = "Open_btn1";
            this.Open_btn1.Size = new System.Drawing.Size(64, 26);
            this.Open_btn1.TabIndex = 6;
            this.Open_btn1.Tag = "1";
            this.Open_btn1.Text = "OPEN";
            this.Open_btn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Open_btn1.UseVisualStyleBackColor = true;
            this.Open_btn1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 34);
            this.button2.TabIndex = 9;
            this.button2.Tag = "5";
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 339);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Open_btn1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Conver_btn);
            this.Controls.Add(this.To_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.From_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox From_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox To_label;
        private System.Windows.Forms.Button Conver_btn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Open_btn1;
        private System.Windows.Forms.Button button2;
    }
}

