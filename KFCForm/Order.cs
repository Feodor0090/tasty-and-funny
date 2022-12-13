﻿using Restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFCForm
{
    public partial class Order : Form
    {
        List<OrderItem> orderItems = new List<OrderItem>();
        Timer tm = new Timer();
    
        public double OrderTotalPrice => orderItems.Select(x => x.Price).Sum() * (1d - Discount);
        // размер скидки, 0d - нету, 1d - 100%
        public double Discount;
        
        public Order()
        {
            InitializeComponent(); 
            tm = new Timer();
        }

        public Order(List<OrderItem> orderItems)
        {
            InitializeComponent();
            this.orderItems = orderItems;
            lableItogo.ForeColor = System.Drawing.Color.Black;
            if (orderItems.Count == 0)
            {
                labelEmpty.Visible = true;
                button3.Enabled = false;
            }

        }

        //программа для кнопок удаления 
        void deleteOrder(Panel p, OrderItem o) {
            p.Dispose();
            orderItems.Remove(o);
        }

        /// <summary>
        /// Обновление цены
        /// </summary>
        private void UpdPriceLabel()
        {
            lableItogo.Text = $"{OrderTotalPrice} руб.";
            if (orderItems.Count == 0)
            {
                labelEmpty.Visible = true;
                button3.Enabled = false;
            }
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Order_Load(object sender, EventArgs e)
        {
            int n = 0;
            foreach (OrderItem item in orderItems)
            {
                CreatePanel(item);
                n++;
            }
            UpdPriceLabel();
        }

        /// <summary>
        /// Создание новой позиции в корзине
        /// </summary>
        /// <param name="order">данные о заказе</param>
        private void CreatePanel(OrderItem order)
        {
            var p = new OrderPanel(order, UpdPriceLabel, deleteOrder);
            Orderpanel.Controls.Add(p);
        }

        /// <summary>
        /// Проверка промокода, если промокод верный, уменьшает итоговую цену
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckProm_Click(object sender, EventArgs e)
        {
            string[] promocodes = File.ReadAllLines("Promocodes.txt");
            string input = InputProm.Text.ToUpper();
            string[] s = new string[2];
            for (int i = 0; i < promocodes.Count(); i++)
            {
               s=  promocodes[i].Split();
                if (input == s[0])
                {
                    Discount = double.Parse(s[1])/100d;
                    UpdPriceLabel();
                }
            }
        }
        int startValue = 0;

        /// <summary>
        /// Таймер готовки заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tm_Tick(object sender, EventArgs e)
        {
            if (startValue != 0)
            {
                startValue--;
            }
            else
            {
                (sender as Timer).Stop(); //когда время вышло, таймер останавливается
                (sender as Timer).Dispose();
                MessageBox.Show("Ваш заказ готов. Приятного аппетита!", "Приходите снова!"); //отображается уведомление о готовности заказа
            }
        }

        /// <summary>
        /// Вызывается при нажатии заказать. Запускает таймер и отображает диалоговое окно, 
        /// в котором уведомляет о времени готовки заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToOrder_Click(object sender, EventArgs e) 
        {
            //todo pizdec peredelat
            Orderpanel.Enabled = false;
            Pricepanel.Enabled = false;
            double time = orderItems.Select(x => x.CookingTime).Max();
            tm.Interval = 1000;
            startValue = (int)time*60;
            tm.Start();
            orderItems.Clear();
            tm.Tick += new EventHandler(tm_Tick);
            MessageBox.Show("Ваш заказ будет готовится "+time+ " мин", "Ждите...");
            this.Close(); 
            labelEmpty.Visible = true;
        }
    }
}
