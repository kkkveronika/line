using System;

namespace Line
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grafic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.table_result = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.button_result = new System.Windows.Forms.Button();
            this.file_input = new System.Windows.Forms.Button();
            this.file_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save_result = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_result)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_x1
            // 
            this.textBox_x1.Location = new System.Drawing.Point(201, 18);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.Size = new System.Drawing.Size(100, 22);
            this.textBox_x1.TabIndex = 0;
            this.textBox_x1.TextChanged += new System.EventHandler(this.textBox_x1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Нижняя граница";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grafic
            // 
            this.grafic.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.grafic.ChartAreas.Add(chartArea1);
            this.grafic.Location = new System.Drawing.Point(25, 29);
            this.grafic.Name = "grafic";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.grafic.Series.Add(series1);
            this.grafic.Size = new System.Drawing.Size(398, 298);
            this.grafic.TabIndex = 3;
            this.grafic.Text = "График";
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title1.Name = "Title1";
            title1.Text = "График Лемниската Жероно";
            this.grafic.Titles.Add(title1);
            this.grafic.Click += new System.EventHandler(this.grafic_Click);
            // 
            // table_result
            // 
            this.table_result.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.table_result.Location = new System.Drawing.Point(25, 346);
            this.table_result.Name = "table_result";
            this.table_result.RowHeadersWidth = 51;
            this.table_result.RowTemplate.Height = 24;
            this.table_result.Size = new System.Drawing.Size(412, 91);
            this.table_result.TabIndex = 4;
            this.table_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_result_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "x";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "y";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Верхняя граница";
            // 
            // textBox_x2
            // 
            this.textBox_x2.Location = new System.Drawing.Point(201, 56);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.Size = new System.Drawing.Size(100, 22);
            this.textBox_x2.TabIndex = 5;
            this.textBox_x2.TextChanged += new System.EventHandler(this.textBox_x2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Шаг";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(201, 100);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 22);
            this.textBox_n.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "a = ";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(201, 145);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 22);
            this.textBox_a.TabIndex = 9;
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(217, 185);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(75, 23);
            this.button_result.TabIndex = 11;
            this.button_result.Text = "Ок";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // file_input
            // 
            this.file_input.BackColor = System.Drawing.SystemColors.ControlLight;
            this.file_input.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.file_input.Location = new System.Drawing.Point(30, 185);
            this.file_input.Name = "file_input";
            this.file_input.Size = new System.Drawing.Size(133, 23);
            this.file_input.TabIndex = 12;
            this.file_input.Text = "Выбрать файл";
            this.file_input.UseVisualStyleBackColor = false;
            this.file_input.Click += new System.EventHandler(this.file_input_Click);
            // 
            // file_save
            // 
            this.file_save.Location = new System.Drawing.Point(592, 263);
            this.file_save.Name = "file_save";
            this.file_save.Size = new System.Drawing.Size(179, 23);
            this.file_save.TabIndex = 13;
            this.file_save.Text = "Сохранить в файл";
            this.file_save.UseVisualStyleBackColor = true;
            this.file_save.Click += new System.EventHandler(this.file_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.file_input);
            this.groupBox1.Controls.Add(this.textBox_x1);
            this.groupBox1.Controls.Add(this.textBox_a);
            this.groupBox1.Controls.Add(this.button_result);
            this.groupBox1.Controls.Add(this.textBox_x2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_n);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(455, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 214);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // save_result
            // 
            this.save_result.Location = new System.Drawing.Point(534, 399);
            this.save_result.Name = "save_result";
            this.save_result.Size = new System.Drawing.Size(179, 23);
            this.save_result.TabIndex = 15;
            this.save_result.Text = "Сохранить результат";
            this.save_result.UseVisualStyleBackColor = true;
            this.save_result.Click += new System.EventHandler(this.save_result_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.настройкиToolStripMenuItem.Text = "Справка";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_result);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.file_save);
            this.Controls.Add(this.table_result);
            this.Controls.Add(this.grafic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "График функции";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_result)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox_x1_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafic;
        private System.Windows.Forms.DataGridView table_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button file_input;
        private System.Windows.Forms.Button file_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save_result;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
    }
}

