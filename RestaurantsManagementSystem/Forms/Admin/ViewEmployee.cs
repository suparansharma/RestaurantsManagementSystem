using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.Admin
{
    public partial class ViewEmployee : Form
    {
        DataAccess dataAccess = new DataAccess();
        public int userType { get; set; }
        public ViewEmployee(int userType)
        {
            InitializeComponent();
            this.userType = userType;
            LoadData();
        }
        private void LoadData()
        {
            dataAccess.GetAllEmployeeByUserType(dataGridViewEmployee, userType);
        }
    }
}
