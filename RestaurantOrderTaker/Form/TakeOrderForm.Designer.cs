
namespace RestaurantOrderTaker
{
    partial class TakeOrderForm
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
            TblTakeOrder = new System.Windows.Forms.TableLayoutPanel();
            LblName = new System.Windows.Forms.Label();
            LblStarter = new System.Windows.Forms.Label();
            LblMainPlate = new System.Windows.Forms.Label();
            LblDrink = new System.Windows.Forms.Label();
            LblDessert = new System.Windows.Forms.Label();
            TxbName = new System.Windows.Forms.TextBox();
            CmbxStarter = new System.Windows.Forms.ComboBox();
            CmbxMainPlate = new System.Windows.Forms.ComboBox();
            CmbxDrink = new System.Windows.Forms.ComboBox();
            CmbxDessert = new System.Windows.Forms.ComboBox();
            BtnCancelOrder = new System.Windows.Forms.Button();
            BtnSaveOrder = new System.Windows.Forms.Button();
            TblTakeOrder.SuspendLayout();
            SuspendLayout();
            // 
            // TblTakeOrder
            // 
            TblTakeOrder.ColumnCount = 4;
            TblTakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TblTakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            TblTakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            TblTakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TblTakeOrder.Controls.Add(LblName, 1, 1);
            TblTakeOrder.Controls.Add(LblStarter, 1, 2);
            TblTakeOrder.Controls.Add(LblMainPlate, 1, 3);
            TblTakeOrder.Controls.Add(LblDrink, 1, 4);
            TblTakeOrder.Controls.Add(LblDessert, 1, 5);
            TblTakeOrder.Controls.Add(TxbName, 2, 1);
            TblTakeOrder.Controls.Add(CmbxStarter, 2, 2);
            TblTakeOrder.Controls.Add(CmbxMainPlate, 2, 3);
            TblTakeOrder.Controls.Add(CmbxDrink, 2, 4);
            TblTakeOrder.Controls.Add(CmbxDessert, 2, 5);
            TblTakeOrder.Controls.Add(BtnCancelOrder, 2, 6);
            TblTakeOrder.Controls.Add(BtnSaveOrder, 1, 6);
            TblTakeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            TblTakeOrder.Location = new System.Drawing.Point(0, 0);
            TblTakeOrder.Name = "TblTakeOrder";
            TblTakeOrder.RowCount = 8;
            TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TblTakeOrder.Size = new System.Drawing.Size(566, 450);
            TblTakeOrder.TabIndex = 0;
            // 
            // LblName
            // 
            LblName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblName.AutoSize = true;
            LblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblName.Location = new System.Drawing.Point(192, 56);
            LblName.Name = "LblName";
            LblName.Size = new System.Drawing.Size(87, 21);
            LblName.TabIndex = 0;
            LblName.Text = "Имя гостя";
            // 
            // LblStarter
            // 
            LblStarter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblStarter.AutoSize = true;
            LblStarter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblStarter.Location = new System.Drawing.Point(208, 112);
            LblStarter.Name = "LblStarter";
            LblStarter.Size = new System.Drawing.Size(71, 21);
            LblStarter.TabIndex = 1;
            LblStarter.Text = "Стартер";
            // 
            // LblMainPlate
            // 
            LblMainPlate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblMainPlate.AutoSize = true;
            LblMainPlate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblMainPlate.Location = new System.Drawing.Point(153, 168);
            LblMainPlate.Name = "LblMainPlate";
            LblMainPlate.Size = new System.Drawing.Size(126, 21);
            LblMainPlate.TabIndex = 2;
            LblMainPlate.Text = "Главное блюдо";
            // 
            // LblDrink
            // 
            LblDrink.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblDrink.AutoSize = true;
            LblDrink.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblDrink.Location = new System.Drawing.Point(205, 224);
            LblDrink.Name = "LblDrink";
            LblDrink.Size = new System.Drawing.Size(74, 21);
            LblDrink.TabIndex = 3;
            LblDrink.Text = "Напиток";
            // 
            // LblDessert
            // 
            LblDessert.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblDessert.AutoSize = true;
            LblDessert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblDessert.Location = new System.Drawing.Point(214, 280);
            LblDessert.Name = "LblDessert";
            LblDessert.Size = new System.Drawing.Size(65, 21);
            LblDessert.TabIndex = 4;
            LblDessert.Text = "Десерт";
            // 
            // TxbName
            // 
            TxbName.Dock = System.Windows.Forms.DockStyle.Top;
            TxbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxbName.Location = new System.Drawing.Point(285, 59);
            TxbName.Name = "TxbName";
            TxbName.Size = new System.Drawing.Size(192, 29);
            TxbName.TabIndex = 6;
            // 
            // CmbxStarter
            // 
            CmbxStarter.Dock = System.Windows.Forms.DockStyle.Top;
            CmbxStarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CmbxStarter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CmbxStarter.FormattingEnabled = true;
            CmbxStarter.Location = new System.Drawing.Point(285, 115);
            CmbxStarter.Name = "CmbxStarter";
            CmbxStarter.Size = new System.Drawing.Size(192, 29);
            CmbxStarter.TabIndex = 7;
            // 
            // CmbxMainPlate
            // 
            CmbxMainPlate.Dock = System.Windows.Forms.DockStyle.Top;
            CmbxMainPlate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CmbxMainPlate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CmbxMainPlate.FormattingEnabled = true;
            CmbxMainPlate.Location = new System.Drawing.Point(285, 171);
            CmbxMainPlate.Name = "CmbxMainPlate";
            CmbxMainPlate.Size = new System.Drawing.Size(192, 29);
            CmbxMainPlate.TabIndex = 8;
            // 
            // CmbxDrink
            // 
            CmbxDrink.Dock = System.Windows.Forms.DockStyle.Top;
            CmbxDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CmbxDrink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CmbxDrink.FormattingEnabled = true;
            CmbxDrink.Location = new System.Drawing.Point(285, 227);
            CmbxDrink.Name = "CmbxDrink";
            CmbxDrink.Size = new System.Drawing.Size(192, 29);
            CmbxDrink.TabIndex = 9;
            // 
            // CmbxDessert
            // 
            CmbxDessert.Dock = System.Windows.Forms.DockStyle.Top;
            CmbxDessert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CmbxDessert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CmbxDessert.FormattingEnabled = true;
            CmbxDessert.Location = new System.Drawing.Point(285, 283);
            CmbxDessert.Name = "CmbxDessert";
            CmbxDessert.Size = new System.Drawing.Size(192, 29);
            CmbxDessert.TabIndex = 10;
            // 
            // BtnCancelOrder
            // 
            BtnCancelOrder.BackColor = System.Drawing.Color.IndianRed;
            BtnCancelOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            BtnCancelOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnCancelOrder.Location = new System.Drawing.Point(285, 356);
            BtnCancelOrder.Name = "BtnCancelOrder";
            BtnCancelOrder.Size = new System.Drawing.Size(192, 33);
            BtnCancelOrder.TabIndex = 13;
            BtnCancelOrder.Text = "Отменить";
            BtnCancelOrder.UseVisualStyleBackColor = false;
            BtnCancelOrder.Click += BtnCancelOrder_Click;
            // 
            // BtnSaveOrder
            // 
            BtnSaveOrder.BackColor = System.Drawing.Color.LightGreen;
            BtnSaveOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            BtnSaveOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnSaveOrder.Location = new System.Drawing.Point(87, 356);
            BtnSaveOrder.Name = "BtnSaveOrder";
            BtnSaveOrder.Size = new System.Drawing.Size(192, 33);
            BtnSaveOrder.TabIndex = 12;
            BtnSaveOrder.Text = "Сохранить";
            BtnSaveOrder.UseVisualStyleBackColor = false;
            BtnSaveOrder.Click += BtnSaveOrder_Click;
            // 
            // TakeOrderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(566, 450);
            Controls.Add(TblTakeOrder);
            Name = "TakeOrderForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Взять заказ";
            FormClosed += TakeOrderForm_FormClosed;
            Load += TakeOrderForm_Load;
            TblTakeOrder.ResumeLayout(false);
            TblTakeOrder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblTakeOrder;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblStarter;
        private System.Windows.Forms.Label LblMainPlate;
        private System.Windows.Forms.Label LblDrink;
        private System.Windows.Forms.Label LblDessert;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.ComboBox CmbxStarter;
        private System.Windows.Forms.ComboBox CmbxMainPlate;
        private System.Windows.Forms.ComboBox CmbxDrink;
        private System.Windows.Forms.ComboBox CmbxDessert;
        private System.Windows.Forms.Button BtnCancelOrder;
        private System.Windows.Forms.Button BtnSaveOrder;
    }
}