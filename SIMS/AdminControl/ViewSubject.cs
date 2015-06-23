﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace SIMS.AdminControl
{
    public partial class ViewSubject : MetroForm
    {
        public ViewSubject()
        {
            InitializeComponent();
        }

        private void sUBJECTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.subjectBS.EndEdit();
                this.tableAM.UpdateAll(this.veiw_subjectDS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes:\n"+ex.Message.ToString());
            }
        }

        private void ViewSubject_Load(object sender, EventArgs e)
        {
            try 
            {
                // TODO: This line of code loads data into the 'dS.SUBJECT' table. You can move, or remove it, as needed.
                this.subjectTA.Fill(this.veiw_subjectDS.SUBJECT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects"+ex.Message.ToString());
            }
        }
    }
}
