namespace StudentCard
{
    partial class ChairForm
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
            this.userName = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.studComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.watchInfo = new System.Windows.Forms.Button();
            this.watchMarks = new System.Windows.Forms.Button();
            this.semestrComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addStudent = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userName.Location = new System.Drawing.Point(26, 43);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(53, 23);
            this.userName.TabIndex = 1;
            this.userName.Text = "label1";
            // 
            // groupComboBox
            // 
            this.groupComboBox.DropDownWidth = 211;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(29, 115);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(211, 26);
            this.groupComboBox.TabIndex = 2;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // studComboBox
            // 
            this.studComboBox.DropDownWidth = 211;
            this.studComboBox.FormattingEnabled = true;
            this.studComboBox.Location = new System.Drawing.Point(30, 169);
            this.studComboBox.Name = "studComboBox";
            this.studComboBox.Size = new System.Drawing.Size(211, 26);
            this.studComboBox.TabIndex = 3;
            this.studComboBox.SelectedIndexChanged += new System.EventHandler(this.studComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Група";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Студент";
            // 
            // watchInfo
            // 
            this.watchInfo.BackColor = System.Drawing.SystemColors.Control;
            this.watchInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.watchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchInfo.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchInfo.Location = new System.Drawing.Point(29, 211);
            this.watchInfo.Name = "watchInfo";
            this.watchInfo.Size = new System.Drawing.Size(211, 34);
            this.watchInfo.TabIndex = 9;
            this.watchInfo.Text = "Переглянути дані";
            this.watchInfo.UseVisualStyleBackColor = false;
            this.watchInfo.Click += new System.EventHandler(this.watchInfo_Click);
            // 
            // watchMarks
            // 
            this.watchMarks.BackColor = System.Drawing.SystemColors.Control;
            this.watchMarks.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.watchMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchMarks.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchMarks.Location = new System.Drawing.Point(30, 322);
            this.watchMarks.Name = "watchMarks";
            this.watchMarks.Size = new System.Drawing.Size(211, 34);
            this.watchMarks.TabIndex = 10;
            this.watchMarks.Text = "Переглянути оцінки";
            this.watchMarks.UseVisualStyleBackColor = false;
            this.watchMarks.Click += new System.EventHandler(this.watchMarks_Click);
            // 
            // semestrComboBox
            // 
            this.semestrComboBox.DropDownWidth = 211;
            this.semestrComboBox.FormattingEnabled = true;
            this.semestrComboBox.Location = new System.Drawing.Point(31, 277);
            this.semestrComboBox.Name = "semestrComboBox";
            this.semestrComboBox.Size = new System.Drawing.Size(211, 26);
            this.semestrComboBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Семестр";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(29, 615);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(211, 34);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Вихід";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.SystemColors.Control;
            this.saveChanges.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChanges.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChanges.Location = new System.Drawing.Point(29, 500);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(211, 34);
            this.saveChanges.TabIndex = 14;
            this.saveChanges.Text = "Зберегти зміни";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(29, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 100);
            this.label1.TabIndex = 15;
            this.label1.Text = "Увага! Зміни зберігаються тільки для виділеного рядка! Тому після кожних змін у р" +
    "ядку натискайте кнопку \"Зберегти зміни\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addStudent
            // 
            this.addStudent.BackColor = System.Drawing.SystemColors.Control;
            this.addStudent.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudent.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudent.Location = new System.Drawing.Point(29, 551);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(211, 34);
            this.addStudent.TabIndex = 16;
            this.addStudent.Text = "Додати студента до бази";
            this.addStudent.UseVisualStyleBackColor = false;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(710, 692);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(274, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 692);
            this.panel1.TabIndex = 17;
            // 
            // ChairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 692);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.semestrComboBox);
            this.Controls.Add(this.watchMarks);
            this.Controls.Add(this.watchInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studComboBox);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.userName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChairForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KafedraForm";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.ComboBox studComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button watchInfo;
        private System.Windows.Forms.Button watchMarks;
        private System.Windows.Forms.ComboBox semestrComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
    }
}