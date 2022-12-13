namespace KFCForm
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEmpty = new System.Windows.Forms.Label();
            this.Pricepanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.lableItogo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Orderpanel = new System.Windows.Forms.Panel();
            this.labelProm = new System.Windows.Forms.Label();
            this.InputProm = new System.Windows.Forms.TextBox();
            this.CheckProm = new System.Windows.Forms.Button();
            this.Pricepanel.SuspendLayout();
            this.Orderpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(2, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ресторан \"Весело и вкусно\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(433, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Корзина";
            // 
            // labelEmpty
            // 
            this.labelEmpty.AutoSize = true;
            this.labelEmpty.BackColor = System.Drawing.Color.MintCream;
            this.labelEmpty.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmpty.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelEmpty.Location = new System.Drawing.Point(254, 28);
            this.labelEmpty.Name = "labelEmpty";
            this.labelEmpty.Size = new System.Drawing.Size(293, 58);
            this.labelEmpty.TabIndex = 4;
            this.labelEmpty.Text = "Корзина пуста";
            this.labelEmpty.Visible = false;
            // 
            // panel2
            // 
            this.Pricepanel.Controls.Add(this.CheckProm);
            this.Pricepanel.Controls.Add(this.InputProm);
            this.Pricepanel.Controls.Add(this.labelProm);
            this.Pricepanel.Controls.Add(this.button3);
            this.Pricepanel.Controls.Add(this.lableItogo);
            this.Pricepanel.Controls.Add(this.label7);
            this.Pricepanel.Location = new System.Drawing.Point(777, 83);
            this.Pricepanel.Name = "panel2";
            this.Pricepanel.Size = new System.Drawing.Size(370, 325);
            this.Pricepanel.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MintCream;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.ForestGreen;
            this.button3.Location = new System.Drawing.Point(19, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(341, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "Оформить заказ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ToOrder_Click);
            // 
            // labelItogo
            // 
            this.lableItogo.AutoSize = true;
            this.lableItogo.BackColor = System.Drawing.Color.MintCream;
            this.lableItogo.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lableItogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lableItogo.Location = new System.Drawing.Point(123, 17);
            this.lableItogo.Name = "labelItogo";
            this.lableItogo.Size = new System.Drawing.Size(29, 33);
            this.lableItogo.TabIndex = 5;
            this.lableItogo.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(7, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 38);
            this.label7.TabIndex = 4;
            this.label7.Text = "Итого: ";
            // 
            // panel1
            // 
            this.Orderpanel.AutoScroll = true;
            this.Orderpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Orderpanel.Controls.Add(this.labelEmpty);
            this.Orderpanel.Location = new System.Drawing.Point(26, 83);
            this.Orderpanel.Name = "panel1";
            this.Orderpanel.Size = new System.Drawing.Size(752, 401);
            this.Orderpanel.TabIndex = 6;
            // 
            // labelProm
            // 
            this.labelProm.AutoSize = true;
            this.labelProm.BackColor = System.Drawing.Color.MintCream;
            this.labelProm.Font = new System.Drawing.Font("Segoe Print", 12.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelProm.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelProm.Location = new System.Drawing.Point(12, 101);
            this.labelProm.Name = "labelProm";
            this.labelProm.Size = new System.Drawing.Size(181, 38);
            this.labelProm.TabIndex = 7;
            this.labelProm.Text = "ПРОМОКОД:";
            // 
            // InputProm
            // 
            this.InputProm.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.InputProm.Location = new System.Drawing.Point(19, 142);
            this.InputProm.Name = "InputProm";
            this.InputProm.Size = new System.Drawing.Size(308, 37);
            this.InputProm.TabIndex = 8;
            // 
            // CheckProm
            // 
            this.CheckProm.BackColor = System.Drawing.Color.MintCream;
            this.CheckProm.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.CheckProm.ForeColor = System.Drawing.Color.ForestGreen;
            this.CheckProm.Location = new System.Drawing.Point(81, 195);
            this.CheckProm.Name = "CheckProm";
            this.CheckProm.Size = new System.Drawing.Size(246, 42);
            this.CheckProm.TabIndex = 9;
            this.CheckProm.Text = "Проверить промокод";
            this.CheckProm.UseVisualStyleBackColor = false;
            this.CheckProm.Click += new System.EventHandler(this.CheckProm_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1149, 505);
            this.Controls.Add(this.Orderpanel);
            this.Controls.Add(this.Pricepanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.Pricepanel.ResumeLayout(false);
            this.Pricepanel.PerformLayout();
            this.Orderpanel.ResumeLayout(false);
            this.Orderpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEmpty;
        private System.Windows.Forms.Panel Pricepanel;
        private System.Windows.Forms.Label lableItogo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel Orderpanel;
        private System.Windows.Forms.Button CheckProm;
        private System.Windows.Forms.TextBox InputProm;
        private System.Windows.Forms.Label labelProm;
    }
}