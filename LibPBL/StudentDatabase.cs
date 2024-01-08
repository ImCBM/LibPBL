using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LibPBL
{
    internal class StudentDatabase
    {
        // Get the current application's base directory (where the .cs files are located)
        private static readonly string DatabaseFolderPath = AppDomain.CurrentDomain.BaseDirectory;

        // Combine the base directory with the file name to get the full path to the CSV file
        public static readonly string DatabasePath = Path.Combine(DatabaseFolderPath, "studentsdb.csv");

        public static void SaveStudentData(string studentID, string firstName, string lastName, string gradeLevel, string section, string password)
        {



            // Check if the file exists, and create it if not
            if (!File.Exists(DatabasePath))
            {
                try
                {
                    // Create the file with a header line
                    File.WriteAllText(DatabasePath, "StudentID,FirstName,LastName,GradeLevel,Section,Password" + Environment.NewLine);
                    MessageBox.Show("File made", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Check for duplicate StudentID
            if (IsDuplicateStudentID(studentID))
            {
                MessageBox.Show("Duplicate StudentID found. Please use a different StudentID. " + studentID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Format the data as a CSV line
            string csvLine = $"{studentID},{firstName},{lastName},{gradeLevel},{section},{password}";

            // Save the CSV line to the file
            try
            {
                File.AppendAllText(DatabasePath, csvLine + Environment.NewLine);
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool IsDuplicateStudentID(string studentID)
        {
            // Read existing StudentIDs from the file
            string[] existingStudentIDs = File.ReadAllLines(DatabasePath)
                .Skip(1) // Skip the header line
                .Select(line => line.Split(',')[0]) // Extract StudentID from each line
                .ToArray();

            // Check if the given studentID already exists in the file
            return existingStudentIDs.Contains(studentID);
        }


        //LOGGED IN COMPONENTS
        public static string GetFullNameByStudentID(string studentID)
        {
            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(DatabasePath);

                // Skip the header line and find the student with the specified StudentID
                string[] studentData = lines.Skip(1).Where(line => line.StartsWith(studentID)).Select(line => line.Split(',')).FirstOrDefault();

                // If the student with the specified ID is found, concatenate FirstName and LastName
                if (studentData != null && studentData.Length >= 3)
                {
                    return $"{studentData[1]}, {studentData[2]}";
                }
                else
                {
                    //MessageBox.Show("Student not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
    }
}
