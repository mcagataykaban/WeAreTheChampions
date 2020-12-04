using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Model;

namespace WeAreTheChampions
{
    
    public partial class TeamsForm : Form
    {
        public event EventHandler HasBeenChanged;
        private readonly WeAreTheChampionsContext db;
        public TeamsForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            ListTeams();
            
        }

        private void TeamColorShow()
        {
            
            var team = (Team)lstTeams.SelectedItem;
            List<Model.Color> renkler = team.TeamColors.ToList();
            if (renkler.Count == 0)
            {
                lblBg.BackColor = System.Drawing.Color.Transparent;
                lblColorFirst.BackColor = lblColorSecond.BackColor = System.Drawing.Color.Transparent;
                return;
            }
            if (renkler.Count == 1)
            {
                lblBg.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
                lblColorFirst.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
                return;
            }
  
                lblBg.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
                lblColorFirst.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
            lblBg2.BackColor = System.Drawing.Color.FromArgb(renkler[1].Red, renkler[1].Green, renkler[1].Blue);
            lblColorSecond.BackColor = System.Drawing.Color.FromArgb(renkler[1].Red, renkler[1].Green, renkler[1].Blue);



        }

        protected virtual void WhenMakeChange(EventArgs args)
        {
            HasBeenChanged?.Invoke(this, args);
        }

        private void ListTeams()
        {
            lstTeams.DataSource = db.Teams.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var renk = CreateColor(lblColorFirst);
            var renk2 = CreateColor(lblColorSecond);
            if (btnAdd.Text == "💾 Save")
            {
                var selectedTeam = (Team)lstTeams.SelectedItem;
              
                //selectedTeam.TeamColors.Add(renk);
                //selectedTeam.TeamColors.Add(renk2);
                selectedTeam.TeamName = txtTeamName.Text;
                db.SaveChanges();
                ListTeams();
                ResetForm();
                WhenMakeChange(EventArgs.Empty);
                return;
            }
            List<Model.Color> renkler = new List<Model.Color>();
            renkler.Add(renk);
            renkler.Add(renk2);
            db.Teams.Add(new Team { TeamName = txtTeamName.Text , TeamColors = renkler});
            db.SaveChanges();
            ListTeams();
            WhenMakeChange(EventArgs.Empty);
        }

        private Model.Color CreateColor(Label lbl)
        {
            System.Drawing.Color firstLblColor = lbl.BackColor;
            byte r = firstLblColor.R;
            byte g = firstLblColor.G;
            byte b = firstLblColor.B;
            var renk = new Model.Color() { Red = r, Green = g, Blue = b };
            return renk;
        }

        private void ResetForm()
        {
            txtTeamName.Clear();
            lstTeams.Enabled = true;
            btnAdd.Text = "➕ Add";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex < 0)
                return;
            var selectedTeam = (Team)lstTeams.SelectedItem;
            if (selectedTeam.Players != null || selectedTeam.Team1Matches != null || selectedTeam.Team2Matches != null)
            {
                selectedTeam.TeamName = selectedTeam.TeamName + "(Closed)";
                if (selectedTeam.Players.Count != 0)
                {
                    var players = selectedTeam.Players.ToList();
                    players.ForEach(x => x.TeamId = null);
                }
                db.SaveChanges();
                WhenMakeChange(EventArgs.Empty);
                ListTeams();
                return;
            }
            db.Teams.Remove(selectedTeam);
            db.SaveChanges();
            WhenMakeChange(EventArgs.Empty);
            ListTeams();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex < 0)
                return;
            //Düzenleme Moduna Geç
            lstTeams.Enabled = false;
            var selectedTeam = (Team)lstTeams.SelectedItem;
            btnAdd.Text = "💾 Save";
            txtTeamName.Text = selectedTeam.TeamName;
        }

        private void lblColorFirst_Click(object sender, EventArgs e)
        {
            if (colorDialogFirst.ShowDialog() == DialogResult.OK)
                lblColorFirst.BackColor = colorDialogFirst.Color;
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeamColorShow();

        }

        private void lblColorSecond_Click(object sender, EventArgs e)
        {
            if (colorDialogSecond.ShowDialog() == DialogResult.OK)
                lblColorSecond.BackColor = colorDialogSecond.Color;
        }


        //var labeller = new List<Label>();
        //for (int i = 0; i < 4; i++)
        //{
        //    Label label = new Label();
        //    label.Visible = true;
        //    label.Text = "selam";
        //    label.Left = 100;
        //    label.Top = 100;
        //    label.Width = 100;
        //    label.Height = 100;

        //    label.BackColor = System.Drawing.Color.Red;
        //    labeller.Insert(i, label);
        //}

        //if (colorDialogFirst.ShowDialog() == DialogResult.OK)
        //{
        //    lblColorFirst.BackColor = colorDialogFirst.Color;

        //}


    }
}
