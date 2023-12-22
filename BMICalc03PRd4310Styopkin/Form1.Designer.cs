
namespace BMICalc03PRd4310Styopkin
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
            this.logoName = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.man = new System.Windows.Forms.Button();
            this.woman = new System.Windows.Forms.Button();
            this.humanHeight = new System.Windows.Forms.TextBox();
            this.humanWeight = new System.Windows.Forms.TextBox();
            this.humanHeightLabel = new System.Windows.Forms.Label();
            this.humanWeightLabel = new System.Windows.Forms.Label();
            this.answerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.bmiStatus = new System.Windows.Forms.Label();
            this.curBMI = new System.Windows.Forms.Label();
            this.bmiTrack = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.toMap = new System.Windows.Forms.Button();
            this.currentSex = new System.Windows.Forms.PictureBox();
            this.manPicture = new System.Windows.Forms.PictureBox();
            this.womanPicture = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmiTrack)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.womanPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // logoName
            // 
            this.logoName.AutoSize = true;
            this.logoName.BackColor = System.Drawing.Color.Transparent;
            this.logoName.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoName.ForeColor = System.Drawing.SystemColors.Control;
            this.logoName.Location = new System.Drawing.Point(105, 10);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(353, 32);
            this.logoName.TabIndex = 0;
            this.logoName.Text = "MARATHON SKILLS 2023";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 32);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(291, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ИМТ калькулятор";
            // 
            // man
            // 
            this.man.BackColor = System.Drawing.Color.LightGray;
            this.man.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.man.Location = new System.Drawing.Point(3, 114);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(114, 40);
            this.man.TabIndex = 1;
            this.man.Text = "Мужской";
            this.man.UseVisualStyleBackColor = false;
            this.man.Click += new System.EventHandler(this.man_Click);
            // 
            // woman
            // 
            this.woman.BackColor = System.Drawing.Color.LightGray;
            this.woman.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.woman.Location = new System.Drawing.Point(3, 114);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(123, 40);
            this.woman.TabIndex = 4;
            this.woman.Text = "Женский";
            this.woman.UseVisualStyleBackColor = false;
            this.woman.Click += new System.EventHandler(this.woman_Click);
            // 
            // humanHeight
            // 
            this.humanHeight.Location = new System.Drawing.Point(59, 338);
            this.humanHeight.Name = "humanHeight";
            this.humanHeight.Size = new System.Drawing.Size(75, 20);
            this.humanHeight.TabIndex = 5;
            // 
            // humanWeight
            // 
            this.humanWeight.Location = new System.Drawing.Point(59, 373);
            this.humanWeight.Name = "humanWeight";
            this.humanWeight.Size = new System.Drawing.Size(75, 20);
            this.humanWeight.TabIndex = 6;
            // 
            // humanHeightLabel
            // 
            this.humanHeightLabel.AutoSize = true;
            this.humanHeightLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humanHeightLabel.Location = new System.Drawing.Point(9, 337);
            this.humanHeightLabel.Name = "humanHeightLabel";
            this.humanHeightLabel.Size = new System.Drawing.Size(44, 18);
            this.humanHeightLabel.TabIndex = 7;
            this.humanHeightLabel.Text = "Рост";
            // 
            // humanWeightLabel
            // 
            this.humanWeightLabel.AutoSize = true;
            this.humanWeightLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humanWeightLabel.Location = new System.Drawing.Point(9, 373);
            this.humanWeightLabel.Name = "humanWeightLabel";
            this.humanWeightLabel.Size = new System.Drawing.Size(38, 18);
            this.humanWeightLabel.TabIndex = 8;
            this.humanWeightLabel.Text = "Вес";
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.LightGray;
            this.answerButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerButton.Location = new System.Drawing.Point(12, 408);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(109, 27);
            this.answerButton.TabIndex = 9;
            this.answerButton.Text = "Рассчитать";
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.LightGray;
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(142, 408);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 27);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "информация о том, что такое ИМТ,\r\nи как работает калькулятор";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.currentSex);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(455, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(248, 248);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.bmiStatus);
            this.flowLayoutPanel5.Controls.Add(this.curBMI);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(55, 214);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(190, 31);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // bmiStatus
            // 
            this.bmiStatus.AutoSize = true;
            this.bmiStatus.BackColor = System.Drawing.Color.Transparent;
            this.bmiStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmiStatus.Location = new System.Drawing.Point(3, 0);
            this.bmiStatus.Name = "bmiStatus";
            this.bmiStatus.Size = new System.Drawing.Size(140, 31);
            this.bmiStatus.TabIndex = 3;
            this.bmiStatus.Text = "Здоровый";
            this.bmiStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curBMI
            // 
            this.curBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curBMI.Location = new System.Drawing.Point(149, 0);
            this.curBMI.Name = "curBMI";
            this.curBMI.Size = new System.Drawing.Size(38, 28);
            this.curBMI.TabIndex = 2;
            this.curBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bmiTrack
            // 
            this.bmiTrack.Location = new System.Drawing.Point(402, 358);
            this.bmiTrack.Maximum = 40;
            this.bmiTrack.Minimum = 10;
            this.bmiTrack.Name = "bmiTrack";
            this.bmiTrack.Size = new System.Drawing.Size(359, 45);
            this.bmiTrack.TabIndex = 15;
            this.bmiTrack.TabStop = false;
            this.bmiTrack.Value = 19;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(409, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 10);
            this.label5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(516, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 10);
            this.label6.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(575, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 10);
            this.label7.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(648, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 10);
            this.label8.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Недостаточный";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(516, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Здоровый";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(577, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Избыточный";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(674, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ожирение";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(145, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "см";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(148, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "кг";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.manPicture);
            this.flowLayoutPanel2.Controls.Add(this.man);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(9, 163);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(120, 157);
            this.flowLayoutPanel2.TabIndex = 26;
            this.flowLayoutPanel2.Click += new System.EventHandler(this.man_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.womanPicture);
            this.flowLayoutPanel3.Controls.Add(this.woman);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(142, 163);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(129, 157);
            this.flowLayoutPanel3.TabIndex = 27;
            this.flowLayoutPanel3.Click += new System.EventHandler(this.woman_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.flowLayoutPanel4.Controls.Add(this.backButton);
            this.flowLayoutPanel4.Controls.Add(this.logoName);
            this.flowLayoutPanel4.Controls.Add(this.toMap);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(800, 54);
            this.flowLayoutPanel4.TabIndex = 28;
            // 
            // toMap
            // 
            this.toMap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toMap.Location = new System.Drawing.Point(464, 13);
            this.toMap.Name = "toMap";
            this.toMap.Size = new System.Drawing.Size(75, 30);
            this.toMap.TabIndex = 2;
            this.toMap.Text = "к карте";
            this.toMap.UseVisualStyleBackColor = true;
            this.toMap.Click += new System.EventHandler(this.toMap_Click);
            // 
            // currentSex
            // 
            this.currentSex.BackColor = System.Drawing.Color.Transparent;
            this.currentSex.Image = global::BMICalc03PRd4310Styopkin.Properties.Resources.female_icon;
            this.currentSex.Location = new System.Drawing.Point(3, 3);
            this.currentSex.Name = "currentSex";
            this.currentSex.Size = new System.Drawing.Size(242, 205);
            this.currentSex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.currentSex.TabIndex = 1;
            this.currentSex.TabStop = false;
            // 
            // manPicture
            // 
            this.manPicture.Image = global::BMICalc03PRd4310Styopkin.Properties.Resources.male_icon;
            this.manPicture.Location = new System.Drawing.Point(3, 3);
            this.manPicture.Name = "manPicture";
            this.manPicture.Size = new System.Drawing.Size(114, 105);
            this.manPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manPicture.TabIndex = 11;
            this.manPicture.TabStop = false;
            this.manPicture.Click += new System.EventHandler(this.man_Click);
            // 
            // womanPicture
            // 
            this.womanPicture.BackColor = System.Drawing.Color.Transparent;
            this.womanPicture.Image = global::BMICalc03PRd4310Styopkin.Properties.Resources.female_icon;
            this.womanPicture.Location = new System.Drawing.Point(3, 3);
            this.womanPicture.Name = "womanPicture";
            this.womanPicture.Size = new System.Drawing.Size(123, 105);
            this.womanPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.womanPicture.TabIndex = 12;
            this.womanPicture.TabStop = false;
            this.womanPicture.Click += new System.EventHandler(this.woman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bmiTrack);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.humanWeightLabel);
            this.Controls.Add(this.humanHeightLabel);
            this.Controls.Add(this.humanWeight);
            this.Controls.Add(this.humanHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmiTrack)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.womanPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoName;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button man;
        private System.Windows.Forms.Button woman;
        private System.Windows.Forms.TextBox humanHeight;
        private System.Windows.Forms.TextBox humanWeight;
        private System.Windows.Forms.Label humanHeightLabel;
        private System.Windows.Forms.Label humanWeightLabel;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox manPicture;
        private System.Windows.Forms.PictureBox womanPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox currentSex;
        private System.Windows.Forms.TrackBar bmiTrack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label bmiStatus;
        private System.Windows.Forms.Label curBMI;
        private System.Windows.Forms.Button toMap;
    }
}

