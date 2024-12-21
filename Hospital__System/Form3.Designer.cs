namespace Hospital__System
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Recptionists = new System.Windows.Forms.Label();
            this.Laboratory = new System.Windows.Forms.Label();
            this.Doctors = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.TextBox();
            this.PGen = new System.Windows.Forms.ComboBox();
            this.PDOB = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PAdd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Pphone = new System.Windows.Forms.TextBox();
            this.PHIV = new System.Windows.Forms.ComboBox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // Recptionists
            // 
            this.Recptionists.AutoSize = true;
            this.Recptionists.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recptionists.ForeColor = System.Drawing.Color.White;
            this.Recptionists.Location = new System.Drawing.Point(63, 361);
            this.Recptionists.Name = "Recptionists";
            this.Recptionists.Size = new System.Drawing.Size(157, 29);
            this.Recptionists.TabIndex = 9;
            this.Recptionists.Text = "Recptionists";
            this.Recptionists.Click += new System.EventHandler(this.label10_Click);
            // 
            // Laboratory
            // 
            this.Laboratory.AutoSize = true;
            this.Laboratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laboratory.ForeColor = System.Drawing.Color.White;
            this.Laboratory.Location = new System.Drawing.Point(63, 240);
            this.Laboratory.Name = "Laboratory";
            this.Laboratory.Size = new System.Drawing.Size(137, 29);
            this.Laboratory.TabIndex = 7;
            this.Laboratory.Text = "Laboratory";
            this.Laboratory.Click += new System.EventHandler(this.label9_Click);
            // 
            // Doctors
            // 
            this.Doctors.AutoSize = true;
            this.Doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctors.ForeColor = System.Drawing.Color.White;
            this.Doctors.Location = new System.Drawing.Point(64, 140);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(103, 29);
            this.Doctors.TabIndex = 5;
            this.Doctors.Text = "Doctors";
            this.Doctors.Click += new System.EventHandler(this.label8_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.Recptionists);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.Laboratory);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.Doctors);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 698);
            this.panel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(64, 609);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 29);
            this.label11.TabIndex = 13;
            this.label11.Text = "Logout";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::Hospital__System.Properties.Resources.logout;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Location = new System.Drawing.Point(12, 596);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(45, 41);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::Hospital__System.Properties.Resources.medical_receptionist_icon_beautiful_meticulously_designed_vector_stock_178754093;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Location = new System.Drawing.Point(12, 352);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(45, 41);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Hospital__System.Properties.Resources.lab_icon_png_16;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Location = new System.Drawing.Point(12, 231);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(45, 41);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Hospital__System.Properties.Resources._360_F_229531197_jmFcViuzXaYOQdoOK1qyg7uIGdnuKhpt;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(12, 133);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 41);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(266, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Patient Name";
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(269, 140);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(182, 22);
            this.PName.TabIndex = 5;
            // 
            // PGen
            // 
            this.PGen.FormattingEnabled = true;
            this.PGen.Items.AddRange(new object[] {
            "male",
            "female"});
            this.PGen.Location = new System.Drawing.Point(550, 140);
            this.PGen.Name = "PGen";
            this.PGen.Size = new System.Drawing.Size(90, 24);
            this.PGen.TabIndex = 7;
            this.PGen.Text = "Gender";
            // 
            // PDOB
            // 
            this.PDOB.BackColor = System.Drawing.Color.SeaGreen;
            this.PDOB.BorderRadius = 0;
            this.PDOB.ForeColor = System.Drawing.Color.White;
            this.PDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PDOB.FormatCustom = null;
            this.PDOB.Location = new System.Drawing.Point(269, 198);
            this.PDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PDOB.Name = "PDOB";
            this.PDOB.Size = new System.Drawing.Size(182, 26);
            this.PDOB.TabIndex = 8;
            this.PDOB.Value = new System.DateTime(2022, 5, 21, 17, 57, 27, 860);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "DOB";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1109, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 25);
            this.label14.TabIndex = 11;
            this.label14.Text = "Address";
            // 
            // PAdd
            // 
            this.PAdd.Location = new System.Drawing.Point(1112, 147);
            this.PAdd.Name = "PAdd";
            this.PAdd.Size = new System.Drawing.Size(182, 22);
            this.PAdd.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(855, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 25);
            this.label15.TabIndex = 13;
            this.label15.Text = "phone";
            // 
            // Pphone
            // 
            this.Pphone.Location = new System.Drawing.Point(858, 147);
            this.Pphone.Name = "Pphone";
            this.Pphone.Size = new System.Drawing.Size(182, 22);
            this.Pphone.TabIndex = 12;
            // 
            // PHIV
            // 
            this.PHIV.FormattingEnabled = true;
            this.PHIV.Items.AddRange(new object[] {
            "Positive ",
            "Negative"});
            this.PHIV.Location = new System.Drawing.Point(715, 133);
            this.PHIV.Name = "PHIV";
            this.PHIV.Size = new System.Drawing.Size(90, 24);
            this.PHIV.TabIndex = 20;
            this.PHIV.Text = "HIV";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gunaDataGridView1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(316, 328);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(898, 358);
            this.gunaDataGridView1.TabIndex = 59;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(666, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 60;
            this.label1.Text = "Patient";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Hospital__System.Properties.Resources.download1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(535, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 81);
            this.pictureBox4.TabIndex = 61;
            this.pictureBox4.TabStop = false;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Edit";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Green;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(659, 263);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(175, 37);
            this.bunifuThinButton23.TabIndex = 18;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Add";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(391, 263);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(175, 37);
            this.bunifuThinButton22.TabIndex = 17;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Delete";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(893, 263);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(175, 37);
            this.bunifuThinButton21.TabIndex = 16;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::Hospital__System.Properties.Resources.close_icon_12;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(1260, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(34, 36);
            this.pictureBox9.TabIndex = 62;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1299, 698);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.PHIV);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Pphone);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PDOB);
            this.Controls.Add(this.PGen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Recptionists;
        private System.Windows.Forms.Label Laboratory;
        private System.Windows.Forms.Label Doctors;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.ComboBox PGen;
        private Bunifu.Framework.UI.BunifuDatepicker PDOB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Pphone;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.ComboBox PHIV;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}