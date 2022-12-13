using Restaurant;
using KFCForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KFCForm
{
    public partial class Form1 : Form
    {

        int index = 0;
        Item[] Dishes = Item.ReadFromCSV("db.csv");
        List<OrderItem> orderItems = new List<OrderItem>();
        int amount;
        public Form1()
        {
            InitializeComponent();
            
            if (index > Dishes.Length)
            {
                index = 0;
            }
            if (index < Dishes.Length)
            {
                index = Dishes.Length - 1;
            }
            Show(Dishes[index]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Help_Click(object sender, EventArgs e)
        {
            string inf = "Работа формы:\nВыбор товара:\n› Пользователь может выбрать товар с помощью\nкнопок 'Дальше' и 'Назад'\n" +
            "Расчёт стоимости заказа:\n› Стоимость расчитывается автоматически в корзине\n" +
            "Корзина:\n› Для добавления заказа в корзину небходимо нажать на кнопку 'Добавить заказ'.\n" +
            "› После добавления заказа в корзину пользователь может изменять количество товаров и узнать общую стоимость заказа, а так же использовать промокод для получения скидки." +
            "Оформление заказа:\n› Для оформления заказа пользователь должен нажать на конопку 'Оформить заказ'.\n" +
            "› После нажатия на кнопку 'Оформить заказ' перед пользователем откроется окно времени ожидания. Когда заказ будет готов, на экране высветится соответствующее сообщение";
            MessageBox.Show(inf, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Отображает на форме информацию о блюде из меню
        /// </summary>
        /// <param name="s">информация о блюде</param>
        public void Show(Item s)
        {
            LabelInf.Text = $"{s.Name}{Environment.NewLine}Описание: {s.Description}{Environment.NewLine}Ингридиенты: {s.Ingredient}{Environment.NewLine}Цена: {s.Price}руб{Environment.NewLine}Вес: {s.Weight}г.{Environment.NewLine}Время приготовления: {s.CookingTime} минут";
            pictureBox1.Image = s.Image;
        }

        /// <summary>
        /// Переход на следующую позицию в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Forward_Click(object sender, EventArgs e)
        {

            if (index + 1 >= Dishes.Length) index = -1;
            index++;
            textBoxInput.Text = "1";
            Show(Dishes[index]);
        }

        /// <summary>
        /// Переход на прошлую позицию в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Backward_Click(object sender, EventArgs e)
        {
            if (index - 1 < 0) index = Dishes.Length;
            index--;
            textBoxInput.Text = "1";
            Show(Dishes[index]);
        }

        /// <summary>
        /// Добавление блюда в корзину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrder_Click(object sender, EventArgs e)
        {

            if (textBoxInput.Text == "0")
            {
                MessageBox.Show("Сначала введите желаемое количество товара!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!uint.TryParse(textBoxInput.Text, out uint amount))
            {
                MessageBox.Show("Количество блюд должно быть целым положительным числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (amount > 100)
            {
                MessageBox.Show("Мы не можем дать одному клиенту более 100 порций", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OrderItem order = new OrderItem(Dishes[index], amount);
            orderItems.Add(order);
        }

        /// <summary>
        /// Просмотр содержимого корзины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCart_Click(object sender, EventArgs e)
        {
            Form f = new Order(orderItems);
            f.ShowDialog();
        }
    }
}
