namespace AutorisationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.TableCar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuCarTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableCar
            // 
            this.TableCar.AllowUserToAddRows = false;
            this.TableCar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cornsilk;
            this.TableCar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TableCar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TableCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableCar.Location = new System.Drawing.Point(0, 25);
            this.TableCar.Margin = new System.Windows.Forms.Padding(5);
            this.TableCar.MultiSelect = false;
            this.TableCar.Name = "TableCar";
            this.TableCar.ReadOnly = true;
            this.TableCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableCar.Size = new System.Drawing.Size(1236, 544);
            this.TableCar.TabIndex = 0;
            this.TableCar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableCar_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.обновитьТаблицуToolStripMenuItem,
            this.справкаToolStripMenuItem});
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
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click_1);
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(121, 19);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.обновитьТаблицуToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользовательскаяДокументацияToolStripMenuItem,
            this.оПриложенииToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // пользовательскаяДокументацияToolStripMenuItem
            // 
            this.пользовательскаяДокументацияToolStripMenuItem.Name = "пользовательскаяДокументацияToolStripMenuItem";
            this.пользовательскаяДокументацияToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.пользовательскаяДокументацияToolStripMenuItem.Text = "Пользовательская документация";
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            // 
            // contextMenuCarTable
            // 
            this.contextMenuCarTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delRecord,
            this.updRecord});
            this.contextMenuCarTable.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuCarTable.Name = "contextMenuCarTable";
            this.contextMenuCarTable.Size = new System.Drawing.Size(195, 70);
            // 
            // delRecord
            // 
            this.delRecord.Name = "delRecord";
            this.delRecord.Size = new System.Drawing.Size(194, 22);
            this.delRecord.Text = "Удалить запись";
            this.delRecord.Click += new System.EventHandler(this.delRecord_Click);
            // 
            // updRecord
            // 
            this.updRecord.Name = "updRecord";
            this.updRecord.Size = new System.Drawing.Size(194, 22);
            this.updRecord.Text = "Редактировать запись";
            this.updRecord.Click += new System.EventHandler(this.updRecord_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 569);
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
    }
}