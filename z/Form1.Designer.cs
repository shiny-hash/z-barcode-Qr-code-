
namespace z
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.btnbarcode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtqrcode = new System.Windows.Forms.TextBox();
            this.btnqrcode = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "barcode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "qrcode";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(304, 33);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(100, 26);
            this.txtbarcode.TabIndex = 2;
            this.txtbarcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnbarcode
            // 
            this.btnbarcode.Location = new System.Drawing.Point(101, 51);
            this.btnbarcode.Name = "btnbarcode";
            this.btnbarcode.Size = new System.Drawing.Size(75, 23);
            this.btnbarcode.TabIndex = 3;
            this.btnbarcode.Text = "barcode";
            this.btnbarcode.UseVisualStyleBackColor = true;
            this.btnbarcode.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(434, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 249);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtqrcode
            // 
            this.txtqrcode.Location = new System.Drawing.Point(304, 131);
            this.txtqrcode.Name = "txtqrcode";
            this.txtqrcode.Size = new System.Drawing.Size(100, 26);
            this.txtqrcode.TabIndex = 5;
            this.txtqrcode.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnqrcode
            // 
            this.btnqrcode.Location = new System.Drawing.Point(101, 127);
            this.btnqrcode.Name = "btnqrcode";
            this.btnqrcode.Size = new System.Drawing.Size(75, 23);
            this.btnqrcode.TabIndex = 6;
            this.btnqrcode.Text = "qrcode";
            this.btnqrcode.UseVisualStyleBackColor = true;
            this.btnqrcode.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(304, 216);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 7;
            this.btnprint.Text = "print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnqrcode);
            this.Controls.Add(this.txtqrcode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnbarcode);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Button btnbarcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtqrcode;
        private System.Windows.Forms.Button btnqrcode;
        private System.Windows.Forms.Button btnprint;
    }
}

