namespace CarShop
{
    partial class Catalog
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableCar = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательскаяДокументацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCarTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.updRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MinPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Make = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableCar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuCarTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableCar
            // 
            this.TableCar.AllowUserToAddRows = false;
            this.TableCar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cornsilk;
            this.TableCar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TableCar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TableCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableCar.Location = new System.Drawing.Point(0, 25);
            this.TableCar.Margin = new System.Windows.Forms.Padding(5);
            this.TableCar.MultiSelect = false;
            this.TableCar.Name = "TableCar";
            this.TableCar.ReadOnly = true;
            this.TableCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableCar.Size = new System.Drawing.Size(1236, 436);
            this.TableCar.TabIndex = 0;
            this.TableCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableCar_CellContentClick);
            this.TableCar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableCar_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.обновитьТаблицуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1236, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Visible = false;
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click_1);
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(126, 19);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.обновитьТаблицуToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользовательскаяДокументацияToolStripMenuItem,
            this.оПриложенииToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // пользовательскаяДокументацияToolStripMenuItem
            // 
            this.пользовательскаяДокументацияToolStripMenuItem.Name = "пользовательскаяДокументацияToolStripMenuItem";
            this.пользовательскаяДокументацияToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.пользовательскаяДокументацияToolStripMenuItem.Text = "Пользовательская документация";
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.оПриложенииToolStripMenuItem_Click);
            // 
            // contextMenuCarTable
            // 
            this.contextMenuCarTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delRecord,
            this.updRecord});
            this.contextMenuCarTable.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuCarTable.Name = "contextMenuCarTable";
            this.contextMenuCarTable.Size = new System.Drawing.Size(204, 48);
            // 
            // delRecord
            // 
            this.delRecord.Name = "delRecord";
            this.delRecord.Size = new System.Drawing.Size(203, 22);
            this.delRecord.Text = "Удалить запись";
            this.delRecord.Visible = false;
            this.delRecord.Click += new System.EventHandler(this.delRecord_Click);
            // 
            // updRecord
            // 
            this.updRecord.Name = "updRecord";
            this.updRecord.Size = new System.Drawing.Size(203, 22);
            this.updRecord.Text = "Редактировать запись";
            this.updRecord.Visible = false;
            this.updRecord.Click += new System.EventHandler(this.updRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MaxPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MinPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Make);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1236, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "до";
            // 
            // MaxPrice
            // 
            this.MaxPrice.Location = new System.Drawing.Point(611, 41);
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.Size = new System.Drawing.Size(214, 27);
            this.MaxPrice.TabIndex = 4;
            this.MaxPrice.TextChanged += new System.EventHandler(this.MaxPrice_TextChanged);
            this.MaxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.MaxPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена от";
            // 
            // MinPrice
            // 
            this.MinPrice.Location = new System.Drawing.Point(356, 41);
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.Size = new System.Drawing.Size(214, 27);
            this.MinPrice.TabIndex = 2;
            this.MinPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.MinPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка";
            // 
            // Make
            // 
            this.Make.FormattingEnabled = true;
            this.Make.Location = new System.Drawing.Point(86, 41);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(184, 28);
            this.Make.TabIndex = 0;
            this.Make.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TableCar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Catalog";
            this.Text = "Каталог";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Catalog_FormClosed);
            this.Load += new System.EventHandler(this.Catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableCar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuCarTable.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableCar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательскаяДокументацияToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuCarTable;
        private System.Windows.Forms.ToolStripMenuItem delRecord;
        private System.Windows.Forms.ToolStripMenuItem updRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Make;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinPrice;
    }
}