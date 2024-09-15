using AmbEmpleados.DAL;
using AmbEmpleados.Models;

namespace AmbEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.name = tBoxName.Text;
            employee.lastName = tBoxLastName.Text;
            employee.leg = tBoxLeg.Text;
            employee.ofice = tBoxOfice.Text;

            int result = EmployeeDAL.addEmployee(employee);

            if (result > 0)
            {
                MessageBox.Show("Se guardo correctamente ");
            }
            else
            {
                MessageBox.Show("Chingale");
            }
            refreshScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshScreen();
        }

        public void refreshScreen()
        {
            dataGridView1.DataSource = EmployeeDAL.getEmployeeList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            lblId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
            tBoxName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["name"].Value);
            tBoxLastName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["LastName"].Value);
            tBoxLeg.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["leg"].Value);
            tBoxOfice.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["ofice"].Value);


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["id"].Value != null)
            {

                try
                {
                    Employee employee = new Employee
                    {
                        name = tBoxName.Text,
                        lastName = tBoxLastName.Text,
                        leg = tBoxLeg.Text,
                        ofice = tBoxOfice.Text,
                        Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value)
                    };


                    int resultUpdate = EmployeeDAL.updateEmployee(employee);


                    if (resultUpdate > 0)
                    {
                        MessageBox.Show("Registro Actualizado");
                    }
                    else
                    {
                        MessageBox.Show("No se actualizo nada");
                    }

                    refreshScreen();

                }
                catch
                {

                }

            }
            else
            {
                MessageBox.Show("Selecciona una fila valida");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentCell.Value != null)
            {

                try
                {
                    Employee employee = new Employee
                    {
                        Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value)
                    };

                    int resultDelete = EmployeeDAL.deleteEmployee(employee);

                }
                catch
                {
                }
                refreshScreen();
            }
            else {

                MessageBox.Show("Selecciona un empleado por favor");
            }
            
        }
    }
}
