
namespace TradingСalculator
{
    partial class MainForm
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
            this.CurrentOreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BasedPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOreTextBox = new System.Windows.Forms.TextBox();
            this.CalcOreButton = new System.Windows.Forms.Button();
            this.TextWindow = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BasedOreTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MinusCoinTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.LeatherMaxTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LeatherPriceReductionTextBox = new System.Windows.Forms.TextBox();
            this.LeatherBasedPriceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LeatherCurrentMountTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LeatherAddTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LeatherPriceTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LeatherCalcButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentOreTextBox
            // 
            this.CurrentOreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentOreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentOreTextBox.Location = new System.Drawing.Point(205, 99);
            this.CurrentOreTextBox.Name = "CurrentOreTextBox";
            this.CurrentOreTextBox.Size = new System.Drawing.Size(147, 29);
            this.CurrentOreTextBox.TabIndex = 4;
            this.CurrentOreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentOreTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(205, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во руды сейчас";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Базовая цена до X руды";
            // 
            // BasedPriceTextBox
            // 
            this.BasedPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BasedPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BasedPriceTextBox.Location = new System.Drawing.Point(205, 36);
            this.BasedPriceTextBox.Name = "BasedPriceTextBox";
            this.BasedPriceTextBox.Size = new System.Drawing.Size(147, 29);
            this.BasedPriceTextBox.TabIndex = 3;
            this.BasedPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BasedPriceTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(205, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кол-во принесенной";
            // 
            // AddOreTextBox
            // 
            this.AddOreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddOreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOreTextBox.Location = new System.Drawing.Point(205, 153);
            this.AddOreTextBox.Name = "AddOreTextBox";
            this.AddOreTextBox.Size = new System.Drawing.Size(147, 29);
            this.AddOreTextBox.TabIndex = 5;
            this.AddOreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddOreTextBox_KeyPress);
            // 
            // CalcOreButton
            // 
            this.CalcOreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CalcOreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalcOreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcOreButton.Location = new System.Drawing.Point(8, 140);
            this.CalcOreButton.Name = "CalcOreButton";
            this.CalcOreButton.Size = new System.Drawing.Size(147, 32);
            this.CalcOreButton.TabIndex = 6;
            this.CalcOreButton.Text = "Рассчитать";
            this.CalcOreButton.UseVisualStyleBackColor = false;
            this.CalcOreButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextWindow
            // 
            this.TextWindow.BackColor = System.Drawing.Color.Black;
            this.TextWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TextWindow.Location = new System.Drawing.Point(12, 217);
            this.TextWindow.Name = "TextWindow";
            this.TextWindow.Size = new System.Drawing.Size(555, 233);
            this.TextWindow.TabIndex = 7;
            this.TextWindow.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(394, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Итого";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTextBox.Enabled = false;
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTextBox.Location = new System.Drawing.Point(394, 99);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(147, 29);
            this.PriceTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кол-во до падения";
            // 
            // BasedOreTextBox
            // 
            this.BasedOreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BasedOreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BasedOreTextBox.Location = new System.Drawing.Point(8, 36);
            this.BasedOreTextBox.Name = "BasedOreTextBox";
            this.BasedOreTextBox.Size = new System.Drawing.Size(147, 29);
            this.BasedOreTextBox.TabIndex = 1;
            this.BasedOreTextBox.Text = "10000";
            this.BasedOreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BasedOreTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Падение каждые";
            // 
            // MinusCoinTextBox
            // 
            this.MinusCoinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinusCoinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusCoinTextBox.Location = new System.Drawing.Point(8, 99);
            this.MinusCoinTextBox.Name = "MinusCoinTextBox";
            this.MinusCoinTextBox.Size = new System.Drawing.Size(147, 29);
            this.MinusCoinTextBox.TabIndex = 2;
            this.MinusCoinTextBox.Text = "2000";
            this.MinusCoinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinusCoinTextBox_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 220);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.PriceTextBox);
            this.tabPage1.Controls.Add(this.MinusCoinTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CurrentOreTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.BasedPriceTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.AddOreTextBox);
            this.tabPage1.Controls.Add(this.BasedOreTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.CalcOreButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Руда";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.LeatherCalcButton);
            this.tabPage2.Controls.Add(this.LeatherPriceTextBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.LeatherAddTextBox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.LeatherCurrentMountTextBox);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.LeatherBasedPriceTextBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.LeatherPriceReductionTextBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.LeatherMaxTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Кожа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Кол-во до падения";
            // 
            // LeatherMaxTextBox
            // 
            this.LeatherMaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeatherMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeatherMaxTextBox.Location = new System.Drawing.Point(8, 36);
            this.LeatherMaxTextBox.Name = "LeatherMaxTextBox";
            this.LeatherMaxTextBox.Size = new System.Drawing.Size(147, 29);
            this.LeatherMaxTextBox.TabIndex = 9;
            this.LeatherMaxTextBox.Text = "800";
            this.LeatherMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeatherMaxTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Падение каждые";
            // 
            // LeatherPriceReductionTextBox
            // 
            this.LeatherPriceReductionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeatherPriceReductionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeatherPriceReductionTextBox.Location = new System.Drawing.Point(8, 99);
            this.LeatherPriceReductionTextBox.Name = "LeatherPriceReductionTextBox";
            this.LeatherPriceReductionTextBox.Size = new System.Drawing.Size(147, 29);
            this.LeatherPriceReductionTextBox.TabIndex = 11;
            this.LeatherPriceReductionTextBox.Text = "50";
            this.LeatherPriceReductionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeatherPriceReductionTextBox_KeyPress);
            // 
            // LeatherBasedPriceTextBox
            // 
            this.LeatherBasedPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeatherBasedPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeatherBasedPriceTextBox.Location = new System.Drawing.Point(205, 36);
            this.LeatherBasedPriceTextBox.Name = "LeatherBasedPriceTextBox";
            this.LeatherBasedPriceTextBox.Size = new System.Drawing.Size(147, 29);
            this.LeatherBasedPriceTextBox.TabIndex = 13;
            this.LeatherBasedPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeatherBasedPriceTextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(205, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Базовая цена до X кожи";
            // 
            // LeatherCurrentMountTextBox
            // 
            this.LeatherCurrentMountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeatherCurrentMountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeatherCurrentMountTextBox.Location = new System.Drawing.Point(205, 99);
            this.LeatherCurrentMountTextBox.Name = "LeatherCurrentMountTextBox";
            this.LeatherCurrentMountTextBox.Size = new System.Drawing.Size(147, 29);
            this.LeatherCurrentMountTextBox.TabIndex = 16;
            this.LeatherCurrentMountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeatherCurrentMountTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(205, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Кол-во кожи сейчас";
            // 
            // LeatherAddTextBox
            // 
            this.LeatherAddTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeatherAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeatherAddTextBox.Location = new System.Drawing.Point(205, 153);
            this.LeatherAddTextBox.Name = "LeatherAddTextBox";
            this.LeatherAddTextBox.Size = new System.Drawing.Size(147, 29);
            this.LeatherAddTextBox.TabIndex = 17;
            this.LeatherAddTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeatherAddTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(205, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Кол-во принесенной";
            // 
            // LeatherPriceTextBox
            // 
            this.LeatherPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeatherPriceTextBox.Enabled = false;
            this.LeatherPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeatherPriceTextBox.Location = new System.Drawing.Point(394, 99);
            this.LeatherPriceTextBox.Name = "LeatherPriceTextBox";
            this.LeatherPriceTextBox.Size = new System.Drawing.Size(147, 29);
            this.LeatherPriceTextBox.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(394, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Итого";
            // 
            // LeatherCalcButton
            // 
            this.LeatherCalcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LeatherCalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LeatherCalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeatherCalcButton.Location = new System.Drawing.Point(8, 140);
            this.LeatherCalcButton.Name = "LeatherCalcButton";
            this.LeatherCalcButton.Size = new System.Drawing.Size(147, 32);
            this.LeatherCalcButton.TabIndex = 21;
            this.LeatherCalcButton.Text = "Рассчитать";
            this.LeatherCalcButton.UseVisualStyleBackColor = false;
            this.LeatherCalcButton.Click += new System.EventHandler(this.LeatherCalcButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TextWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Динамический калькулятор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Closed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentOreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BasedPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddOreTextBox;
        private System.Windows.Forms.Button CalcOreButton;
        private System.Windows.Forms.RichTextBox TextWindow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BasedOreTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MinusCoinTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox LeatherAddTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LeatherCurrentMountTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LeatherBasedPriceTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LeatherPriceReductionTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LeatherMaxTextBox;
        private System.Windows.Forms.Button LeatherCalcButton;
        private System.Windows.Forms.TextBox LeatherPriceTextBox;
        private System.Windows.Forms.Label label12;
    }
}

