using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Attendance_Management_System.Login
{
    public class PasswordHelper
    {
        public static string HashPassword(string Password)
        {
            return BCrypt.Net.BCrypt.HashPassword(Password);
        }

        public static bool VerifyPassword(string Password, string HashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(Password, HashedPassword);
        }
        public static Dictionary<string, string> ValidatePassword(string Password)
        {
            var errorDictionary = new Dictionary<string, string>();
            try
            {
                if (Password.Length < 6)
                {
                    errorDictionary.Add("Missing Character Requirement", "Password must include at least one uppercase letter (A-Z).");
                }
                if (!Regex.IsMatch(Password, @"[A-Z]"))
                {
                    errorDictionary.Add("Missing Character Requirement", "Password must be at least 8 characters long.");
                }
                if (!Regex.IsMatch(Password, @"[a-z]"))
                {
                    errorDictionary.Add("Invalid Length", "Password must include at least one lowercase letter (a-z).");

                }
                if (!Regex.IsMatch(Password, @"\d"))
                {
                    errorDictionary.Add("Missing Character Requirement", " Password must include at least one digit (0-9).");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return errorDictionary;
        }
    }
}
