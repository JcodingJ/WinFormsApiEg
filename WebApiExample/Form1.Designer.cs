namespace WebApiExample
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
            this.txtCur = new System.Windows.Forms.TextBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblRatee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // txtCur
            // 
            this.txtCur.Location = new System.Drawing.Point(150, 25);
            this.txtCur.Name = "txtCur";
            this.txtCur.Size = new System.Drawing.Size(100, 20);
            this.txtCur.TabIndex = 1;
            this.txtCur.Text = "EUR";

            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(18, 25);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(100, 20);
            this.txtVal.TabIndex = 2;
            this.txtVal.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Currency";
            // 
            // txtRes
            // 
            this.txtRes.Enabled = false;
            this.txtRes.Location = new System.Drawing.Point(18, 76);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(320, 110);
            this.txtRes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "xml result";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(263, 226);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(49, 192);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(35, 13);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "label4";
            // 
            // lblRatee
            // 
            this.lblRatee.AutoSize = true;
            this.lblRatee.Location = new System.Drawing.Point(13, 192);
            this.lblRatee.Name = "lblRatee";
            this.lblRatee.Size = new System.Drawing.Size(36, 13);
            this.lblRatee.TabIndex = 8;
            this.lblRatee.Text = "Rate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 192);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Result";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(169, 192);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(35, 13);
            this.lblRes.TabIndex = 10;
            this.lblRes.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRatee);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.txtCur);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCur;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblRatee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRes;
    }
}

