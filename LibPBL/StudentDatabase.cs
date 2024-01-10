using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LibPBL
{
    internal class StudentDatabase
    {
        // Get the current application's base directory (where the .cs files are located)
        public static readonly string DatabasePath = "Data Source=PBL.db;Version=3;";

        // Combine the base directory with the file name to get the full path to the CSV file
        public static void SaveStudentData(string studentID, string firstName, string lastName, string gradeLevel, string section, string password)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DatabasePath))
                {
                    connection.Open();

                    // Create the Students table if it doesn't exist
                    using (SQLiteCommand createTableCommand = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Students (StudentID TEXT PRIMARY KEY, FirstName TEXT, LastName TEXT, GradeLevel TEXT, Section TEXT, Password TEXT);", connection))
                    {
                        createTableCommand.ExecuteNonQuery();
                    }

                    // Check for duplicate StudentID
                    if (IsDuplicateStudentID(studentID, connection))
                    {
                        MessageBox.Show("Duplicate StudentID found. Please use a different StudentID. " + studentID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert data into the Students table
                    using (SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO Students (StudentID, FirstName, LastName, GradeLevel, Section, Password) VALUES (@StudentID, @FirstName, @LastName, @GradeLevel, @Section, @Password);", connection))
                    {
                        insertCommand.Parameters.AddWithValue("@StudentID", studentID);
                        insertCommand.Parameters.AddWithValue("@FirstName", firstName);
                        insertCommand.Parameters.AddWithValue("@LastName", lastName);
                        insertCommand.Parameters.AddWithValue("@GradeLevel", gradeLevel);
                        insertCommand.Parameters.AddWithValue("@Section", section);
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
        public static bool IsDuplicateStudentID(string studentID, SQLiteConnection connection)
        {
            using (SQLiteCommand command = new SQLiteCommand("SELECT StudentID FROM Students WHERE StudentID = @StudentID;", connection))
            {
                command.Parameters.AddWithValue("@StudentID", studentID);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    return reader.Read();
                }
            }
        }


        //LOGGED IN COMPONENTS
        public static string GetFullNameByStudentID(string studentID)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DatabasePath))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand("SELECT FirstName, LastName FROM Students WHERE StudentID = @StudentID;", connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return $"{reader["FirstName"].ToString()}, {reader["LastName"].ToString()}";
                            }
                        }
                    }
                }

                // If the student with the specified ID is not found
                MessageBox.Show("Student not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
    }
}
