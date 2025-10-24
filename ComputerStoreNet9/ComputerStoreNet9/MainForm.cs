using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StoreLogicNet;
using StoreAI;

namespace ComputerStoreNet9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private PriceCalculator calculator; // 🔹 Об'єкт C++/CLI, який обробляє логіку розрахунку

        private void LoadProducts()
        {
            // 🔹 Отримуємо список товарів з F# модуля
            var items = ProductModule.getProducts();

            // 🔹 Створюємо калькулятор і передаємо йому список товарів
            calculator = new PriceCalculator();
            calculator.SetProducts(items); // 🔹 Зберігає список для подальшого розрахунку

            // 🔹 Прив'язуємо список товарів до таблиці
            dataGridViewProducts.DataSource = items;

            // 🔹 Додаємо колонку з чекбоксами, якщо її ще немає
            if (!dataGridViewProducts.Columns.Contains("IsSelected"))
            {
                var checkColumn = new DataGridViewCheckBoxColumn
                {
                    DataPropertyName = "IsSelected",
                    HeaderText = "Вибрати",
                    Name = "IsSelected"
                };
                dataGridViewProducts.Columns.Insert(0, checkColumn);
            }
        }

        // 🔸 Обробка натискання кнопки "Розрахувати"
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var result = calculator.CalculateTotal(); // 🔹 Викликаємо C++/CLI метод, який обробляє вибрані товари

            // 🔹 Виводимо загальну суму без знижки
            lblTotal.Text = $"Загальна: {result.OriginalPrice:F2} $";

            // 🔹 Виводимо суму зі знижкою + текст знижки
            lblDiscount.Text = $"{result.DiscountedPrice:F2} $ (знижка {result.DiscountPercent}%)";
        }
    }
}
