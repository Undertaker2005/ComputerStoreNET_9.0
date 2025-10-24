namespace ComputerStoreNet9
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProducts = new DataGridView();
            btnCalculate = new Button();
            lblTotal = new Label();
            lblDiscount = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(58, 43);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(553, 189);
            dataGridViewProducts.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(58, 259);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(208, 73);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Порахувати";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(300, 266);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(41, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Ціна";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(300, 312);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(124, 20);
            lblDiscount.TabIndex = 3;
            lblDiscount.Text = "Ціна зі знижкою";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDiscount);
            Controls.Add(lblTotal);
            Controls.Add(btnCalculate);
            Controls.Add(dataGridViewProducts);
            Name = "MainForm";
            Text = "Головна Сторінка";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Button btnCalculate;
        private Label lblTotal;
        private Label lblDiscount;
    }
}
