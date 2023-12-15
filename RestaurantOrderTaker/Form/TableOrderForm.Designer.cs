
namespace RestaurantOrderTaker
{
    partial class TableOrderForm
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
            TblTableOrder = new System.Windows.Forms.TableLayoutPanel();
            BtnSaveOrders = new System.Windows.Forms.Button();
            BtnCancelOrders = new System.Windows.Forms.Button();
            BtnTakeOrder = new System.Windows.Forms.Button();
            LbxOrders = new System.Windows.Forms.ListBox();
            LblTableToOrder = new System.Windows.Forms.Label();
            CmbxPeopleOntable = new System.Windows.Forms.ComboBox();
            LblNumberOfPeople = new System.Windows.Forms.Label();
            TblTableOrder.SuspendLayout();
            SuspendLayout();
            // 
            // TblTableOrder
            // 
            TblTableOrder.ColumnCount = 4;
            TblTableOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TblTableOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            TblTableOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            TblTableOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TblTableOrder.Controls.Add(BtnSaveOrders, 1, 5);
            TblTableOrder.Controls.Add(BtnCancelOrders, 2, 5);
            TblTableOrder.Controls.Add(BtnTakeOrder, 1, 4);
            TblTableOrder.Controls.Add(LbxOrders, 1, 2);
            TblTableOrder.Controls.Add(LblTableToOrder, 1, 0);
            TblTableOrder.Controls.Add(CmbxPeopleOntable, 2, 1);
            TblTableOrder.Controls.Add(LblNumberOfPeople, 1, 1);
            TblTableOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            TblTableOrder.Location = new System.Drawing.Point(0, 0);
            TblTableOrder.Name = "TblTableOrder";
            TblTableOrder.RowCount = 6;
            TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            TblTableOrder.Size = new System.Drawing.Size(564, 450);
            TblTableOrder.TabIndex = 0;
            // 
            // BtnSaveOrders
            // 
            BtnSaveOrders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            BtnSaveOrders.BackColor = System.Drawing.Color.LightGreen;
            BtnSaveOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnSaveOrders.Location = new System.Drawing.Point(87, 378);
            BtnSaveOrders.Name = "BtnSaveOrders";
            BtnSaveOrders.Size = new System.Drawing.Size(191, 30);
            BtnSaveOrders.TabIndex = 2;
            BtnSaveOrders.Text = "Сохранить";
            BtnSaveOrders.UseVisualStyleBackColor = false;
            BtnSaveOrders.Click += BtnSaveOrders_Click;
            // 
            // BtnCancelOrders
            // 
            BtnCancelOrders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            BtnCancelOrders.BackColor = System.Drawing.Color.IndianRed;
            BtnCancelOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnCancelOrders.Location = new System.Drawing.Point(284, 378);
            BtnCancelOrders.Name = "BtnCancelOrders";
            BtnCancelOrders.Size = new System.Drawing.Size(191, 30);
            BtnCancelOrders.TabIndex = 3;
            BtnCancelOrders.Text = "Оменить";
            BtnCancelOrders.UseVisualStyleBackColor = false;
            BtnCancelOrders.Click += BtnCancelOrders_Click;
            // 
            // BtnTakeOrder
            // 
            BtnTakeOrder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            BtnTakeOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            TblTableOrder.SetColumnSpan(BtnTakeOrder, 2);
            BtnTakeOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnTakeOrder.Location = new System.Drawing.Point(87, 303);
            BtnTakeOrder.Name = "BtnTakeOrder";
            BtnTakeOrder.Size = new System.Drawing.Size(388, 32);
            BtnTakeOrder.TabIndex = 4;
            BtnTakeOrder.Text = "Взять заказ";
            BtnTakeOrder.UseVisualStyleBackColor = false;
            BtnTakeOrder.Click += BtnTakeOrder_Click;
            // 
            // LbxOrders
            // 
            LbxOrders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TblTableOrder.SetColumnSpan(LbxOrders, 2);
            LbxOrders.FormattingEnabled = true;
            LbxOrders.ItemHeight = 15;
            LbxOrders.Location = new System.Drawing.Point(87, 153);
            LbxOrders.Name = "LbxOrders";
            TblTableOrder.SetRowSpan(LbxOrders, 2);
            LbxOrders.Size = new System.Drawing.Size(388, 139);
            LbxOrders.TabIndex = 0;
            LbxOrders.SelectedIndexChanged += LbxOrders_SelectedIndexChanged;
            // 
            // LblTableToOrder
            // 
            LblTableToOrder.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            LblTableToOrder.AutoSize = true;
            TblTableOrder.SetColumnSpan(LblTableToOrder, 2);
            LblTableToOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblTableToOrder.Location = new System.Drawing.Point(87, 22);
            LblTableToOrder.Name = "LblTableToOrder";
            LblTableToOrder.Size = new System.Drawing.Size(388, 30);
            LblTableToOrder.TabIndex = 5;
            LblTableToOrder.Text = "Стол # 0";
            LblTableToOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbxPeopleOntable
            // 
            CmbxPeopleOntable.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            CmbxPeopleOntable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CmbxPeopleOntable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CmbxPeopleOntable.FormattingEnabled = true;
            CmbxPeopleOntable.Location = new System.Drawing.Point(284, 98);
            CmbxPeopleOntable.Name = "CmbxPeopleOntable";
            CmbxPeopleOntable.Size = new System.Drawing.Size(191, 29);
            CmbxPeopleOntable.TabIndex = 1;
            // 
            // LblNumberOfPeople
            // 
            LblNumberOfPeople.Anchor = System.Windows.Forms.AnchorStyles.Right;
            LblNumberOfPeople.AutoSize = true;
            LblNumberOfPeople.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblNumberOfPeople.Location = new System.Drawing.Point(123, 102);
            LblNumberOfPeople.Name = "LblNumberOfPeople";
            LblNumberOfPeople.Size = new System.Drawing.Size(155, 21);
            LblNumberOfPeople.TabIndex = 6;
            LblNumberOfPeople.Text = "Количество гостей";
            // 
            // TableOrderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(564, 450);
            Controls.Add(TblTableOrder);
            Name = "TableOrderForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Стол";
            FormClosed += TableOrderForm_FormClosed;
            Load += TableOrderForm_Load;
            VisibleChanged += TableOrderForm_VisibleChanged;
            TblTableOrder.ResumeLayout(false);
            TblTableOrder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblTableOrder;
        private System.Windows.Forms.Button BtnSaveOrders;
        private System.Windows.Forms.Button BtnCancelOrders;
        private System.Windows.Forms.Button BtnTakeOrder;
        private System.Windows.Forms.ListBox LbxOrders;
        private System.Windows.Forms.ComboBox CmbxPeopleOntable;
        private System.Windows.Forms.Label LblTableToOrder;
        private System.Windows.Forms.Label LblNumberOfPeople;
    }
}