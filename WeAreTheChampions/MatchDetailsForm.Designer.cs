
namespace WeAreTheChampions
{
    partial class MatchDetailsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboNewTeam1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboNewTeam2 = new System.Windows.Forms.ComboBox();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.cboMatches = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEditTeam2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEditTeam1 = new System.Windows.Forms.ComboBox();
            this.dtpEditDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.nudScore1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudScore2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSecondColor = new System.Windows.Forms.Label();
            this.lblFirstColor = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Match";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(5, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edit Match";
            // 
            // cboNewTeam1
            // 
            this.cboNewTeam1.DisplayMember = "TeamName";
            this.cboNewTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewTeam1.FormattingEnabled = true;
            this.cboNewTeam1.Location = new System.Drawing.Point(9, 62);
            this.cboNewTeam1.Name = "cboNewTeam1";
            this.cboNewTeam1.Size = new System.Drawing.Size(167, 26);
            this.cboNewTeam1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Team 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Team 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Match Date";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(595, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "➕";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboNewTeam2
            // 
            this.cboNewTeam2.DisplayMember = "TeamName";
            this.cboNewTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewTeam2.FormattingEnabled = true;
            this.cboNewTeam2.Location = new System.Drawing.Point(199, 62);
            this.cboNewTeam2.Name = "cboNewTeam2";
            this.cboNewTeam2.Size = new System.Drawing.Size(167, 26);
            this.cboNewTeam2.TabIndex = 7;
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.CustomFormat = "MMMMdd,yyyy | hh:mm";
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewDate.Location = new System.Drawing.Point(372, 64);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(217, 24);
            this.dtpNewDate.TabIndex = 8;
            // 
            // cboMatches
            // 
            this.cboMatches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatches.FormattingEnabled = true;
            this.cboMatches.Location = new System.Drawing.Point(9, 150);
            this.cboMatches.Name = "cboMatches";
            this.cboMatches.Size = new System.Drawing.Size(614, 26);
            this.cboMatches.TabIndex = 9;
            this.cboMatches.SelectedIndexChanged += new System.EventHandler(this.cboMatches_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select Match";
            // 
            // cboEditTeam2
            // 
            this.cboEditTeam2.DisplayMember = "TeamName";
            this.cboEditTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditTeam2.FormattingEnabled = true;
            this.cboEditTeam2.Location = new System.Drawing.Point(437, 273);
            this.cboEditTeam2.Name = "cboEditTeam2";
            this.cboEditTeam2.Size = new System.Drawing.Size(192, 26);
            this.cboEditTeam2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Team 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Team 1";
            // 
            // cboEditTeam1
            // 
            this.cboEditTeam1.DisplayMember = "TeamName";
            this.cboEditTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditTeam1.FormattingEnabled = true;
            this.cboEditTeam1.Location = new System.Drawing.Point(9, 271);
            this.cboEditTeam1.Name = "cboEditTeam1";
            this.cboEditTeam1.Size = new System.Drawing.Size(192, 26);
            this.cboEditTeam1.TabIndex = 11;
            // 
            // dtpEditDate
            // 
            this.dtpEditDate.CustomFormat = "MMMMdd,yyyy | hh:mm";
            this.dtpEditDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditDate.Location = new System.Drawing.Point(191, 212);
            this.dtpEditDate.Name = "dtpEditDate";
            this.dtpEditDate.Size = new System.Drawing.Size(228, 24);
            this.dtpEditDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Match Date";
            // 
            // nudScore1
            // 
            this.nudScore1.Location = new System.Drawing.Point(212, 272);
            this.nudScore1.Name = "nudScore1";
            this.nudScore1.Size = new System.Drawing.Size(55, 24);
            this.nudScore1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Score 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Score 2";
            // 
            // nudScore2
            // 
            this.nudScore2.Location = new System.Drawing.Point(369, 274);
            this.nudScore2.Name = "nudScore2";
            this.nudScore2.Size = new System.Drawing.Size(55, 24);
            this.nudScore2.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(305, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 33);
            this.label12.TabIndex = 21;
            this.label12.Text = "-";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(9, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(620, 33);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSecondColor
            // 
            this.lblSecondColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecondColor.Location = new System.Drawing.Point(43, 226);
            this.lblSecondColor.Name = "lblSecondColor";
            this.lblSecondColor.Size = new System.Drawing.Size(25, 26);
            this.lblSecondColor.TabIndex = 26;
            // 
            // lblFirstColor
            // 
            this.lblFirstColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstColor.Location = new System.Drawing.Point(12, 226);
            this.lblFirstColor.Name = "lblFirstColor";
            this.lblFirstColor.Size = new System.Drawing.Size(25, 26);
            this.lblFirstColor.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(573, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 26);
            this.label13.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(604, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 26);
            this.label14.TabIndex = 27;
            // 
            // MatchDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 363);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblSecondColor);
            this.Controls.Add(this.lblFirstColor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudScore2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudScore1);
            this.Controls.Add(this.dtpEditDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboEditTeam2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboEditTeam1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMatches);
            this.Controls.Add(this.dtpNewDate);
            this.Controls.Add(this.cboNewTeam2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNewTeam1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatchDetailsForm";
            this.Text = "MatchDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNewTeam1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboNewTeam2;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.ComboBox cboMatches;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEditTeam2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEditTeam1;
        private System.Windows.Forms.DateTimePicker dtpEditDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudScore1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudScore2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSecondColor;
        private System.Windows.Forms.Label lblFirstColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}