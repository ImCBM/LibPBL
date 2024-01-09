using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPBL
{
    internal class StudEmpLoginComponent
    {
        public static bool CheckStudCredentials(string studentID, string password)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(StudentDatabase.DatabasePath))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand("SELECT StudentID, Password FROM Students WHERE StudentID = @StudentID;", connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string existingPassword = reader["Password"].ToString().Trim();

                                // Check if the corresponding password is correct
                                if (existingPassword == password)
                                {
                                    return true; // Credentials are valid
                                }
                                else
                                {
                                    MessageBox.Show("Invalid credentials. Incorrect ID or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                        }
                    }
                }

                // No matching studentID found
                //MessageBox.Show($"Invalid credentials. No student found with StudentID '{studentID}'. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking credentials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CheckEmpCredentials(string employeeID, string password)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(TeacherDatabase.DatabasePath))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand("SELECT EmployeeID, Password FROM Teachers WHERE EmployeeID = @EmployeeID;", connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string existingPassword = reader["Password"].ToString().Trim();

                                // Check if the corresponding password is correct
                                if (existingPassword == password)
                                {
                                    return true; // Credentials are valid
                                }
                                else
                                {
                                    MessageBox.Show("Invalid credentials. Incorrect ID or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                        }
                    }
                }

                // No matching employeeID found
                //MessageBox.Show($"Invalid credentials. No employee found with EmployeeID '{employeeID}'. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking credentials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
