using BusinessLayer.Enum;
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
    public partial class TakeOrderForm : Form
    {
        public TakeOrderForm()
        {
            InitializeComponent();
        }

        #region Events
        
        private void TakeOrderForm_Load(object sender, EventArgs e)
        {
            // Load ComboBox options.
            LoadStarterOptions();
            LoadMainPlateOptions();
            LoadDrinkOptions();
            LoadDessertOptions();
        }

        private void TakeOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TableOrderForm.Instance.Show();
        }

        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {
            SaveOrder();
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void SaveOrder()
        {
            string name = TxbName.Text;
            ComboBoxItem starter = CmbxStarter.SelectedItem as ComboBoxItem;
            ComboBoxItem mainPlate = CmbxMainPlate.SelectedItem as ComboBoxItem;
            ComboBoxItem drink = CmbxDrink.SelectedItem as ComboBoxItem;
            ComboBoxItem dessert = CmbxDessert.SelectedItem as ComboBoxItem;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Пожалуйста, введите имя", "Ошибка!");
            }
            else if (starter.Value == null)
            {
                MessageBox.Show("Пожалуйста, выберите стартер", "Ошибка!");
            }
            else if (mainPlate.Value == null)
            {
                MessageBox.Show("Пожалуйста, выберите основное блюдо", "Ошибка!");
            }
            else if (drink.Value == null)
            {
                MessageBox.Show("Пожалуйста, выберите напиток.", "Ошибка!");
            }
            else if (dessert.Value == null)
            {
                MessageBox.Show("Пожалуйста, выберите десерт", "Ошибка!");
            }
            else
            {
                TableService tableService = new TableService();

                Order newOrder = new Order
                {
                    Table = TableRepository.Instance.SelectedTable,
                    Name = name,
                    Starter = starter.Text,
                    MainPlate = mainPlate.Text,
                    Drink = drink.Text,
                    Dessert = dessert.Text
                };

                tableService.Add(newOrder);
                CloseForm();
            }
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void LoadStarterOptions()
        {
            List<ComboBoxItem> starters = new List<ComboBoxItem>()
            {
                new ComboBoxItem
                {
                    Text = "Выберите блюдо",
                    Value = null
                },
                new ComboBoxItem
                {
                    Text = "Чесночный хлеб",
                    Value = (int)MenuStarterOptions.Чесночный_хлеб
                },
                new ComboBoxItem
                {
                    Text = "Луковые кольца",
                    Value = (int)MenuStarterOptions.Луковые_кольца
                },
                new ComboBoxItem
                {
                    Text = "Палочки моцарелла",
                    Value = (int)MenuStarterOptions.Палочки_моцарелла
                },
                new ComboBoxItem
                {
                    Text = "Острые крылышки",
                    Value = (int)MenuStarterOptions.Острые_крылышки
                },
                new ComboBoxItem
                {
                    Text = "Картошка фри",
                    Value = (int)MenuStarterOptions.Картошка_фри
                },
            };

            foreach (ComboBoxItem starter in starters)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = starter.Text,
                    Value = starter.Value
                };

                CmbxStarter.Items.Add(newItem);
            }

            CmbxStarter.SelectedItem = CmbxStarter.Items[0];
        }

        private void LoadMainPlateOptions()
        {
            List<ComboBoxItem> mainPlates = new List<ComboBoxItem>()
            {
                new ComboBoxItem
                {
                    Text = "Выберите блюдо",
                    Value = null
                },
                new ComboBoxItem
                {
                    Text = "Салат",
                    Value = (int)MenuMainPlateOptions.Салат
                },
                new ComboBoxItem
                {
                    Text = "Куриный суп",
                    Value = (int)MenuMainPlateOptions.Куриный_суп
                },
                new ComboBoxItem
                {
                    Text = "Равиолли",
                    Value = (int)MenuMainPlateOptions.Равиолли
                },
                new ComboBoxItem
                {
                    Text = "Лазанья",
                    Value = (int)MenuMainPlateOptions.Лазанья
                },
                new ComboBoxItem
                {
                    Text = "Мясные шарики",
                    Value = (int)MenuMainPlateOptions.Мясные_шарики
                },
                new ComboBoxItem
                {
                    Text = "Карбонара",
                    Value = (int)MenuMainPlateOptions.Карбонара
                },
                new ComboBoxItem
                {
                    Text = "Маринара",
                    Value = (int)MenuMainPlateOptions.Маринара
                },
                new ComboBoxItem
                {
                    Text = "Гамбургер",
                    Value = (int)MenuMainPlateOptions.Гамбургер
                },
                new ComboBoxItem
                {
                    Text = "Пицца",
                    Value = (int)MenuMainPlateOptions.Пицца
                },
                new ComboBoxItem
                {
                    Text = "Куриное филе",
                    Value = (int)MenuMainPlateOptions.Куриное_филе
                },
            };

            foreach (ComboBoxItem mainPlate in mainPlates)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = mainPlate.Text,
                    Value = mainPlate.Value
                };

                CmbxMainPlate.Items.Add(newItem);
            }

            CmbxMainPlate.SelectedItem = CmbxMainPlate.Items[0];
        }

        private void LoadDrinkOptions()
        {
            List<ComboBoxItem> drinks = new List<ComboBoxItem>()
            {
                new ComboBoxItem
                {
                    Text = "Выберите напиток",
                    Value = null
                },
                new ComboBoxItem
                {
                    Text = "Вода",
                    Value = (int)MenuDrinkOptions.Вода
                },
                new ComboBoxItem
                {
                    Text = "Сок",
                    Value = (int)MenuDrinkOptions.Сок
                },
                new ComboBoxItem
                {
                    Text = "Холодный чай",
                    Value = (int)MenuDrinkOptions.Холодный_чай
                },
                new ComboBoxItem
                {
                    Text = "Пиво",
                    Value = (int)MenuDrinkOptions.Пиво
                },
                new ComboBoxItem
                {
                    Text = "Вино",
                    Value = (int)MenuDrinkOptions.Вино
                },
            };

            foreach (ComboBoxItem drink in drinks)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = drink.Text,
                    Value = drink.Value
                };

                CmbxDrink.Items.Add(newItem);
            }

            CmbxDrink.SelectedItem = CmbxDrink.Items[0];
        }

        private void LoadDessertOptions()
        {
            List<ComboBoxItem> desserts = new List<ComboBoxItem>()
            {
                new ComboBoxItem
                {
                    Text = "Выберите десерт",
                    Value = null
                },
                new ComboBoxItem
                {
                    Text = "Яблочный пирог",
                    Value = (int)MenuDessertOptions.Яблочный_пирог
                },
                new ComboBoxItem
                {
                    Text = "Блонди",
                    Value = (int)MenuDessertOptions.Блонди
                },
                new ComboBoxItem
                {
                    Text = "Брауни",
                    Value = (int)MenuDessertOptions.Брауни
                },
                new ComboBoxItem
                {
                    Text = "Чизкейк",
                    Value = (int)MenuDessertOptions.Чизкейк
                },
                new ComboBoxItem
                {
                    Text = "Джелато",
                    Value = (int)MenuDessertOptions.Джелато
                },
            };

            foreach (ComboBoxItem dessert in desserts)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = dessert.Text,
                    Value = dessert.Value
                };

                CmbxDessert.Items.Add(newItem);
            }

            CmbxDessert.SelectedItem = CmbxDessert.Items[0];
        }

        #endregion
    }
}
