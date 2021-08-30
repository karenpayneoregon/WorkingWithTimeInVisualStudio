Instructions
As delivered Form1 is the startup form. To run the other examples
simply change the startup form in Program.cs, build and run.

time (Transact-SQL) https://docs.microsoft.com/en-us/sql/t-sql/data-types/time-transact-sql?view=sql-server-2017

SQL Server 2008 introduces a `TIME` data type which allows us to store the time without the date.
`TIME` doesn't include any information on the time zone.  It will accept a time with time zone information but will ignore the time zone.
`TIME` will do an implicit conversion from DATETIME and retain only the time portion.  `TIME` will implicitly accept strings in most common time formats.


- AM/PM [Date and Time Formats](http://www.fmsinc.com/microsoftaccess/sqlserverupsizing/AM_PM_date_time_format.htm) in Microsoft SQL Server
- [Time Period Library for .NET](https://www.codeproject.com/Articles/168662/Time-Period-Library-for-NET)
