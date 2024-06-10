namespace Csharp_hinhtron
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
            this.lblBK = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBK = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnCV = new System.Windows.Forms.Button();
            this.btnDT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTinhL1 = new System.Windows.Forms.Button();
            this.btnTinhL2 = new System.Windows.Forms.Button();
            this.rdbCV = new System.Windows.Forms.RadioButton();
            this.rdbDT = new System.Windows.Forms.RadioButton();
            this.chkCV = new System.Windows.Forms.CheckBox();
            this.chkDT = new System.Windows.Forms.CheckBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBK
            // 
            this.lblBK.AutoSize = true;
            this.lblBK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBK.Location = new System.Drawing.Point(12, 33);
            this.lblBK.Name = "lblBK";
            this.lblBK.Size = new System.Drawing.Size(48, 13);
            this.lblBK.TabIndex = 0;
            this.lblBK.Text = "Bán Kính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtBK
            // 
            this.txtBK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBK.Location = new System.Drawing.Point(68, 30);
            this.txtBK.Name = "txtBK";
            this.txtBK.Size = new System.Drawing.Size(100, 21);
            this.txtBK.TabIndex = 2;
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(68, 168);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 21);
            this.txtKQ.TabIndex = 3;
            // 
            // btnCV
            // 
            this.btnCV.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCV.Location = new System.Drawing.Point(16, 91);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(75, 23);
            this.btnCV.TabIndex = 4;
            this.btnCV.Text = "Chu vi";
            this.btnCV.UseVisualStyleBackColor = true;
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // btnDT
            // 
            this.btnDT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDT.Location = new System.Drawing.Point(113, 91);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(75, 23);
            this.btnDT.TabIndex = 5;
            this.btnDT.Text = "Diện tích";
            this.btnDT.UseVisualStyleBackColor = true;
            this.btnDT.Click += new System.EventHandler(this.btnDT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDT);
            this.groupBox1.Controls.Add(this.rdbCV);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(279, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDT);
            this.groupBox2.Controls.Add(this.chkCV);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(570, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 116);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "chọn";
            // 
            // btnTinhL1
            // 
            this.btnTinhL1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhL1.Location = new System.Drawing.Point(324, 160);
            this.btnTinhL1.Name = "btnTinhL1";
            this.btnTinhL1.Size = new System.Drawing.Size(131, 33);
            this.btnTinhL1.TabIndex = 8;
            this.btnTinhL1.Text = "Tính L1";
            this.btnTinhL1.UseVisualStyleBackColor = true;
            this.btnTinhL1.Click += new System.EventHandler(this.btnTinhL1_Click);
            // 
            // btnTinhL2
            // 
            this.btnTinhL2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhL2.Location = new System.Drawing.Point(623, 161);
            this.btnTinhL2.Name = "btnTinhL2";
            this.btnTinhL2.Size = new System.Drawing.Size(131, 33);
            this.btnTinhL2.TabIndex = 9;
            this.btnTinhL2.Text = "Tính L2";
            this.btnTinhL2.UseVisualStyleBackColor = true;
            this.btnTinhL2.Click += new System.EventHandler(this.btnTinhL2_Click);
            // 
            // rdbCV
            // 
            this.rdbCV.AutoSize = true;
            this.rdbCV.Location = new System.Drawing.Point(7, 29);
            this.rdbCV.Name = "rdbCV";
            this.rdbCV.Size = new System.Drawing.Size(53, 17);
            this.rdbCV.TabIndex = 0;
            this.rdbCV.TabStop = true;
            this.rdbCV.Text = "chu vi";
            this.rdbCV.UseVisualStyleBackColor = true;
            // 
            // rdbDT
            // 
            this.rdbDT.AutoSize = true;
            this.rdbDT.Location = new System.Drawing.Point(7, 67);
            this.rdbDT.Name = "rdbDT";
            this.rdbDT.Size = new System.Drawing.Size(65, 17);
            this.rdbDT.TabIndex = 1;
            this.rdbDT.TabStop = true;
            this.rdbDT.Text = "diện tích";
            this.rdbDT.UseVisualStyleBackColor = true;
            // 
            // chkCV
            // 
            this.chkCV.AutoSize = true;
            this.chkCV.Location = new System.Drawing.Point(7, 28);
            this.chkCV.Name = "chkCV";
            this.chkCV.Size = new System.Drawing.Size(54, 17);
            this.chkCV.TabIndex = 0;
            this.chkCV.Text = "chu vi";
            this.chkCV.UseVisualStyleBackColor = true;
            // 
            // chkDT
            // 
            this.chkDT.AutoSize = true;
            this.chkDT.Location = new System.Drawing.Point(7, 64);
            this.chkDT.Name = "chkDT";
            this.chkDT.Size = new System.Drawing.Size(66, 17);
            this.chkDT.TabIndex = 1;
            this.chkDT.Text = "diện tích";
            this.chkDT.UseVisualStyleBackColor = true;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(12, 170);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(44, 13);
            this.lblKQ.TabIndex = 10;
            this.lblKQ.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnTinhL2);
            this.Controls.Add(this.btnTinhL1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDT);
            this.Controls.Add(this.btnCV);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtBK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBK;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDT;
        private System.Windows.Forms.RadioButton rdbCV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDT;
        private System.Windows.Forms.CheckBox chkCV;
        private System.Windows.Forms.Button btnTinhL1;
        private System.Windows.Forms.Button btnTinhL2;
        private System.Windows.Forms.Label lblKQ;
    }
}

