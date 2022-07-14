
namespace mindalSHOP
{
    partial class menuForm
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
            this.btnItems = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnProdviders = new System.Windows.Forms.Button();
            this.panelHeading = new System.Windows.Forms.Panel();
            this.labelHeading = new System.Windows.Forms.Label();
            this.pBImage = new System.Windows.Forms.PictureBox();
            this.panelHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.SlateBlue;
            this.btnItems.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnItems.Location = new System.Drawing.Point(93, 171);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(192, 70);
            this.btnItems.TabIndex = 0;
            this.btnItems.Text = "Товары";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCart.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCart.Location = new System.Drawing.Point(291, 171);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(192, 70);
            this.btnCart.TabIndex = 1;
            this.btnCart.Text = "Корзина";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.SlateBlue;
            this.btnOrders.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrders.Location = new System.Drawing.Point(93, 247);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(192, 70);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Оформленные заказы";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Visible = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.BackColor = System.Drawing.Color.SlateBlue;
            this.btnStorage.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStorage.Location = new System.Drawing.Point(291, 247);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(192, 70);
            this.btnStorage.TabIndex = 3;
            this.btnStorage.Text = "Управление товарами";
            this.btnStorage.UseVisualStyleBackColor = false;
            this.btnStorage.Visible = false;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWelcome.Location = new System.Drawing.Point(12, 91);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(542, 61);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBack.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(421, 358);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Выйти";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnProdviders
            // 
            this.btnProdviders.BackColor = System.Drawing.Color.SlateBlue;
            this.btnProdviders.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProdviders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProdviders.Location = new System.Drawing.Point(187, 322);
            this.btnProdviders.Name = "btnProdviders";
            this.btnProdviders.Size = new System.Drawing.Size(192, 70);
            this.btnProdviders.TabIndex = 6;
            this.btnProdviders.Text = "Управление поставщиками";
            this.btnProdviders.UseVisualStyleBackColor = false;
            this.btnProdviders.Visible = false;
            this.btnProdviders.Click += new System.EventHandler(this.btnProdviders_Click);
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.SlateBlue;
            this.panelHeading.Controls.Add(this.labelHeading);
            this.panelHeading.Controls.Add(this.pBImage);
            this.panelHeading.Location = new System.Drawing.Point(-4, -4);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(581, 78);
            this.panelHeading.TabIndex = 7;
            // 
            // labelHeading
            // 
            this.labelHeading.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeading.Location = new System.Drawing.Point(96, 13);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(409, 52);
            this.labelHeading.TabIndex = 8;
            this.labelHeading.Text = "Магазин одежды \"Миндаль\"";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBImage
            // 
            this.pBImage.Image = global::mindalSHOP.Properties.Resources.store;
            this.pBImage.Location = new System.Drawing.Point(16, 13);
            this.pBImage.Name = "pBImage";
            this.pBImage.Size = new System.Drawing.Size(74, 58);
            this.pBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBImage.TabIndex = 8;
            this.pBImage.TabStop = false;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 400);
            this.Controls.Add(this.panelHeading);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btnProdviders);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStorage);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.panelHeading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnProdviders;
        private System.Windows.Forms.Panel panelHeading;
        private System.Windows.Forms.PictureBox pBImage;
        private System.Windows.Forms.Label labelHeading;
    }
}