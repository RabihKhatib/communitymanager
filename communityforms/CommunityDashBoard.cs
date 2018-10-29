using System;
using System.Collections.Generic;
using System.Windows.Forms;
using communitylibs;

namespace communityforms
{
    public partial class CommunityDashBoard : Form
    {
        List<SP_CITIZEN_VO> citizens = new List<SP_CITIZEN_VO>();
        public CommunityDashBoard()
        {
            InitializeComponent();

            LoadCitizenList();
        }
         
        private void LoadCitizenList()
        {
            citizens = SqliteDAO.loadCitizens();


            WireUpCitizensList();
        }

        private void WireUpCitizensList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = citizens;
            listBox1.DisplayMember = "FullName";
        }

        private void refreshList_Click(object sender, EventArgs e)
        {
            LoadCitizenList();
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            SP_CITIZEN_VO p = new SP_CITIZEN_VO();

            p.FIRST_NAME = firstNameText.Text;
            p.LAST_NAME = lastNameText.Text;

            SqliteDAO.saveCitizen(p);

            firstNameText.Text = "";
            lastNameText.Text = "";
        }

    }
}
