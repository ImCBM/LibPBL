using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace LibPBL
{
    internal class TeacherDatabase
    {
        //private static readonly string DatabaseFolderPath = AppDomain.CurrentDomain.BaseDirectory;
        //public static readonly string DatabasePath = Path.Combine(DatabaseFolderPath, "PBL.db");
        public static readonly string DatabasePath = "Data Source=PBL.db;Version=3;";

        public static void SaveTeacherData(string empID, string firstName, string lastName, string dept, string password)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DatabasePath))
                {
                    connection.Open();

                    using (SQLiteCommand createTableCommand = new SQLiteCommand(
                        "CREATE TABLE IF NOT EXISTS Teachers (" +
                        "EmpID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                        "EmployeeID TEXT, " +
                        "FirstName TEXT, " +
                        "LastName TEXT, " +
                        "Department TEXT, " +
                        "Password TEXT);", connection))
                    {
                        createTableCommand.ExecuteNonQuery();
                    }

                    if (IsDuplicateEmpID(empID, connection))
                    {
                        MessageBox.Show("Duplicate Employee ID found. Please use a different Employee ID. " + empID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SQLiteCommand insertCommand = new SQLiteCommand(
                        "INSERT INTO Teachers (EmployeeID, FirstName, LastName, Department, Password) " +
                        "VALUES (@EmployeeID, @FirstName, @LastName, @Department, @Password);", connection))
                    {
                        insertCommand.Parameters.AddWithValue("@EmployeeID", empID);
                        insertCommand.Parameters.AddWithValue("@FirstName", firstName);
                        insertCommand.Parameters.AddWithValue("@LastName", lastName);
                        insertCommand.Parameters.AddWithValue("@Department", dept);
                        insertCommand.Parameters.AddWithValue("@Password", password);

                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool IsDuplicateEmpID(string empID, SQLiteConnection connection)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("SELECT EmployeeID FROM Teachers WHERE EmployeeID = @EmployeeID;", connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", empID);

                    object result = command.ExecuteScalar();
                    return result != null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking duplicate Employee ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string GetFullNameByEmpID(string empID)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DatabasePath))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand("SELECT FirstName, LastName FROM Teachers WHERE EmployeeID = @EmployeeID;", connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", empID);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["FirstName"].ToString();
                                string lastName = reader["LastName"].ToString();
                                string formattedName;
                                
                                if ( firstName.Length >= 8)
                                {
                                    formattedName = $"{firstName},\n {lastName}";
                                    return formattedName;
                                }
                                return $"{firstName}, {lastName}";
                                
                            }
                        }
                    }
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving full name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
    }
}
