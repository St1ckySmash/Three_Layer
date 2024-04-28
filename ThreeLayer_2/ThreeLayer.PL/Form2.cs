using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeLayer.BLL;
using ThreeLayer.Entities;
using ThreeLayer.Common;

namespace ThreeLayer.PL
{
    public partial class Form2 : Form
    {
        Form1 parentForm;
        public Form2(Form1 parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }
        private void OrganizationParameter_CheckedChanged(object sender, EventArgs e)
        {
            parentForm.OrganizationParameter = OrganizationParameter.Text;
        }
        private void DepartmentParameter_CheckedChanged(object sender, EventArgs e)
        {
            parentForm.OrganizationParameter = DepartmentParameter.Text;
        }
        private void LastNameParameter_CheckedChanged(object sender, EventArgs e)
        {
            parentForm.PersonParameter = LastNameParameter.Text;
        }
        private void FirstNameParameter_CheckedChanged(object sender, EventArgs e)
        {
            parentForm.PersonParameter = FirstNameParameter.Text;
        }
        private void PositionParameter_CheckedChanged(object sender, EventArgs e)
        {
            parentForm.PersonParameter = PositionParameter.Text;
        }
    }
}
