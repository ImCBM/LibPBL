using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPBL
{
    internal class StudentLoginComponent
    {
        public static bool CheckCredentials(string studentID, string password)
        {

            // Read existing credentials from the file
            string[] lines = File.ReadAllLines(StudentDatabase.DatabasePath);
            foreach (string line in lines.Skip(1)) // Skip the header line
            {
                string[] parts = line.Split(',');
                string existingStudentID = parts[0].Trim(); // Assuming studentID is at index 0
                string existingPassword = parts[4].Trim();   // Assuming password is at index 4

                // Check for a matching studentID
                if (string.Equals(existingStudentID, studentID, StringComparison.OrdinalIgnoreCase))
                {
                    // Check if the corresponding password is correct
                    if (existingPassword == password)
                    {
                        return true; // Credentials are valid
                    }
                    else
                    {
                        // For testing purposes, display the correct password in the error message
                        MessageBox.Show($"Invalid credentials. The correct password for StudentID '{studentID}' is '{existingPassword}'. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            // No matching studentID found
            MessageBox.Show($"Invalid credentials. No student found with StudentID '{studentID}'. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
