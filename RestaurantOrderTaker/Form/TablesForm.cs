using BusinessLayer.Enum;
using BusinessLayer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderTaker
{
    public sealed partial class TablesForm : Form
    {

        public static TablesForm Instance { get; } = new TablesForm();

        public TablesForm()
        {
            InitializeComponent();
        }

        #region Events

        private void BtnTableOne_Click(object sender, EventArgs e)
        {
            SelectTable(1);
        }

        private void BtnTableTwo_Click(object sender, EventArgs e)
        {
            SelectTable(2);
        }

        private void BtnTableThree_Click(object sender, EventArgs e)
        {
            SelectTable(3);
        }

        private void BtnTableFour_Click(object sender, EventArgs e)
        {
            SelectTable(4);
        }

        private void BtnTableFive_Click(object sender, EventArgs e)
        {
            SelectTable(5);
        }

        private void BtnViewOrders_Click(object sender, EventArgs e)
        {
            AllOrdersFrom newAllOrdersFrom = new AllOrdersFrom();
            newAllOrdersFrom.Show();
            this.Hide();
        }

        #endregion

        #region Methods

        private void SelectTable(int tableNumber)
        {
            TableRepository.Instance.SelectedTable = tableNumber;
            TableOrderForm newTableOrderForm = new TableOrderForm();
            newTableOrderForm.Show();
            this.Hide();
        }

        #endregion
    }
}
