using Restaurant;
using System;
using System.Drawing;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace KFCForm
{
    public partial class Order
    {
        private class OrderPanel : Panel {

            public readonly OrderItem item;
            private readonly Action upd;
            private readonly Label PriceLabel;
            private readonly Label CountLabel;

            public OrderPanel(OrderItem order, Action onOrderUpdate, Action<Panel, OrderItem> deleteAction) {
                item = order;
                upd = onOrderUpdate;

                PictureBox pic = new PictureBox();
                // 
                // pictureBox1
                // 
                pic.Size = new System.Drawing.Size(123, 111);
                pic.Image = order.Image;
                pic.SizeMode=PictureBoxSizeMode.StretchImage;
                pic.Location = new System.Drawing.Point(3, 3);
                pic.TabStop=false;
                // 
                // button4
                // 
                Button but2 = new Button();
                but2.BackColor = System.Drawing.Color.MintCream;
                but2.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
                but2.ForeColor = System.Drawing.Color.ForestGreen;
                but2.Location = new System.Drawing.Point(390, 90);
                but2.Size = new System.Drawing.Size(129, 49);
                but2.TabIndex = 7;
                but2.Text = "удалить";
                but2.UseVisualStyleBackColor = false;
                but2.Click += (a,b)=>{
                    deleteAction(this,item);
                    upd();
                };
                // 
                // labelPrice
                // 
                PriceLabel = new Label();
                PriceLabel.AutoSize = true;
                PriceLabel.BackColor = System.Drawing.Color.MintCream;
                PriceLabel.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
                PriceLabel.ForeColor = System.Drawing.Color.Black;
                PriceLabel.Location = new System.Drawing.Point(414, 41);
                PriceLabel.Size = new System.Drawing.Size(27, 31);
                PriceLabel.TabIndex = 8;
                PriceLabel.Text = order.Price.ToString() + " руб.";
                // 
                // button1
                // 
                Button but1 = new Button();
                but1.BackColor = System.Drawing.Color.MintCream;
                but1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                but1.ForeColor = System.Drawing.Color.ForestGreen;
                but1.Location = new System.Drawing.Point(310, 10);
                but1.Size = new System.Drawing.Size(25, 28);
                but1.TabIndex = 7;
                but1.Text = "+";
                but1.Click += incrCount;
                but1.UseVisualStyleBackColor = false;
                // 
                // labelName
                // 
                Label lable3 = new System.Windows.Forms.Label();
                lable3.AutoSize = true;
                lable3.MaximumSize = new Size(152, 131);
                lable3.AutoEllipsis = true;
                lable3.BackColor = System.Drawing.Color.MintCream;
                lable3.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
                lable3.ForeColor = System.Drawing.Color.Black;
                lable3.Location = new System.Drawing.Point(132, 41);
                lable3.Size = new System.Drawing.Size(52, 31);
                lable3.TabIndex = 5;
                lable3.Text = order.Name;
                // 
                // button2
                // 
                Button but = new Button();
                but.BackColor = System.Drawing.Color.MintCream;
                but.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                but.ForeColor = System.Drawing.Color.ForestGreen;
                but.Location = new System.Drawing.Point(310, 75);
                but.Size = new System.Drawing.Size(25, 28);
                but.TabIndex = 6;
                but.Text = "-";
                but.UseVisualStyleBackColor = false;
                but.Click += decrCount;
                // 
                // labelCount
                // 
                CountLabel = new Label();
                CountLabel.AutoSize = true;
                CountLabel.BackColor = System.Drawing.Color.MintCream;
                CountLabel.Font = new System.Drawing.Font("Segoe Print", 9.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
                CountLabel.ForeColor = System.Drawing.Color.Black;
                CountLabel.Location = new System.Drawing.Point(298, 41);
                CountLabel.Size = new System.Drawing.Size(27, 31);
                CountLabel.TabIndex = 4;
                CountLabel.Text = order.Amount.ToString() + " шт.";

                Controls.Add(pic);
                Controls.Add(PriceLabel);
                Controls.Add(lable3);
                Controls.Add(CountLabel);
                Controls.Add(but);
                Controls.Add(but1);
                Controls.Add(but2);
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
                Dock = System.Windows.Forms.DockStyle.Top;
                Location = new System.Drawing.Point(200, 200);
                Size = new System.Drawing.Size(745, 141);
            }

            void decrCount(object sender, EventArgs e) {
                item.DecAmount();
                upd();
                PriceLabel.Text = $"{item.Price} руб.";
                CountLabel.Text = $"{item.Amount} шт.";
            }

            void incrCount(object sender, EventArgs e) {
                item.IncAmount();
                upd();
                PriceLabel.Text = $"{item.Price} руб.";
                CountLabel.Text = $"{item.Amount} шт.";
            }
        }
    }
}
