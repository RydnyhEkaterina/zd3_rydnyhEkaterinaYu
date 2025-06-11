
namespace zd3_Rydnyh
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBel = new System.Windows.Forms.TextBox();
            this.textBoxYg = new System.Windows.Forms.TextBox();
            this.textBoxKal = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAddKal = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonFil = new System.Windows.Forms.Button();
            this.buttonFilDel = new System.Windows.Forms.Button();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(41, 92);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Введите название продукта";
            // 
            // textBoxBel
            // 
            this.textBoxBel.Location = new System.Drawing.Point(41, 118);
            this.textBoxBel.Name = "textBoxBel";
            this.textBoxBel.Size = new System.Drawing.Size(191, 20);
            this.textBoxBel.TabIndex = 2;
            this.textBoxBel.Text = "Введите кол-во белков";
            // 
            // textBoxYg
            // 
            this.textBoxYg.Location = new System.Drawing.Point(41, 144);
            this.textBoxYg.Name = "textBoxYg";
            this.textBoxYg.Size = new System.Drawing.Size(191, 20);
            this.textBoxYg.TabIndex = 3;
            this.textBoxYg.Text = "Введите кол-во углеводов";
            // 
            // textBoxKal
            // 
            this.textBoxKal.Location = new System.Drawing.Point(41, 170);
            this.textBoxKal.Name = "textBoxKal";
            this.textBoxKal.Size = new System.Drawing.Size(191, 20);
            this.textBoxKal.TabIndex = 4;
            this.textBoxKal.Text = "Введите калорийность продукта";
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.Location = new System.Drawing.Point(41, 196);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(178, 24);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить продукт";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAddKal
            // 
            this.buttonAddKal.AutoSize = true;
            this.buttonAddKal.Location = new System.Drawing.Point(41, 226);
            this.buttonAddKal.Name = "buttonAddKal";
            this.buttonAddKal.Size = new System.Drawing.Size(178, 24);
            this.buttonAddKal.TabIndex = 6;
            this.buttonAddKal.Text = "Добавить продукт с калориями";
            this.buttonAddKal.UseVisualStyleBackColor = true;
            this.buttonAddKal.Click += new System.EventHandler(this.buttonAddKal_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.AutoSize = true;
            this.buttonDel.Location = new System.Drawing.Point(41, 256);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(178, 24);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить продукт";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonFil
            // 
            this.buttonFil.AutoSize = true;
            this.buttonFil.Location = new System.Drawing.Point(41, 317);
            this.buttonFil.Name = "buttonFil";
            this.buttonFil.Size = new System.Drawing.Size(178, 24);
            this.buttonFil.TabIndex = 8;
            this.buttonFil.Text = "Отфильтровать список";
            this.buttonFil.UseVisualStyleBackColor = true;
            this.buttonFil.Click += new System.EventHandler(this.buttonFil_Click);
            // 
            // buttonFilDel
            // 
            this.buttonFilDel.AutoSize = true;
            this.buttonFilDel.Location = new System.Drawing.Point(41, 347);
            this.buttonFilDel.Name = "buttonFilDel";
            this.buttonFilDel.Size = new System.Drawing.Size(178, 24);
            this.buttonFilDel.TabIndex = 9;
            this.buttonFilDel.Text = "Убрать фильтрацию";
            this.buttonFilDel.UseVisualStyleBackColor = true;
            this.buttonFilDel.Click += new System.EventHandler(this.buttonFilDel_Click);
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(41, 291);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(178, 20);
            this.textBoxQ.TabIndex = 10;
            this.textBoxQ.Text = "Введите Q или Qp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 279);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.buttonFilDel);
            this.Controls.Add(this.buttonFil);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAddKal);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxKal);
            this.Controls.Add(this.textBoxYg);
            this.Controls.Add(this.textBoxBel);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBel;
        private System.Windows.Forms.TextBox textBoxYg;
        private System.Windows.Forms.TextBox textBoxKal;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAddKal;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonFil;
        private System.Windows.Forms.Button buttonFilDel;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

