using System;
 using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Userform_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e){
            SqlConnection  con = new SqlConnection("Data Source=ASUS;Initial Catalog=userRegistration;Integrated Security=True")
            SqlCommand cmd =new SqlCommand(@"INSERT INTO [dbo].[register]
           ([firstname]
           ,[lastname]
           ,[address]
           ,[gender]
           ,[email]
           ,[phone]
           ,[username]
           ,[password])
     VALUES
           ('" + textFname.Text + "', '" + textLname.Text + "' , '" + textAdd.Text + "' , '" + cmdGender.SelectedItem.ToString() +"','"+textEmail.Text+"','"+textPhone.Text+"' ,'"+textUser.Text+"' ,'"+textPass.Text+"')" ,con)
              con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Sucessfully");
    {

                  
                };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}