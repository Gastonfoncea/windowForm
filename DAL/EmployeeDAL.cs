using AmbEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbEmpleados.DAL
{
    public class EmployeeDAL
    {

        public static int addEmployee(Employee employee)
        {

            int retorna = 0;

            using (SqlConnection connection = DataBaseManager.getConection())
            {
                
                string query = "INSERT INTO Employees (name,lastName,leg,section,ofice) VALUES ('"+employee.name+ "' , '"+employee.lastName+ "' , '"+employee.leg+ "', '"+employee.section+ "' , '"+employee.ofice+"')";
                SqlCommand command = new SqlCommand(query,connection);

                retorna = command.ExecuteNonQuery();

            }
            return retorna;
        }


        public static List<Employee> getEmployeeList()
        {
            List<Employee> list = new List<Employee>();

            using (SqlConnection connection = DataBaseManager.getConection())
            {
                string query = "SELECT *FROM Employees";
                SqlCommand comando = new SqlCommand(query, connection);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Employee emp = new Employee();
                    emp.Id = reader.GetInt32(0);
                    emp.name = reader.GetString(1);
                    emp.lastName = reader.GetString(2);
                    emp.leg = reader.GetString(3);
                    emp.section = reader.GetString(4);
                    emp.ofice = reader.GetString(5);
                    list.Add(emp);  

                }
                connection.Close();
                return list;
            }
            
        }


        public static int deleteEmployee(Employee employee)
        {
         int result = 0;

            if (employee == null || employee.Id == null)
            {
                MessageBox.Show("Selecciona un empleado por favor");
            }


            using (SqlConnection connection = DataBaseManager.getConection()) {
                string query = "DELETE FROM Employees WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection)) {

                    command.Parameters.AddWithValue("@id", employee.Id);

                    result = command.ExecuteNonQuery();
                }


            }
            return result;

        }


        public static int updateEmployee(Employee employee)
        {
            int result = 0;

            if (employee == null || employee.Id == null) {

                MessageBox.Show("Selecciona un empleado por favor");
        }

            using (SqlConnection connection = DataBaseManager.getConection()) {
                string query = "UPDATE Employees SET name = @name, lastName = @lastName, leg = @leg, ofice = @ofice WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection)) {

                    // Agregar parámetros para evitar inyección de SQL
                    command.Parameters.AddWithValue("@name", employee.name);
                    command.Parameters.AddWithValue("@lastName", employee.lastName);
                    command.Parameters.AddWithValue("@leg", employee.leg);
                    command.Parameters.AddWithValue("@ofice", employee.ofice);
                    command.Parameters.AddWithValue("@id", employee.Id);

                    // Ejecutar la consulta
                    result = command.ExecuteNonQuery();

                }
            }

            return result;
        }
    }
}
