using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPBL
{
    internal class TeacherDatabase
    {
        // Get the current application's base directory (where the .cs files are located)
        private static readonly string DatabaseFolderPath = AppDomain.CurrentDomain.BaseDirectory;

        // Combine the base directory with the file name to get the full path to the CSV file
        public static readonly string DatabasePath = Path.Combine(DatabaseFolderPath, "employeedb.csv");

        public static void SaveTeacherData(string EmpID, string firstName, string lastName, string Dept, string password)
        {



            // Check if the file exists, and create it if not
            if (!File.Exists(DatabasePath))
            {
                try
                {
                    // Create the file with a header line
                    File.WriteAllText(DatabasePath, "EmployeeID,FirstName,LastName,Department,Password" + Environment.NewLine);
                    MessageBox.Show("File made", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Check for duplicate StudentID
            if (IsDuplicateEmpID(EmpID))
            {
                MessageBox.Show("Duplicate Employee ID found. Please use a different StudentID. " + EmpID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





            // Format the data as a CSV line
            string csvLine = $"{EmpID},{firstName},{lastName},{Dept},{password}";

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






        public static bool IsDuplicateEmpID(string studentID)
        {
            // Read existing StudentIDs from the file
            string[] existingEmpIDs = File.ReadAllLines(DatabasePath)
                .Skip(1) // Skip the header line
                .Select(line => line.Split(',')[0]) // Extract StudentID from each line
                .ToArray();

            // Check if the given studentID already exists in the file
            return existingEmpIDs.Contains(studentID);
        }
    }
}
