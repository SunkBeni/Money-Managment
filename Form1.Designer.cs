namespace Money_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            main_list = new DataGridView();
            main_list_name = new DataGridViewTextBoxColumn();
            main_list_money = new DataGridViewTextBoxColumn();
            Main_list_CashCredit = new DataGridViewTextBoxColumn();
            main_data4 = new Label();
            main_data5 = new Label();
            main_data3 = new Label();
            main_data2 = new Label();
            main_data1 = new Label();
            main_databox1 = new GroupBox();
            main_databox2 = new GroupBox();
            menuStrip1 = new MenuStrip();
            strip_settings = new ToolStripMenuItem();
            strip_settings_ML = new ToolStripMenuItem();
            strip_settings_ML_text1 = new ToolStripMenuItem();
            strip_settings_ML_textbox1 = new ToolStripTextBox();
            strip_settings_ML_set = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)main_list).BeginInit();
            main_databox1.SuspendLayout();
            main_databox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // main_list
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            main_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            main_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            main_list.BackgroundColor = Color.White;
            main_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 94, 73);
            dataGridViewCellStyle2.Font = new Font("Roboto Slab", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(61, 61, 61);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            main_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            main_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            main_list.Columns.AddRange(new DataGridViewColumn[] { main_list_name, main_list_money, Main_list_CashCredit });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            main_list.DefaultCellStyle = dataGridViewCellStyle3;
            main_list.EnableHeadersVisualStyles = false;
            main_list.GridColor = Color.FromArgb(38, 94, 73);
            main_list.Location = new Point(12, 136);
            main_list.Name = "main_list";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            main_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            main_list.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            main_list.RowsDefaultCellStyle = dataGridViewCellStyle5;
            main_list.RowTemplate.Height = 25;
            main_list.RowTemplate.Resizable = DataGridViewTriState.False;
            main_list.Size = new Size(920, 533);
            main_list.TabIndex = 1;
            main_list.MouseDoubleClick += list_double_click;
            // 
            // main_list_name
            // 
            main_list_name.HeaderText = "Name";
            main_list_name.Name = "main_list_name";
            main_list_name.ReadOnly = true;
            // 
            // main_list_money
            // 
            main_list_money.HeaderText = "Money";
            main_list_money.Name = "main_list_money";
            main_list_money.ReadOnly = true;
            // 
            // Main_list_CashCredit
            // 
            Main_list_CashCredit.HeaderText = "Cash/Credit";
            Main_list_CashCredit.Name = "Main_list_CashCredit";
            Main_list_CashCredit.ReadOnly = true;
            // 
            // main_data4
            // 
            main_data4.AutoSize = true;
            main_data4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            main_data4.ForeColor = Color.Green;
            main_data4.Location = new Point(1, 45);
            main_data4.Name = "main_data4";
            main_data4.Size = new Size(42, 50);
            main_data4.TabIndex = 2;
            main_data4.Text = "₪";
            // 
            // main_data5
            // 
            main_data5.AutoSize = true;
            main_data5.Font = new Font("Roboto Slab", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            main_data5.ForeColor = Color.Green;
            main_data5.Location = new Point(219, 46);
            main_data5.Name = "main_data5";
            main_data5.Size = new Size(43, 49);
            main_data5.TabIndex = 1;
            main_data5.Text = "0";
            // 
            // main_data3
            // 
            main_data3.AutoSize = true;
            main_data3.Font = new Font("Roboto Slab", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_data3.ForeColor = Color.Green;
            main_data3.Location = new Point(155, 10);
            main_data3.Name = "main_data3";
            main_data3.Size = new Size(176, 35);
            main_data3.TabIndex = 0;
            main_data3.Text = "Total Money";
            // 
            // main_data2
            // 
            main_data2.AutoSize = true;
            main_data2.Font = new Font("Roboto Slab", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            main_data2.ForeColor = SystemColors.Control;
            main_data2.Location = new Point(127, 10);
            main_data2.Name = "main_data2";
            main_data2.Size = new Size(174, 35);
            main_data2.TabIndex = 0;
            main_data2.Text = "Total People";
            // 
            // main_data1
            // 
            main_data1.AutoSize = true;
            main_data1.Font = new Font("Roboto Slab", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            main_data1.ForeColor = SystemColors.ButtonFace;
            main_data1.Location = new Point(188, 46);
            main_data1.Name = "main_data1";
            main_data1.Size = new Size(43, 49);
            main_data1.TabIndex = 1;
            main_data1.Text = "0";
            // 
            // main_databox1
            // 
            main_databox1.Controls.Add(main_data2);
            main_databox1.Controls.Add(main_data1);
            main_databox1.Location = new Point(12, 27);
            main_databox1.Name = "main_databox1";
            main_databox1.Size = new Size(433, 97);
            main_databox1.TabIndex = 5;
            main_databox1.TabStop = false;
            // 
            // main_databox2
            // 
            main_databox2.Controls.Add(main_data4);
            main_databox2.Controls.Add(main_data3);
            main_databox2.Controls.Add(main_data5);
            main_databox2.Location = new Point(451, 27);
            main_databox2.Name = "main_databox2";
            main_databox2.Size = new Size(481, 97);
            main_databox2.TabIndex = 6;
            main_databox2.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(26, 26, 26);
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { strip_settings });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(944, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // strip_settings
            // 
            strip_settings.DropDownItems.AddRange(new ToolStripItem[] { strip_settings_ML });
            strip_settings.ForeColor = SystemColors.Control;
            strip_settings.Name = "strip_settings";
            strip_settings.Size = new Size(60, 20);
            strip_settings.Text = "settings";
            // 
            // strip_settings_ML
            // 
            strip_settings_ML.BackColor = Color.FromArgb(6, 6, 28);
            strip_settings_ML.BackgroundImageLayout = ImageLayout.None;
            strip_settings_ML.DisplayStyle = ToolStripItemDisplayStyle.Text;
            strip_settings_ML.DropDownItems.AddRange(new ToolStripItem[] { strip_settings_ML_text1, strip_settings_ML_textbox1, strip_settings_ML_set });
            strip_settings_ML.ForeColor = SystemColors.ActiveCaptionText;
            strip_settings_ML.ImageTransparentColor = Color.FromArgb(6, 6, 28);
            strip_settings_ML.Name = "strip_settings_ML";
            strip_settings_ML.Size = new Size(189, 22);
            strip_settings_ML.Text = "change money layout";
            // 
            // strip_settings_ML_text1
            // 
            strip_settings_ML_text1.BackColor = Color.FromArgb(6, 6, 28);
            strip_settings_ML_text1.ForeColor = Color.Black;
            strip_settings_ML_text1.Name = "strip_settings_ML_text1";
            strip_settings_ML_text1.Size = new Size(164, 22);
            strip_settings_ML_text1.Text = "V Enter Symbol V";
            // 
            // strip_settings_ML_textbox1
            // 
            strip_settings_ML_textbox1.Name = "strip_settings_ML_textbox1";
            strip_settings_ML_textbox1.Size = new Size(100, 23);
            // 
            // strip_settings_ML_set
            // 
            strip_settings_ML_set.Name = "strip_settings_ML_set";
            strip_settings_ML_set.Size = new Size(164, 22);
            strip_settings_ML_set.Text = "Set Symbol";
            strip_settings_ML_set.Click += setSymbolToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(944, 681);
            Controls.Add(menuStrip1);
            Controls.Add(main_databox2);
            Controls.Add(main_databox1);
            Controls.Add(main_list);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Money Manager";
            ((System.ComponentModel.ISupportInitialize)main_list).EndInit();
            main_databox1.ResumeLayout(false);
            main_databox1.PerformLayout();
            main_databox2.ResumeLayout(false);
            main_databox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView main_list;
        private Label data_owe;
        private Label main_data5;
        private Label main_data3;
        private Label main_data4;
        private Label main_data2;
        private Label main_data1;
        private GroupBox main_databox1;
        private GroupBox main_databox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem strip_settings;
        private ToolStripMenuItem strip_settings_ML;
        private ToolStripMenuItem strip_settings_ML_text1;
        private ToolStripTextBox strip_settings_ML_textbox1;
        private ToolStripMenuItem strip_settings_ML_set;
        private DataGridViewTextBoxColumn main_list_name;
        private DataGridViewTextBoxColumn main_list_money;
        private DataGridViewTextBoxColumn Main_list_CashCredit;
    }
}