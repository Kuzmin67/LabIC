namespace lbl11
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
            this.rt_CI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_CC = new System.Windows.Forms.TextBox();
            this.tb_CN = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rt_CI
            // 
            this.rt_CI.Location = new System.Drawing.Point(9, 177);
            this.rt_CI.Name = "rt_CI";
            this.rt_CI.Size = new System.Drawing.Size(76, 20);
            this.rt_CI.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Стоимость";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(237, 303);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(152, 19);
            this.btn_Create.TabIndex = 25;
            this.btn_Create.Text = "Добавить строку в таблицу";
            this.btn_Create.UseVisualStyleBackColor = true;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(237, 280);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(152, 19);
            this.btn_Change.TabIndex = 24;
            this.btn_Change.Text = "Изменить данные";
            this.btn_Change.UseVisualStyleBackColor = true;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(237, 257);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(152, 19);
            this.btn_Del.TabIndex = 23;
            this.btn_Del.Text = "Удалить строку в таблице";
            this.btn_Del.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Производитель ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Название Видеокарты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Код";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 19);
            this.button1.TabIndex = 19;
            this.button1.Text = "Отобразить бд Видеокарты";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_CC
            // 
            this.tb_CC.Location = new System.Drawing.Point(9, 139);
            this.tb_CC.Margin = new System.Windows.Forms.Padding(2);
            this.tb_CC.Name = "tb_CC";
            this.tb_CC.Size = new System.Drawing.Size(76, 20);
            this.tb_CC.TabIndex = 18;
            // 
            // tb_CN
            // 
            this.tb_CN.Location = new System.Drawing.Point(9, 102);
            this.tb_CN.Margin = new System.Windows.Forms.Padding(2);
            this.tb_CN.Name = "tb_CN";
            this.tb_CN.Size = new System.Drawing.Size(76, 20);
            this.tb_CN.TabIndex = 17;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(9, 65);
            this.tb_Id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(76, 20);
            this.tb_Id.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(421, 228);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 354);
            this.Controls.Add(this.rt_CI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_CC);
            this.Controls.Add(this.tb_CN);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Бд Видеокарты";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rt_CI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_CC;
        private System.Windows.Forms.TextBox tb_CN;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

