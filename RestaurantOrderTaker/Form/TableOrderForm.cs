using BusinessLayer.Model;
using BusinessLayer.Repository;
using BusinessLayer.Service;
using RestaurantOrderTaker.CustomControlItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantOrderTaker
{
    public sealed partial class TableOrderForm : Form
    {
        public static TableOrderForm Instance { get; } = new TableOrderForm();

        private readonly TableService tableService;
        private readonly OrderService orderService;

        public TableOrderForm()
        {
            InitializeComponent();

            tableService = new TableService();
            orderService = new OrderService();
            LbxOrders.KeyDown += new KeyEventHandler(ListBox_KeyDown);
        }

        #region Events

        private void TableOrderForm_Load(object sender, EventArgs e)
        {
            // Update table selected.
            LblTableToOrder.Text = $"Стол # {TableRepository.Instance.SelectedTable}";

            // Load ComboBox options.
            LoadPeopleOnTableOptions();

            // Load all orders in table.
            LoadOrders();
        }

        private void TableOrderForm_VisibleChanged(object sender, EventArgs e)
        {
            // Update table selected.
            LblTableToOrder.Text = $"Стол # {TableRepository.Instance.SelectedTable}";

            // Load all orders in table.
            LoadOrders();
        }

        private void TableOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TablesForm.Instance.Show();
        }

        private void BtnTakeOrder_Click(object sender, EventArgs e)
        {
            TakeOrder();
        }

        private void BtnSaveOrders_Click(object sender, EventArgs e)
        {
            SaveOrders();
        }

        private void BtnCancelOrders_Click(object sender, EventArgs e)
        {
            CancelOrders();
        }

        #endregion

        #region Methods

        private void TakeOrder()
        {
            List<Order> orders = tableService.GetAll();
            ComboBoxItem peopleOnTable = CmbxPeopleOntable.SelectedItem as ComboBoxItem;

            if (int.Parse(peopleOnTable.Text) > orders.Count)
            {
                TakeOrderForm newTakeOrderForm = new TakeOrderForm();
                newTakeOrderForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Все заказы для данного столика взяты.", "Ошибка!");
            }
        }

        private void SaveOrders()
        {
            List<Order> orders = tableService.GetAll();
            ComboBoxItem peopleOnTable = CmbxPeopleOntable.SelectedItem as ComboBoxItem;

            if (int.Parse(peopleOnTable.Text) == orders.Count)
            {
                orderService.ManyOrders(orders);

                // CancelOrders();
                CloseForm();
            }
            else
            {
                MessageBox.Show("Необходимо взять заказ каждого гостя.", "Ошибка!");
            }
        }

        private void CancelOrders()
        {
            TableRepository.Instance.Orders = OrderRepository.Instance.Orders;
            CloseForm();
        }

        private void CloseForm()
        {
            TablesForm.Instance.Show();
            this.Hide();
        }

        private void LoadPeopleOnTableOptions()
        {
            for (int i = 1; i <= 4; i++)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = i.ToString(),
                    Value = i
                };

                CmbxPeopleOntable.Items.Add(newItem);
            }

            CmbxPeopleOntable.SelectedItem = CmbxPeopleOntable.Items[0];
        }

        private void LoadOrders()
        {
            LbxOrders.BeginUpdate();

            LbxOrders.Items.Clear();

            List<Order> orders = tableService.GetAll();

            foreach (Order order in orders)
            {
                LbxOrders.Items.Add(order.Data);
            }

            LbxOrders.EndUpdate();
        }

        #endregion

        private void LbxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Проверка, нажата ли именно клавиша Delete
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedItemFromListBox();
            }
        }
        private void DeleteSelectedItemFromListBox()
        {
            var selectedIndex = LbxOrders.SelectedIndex;
            if (LbxOrders.SelectedIndex != -1)
            {
                var a = LbxOrders.SelectedItems[0].ToString();

                tableService.Delete(a);
                LbxOrders.Items.RemoveAt(selectedIndex);
            }
        }
    }
}
