namespace StudentCard
{
    partial class DeanForm
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
            this.userName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.semestrComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.watchStMarks = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.watchInfo = new System.Windows.Forms.Button();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userName.Location = new System.Drawing.Point(26, 30);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(79, 33);
            this.userName.TabIndex = 2;
            this.userName.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Семестр";
            // 
            // semestrComboBox
            // 
            this.semestrComboBox.FormattingEnabled = true;
            this.semestrComboBox.Location = new System.Drawing.Point(30, 243);
            this.semestrComboBox.Name = "semestrComboBox";
            this.semestrComboBox.Size = new System.Drawing.Size(211, 26);
            this.semestrComboBox.TabIndex = 12;
            this.semestrComboBox.SelectedIndexChanged += new System.EventHandler(this.semestrComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Студент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Група";
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(31, 185);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(211, 26);
            this.studentComboBox.TabIndex = 9;
            this.studentComboBox.SelectedIndexChanged += new System.EventHandler(this.studentComboBox_SelectedIndexChanged);
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(30, 127);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(211, 26);
            this.groupComboBox.TabIndex = 8;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // watchStMarks
            // 
            this.watchStMarks.BackColor = System.Drawing.SystemColors.Control;
            this.watchStMarks.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.watchStMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchStMarks.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchStMarks.Location = new System.Drawing.Point(30, 341);
            this.watchStMarks.Name = "watchStMarks";
            this.watchStMarks.Size = new System.Drawing.Size(211, 30);
            this.watchStMarks.TabIndex = 14;
            this.watchStMarks.Text = "Переглянути оцінки";
            this.watchStMarks.UseVisualStyleBackColor = false;
            this.watchStMarks.Click += new System.EventHandler(this.watchStMarks_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(30, 514);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(211, 34);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Вихід";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 1);
            this.panel1.TabIndex = 17;
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.dataGridView);
            this.gridPanel.Location = new System.Drawing.Point(280, 95);
            this.gridPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(692, 590);
            this.gridPanel.TabIndex = 16;
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
            // watchInfo
            // 
            this.watchInfo.BackColor = System.Drawing.SystemColors.Control;
            this.watchInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.watchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchInfo.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchInfo.Location = new System.Drawing.Point(30, 387);
            this.watchInfo.Name = "watchInfo";
            this.watchInfo.Size = new System.Drawing.Size(211, 30);
            this.watchInfo.TabIndex = 18;
            this.watchInfo.Text = "Переглянути інформацію";
            this.watchInfo.UseVisualStyleBackColor = false;
            this.watchInfo.Click += new System.EventHandler(this.watchInfo_Click);
            // 
            // DeanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 692);
            this.ControlBox = false;
            this.Controls.Add(this.watchInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.watchStMarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.semestrComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentComboBox);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.userName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeanForm";
            this.Load += new System.EventHandler(this.DeanForm_Load);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox semestrComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Button watchStMarks;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button watchInfo;
    }
}