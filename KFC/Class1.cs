using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Restaurant
{
    /// <summary>
    /// Класс Item, описывающий блюда представленные в меню
    /// У каждой позиции в меню есть наименование, цена, список ингридиентов, 
    /// вес в граммах и короткое описание.
    /// Для блюд определены операции подсчёта стоимости по количеству.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Цена за 1 шт
        /// </summary>
        public readonly double Price;
        /// <summary>
        /// Описание
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Время приготовления
        /// </summary>
        public readonly double CookingTime;
        /// <summary>
        /// Состав
        /// </summary>
        public readonly string Ingredient;
        /// <summary>
        /// Вес одной порции
        /// </summary>
        public readonly double Weight;
        /// <summary>
        /// Демонстрационное изображение готового блюда
        /// </summary>
        public readonly Image Image;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Item()
        {
            Name = "";
            Price = 0.0;
            Weight = 0.0;
            Description = "";
            CookingTime = 0.0;
            Ingredient = "";
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Наименование блюда</param>
        /// <param name="descr">Описание</param>
        /// <param name="price">Цена за одну порцию</param>
        /// <param name="weight">Вес одной порции</param>
        /// <param name="receipt">Состав</param>
        /// <param name="time">Время приготовления</param>
        /// <param name="imageName">Название иллюстрации блюда</param>
        public Item(string name, string descr, int price, int weight, string receipt, int time, string imageName)
        {
            this.Name = name;
            this.Description = descr;
            this.Price = price;
            this.Weight = weight;
            this.Ingredient = receipt;
            this.CookingTime = time;
            this.Image = Image.FromFile(imageName);
        }


        /// <summary>
        /// Получение данных из файла БД
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <returns>Список блюд и их характеристики</returns>
        public static Item[] ReadFromCSV(string fileName)
        {
            var items = new List<Item>();
            var lines = File.ReadAllLines(fileName, Encoding.UTF8).Skip(1).Select(x => x.Split('\t'));
            foreach (var line in lines)
            {
                items.Add(new Item(line[0], line[1], int.Parse(line[2]), int.Parse(line[3]), line[4], int.Parse(line[5]), line[6]));
            }
            return items.ToArray();
        }


        /// <summary>
        /// Функция подсчёта цены по количеству
        /// </summary>
        /// <param name="amount">Количество</param>
        /// <returns>Общая цена</returns>
        public double CountPriceByAmount(uint amount)
        {
            return Math.Round(Price * amount, 2);
        }

    }

    /// <summary>
    /// Класс OrderItem описывает заказ.
    /// Для каждого заказа есть методы увеличения количества товара
    /// и его уменьшения.
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Максимальное количество в 1 руки
        /// </summary>
        public const int MAX_AMOUNT = 100;

        /// <summary>
        /// Блюдо
        /// </summary>
        public readonly Item Dish;
        /// <summary>
        /// Количество порций
        /// </summary>
        private uint amount;

        /// <summary>
        /// Цена заказанных блюд
        /// </summary>
        public double Price => Dish.CountPriceByAmount(Amount);
        /// <summary>
        /// Изображение
        /// </summary>
        public Image Image => Dish.Image;
        /// <summary>
        /// Время приготовление
        /// </summary>
        public double CookingTime => Dish.CookingTime;

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get { return Dish.Name; } }

        /// <summary>
        /// свойства для amount
        /// </summary>
        public uint Amount
        {
            get => amount;
            set
            {
                if (value > MAX_AMOUNT)
                    amount = MAX_AMOUNT;
                if (value == 0)
                    amount = 1;
                else
                    amount = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public OrderItem()
        {
            Dish = new Item();
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="s">Блюдо</param>
        /// <param name="a">Количество порций</param>
        public OrderItem(Item s, uint a)
        {
            Dish = s;
            Amount = a;
        }
        /// <summary>
        /// Функция увеличения количества порций в заказе
        /// </summary>
        public void IncAmount()
        {
            Amount++;
        }
        /// <summary>
        /// Функция уменьшения количества порций в заказе
        /// </summary>
        public void DecAmount()
        {
            if (Amount == 1) return;
            Amount--;
        }
    }
}
