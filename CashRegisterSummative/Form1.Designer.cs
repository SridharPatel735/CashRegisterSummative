namespace CashRegisterSummative
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
            this.burgerLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.drinksInput = new System.Windows.Forms.TextBox();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.calculateTotalsButton = new System.Windows.Forms.Button();
            this.subLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.Location = new System.Drawing.Point(12, 62);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(162, 19);
            this.burgerLabel.TabIndex = 0;
            this.burgerLabel.Text = "Number of Burgers";
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(12, 129);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(153, 19);
            this.drinksLabel.TabIndex = 1;
            this.drinksLabel.Text = "Number of Drinks";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(12, 94);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(144, 19);
            this.friesLabel.TabIndex = 2;
            this.friesLabel.Text = "Number of Fries";
            // 
            // burgerInput
            // 
            this.burgerInput.Location = new System.Drawing.Point(181, 62);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(38, 20);
            this.burgerInput.TabIndex = 3;
            // 
            // drinksInput
            // 
            this.drinksInput.Location = new System.Drawing.Point(181, 130);
            this.drinksInput.Name = "drinksInput";
            this.drinksInput.Size = new System.Drawing.Size(38, 20);
            this.drinksInput.TabIndex = 4;
            // 
            // friesInput
            // 
            this.friesInput.Location = new System.Drawing.Point(181, 95);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(38, 20);
            this.friesInput.TabIndex = 5;
            // 
            // calculateTotalsButton
            // 
            this.calculateTotalsButton.Location = new System.Drawing.Point(16, 164);
            this.calculateTotalsButton.Name = "calculateTotalsButton";
            this.calculateTotalsButton.Size = new System.Drawing.Size(203, 23);
            this.calculateTotalsButton.TabIndex = 6;
            this.calculateTotalsButton.Text = "Calculate Totals";
            this.calculateTotalsButton.UseVisualStyleBackColor = true;
            // 
            // subLabel
            // 
            this.subLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.Location = new System.Drawing.Point(181, 203);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(38, 23);
            this.subLabel.TabIndex = 7;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(13, 203);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(90, 19);
            this.subTotalLabel.TabIndex = 8;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(13, 260);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(54, 19);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(13, 232);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(36, 19);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax";
            this.taxLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.titleLabel.Font = new System.Drawing.Font("Millenium BdEx BT", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-7, -2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(518, 64);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Hambuguh Too";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.calculateTotalsButton);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.drinksInput);
            this.Controls.Add(this.burgerInput);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.burgerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.TextBox drinksInput;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.Button calculateTotalsButton;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}

