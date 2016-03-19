namespace _3_oop
{
    partial class DrugSpace
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._Console = new System.Windows.Forms.TextBox();
            this._List = new System.Windows.Forms.ComboBox();
            this.listAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._Delete = new System.Windows.Forms.ComboBox();
            this.Serialize = new System.Windows.Forms.Button();
            this.Deserialize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._Bool = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _Console
            // 
            this._Console.Location = new System.Drawing.Point(12, 12);
            this._Console.Multiline = true;
            this._Console.Name = "_Console";
            this._Console.Size = new System.Drawing.Size(271, 309);
            this._Console.TabIndex = 0;
            // 
            // _List
            // 
            this._List.FormattingEnabled = true;
            this._List.Location = new System.Drawing.Point(287, 215);
            this._List.Name = "_List";
            this._List.Size = new System.Drawing.Size(135, 21);
            this._List.TabIndex = 2;
            // 
            // listAll
            // 
            this.listAll.Location = new System.Drawing.Point(13, 327);
            this.listAll.Name = "listAll";
            this.listAll.Size = new System.Drawing.Size(270, 23);
            this.listAll.TabIndex = 3;
            this.listAll.Text = "listAll";
            this.listAll.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(288, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Drug Creation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Drug Removal";
            // 
            // _Delete
            // 
            this._Delete.FormattingEnabled = true;
            this._Delete.Location = new System.Drawing.Point(287, 271);
            this._Delete.Name = "_Delete";
            this._Delete.Size = new System.Drawing.Size(135, 21);
            this._Delete.TabIndex = 10;
            // 
            // Serialize
            // 
            this.Serialize.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serialize.Location = new System.Drawing.Point(330, 307);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(92, 23);
            this.Serialize.TabIndex = 11;
            this.Serialize.Text = "Serialize";
            this.Serialize.UseVisualStyleBackColor = true;
            // 
            // Deserialize
            // 
            this.Deserialize.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deserialize.Location = new System.Drawing.Point(485, 307);
            this.Deserialize.Name = "Deserialize";
            this.Deserialize.Size = new System.Drawing.Size(88, 23);
            this.Deserialize.TabIndex = 12;
            this.Deserialize.Text = "Deserialize";
            this.Deserialize.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Reciept";
            // 
            // _Bool
            // 
            this._Bool.FormattingEnabled = true;
            this._Bool.Location = new System.Drawing.Point(288, 173);
            this._Bool.Name = "_Bool";
            this._Bool.Size = new System.Drawing.Size(71, 21);
            this._Bool.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Choose your drug";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "______________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(331, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "______________________________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(453, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "/";
            // 
            // DrugSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 362);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._Bool);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Deserialize);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this._Delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listAll);
            this.Controls.Add(this._List);
            this.Controls.Add(this._Console);
            this.Name = "DrugSpace";
            this.Text = "DrugSpace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _Console;
        private System.Windows.Forms.ComboBox _List;
        private System.Windows.Forms.Button listAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _Delete;
        private System.Windows.Forms.Button Serialize;
        private System.Windows.Forms.Button Deserialize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _Bool;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

