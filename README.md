# BCrypt for SQL Server

This project creates two SQL Server functions that are wrappers around the [BCrypt.Net](https://github.com/BcryptNet/bcrypt.net) functions used to hash and verify passwords.

* `bcrypt.CheckPassword` calls `BCrypt.Net.BCrypt.Verify`
* `bcrypt.HashPassword` calls `BCrypt.Net.BCrypt.HashPassword` 

## Usage examples

```sql
declare
    @password varchar(57) = 'abc',
    @hash varchar(max)= '$2a$10$qvcDFHfBnxfX1.1KMIcX4O1UC9yLTkFzq/pQNPT24pm8VudXTnDC2';

select bcrypt.HashPassword(@password);
select bcrypt.CheckPassword(@password, @hash);
```
