CREATE TABLE [dbo].[tblAppointments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [text] VARCHAR(50) NULL, 
    [appointment_type] VARCHAR(50) NULL, 
    [start_date] DATETIME NULL, 
    [end_date] DATETIME NULL, 
    [time] NCHAR(10) NULL
)
