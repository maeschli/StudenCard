namespace StudentCard
{
    partial class StudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.Label();
            this.comboSemester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.watchData = new System.Windows.Forms.Button();
            this.printToWord = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.watchInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(692, 590);
            this.dataGridView.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userName.Location = new System.Drawing.Point(26, 18);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(94, 40);
            this.userName.TabIndex = 1;
            this.userName.Text = "label1";
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // comboSemester
            // 
            this.comboSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboSemester.FormattingEnabled = true;
            this.comboSemester.Location = new System.Drawing.Point(29, 127);
            this.comboSemester.Name = "comboSemester";
            this.comboSemester.Size = new System.Drawing.Size(211, 26);
            this.comboSemester.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Семестр:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // watchData
            // 
            this.watchData.BackColor = System.Drawing.SystemColors.Control;
            this.watchData.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.watchData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchData.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchData.Location = new System.Drawing.Point(29, 214);
            this.watchData.Name = "watchData";
            this.watchData.Size = new System.Drawing.Size(211, 30);
            this.watchData.TabIndex = 4;
            this.watchData.Text = "Переглянути оцінки";
            this.watchData.UseVisualStyleBackColor = false;
            this.watchData.Click += new System.EventHandler(this.watchData_Click);
            // 
            // printToWord
            // 
            this.printToWord.BackColor = System.Drawing.SystemColors.Control;
            this.printToWord.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.printToWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printToWord.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printToWord.Location = new System.Drawing.Point(29, 307);
            this.printToWord.Name = "printToWord";
            this.printToWord.Size = new System.Drawing.Size(211, 30);
            this.printToWord.TabIndex = 5;
            this.printToWord.Text = "Вивести у MS Word";
            this.printToWord.UseVisualStyleBackColor = false;
            this.printToWord.Click += new System.EventHandler(this.printToWord_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(29, 560);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(211, 34);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Вихід";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.dataGridView);
            this.gridPanel.Location = new System.Drawing.Point(280, 95);
            this.gridPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(692, 590);
            this.gridPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 1);
            this.panel1.TabIndex = 8;
            // 
            // watchInfo
            // 
            this.watchInfo.BackColor = System.Drawing.SystemColors.Control;
            this.watchInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.watchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchInfo.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchInfo.Location = new System.Drawing.Point(29, 261);
            this.watchInfo.Name = "watchInfo";
            this.watchInfo.Size = new System.Drawing.Size(211, 30);
            this.watchInfo.TabIndex = 9;
            this.watchInfo.Text = "Переглянути інформацію";
            this.watchInfo.UseVisualStyleBackColor = false;
            this.watchInfo.Click += new System.EventHandler(this.watchInfo_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 684);
            this.ControlBox = false;
            this.Controls.Add(this.watchInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.printToWord);
            this.Controls.Add(this.watchData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSemester);
            this.Controls.Add(this.userName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gridPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.ComboBox comboSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button watchData;
        private System.Windows.Forms.Button printToWord;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button watchInfo;
    }
}