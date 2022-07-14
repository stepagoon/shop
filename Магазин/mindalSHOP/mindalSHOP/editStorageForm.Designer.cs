
namespace mindalSHOP
{
    partial class editStorageForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.numericPriceEdit = new System.Windows.Forms.NumericUpDown();
            this.numericCountEdit = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbItemEdit = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.labelProvisers = new System.Windows.Forms.Label();
            this.cbProviders = new System.Windows.Forms.ComboBox();
            this.labelHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBack.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(250, 327);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 55);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numericPriceEdit
            // 
            this.numericPriceEdit.DecimalPlaces = 2;
            this.numericPriceEdit.Location = new System.Drawing.Point(183, 236);
            this.numericPriceEdit.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericPriceEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericPriceEdit.Name = "numericPriceEdit";
            this.numericPriceEdit.Size = new System.Drawing.Size(187, 20);
            this.numericPriceEdit.TabIndex = 52;
            this.numericPriceEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericCountEdit
            // 
            this.numericCountEdit.Location = new System.Drawing.Point(183, 189);
            this.numericCountEdit.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericCountEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCountEdit.Name = "numericCountEdit";
            this.numericCountEdit.Size = new System.Drawing.Size(187, 20);
            this.numericCountEdit.TabIndex = 51;
            this.numericCountEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(132, 232);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(45, 22);
            this.labelPrice.TabIndex = 50;
            this.labelPrice.Text = "Цена";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(80, 185);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(97, 22);
            this.labelCount.TabIndex = 49;
            this.labelCount.Text = "Количество";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(29, 144);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(148, 22);
            this.labelDate.TabIndex = 48;
            this.labelDate.Text = "Дата изготовления";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 144);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // tbItemEdit
            // 
            this.tbItemEdit.Location = new System.Drawing.Point(183, 104);
            this.tbItemEdit.Name = "tbItemEdit";
            this.tbItemEdit.Size = new System.Drawing.Size(187, 20);
            this.tbItemEdit.TabIndex = 46;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(46, 101);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(131, 22);
            this.labelName.TabIndex = 45;
            this.labelName.Text = "Название товара";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEdit.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(52, 327);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 55);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelProvisers
            // 
            this.labelProvisers.AutoSize = true;
            this.labelProvisers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProvisers.Location = new System.Drawing.Point(88, 277);
            this.labelProvisers.Name = "labelProvisers";
            this.labelProvisers.Size = new System.Drawing.Size(89, 22);
            this.labelProvisers.TabIndex = 54;
            this.labelProvisers.Text = "Поставщик";
            // 
            // cbProviders
            // 
            this.cbProviders.FormattingEnabled = true;
            this.cbProviders.Location = new System.Drawing.Point(183, 280);
            this.cbProviders.Name = "cbProviders";
            this.cbProviders.Size = new System.Drawing.Size(187, 21);
            this.cbProviders.TabIndex = 55;
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.SlateBlue;
            this.labelHeading.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeading.Location = new System.Drawing.Point(-11, -2);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(487, 62);
            this.labelHeading.TabIndex = 56;
            this.labelHeading.Text = "Редактирование товара";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editStorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 403);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.cbProviders);
            this.Controls.Add(this.labelProvisers);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.numericPriceEdit);
            this.Controls.Add(this.numericCountEdit);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbItemEdit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "editStorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown numericPriceEdit;
        private System.Windows.Forms.NumericUpDown numericCountEdit;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbItemEdit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelProvisers;
        private System.Windows.Forms.ComboBox cbProviders;
        private System.Windows.Forms.Label labelHeading;
    }
}