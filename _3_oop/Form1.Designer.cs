namespace _3_oop
{
    partial class FlyerName
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
            this.SwimmersName = new System.Windows.Forms.TextBox();
            this.SwimmersAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Label();
            this.ChooseAnimal = new System.Windows.Forms.ComboBox();
            this.Serialize = new System.Windows.Forms.Button();
            this.Deserialize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FlyersCanFly = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Bird = new System.Windows.Forms.Button();
            this.Butterfly = new System.Windows.Forms.Button();
            this.Fox = new System.Windows.Forms.Button();
            this.Snake = new System.Windows.Forms.Button();
            this.Salmon = new System.Windows.Forms.Button();
            this.Dolphin = new System.Windows.Forms.Button();
            this.SwimmersLocation = new System.Windows.Forms.TextBox();
            this.SwimmersSpeed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.WhatDoesTheSay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.WalkersAge = new System.Windows.Forms.TextBox();
            this.WalkersName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.FlyersAge = new System.Windows.Forms.TextBox();
            this.FlyersName = new System.Windows.Forms.TextBox();
            this.WalkersAreal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.WalkerIsWalker = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SwimmersIsFish = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.FlyersWingsQuantity = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this._delete = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.ChangeProp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _Console
            // 
            this._Console.Location = new System.Drawing.Point(12, 12);
            this._Console.Multiline = true;
            this._Console.Name = "_Console";
            this._Console.Size = new System.Drawing.Size(204, 247);
            this._Console.TabIndex = 0;
            this._Console.TextChanged += new System.EventHandler(this._Console_TextChanged);
            // 
            // SwimmersName
            // 
            this.SwimmersName.Location = new System.Drawing.Point(227, 60);
            this.SwimmersName.Name = "SwimmersName";
            this.SwimmersName.Size = new System.Drawing.Size(135, 20);
            this.SwimmersName.TabIndex = 4;
            this.SwimmersName.TextChanged += new System.EventHandler(this._Name_TextChanged);
            // 
            // SwimmersAge
            // 
            this.SwimmersAge.Location = new System.Drawing.Point(227, 99);
            this.SwimmersAge.Name = "SwimmersAge";
            this.SwimmersAge.Size = new System.Drawing.Size(135, 20);
            this.SwimmersAge.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Animal creation";
            // 
            // select
            // 
            this.select.AutoSize = true;
            this.select.Location = new System.Drawing.Point(448, 246);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(69, 13);
            this.select.TabIndex = 9;
            this.select.Text = "Animal select";
            // 
            // ChooseAnimal
            // 
            this.ChooseAnimal.FormattingEnabled = true;
            this.ChooseAnimal.Location = new System.Drawing.Point(446, 267);
            this.ChooseAnimal.Name = "ChooseAnimal";
            this.ChooseAnimal.Size = new System.Drawing.Size(135, 21);
            this.ChooseAnimal.TabIndex = 10;
            this.ChooseAnimal.SelectedIndexChanged += new System.EventHandler(this._Delete_SelectedIndexChanged);
            // 
            // Serialize
            // 
            this.Serialize.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serialize.Location = new System.Drawing.Point(330, 405);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(92, 32);
            this.Serialize.TabIndex = 11;
            this.Serialize.Text = "Serialize";
            this.Serialize.UseVisualStyleBackColor = true;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // Deserialize
            // 
            this.Deserialize.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deserialize.Location = new System.Drawing.Point(485, 405);
            this.Deserialize.Name = "Deserialize";
            this.Deserialize.Size = new System.Drawing.Size(88, 32);
            this.Deserialize.TabIndex = 12;
            this.Deserialize.Text = "Deserialize";
            this.Deserialize.UseVisualStyleBackColor = true;
            this.Deserialize.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Location";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "CanFly ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FlyersCanFly
            // 
            this.FlyersCanFly.FormattingEnabled = true;
            this.FlyersCanFly.Location = new System.Drawing.Point(631, 180);
            this.FlyersCanFly.Name = "FlyersCanFly";
            this.FlyersCanFly.Size = new System.Drawing.Size(71, 21);
            this.FlyersCanFly.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Choose your animal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(553, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "_________________________________________________________________________________" +
    "__________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(553, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "_________________________________________________________________________________" +
    "__________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(453, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "/";
            // 
            // Bird
            // 
            this.Bird.Location = new System.Drawing.Point(621, 316);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(75, 23);
            this.Bird.TabIndex = 22;
            this.Bird.Text = "Bird";
            this.Bird.UseVisualStyleBackColor = true;
            this.Bird.Click += new System.EventHandler(this.Bird_Click);
            // 
            // Butterfly
            // 
            this.Butterfly.Location = new System.Drawing.Point(702, 316);
            this.Butterfly.Name = "Butterfly";
            this.Butterfly.Size = new System.Drawing.Size(75, 23);
            this.Butterfly.TabIndex = 23;
            this.Butterfly.Text = "Butterfly";
            this.Butterfly.UseVisualStyleBackColor = true;
            this.Butterfly.Click += new System.EventHandler(this.Butterfly_Click);
            // 
            // Fox
            // 
            this.Fox.Location = new System.Drawing.Point(443, 315);
            this.Fox.Name = "Fox";
            this.Fox.Size = new System.Drawing.Size(75, 23);
            this.Fox.TabIndex = 24;
            this.Fox.Text = "Fox";
            this.Fox.UseVisualStyleBackColor = true;
            this.Fox.Click += new System.EventHandler(this.Fox_Click);
            // 
            // Snake
            // 
            this.Snake.Location = new System.Drawing.Point(524, 316);
            this.Snake.Name = "Snake";
            this.Snake.Size = new System.Drawing.Size(75, 23);
            this.Snake.TabIndex = 25;
            this.Snake.Text = "Snake";
            this.Snake.UseVisualStyleBackColor = true;
            this.Snake.Click += new System.EventHandler(this.Snake_Click);
            // 
            // Salmon
            // 
            this.Salmon.Location = new System.Drawing.Point(226, 315);
            this.Salmon.Name = "Salmon";
            this.Salmon.Size = new System.Drawing.Size(75, 23);
            this.Salmon.TabIndex = 26;
            this.Salmon.Text = "Salmon";
            this.Salmon.UseVisualStyleBackColor = true;
            this.Salmon.Click += new System.EventHandler(this.Salmon_Click);
            // 
            // Dolphin
            // 
            this.Dolphin.Location = new System.Drawing.Point(307, 315);
            this.Dolphin.Name = "Dolphin";
            this.Dolphin.Size = new System.Drawing.Size(75, 23);
            this.Dolphin.TabIndex = 27;
            this.Dolphin.Text = "Dolphin";
            this.Dolphin.UseVisualStyleBackColor = true;
            this.Dolphin.Click += new System.EventHandler(this.Dolphin_Click);
            // 
            // SwimmersLocation
            // 
            this.SwimmersLocation.Location = new System.Drawing.Point(227, 138);
            this.SwimmersLocation.Name = "SwimmersLocation";
            this.SwimmersLocation.Size = new System.Drawing.Size(135, 20);
            this.SwimmersLocation.TabIndex = 28;
            // 
            // SwimmersSpeed
            // 
            this.SwimmersSpeed.Location = new System.Drawing.Point(225, 223);
            this.SwimmersSpeed.Name = "SwimmersSpeed";
            this.SwimmersSpeed.Size = new System.Drawing.Size(135, 20);
            this.SwimmersSpeed.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Speed";
            // 
            // WhatDoesTheSay
            // 
            this.WhatDoesTheSay.Location = new System.Drawing.Point(447, 223);
            this.WhatDoesTheSay.Name = "WhatDoesTheSay";
            this.WhatDoesTheSay.Size = new System.Drawing.Size(135, 20);
            this.WhatDoesTheSay.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(448, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Whatdoesthe...say";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(448, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Age";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(448, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Name";
            // 
            // WalkersAge
            // 
            this.WalkersAge.Location = new System.Drawing.Point(447, 99);
            this.WalkersAge.Name = "WalkersAge";
            this.WalkersAge.Size = new System.Drawing.Size(135, 20);
            this.WalkersAge.TabIndex = 34;
            // 
            // WalkersName
            // 
            this.WalkersName.Location = new System.Drawing.Point(447, 60);
            this.WalkersName.Name = "WalkersName";
            this.WalkersName.Size = new System.Drawing.Size(135, 20);
            this.WalkersName.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(632, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Age";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(632, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Name";
            // 
            // FlyersAge
            // 
            this.FlyersAge.Location = new System.Drawing.Point(631, 99);
            this.FlyersAge.Name = "FlyersAge";
            this.FlyersAge.Size = new System.Drawing.Size(135, 20);
            this.FlyersAge.TabIndex = 38;
            // 
            // FlyersName
            // 
            this.FlyersName.Location = new System.Drawing.Point(631, 60);
            this.FlyersName.Name = "FlyersName";
            this.FlyersName.Size = new System.Drawing.Size(135, 20);
            this.FlyersName.TabIndex = 37;
            // 
            // WalkersAreal
            // 
            this.WalkersAreal.Location = new System.Drawing.Point(447, 138);
            this.WalkersAreal.Name = "WalkersAreal";
            this.WalkersAreal.Size = new System.Drawing.Size(135, 20);
            this.WalkersAreal.TabIndex = 42;
            this.WalkersAreal.TextChanged += new System.EventHandler(this.WalkersAreal_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(448, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = " ";
            // 
            // WalkerIsWalker
            // 
            this.WalkerIsWalker.FormattingEnabled = true;
            this.WalkerIsWalker.Location = new System.Drawing.Point(447, 180);
            this.WalkerIsWalker.Name = "WalkerIsWalker";
            this.WalkerIsWalker.Size = new System.Drawing.Size(71, 21);
            this.WalkerIsWalker.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(448, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "IsWalker";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(228, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Swimmers";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(448, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Walkers";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(628, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "Flyers";
            // 
            // SwimmersIsFish
            // 
            this.SwimmersIsFish.FormattingEnabled = true;
            this.SwimmersIsFish.Location = new System.Drawing.Point(225, 180);
            this.SwimmersIsFish.Name = "SwimmersIsFish";
            this.SwimmersIsFish.Size = new System.Drawing.Size(71, 21);
            this.SwimmersIsFish.TabIndex = 51;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(226, 161);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 50;
            this.label23.Text = "IsFish";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(448, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 13);
            this.label24.TabIndex = 52;
            this.label24.Text = "Areal";
            // 
            // FlyersWingsQuantity
            // 
            this.FlyersWingsQuantity.Location = new System.Drawing.Point(631, 223);
            this.FlyersWingsQuantity.Name = "FlyersWingsQuantity";
            this.FlyersWingsQuantity.Size = new System.Drawing.Size(135, 20);
            this.FlyersWingsQuantity.TabIndex = 54;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(630, 204);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 13);
            this.label25.TabIndex = 53;
            this.label25.Text = "WingsQuantity";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(225, 286);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(553, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "_________________________________________________________________________________" +
    "__________";
            // 
            // _delete
            // 
            this._delete.Location = new System.Drawing.Point(365, 265);
            this._delete.Name = "_delete";
            this._delete.Size = new System.Drawing.Size(75, 23);
            this._delete.TabIndex = 56;
            this._delete.Text = "delete";
            this._delete.UseVisualStyleBackColor = true;
            this._delete.Click += new System.EventHandler(this._delete_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(587, 267);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 57;
            this.change.Text = "change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // ChangeProp
            // 
            this.ChangeProp.Location = new System.Drawing.Point(12, 286);
            this.ChangeProp.Multiline = true;
            this.ChangeProp.Name = "ChangeProp";
            this.ChangeProp.Size = new System.Drawing.Size(204, 174);
            this.ChangeProp.TabIndex = 58;
            // 
            // FlyerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 478);
            this.Controls.Add(this.ChangeProp);
            this.Controls.Add(this.change);
            this.Controls.Add(this._delete);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.FlyersWingsQuantity);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.SwimmersIsFish);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.WalkerIsWalker);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.WalkersAreal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.FlyersAge);
            this.Controls.Add(this.FlyersName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.WalkersAge);
            this.Controls.Add(this.WalkersName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.WhatDoesTheSay);
            this.Controls.Add(this.SwimmersSpeed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SwimmersLocation);
            this.Controls.Add(this.Dolphin);
            this.Controls.Add(this.Salmon);
            this.Controls.Add(this.Snake);
            this.Controls.Add(this.Fox);
            this.Controls.Add(this.Butterfly);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FlyersCanFly);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Deserialize);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this.ChooseAnimal);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SwimmersAge);
            this.Controls.Add(this.SwimmersName);
            this.Controls.Add(this._Console);
            this.Name = "FlyerName";
            this.Text = "Animal planet";
            this.Load += new System.EventHandler(this.AnimalSpace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _Console;
        private System.Windows.Forms.TextBox SwimmersName;
        private System.Windows.Forms.TextBox SwimmersAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label select;
        private System.Windows.Forms.ComboBox ChooseAnimal;
        private System.Windows.Forms.Button Serialize;
        private System.Windows.Forms.Button Deserialize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FlyersCanFly;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Bird;
        private System.Windows.Forms.Button Butterfly;
        private System.Windows.Forms.Button Fox;
        private System.Windows.Forms.Button Snake;
        private System.Windows.Forms.Button Salmon;
        private System.Windows.Forms.Button Dolphin;
        private System.Windows.Forms.TextBox SwimmersLocation;
        private System.Windows.Forms.TextBox SwimmersSpeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox WhatDoesTheSay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox WalkersAge;
        private System.Windows.Forms.TextBox WalkersName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox FlyersAge;
        private System.Windows.Forms.TextBox FlyersName;
        private System.Windows.Forms.TextBox WalkersAreal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox WalkerIsWalker;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox SwimmersIsFish;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox FlyersWingsQuantity;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button _delete;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox ChangeProp;
    }
}

