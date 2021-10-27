CREATE OR ALTER FUNCTION [bcrypt].[HashPassword]
(
    @password nvarchar(max)
)
RETURNS  nvarchar(60)

/*******************************************************************************

Overview:
Calls the BCrypt HashPassword function in the BCryptSS assembly.

Example usage:
select bcrypt.HashPassword('abcd');

Input Parameters:
  @password - user password to hash

Output:
  hashed password

*******************************************************************************/

WITH EXECUTE AS CALLER
AS EXTERNAL NAME
    BCryptSS.BCryptFunctions.HashPassword;

GO
