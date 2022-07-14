
namespace mindalSHOP
{
    partial class editCartForm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cBItems = new System.Windows.Forms.ComboBox();
            this.numericCount = new System.Windows.Forms.NumericUpDown();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCountScore = new System.Windows.Forms.Label();
            this.labelHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEdit.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(48, 215);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 48);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBack.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(250, 215);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 48);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cBItems
            // 
            this.cBItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBItems.FormattingEnabled = true;
            this.cBItems.Location = new System.Drawing.Point(176, 86);
            this.cBItems.Name = "cBItems";
            this.cBItems.Size = new System.Drawing.Size(182, 21);
            this.cBItems.TabIndex = 39;
            this.cBItems.SelectionChangeCommitted += new System.EventHandler(this.cBItems_SelectionChangeCommitted);
            // 
            // numericCount
            // 
            this.numericCount.Location = new System.Drawing.Point(176, 125);
            this.numericCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCount.Name = "numericCount";
            this.numericCount.Size = new System.Drawing.Size(182, 20);
            this.numericCount.TabIndex = 40;
            this.numericCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericCount_KeyUp);
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItem.Location = new System.Drawing.Point(59, 83);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(111, 22);
            this.labelItem.TabIndex = 41;
            this.labelItem.Text = "Выбор товара";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(73, 121);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(97, 22);
            this.labelCount.TabIndex = 42;
            this.labelCount.Text = "Количество";
            // 
            // labelCountScore
            // 
            this.labelCountScore.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountScore.Location = new System.Drawing.Point(12, 169);
            this.labelCountScore.Name = "labelCountScore";
            this.labelCountScore.Size = new System.Drawing.Size(417, 23);
            this.labelCountScore.TabIndex = 43;
            this.labelCountScore.Text = "Доступно: 0";
            this.labelCountScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.SlateBlue;
            this.labelHeading.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeading.Location = new System.Drawing.Point(-1, -4);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(448, 47);
            this.labelHeading.TabIndex = 44;
            this.labelHeading.Text = "Редактирование заказа";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 275);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.labelCountScore);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.numericCount);
            this.Controls.Add(this.cBItems);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "editCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заказа";
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cBItems;
        private System.Windows.Forms.NumericUpDown numericCount;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelCountScore;
        private System.Windows.Forms.Label labelHeading;
    }
}