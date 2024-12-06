namespace SalesTaxCalc
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_DisplayCostAfterTax = new System.Windows.Forms.TextBox();
            this.btn_CalculateTax = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_Subtotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "13%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sales Tax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cost after tax:";
            // 
            // txtbox_DisplayCostAfterTax
            // 
            this.txtbox_DisplayCostAfterTax.Location = new System.Drawing.Point(111, 54);
            this.txtbox_DisplayCostAfterTax.Name = "txtbox_DisplayCostAfterTax";
            this.txtbox_DisplayCostAfterTax.ReadOnly = true;
            this.txtbox_DisplayCostAfterTax.Size = new System.Drawing.Size(100, 20);
            this.txtbox_DisplayCostAfterTax.TabIndex = 10;
            this.txtbox_DisplayCostAfterTax.Text = "0";
            // 
            // btn_CalculateTax
            // 
            this.btn_CalculateTax.Location = new System.Drawing.Point(81, 97);
            this.btn_CalculateTax.Name = "btn_CalculateTax";
            this.btn_CalculateTax.Size = new System.Drawing.Size(75, 23);
            this.btn_CalculateTax.TabIndex = 9;
            this.btn_CalculateTax.Text = "Calculate";
            this.btn_CalculateTax.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter the subtotal:";
            // 
            // txtbox_Subtotal
            // 
            this.txtbox_Subtotal.Location = new System.Drawing.Point(111, 6);
            this.txtbox_Subtotal.Name = "txtbox_Subtotal";
            this.txtbox_Subtotal.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Subtotal.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 132);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_DisplayCostAfterTax);
            this.Controls.Add(this.btn_CalculateTax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_Subtotal);
            this.Name = "Form1";
            this.Text = "Sales Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_DisplayCostAfterTax;
        private System.Windows.Forms.Button btn_CalculateTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_Subtotal;
    }
}

