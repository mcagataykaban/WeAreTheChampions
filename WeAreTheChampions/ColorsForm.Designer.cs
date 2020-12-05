
namespace WeAreTheChampions
{
    partial class ColorsForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.lstColors = new System.Windows.Forms.ListBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.hsRed = new System.Windows.Forms.HScrollBar();
            this.hsGreen = new System.Windows.Forms.HScrollBar();
            this.hsBlue = new System.Windows.Forms.HScrollBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add New Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color Name : ";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(122, 64);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(296, 24);
            this.txtColorName.TabIndex = 7;
            // 
            // lstColors
            // 
            this.lstColors.DisplayMember = "ColorName";
            this.lstColors.FormattingEnabled = true;
            this.lstColors.ItemHeight = 18;
            this.lstColors.Location = new System.Drawing.Point(17, 259);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(390, 184);
            this.lstColors.TabIndex = 9;
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
            // 
            // lblPreview
            // 
            this.lblPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPreview.Location = new System.Drawing.Point(407, 259);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(11, 184);
            this.lblPreview.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(401, 31);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "➕ Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(318, 449);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "🗑️ Delete ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(17, 449);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 31);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "🖊️ Edit ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblColor.Location = new System.Drawing.Point(17, 97);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(401, 24);
            this.lblColor.TabIndex = 4;
            // 
            // hsRed
            // 
            this.hsRed.LargeChange = 1;
            this.hsRed.Location = new System.Drawing.Point(100, 131);
            this.hsRed.Maximum = 255;
            this.hsRed.Name = "hsRed";
            this.hsRed.Size = new System.Drawing.Size(318, 18);
            this.hsRed.TabIndex = 15;
            this.hsRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsRed_Scroll);
            // 
            // hsGreen
            // 
            this.hsGreen.LargeChange = 1;
            this.hsGreen.Location = new System.Drawing.Point(100, 162);
            this.hsGreen.Maximum = 255;
            this.hsGreen.Name = "hsGreen";
            this.hsGreen.Size = new System.Drawing.Size(318, 18);
            this.hsGreen.TabIndex = 16;
            this.hsGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsGreen_Scroll);
            // 
            // hsBlue
            // 
            this.hsBlue.LargeChange = 1;
            this.hsBlue.Location = new System.Drawing.Point(100, 190);
            this.hsBlue.Maximum = 255;
            this.hsBlue.Name = "hsBlue";
            this.hsBlue.Size = new System.Drawing.Size(318, 18);
            this.hsBlue.TabIndex = 17;
            this.hsBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsBlue_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Red";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Green";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.Location = new System.Drawing.Point(69, 162);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(35, 18);
            this.lblGreen.TabIndex = 21;
            this.lblGreen.Text = "000";
            // 
            // lblRed
            // 
            this.lblRed.Location = new System.Drawing.Point(69, 131);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(35, 18);
            this.lblRed.TabIndex = 22;
            this.lblRed.Text = "000";
            // 
            // lblBlue
            // 
            this.lblBlue.Location = new System.Drawing.Point(69, 190);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(35, 18);
            this.lblBlue.TabIndex = 23;
            this.lblBlue.Text = "000";
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 494);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hsBlue);
            this.Controls.Add(this.hsGreen);
            this.Controls.Add(this.hsRed);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ColorsForm";
            this.Text = "ColorsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.HScrollBar hsRed;
        private System.Windows.Forms.HScrollBar hsGreen;
        private System.Windows.Forms.HScrollBar hsBlue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Timer timer1;
    }
}