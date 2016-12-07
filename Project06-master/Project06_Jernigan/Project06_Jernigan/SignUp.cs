/*Christopher Jernigan ITP 136 82 HP
 * 12/2/2016 
 * Project 06 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Project06_Jernigan
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void CustomerSignUp_Load(object sender, EventArgs e)
        {
           try
            {
                string _tempLine;
                StreamReader _inputPerson = File.OpenText("Person.txt");
               
                List<Person> _personList = new List<Person>();
                
                while (!_inputPerson.EndOfStream)
               {
                    _tempLine = _inputPerson.ReadLine();
                    string[] delim = _tempLine.Split(',');
                    Person nPerson = new Person();
                    nPerson.Name = delim[0];
                    nPerson.address = delim[1];
                    nPerson.teleNumber = delim[2];
                    _personList.Add(nPerson);
                    personList.Items.Add(nPerson.Name);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            try
            {
                string _tempLine;
                StreamReader _inputCustomer = File.OpenText("Customer.txt");

                List<Customer> _customerList = new List<Customer>();

                while (!_inputCustomer.EndOfStream)
                {
                    _tempLine = _inputCustomer.ReadLine();
                    List<> delim = new List<T>;
                    delim = _tempLine.Split(',');
                    Customer nCustomer = new Customer();
                    nCustomer.Name = delim[0];
                    nCustomer.address = delim[1];
                    nCustomer.teleNumber = delim[2];
                    nCustomer.customerNumber = delim[3];
                    nCustomer.newsletter = delim[4];
                    _customerList.Add(nCustomer);
                    personList.Items.Add(nCustomer.Name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }




        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
