namespace FctTestSubject
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
            this.factoryNumDrop = new System.Windows.Forms.NumericUpDown();
            this.productHourNumDrop = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.mNumDrop = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.warehouseProgBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelWarehouseNum = new System.Windows.Forms.Label();
            this.statsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.factoryNumDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productHourNumDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // factoryNumDrop
            // 
            this.factoryNumDrop.Location = new System.Drawing.Point(187, 144);
            this.factoryNumDrop.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.factoryNumDrop.Name = "factoryNumDrop";
            this.factoryNumDrop.Size = new System.Drawing.Size(120, 23);
            this.factoryNumDrop.TabIndex = 0;
            this.factoryNumDrop.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // productHourNumDrop
            // 
            this.productHourNumDrop.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.productHourNumDrop.Location = new System.Drawing.Point(187, 171);
            this.productHourNumDrop.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.productHourNumDrop.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.productHourNumDrop.Name = "productHourNumDrop";
            this.productHourNumDrop.Size = new System.Drawing.Size(120, 23);
            this.productHourNumDrop.TabIndex = 1;
            this.productHourNumDrop.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Factories";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(30, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Products in Hour";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(176, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Stop and Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mNumDrop
            // 
            this.mNumDrop.Location = new System.Drawing.Point(187, 206);
            this.mNumDrop.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.mNumDrop.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.mNumDrop.Name = "mNumDrop";
            this.mNumDrop.Size = new System.Drawing.Size(120, 23);
            this.mNumDrop.TabIndex = 6;
            this.mNumDrop.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "M";
            // 
            // warehouseProgBar
            // 
            this.warehouseProgBar.Location = new System.Drawing.Point(30, 74);
            this.warehouseProgBar.Name = "warehouseProgBar";
            this.warehouseProgBar.Size = new System.Drawing.Size(286, 27);
            this.warehouseProgBar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(82, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Warehouse fullness";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 201);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(433, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Events";
            // 
            // labelWarehouseNum
            // 
            this.labelWarehouseNum.AutoSize = true;
            this.labelWarehouseNum.BackColor = System.Drawing.Color.Transparent;
            this.labelWarehouseNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarehouseNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarehouseNum.Location = new System.Drawing.Point(146, 104);
            this.labelWarehouseNum.Name = "labelWarehouseNum";
            this.labelWarehouseNum.Size = new System.Drawing.Size(24, 27);
            this.labelWarehouseNum.TabIndex = 12;
            this.labelWarehouseNum.Text = "0";
            // 
            // statsTextBox
            // 
            this.statsTextBox.Location = new System.Drawing.Point(162, 326);
            this.statsTextBox.Multiline = true;
            this.statsTextBox.Name = "statsTextBox";
            this.statsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statsTextBox.Size = new System.Drawing.Size(382, 201);
            this.statsTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(307, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Statistics";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 539);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statsTextBox);
            this.Controls.Add(this.labelWarehouseNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.warehouseProgBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mNumDrop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productHourNumDrop);
            this.Controls.Add(this.factoryNumDrop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.factoryNumDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productHourNumDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown factoryNumDrop;
        private NumericUpDown productHourNumDrop;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private NumericUpDown mNumDrop;
        private Label label3;
        private ProgressBar warehouseProgBar;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label labelWarehouseNum;
        private TextBox statsTextBox;
        private Label label6;
    }
}