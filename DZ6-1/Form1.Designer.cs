namespace DZ6_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopLevelMenu = new System.Windows.Forms.TextBox();
            this.SubItem = new System.Windows.Forms.TextBox();
            this.btnTopLevelMenu = new System.Windows.Forms.Button();
            this.btnSubItem = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TopLevelMenu
            // 
            this.TopLevelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLevelMenu.Location = new System.Drawing.Point(15, 156);
            this.TopLevelMenu.Margin = new System.Windows.Forms.Padding(6);
            this.TopLevelMenu.Name = "TopLevelMenu";
            this.TopLevelMenu.Size = new System.Drawing.Size(430, 55);
            this.TopLevelMenu.TabIndex = 2;
            this.TopLevelMenu.Click += new System.EventHandler(this.Level_Click);
            // 
            // SubItem
            // 
            this.SubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubItem.Location = new System.Drawing.Point(15, 300);
            this.SubItem.Margin = new System.Windows.Forms.Padding(6);
            this.SubItem.Name = "SubItem";
            this.SubItem.Size = new System.Drawing.Size(430, 55);
            this.SubItem.TabIndex = 3;
            this.SubItem.Click += new System.EventHandler(this.Level_Click);
            // 
            // btnTopLevelMenu
            // 
            this.btnTopLevelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTopLevelMenu.Location = new System.Drawing.Point(461, 156);
            this.btnTopLevelMenu.Margin = new System.Windows.Forms.Padding(6);
            this.btnTopLevelMenu.Name = "btnTopLevelMenu";
            this.btnTopLevelMenu.Size = new System.Drawing.Size(588, 60);
            this.btnTopLevelMenu.TabIndex = 4;
            this.btnTopLevelMenu.Text = "Добавить пункт меню";
            this.btnTopLevelMenu.UseVisualStyleBackColor = true;
            this.btnTopLevelMenu.Click += new System.EventHandler(this.BtnTopLevelMenu_Click);
            // 
            // btnSubItem
            // 
            this.btnSubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubItem.Location = new System.Drawing.Point(461, 300);
            this.btnSubItem.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubItem.Name = "btnSubItem";
            this.btnSubItem.Size = new System.Drawing.Size(588, 60);
            this.btnSubItem.TabIndex = 5;
            this.btnSubItem.Text = "Добавить подменю";
            this.btnSubItem.UseVisualStyleBackColor = true;
            this.btnSubItem.Click += new System.EventHandler(this.BtnSubItem_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(157, 64);
            this.label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(565, 48);
            this.label.TabIndex = 7;
            this.label.Text = "Добавления пунктов меню";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 442);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnSubItem);
            this.Controls.Add(this.btnTopLevelMenu);
            this.Controls.Add(this.SubItem);
            this.Controls.Add(this.TopLevelMenu);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Добавление пункта меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TopLevelMenu;
        private System.Windows.Forms.TextBox SubItem;
        private System.Windows.Forms.Button btnTopLevelMenu;
        private System.Windows.Forms.Button btnSubItem;
        private System.Windows.Forms.Label label;
    }
}

