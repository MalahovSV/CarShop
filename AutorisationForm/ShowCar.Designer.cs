
namespace CarShop
{
    partial class ShowCar
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
            this.NameCar = new System.Windows.Forms.Label();
            this.DateCar = new System.Windows.Forms.Label();
            this.MakeCar = new System.Windows.Forms.Label();
            this.PriceCar = new System.Windows.Forms.Label();
            this.VEngineCar = new System.Windows.Forms.Label();
            this.comments = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameCar
            // 
            this.NameCar.AutoSize = true;
            this.NameCar.Location = new System.Drawing.Point(179, 59);
            this.NameCar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NameCar.Name = "NameCar";
            this.NameCar.Size = new System.Drawing.Size(97, 20);
            this.NameCar.TabIndex = 1;
            this.NameCar.Text = "[NameCar]";
            // 
            // DateCar
            // 
            this.DateCar.AutoSize = true;
            this.DateCar.Location = new System.Drawing.Point(182, 97);
            this.DateCar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DateCar.Name = "DateCar";
            this.DateCar.Size = new System.Drawing.Size(89, 20);
            this.DateCar.TabIndex = 2;
            this.DateCar.Text = "[DateCar]";
            this.DateCar.Click += new System.EventHandler(this.label1_Click);
            // 
            // MakeCar
            // 
            this.MakeCar.AutoSize = true;
            this.MakeCar.Location = new System.Drawing.Point(179, 23);
            this.MakeCar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MakeCar.Name = "MakeCar";
            this.MakeCar.Size = new System.Drawing.Size(92, 20);
            this.MakeCar.TabIndex = 3;
            this.MakeCar.Text = "[MakeCar]";
            // 
            // PriceCar
            // 
            this.PriceCar.AutoSize = true;
            this.PriceCar.Location = new System.Drawing.Point(182, 138);
            this.PriceCar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PriceCar.Name = "PriceCar";
            this.PriceCar.Size = new System.Drawing.Size(62, 20);
            this.PriceCar.TabIndex = 4;
            this.PriceCar.Text = "[Price]";
            this.PriceCar.Click += new System.EventHandler(this.PriceCar_Click);
            // 
            // VEngineCar
            // 
            this.VEngineCar.AutoSize = true;
            this.VEngineCar.Location = new System.Drawing.Point(182, 169);
            this.VEngineCar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VEngineCar.Name = "VEngineCar";
            this.VEngineCar.Size = new System.Drawing.Size(99, 20);
            this.VEngineCar.TabIndex = 5;
            this.VEngineCar.Text = "[V_Engine]";
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(446, 210);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(446, 141);
            this.comments.TabIndex = 6;
            this.comments.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Объём двигателя";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Марка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата производства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Модель";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.VEngineCar);
            this.groupBox1.Controls.Add(this.PriceCar);
            this.groupBox1.Controls.Add(this.MakeCar);
            this.groupBox1.Controls.Add(this.DateCar);
            this.groupBox1.Controls.Add(this.NameCar);
            this.groupBox1.Location = new System.Drawing.Point(443, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 196);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            // 
            // ShowCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(911, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ShowCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ShowCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameCar;
        private System.Windows.Forms.Label DateCar;
        private System.Windows.Forms.Label MakeCar;
        private System.Windows.Forms.Label PriceCar;
        private System.Windows.Forms.Label VEngineCar;
        private System.Windows.Forms.RichTextBox comments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}