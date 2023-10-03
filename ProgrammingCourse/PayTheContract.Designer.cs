namespace ProgrammingCourse
{
    partial class PayTheContract
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContractIsPayed = new System.Windows.Forms.TextBox();
            this.txtContractPrice = new System.Windows.Forms.TextBox();
            this.txtContractStudyDuration = new System.Windows.Forms.TextBox();
            this.txtContractSubjectName = new System.Windows.Forms.TextBox();
            this.txtContractDate = new System.Windows.Forms.TextBox();
            this.txtContractNumber = new System.Windows.Forms.TextBox();
            this.txtContractPIB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(219, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть номер контракту";
            // 
            // txtSearchNumber
            // 
            this.txtSearchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchNumber.Location = new System.Drawing.Point(193, 37);
            this.txtSearchNumber.Name = "txtSearchNumber";
            this.txtSearchNumber.Size = new System.Drawing.Size(231, 24);
            this.txtSearchNumber.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(267, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 36);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPay.Location = new System.Drawing.Point(56, 491);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(151, 46);
            this.btnPay.TabIndex = 24;
            this.btnPay.Text = "Сплатити";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtContractIsPayed);
            this.panel1.Controls.Add(this.txtContractPrice);
            this.panel1.Controls.Add(this.txtContractStudyDuration);
            this.panel1.Controls.Add(this.txtContractSubjectName);
            this.panel1.Controls.Add(this.txtContractDate);
            this.panel1.Controls.Add(this.txtContractNumber);
            this.panel1.Controls.Add(this.txtContractPIB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(56, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 353);
            this.panel1.TabIndex = 25;
            // 
            // txtContractIsPayed
            // 
            this.txtContractIsPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContractIsPayed.Location = new System.Drawing.Point(211, 295);
            this.txtContractIsPayed.Name = "txtContractIsPayed";
            this.txtContractIsPayed.ReadOnly = true;
            this.txtContractIsPayed.Size = new System.Drawing.Size(246, 24);
            this.txtContractIsPayed.TabIndex = 29;
            // 
            // txtContractPrice
            // 
            this.txtContractPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContractPrice.Location = new System.Drawing.Point(211, 250);
            this.txtContractPrice.Name = "txtContractPrice";
            this.txtContractPrice.ReadOnly = true;
            this.txtContractPrice.Size = new System.Drawing.Size(246, 24);
            this.txtContractPrice.TabIndex = 28;
            // 
            // txtContractStudyDuration
            // 
            this.txtContractStudyDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContractStudyDuration.Location = new System.Drawing.Point(211, 206);
            this.txtContractStudyDuration.Name = "txtContractStudyDuration";
            this.txtContractStudyDuration.ReadOnly = true;
            this.txtContractStudyDuration.Size = new System.Drawing.Size(246, 24);
            this.txtContractStudyDuration.TabIndex = 27;
            // 
            // txtContractSubjectName
            // 
            this.txtContractSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContractSubjectName.Location = new System.Drawing.Point(211, 163);
            this.txtContractSubjectName.Name = "txtContractSubjectName";
            this.txtContractSubjectName.ReadOnly = true;
            this.txtContractSubjectName.Size = new System.Drawing.Size(246, 24);
            this.txtContractSubjectName.TabIndex = 26;
            // 
            // txtContractDate
            // 
            this.txtContractDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContractDate.Location = new System.Drawing.Point(211, 121);
            this.txtContractDate.Name = "txtContractDate";
            this.txtContractDate.ReadOnly = true;
            this.txtContractDate.Size = new System.Drawing.Size(246, 24);
            this.txtContractDate.TabIndex = 25;
            // 
            // txtContractNumber
            // 
            this.txtContractNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContractNumber.Location = new System.Drawing.Point(211, 76);
            this.txtContractNumber.Name = "txtContractNumber";
            this.txtContractNumber.ReadOnly = true;
            this.txtContractNumber.Size = new System.Drawing.Size(246, 24);
            this.txtContractNumber.TabIndex = 24;
            // 
            // txtContractPIB
            // 
            this.txtContractPIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContractPIB.Location = new System.Drawing.Point(211, 33);
            this.txtContractPIB.Name = "txtContractPIB";
            this.txtContractPIB.ReadOnly = true;
            this.txtContractPIB.Size = new System.Drawing.Size(246, 24);
            this.txtContractPIB.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(36, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Статус контракту";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(36, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Вартість навчання";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(36, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Тривалість навчання";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(36, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Назва курсу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Дата оформлення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Номер контракту";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "ПІБ учня";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(411, 491);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 46);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(233, 491);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(151, 46);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Оновити";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PayTheContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 556);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PayTheContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата контракту";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtContractIsPayed;
        private System.Windows.Forms.TextBox txtContractPrice;
        private System.Windows.Forms.TextBox txtContractStudyDuration;
        private System.Windows.Forms.TextBox txtContractSubjectName;
        private System.Windows.Forms.TextBox txtContractDate;
        private System.Windows.Forms.TextBox txtContractNumber;
        private System.Windows.Forms.TextBox txtContractPIB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReset;
    }
}