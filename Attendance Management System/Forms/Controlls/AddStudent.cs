using Attendance_Management_System.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Attendance_Management_System.Forms.Controlls
{
    public partial class AddStudent : UserControl
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        int ID = Connection.GetNextId("tblstudent", "StudentID");
        private void btnGenerateQr_Click(object sender, EventArgs e)
        {

        }

        private void dpdParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dpdParent.SelectedIndex == 0)
            {

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFname.Text) && !string.IsNullOrWhiteSpace(txtLname.Text))
            {
                int ID = Connection.GetNextId("tblStudent", "StudentID");
                pbxQrCode.Image = QrHelper.GenerateQr(ID.ToString());
                lbQrName.Text = $"{txtFname.Text} {txtLname.Text}";

                string query = "INSERT INTO `tblstudent`(`StudentID`, `FIrstName`, `LastName`, `Gender`, `Status`) VALUES (@id,@fName,@lName,@gender,@status)";

                var parameters = new Dictionary<string, object>
                   {
                       {"@id", ID},
                       {"@fName",txtFname.Text },
                       {"@lName",txtLname.Text },
                       {"@gender", (rbMale.Checked ? "Male" : "Female") },
                       {"@status",true},
                   };

                Connection.CreateUpdateDelete(query, parameters);
            }
            else
            {
                MessageBox.Show("Please fill in all name fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}
