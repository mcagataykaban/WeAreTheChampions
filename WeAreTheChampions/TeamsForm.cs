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
            if (btnAdd.Text == "💾 Save")
            {
                var selectedTeam = (Team)lstTeams.SelectedItem;
                selectedTeam.TeamName = txtTeamName.Text;
                db.SaveChanges();
                ListTeams();
                ResetForm();
                WhenMakeChange(EventArgs.Empty);
                return;
            }
            db.Teams.Add(new Team { TeamName = txtTeamName.Text });
            db.SaveChanges();
            ListTeams();
            WhenMakeChange(EventArgs.Empty);
        }

        private void ResetForm()
        {
            txtTeamName.Clear();
            lstTeams.Enabled = true;
            btnAdd.Text = "➕ Add";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedTeam = (Team)lstTeams.SelectedItem;
            db.Teams.Remove(selectedTeam);
            db.SaveChanges();
            WhenMakeChange(EventArgs.Empty);
            ListTeams();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Düzenleme Moduna Geç
            lstTeams.Enabled = false;
            var selectedTeam = (Team)lstTeams.SelectedItem;
            btnAdd.Text = "💾 Save";
            txtTeamName.Text = selectedTeam.TeamName;
        }
    }
}
