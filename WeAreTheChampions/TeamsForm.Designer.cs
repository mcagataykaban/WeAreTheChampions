
namespace WeAreTheChampions
{
    partial class TeamsForm
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
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnListPlayers = new System.Windows.Forms.Button();
            this.colorDialogFirst = new System.Windows.Forms.ColorDialog();
            this.colorDialogSecond = new System.Windows.Forms.ColorDialog();
            this.lblBg = new System.Windows.Forms.Label();
            this.lblBg2 = new System.Windows.Forms.Label();
            this.cboFirstColor = new System.Windows.Forms.ComboBox();
            this.cboSecondColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFirstColor = new System.Windows.Forms.Label();
            this.lblSecondColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTeams
            // 
            this.lstTeams.DisplayMember = "TeamName";
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.ItemHeight = 18;
            this.lstTeams.Location = new System.Drawing.Point(18, 183);
            this.lstTeams.Margin = new System.Windows.Forms.Padding(4);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(401, 256);
            this.lstTeams.TabIndex = 0;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Team";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(19, 82);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(151, 24);
            this.txtTeamName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team Name :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(320, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 31);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "🗑️ Delete ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(18, 446);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 31);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "🖊️ Edit ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(402, 31);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "➕ Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnListPlayers
            // 
            this.btnListPlayers.Location = new System.Drawing.Point(19, 145);
            this.btnListPlayers.Name = "btnListPlayers";
            this.btnListPlayers.Size = new System.Drawing.Size(401, 31);
            this.btnListPlayers.TabIndex = 10;
            this.btnListPlayers.Text = "📜 List Players";
            this.btnListPlayers.UseVisualStyleBackColor = true;
            this.btnListPlayers.Click += new System.EventHandler(this.btnListPlayers_Click);
            // 
            // colorDialogFirst
            // 
            this.colorDialogFirst.AnyColor = true;
            this.colorDialogFirst.Color = System.Drawing.Color.DarkGray;
            this.colorDialogFirst.FullOpen = true;
            this.colorDialogFirst.SolidColorOnly = true;
            // 
            // colorDialogSecond
            // 
            this.colorDialogSecond.AnyColor = true;
            this.colorDialogSecond.Color = System.Drawing.Color.DarkGray;
            this.colorDialogSecond.FullOpen = true;
            this.colorDialogSecond.SolidColorOnly = true;
            // 
            // lblBg
            // 
            this.lblBg.BackColor = System.Drawing.Color.Transparent;
            this.lblBg.Location = new System.Drawing.Point(-1, -2);
            this.lblBg.Name = "lblBg";
            this.lblBg.Size = new System.Drawing.Size(432, 14);
            this.lblBg.TabIndex = 13;
            // 
            // lblBg2
            // 
            this.lblBg2.BackColor = System.Drawing.Color.Transparent;
            this.lblBg2.Location = new System.Drawing.Point(-1, 12);
            this.lblBg2.Name = "lblBg2";
            this.lblBg2.Size = new System.Drawing.Size(432, 14);
            this.lblBg2.TabIndex = 14;
            // 
            // cboFirstColor
            // 
            this.cboFirstColor.DisplayMember = "ColorName";
            this.cboFirstColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFirstColor.FormattingEnabled = true;
            this.cboFirstColor.Location = new System.Drawing.Point(279, 48);
            this.cboFirstColor.Name = "cboFirstColor";
            this.cboFirstColor.Size = new System.Drawing.Size(110, 26);
            this.cboFirstColor.TabIndex = 15;
            this.cboFirstColor.SelectedIndexChanged += new System.EventHandler(this.cboFirstColor_SelectedIndexChanged);
            // 
            // cboSecondColor
            // 
            this.cboSecondColor.DisplayMember = "ColorName";
            this.cboSecondColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSecondColor.FormattingEnabled = true;
            this.cboSecondColor.Location = new System.Drawing.Point(279, 80);
            this.cboSecondColor.Name = "cboSecondColor";
            this.cboSecondColor.Size = new System.Drawing.Size(110, 26);
            this.cboSecondColor.TabIndex = 16;
            this.cboSecondColor.SelectedIndexChanged += new System.EventHandler(this.cboSecondColor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "First color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Second color";
            // 
            // lblFirstColor
            // 
            this.lblFirstColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstColor.Location = new System.Drawing.Point(395, 48);
            this.lblFirstColor.Name = "lblFirstColor";
            this.lblFirstColor.Size = new System.Drawing.Size(25, 26);
            this.lblFirstColor.TabIndex = 19;
            // 
            // lblSecondColor
            // 
            this.lblSecondColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecondColor.Location = new System.Drawing.Point(394, 80);
            this.lblSecondColor.Name = "lblSecondColor";
            this.lblSecondColor.Size = new System.Drawing.Size(25, 26);
            this.lblSecondColor.TabIndex = 20;
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 487);
            this.Controls.Add(this.lblSecondColor);
            this.Controls.Add(this.lblFirstColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSecondColor);
            this.Controls.Add(this.cboFirstColor);
            this.Controls.Add(this.lblBg2);
            this.Controls.Add(this.lblBg);
            this.Controls.Add(this.btnListPlayers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTeams);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamsForm";
            this.Text = "TeamsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnListPlayers;
        private System.Windows.Forms.ColorDialog colorDialogFirst;
        private System.Windows.Forms.ColorDialog colorDialogSecond;
        private System.Windows.Forms.Label lblBg;
        private System.Windows.Forms.Label lblBg2;
        private System.Windows.Forms.ComboBox cboFirstColor;
        private System.Windows.Forms.ComboBox cboSecondColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFirstColor;
        private System.Windows.Forms.Label lblSecondColor;
    }
}