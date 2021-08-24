SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

CREATE OR ALTER FUNCTION bcrypt.HashPassword(
    @password nvarchar(max)
)
    RETURNS nvarchar(max)

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

CREATE OR ALTER FUNCTION bcrypt.CheckPassword(
    @password nvarchar(max),
    @hash     nvarchar(max)
)
    RETURNS bit

/*******************************************************************************
Overview:
Calls the BCrypt CheckPassword function in the BCryptSS assembly.

Example usage:
select bcrypt.CheckPassword('abcd','$2a$10$l37yN6i1SVL.4kGAz1v7MOFkZAetcKNJkk2tDAoMFH05KpbsbHZwi');

Input Parameters:
  @password - user password to compare
  @hash - password hash to compare

Output:
  1 if matched
  0 if not matched

*******************************************************************************/

    WITH EXECUTE AS CALLER
AS EXTERNAL NAME
    BCryptSS.BCryptFunctions.CheckPassword;
GO
