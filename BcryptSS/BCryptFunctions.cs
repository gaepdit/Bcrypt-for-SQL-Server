using Microsoft.SqlServer.Server;

public class BCryptFunctions
{
    /// <summary>
    /// Verifies that the BCrypt hash of the given text (password) matches the provided hash
    /// </summary>
    /// <param name="password">The password to verify</param>
    /// <param name="hash">The previously-generated hash</param>
    /// <returns>True if </returns>
    [SqlFunction()]
    public static bool CheckPassword(string password, string hash)
    {
        return BCrypt.Net.BCrypt.Verify(password.ToString(), hash.ToString());
    }

    /// <summary>
    /// Generates a BCrypt hash from a given password
    /// </summary>
    /// <param name="password">The password to hash</param>
    [SqlFunction()]
    public static string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password.ToString(), BCrypt.Net.BCrypt.GenerateSalt());
    }
}
