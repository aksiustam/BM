namespace _153301021_bm
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Hesapla = new System.Windows.Forms.Button();
            this.numericUpDown_miktar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_hassaslik = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_kirlilik = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_deterjan = new System.Windows.Forms.Label();
            this.label_sure = new System.Windows.Forms.Label();
            this.label_donusHizi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hassaslik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kirlilik)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Hesapla);
            this.groupBox3.Controls.Add(this.numericUpDown_miktar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDown_hassaslik);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numericUpDown_kirlilik);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 120);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Değer";
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(225, 26);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(104, 79);
            this.Hesapla.TabIndex = 2;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // numericUpDown_miktar
            // 
            this.numericUpDown_miktar.DecimalPlaces = 2;
            this.numericUpDown_miktar.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown_miktar.Location = new System.Drawing.Point(105, 85);
            this.numericUpDown_miktar.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_miktar.Name = "numericUpDown_miktar";
            this.numericUpDown_miktar.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown_miktar.TabIndex = 0;
            this.numericUpDown_miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_miktar.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Miktar";
            // 
            // numericUpDown_hassaslik
            // 
            this.numericUpDown_hassaslik.DecimalPlaces = 2;
            this.numericUpDown_hassaslik.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown_hassaslik.Location = new System.Drawing.Point(105, 26);
            this.numericUpDown_hassaslik.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_hassaslik.Name = "numericUpDown_hassaslik";
            this.numericUpDown_hassaslik.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown_hassaslik.TabIndex = 0;
            this.numericUpDown_hassaslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_hassaslik.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kirlilik";
            // 
            // numericUpDown_kirlilik
            // 
            this.numericUpDown_kirlilik.DecimalPlaces = 2;
            this.numericUpDown_kirlilik.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown_kirlilik.Location = new System.Drawing.Point(105, 56);
            this.numericUpDown_kirlilik.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_kirlilik.Name = "numericUpDown_kirlilik";
            this.numericUpDown_kirlilik.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown_kirlilik.TabIndex = 0;
            this.numericUpDown_kirlilik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_kirlilik.Value = new decimal(new int[] {
            39,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hassaslik";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_deterjan);
            this.groupBox1.Controls.Add(this.label_sure);
            this.groupBox1.Controls.Add(this.label_donusHizi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(357, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ağırlıklı Ortalama";
            // 
            // label_deterjan
            // 
            this.label_deterjan.BackColor = System.Drawing.SystemColors.Control;
            this.label_deterjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_deterjan.Location = new System.Drawing.Point(130, 95);
            this.label_deterjan.Name = "label_deterjan";
            this.label_deterjan.Size = new System.Drawing.Size(150, 20);
            this.label_deterjan.TabIndex = 2;
            this.label_deterjan.Text = "Deterjan";
            this.label_deterjan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_sure
            // 
            this.label_sure.BackColor = System.Drawing.SystemColors.Control;
            this.label_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sure.Location = new System.Drawing.Point(130, 61);
            this.label_sure.Name = "label_sure";
            this.label_sure.Size = new System.Drawing.Size(150, 20);
            this.label_sure.TabIndex = 3;
            this.label_sure.Text = "Süre";
            this.label_sure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_donusHizi
            // 
            this.label_donusHizi.BackColor = System.Drawing.SystemColors.Control;
            this.label_donusHizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_donusHizi.Location = new System.Drawing.Point(130, 26);
            this.label_donusHizi.Name = "label_donusHizi";
            this.label_donusHizi.Size = new System.Drawing.Size(150, 20);
            this.label_donusHizi.TabIndex = 4;
            this.label_donusHizi.Text = "Dönüş Hızı";
            this.label_donusHizi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Deterjan Miktarı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Süre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dönüş Hızı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(660, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 120);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mamdani";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 95);
            this.listBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(32, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 15;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(744, 429);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hassaslik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kirlilik)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.NumericUpDown numericUpDown_miktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_hassaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_kirlilik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_deterjan;
        private System.Windows.Forms.Label label_sure;
        private System.Windows.Forms.Label label_donusHizi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        
    }
}

