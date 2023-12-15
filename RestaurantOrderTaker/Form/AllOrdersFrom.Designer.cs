
namespace RestaurantOrderTaker
{
    partial class AllOrdersFrom
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
            TlpAllOrders = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            LboxAllOrders = new System.Windows.Forms.ListBox();
            BtnBackToTables = new System.Windows.Forms.Button();
            TlpAllOrders.SuspendLayout();
            SuspendLayout();
            // 
            // TlpAllOrders
            // 
            TlpAllOrders.ColumnCount = 3;
            TlpAllOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TlpAllOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            TlpAllOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TlpAllOrders.Controls.Add(label1, 1, 0);
            TlpAllOrders.Controls.Add(LboxAllOrders, 1, 1);
            TlpAllOrders.Controls.Add(BtnBackToTables, 1, 2);
            TlpAllOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            TlpAllOrders.Location = new System.Drawing.Point(0, 0);
            TlpAllOrders.Name = "TlpAllOrders";
            TlpAllOrders.RowCount = 4;
            TlpAllOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TlpAllOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            TlpAllOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            TlpAllOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TlpAllOrders.Size = new System.Drawing.Size(557, 450);
            TlpAllOrders.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(86, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(383, 25);
            label1.TabIndex = 0;
            label1.Text = "Все заказы клиентов";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LboxAllOrders
            // 
            LboxAllOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            LboxAllOrders.FormattingEnabled = true;
            LboxAllOrders.ItemHeight = 15;
            LboxAllOrders.Location = new System.Drawing.Point(86, 70);
            LboxAllOrders.Name = "LboxAllOrders";
            LboxAllOrders.Size = new System.Drawing.Size(383, 264);
            LboxAllOrders.TabIndex = 1;
            // 
            // BtnBackToTables
            // 
            BtnBackToTables.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            BtnBackToTables.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnBackToTables.Location = new System.Drawing.Point(86, 344);
            BtnBackToTables.Name = "BtnBackToTables";
            BtnBackToTables.Size = new System.Drawing.Size(383, 31);
            BtnBackToTables.TabIndex = 2;
            BtnBackToTables.Text = "Вернуться к Столам";
            BtnBackToTables.UseVisualStyleBackColor = true;
            BtnBackToTables.Click += BtnBackToTables_Click;
            // 
            // AllOrdersFrom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(557, 450);
            Controls.Add(TlpAllOrders);
            Name = "AllOrdersFrom";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Все заказы";
            FormClosed += AllOrdersFrom_FormClosed;
            Load += AllOrdersFrom_Load;
            TlpAllOrders.ResumeLayout(false);
            TlpAllOrders.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpAllOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LboxAllOrders;
        private System.Windows.Forms.Button BtnBackToTables;
    }
}