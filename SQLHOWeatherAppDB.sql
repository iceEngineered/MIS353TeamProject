create database HOWeatherAppDB
GO

use HOWeatherAppDB
GO

CREATE TABLE [dbo].[City](
[CID] int NOT NULL identity primary key,
[CName] [nvarchar](max) NOT NULL,
[CState] [nvarchar] (max) NOT NULL)

GO

CREATE TABLE [dbo].[WeatherForecast](
[CID] int NOT NULL FOREIGN KEY REFERENCES City(CID),
[WFTemp] [int] NOT NULL,
[WFDate] [date] NOT NULL)

GO

CREATE TABLE [dbo].[NaturalDisasterHistory](
[CID] int NOT NULL FOREIGN KEY REFERENCES City(CID),
[NDType] [nvarchar] (max) NOT NULL,
[NDDate] [date] NOT NULL)

GO


CREATE TABLE [ForecastvsActual](
[CID] int NOT NULL FOREIGN KEY REFERENCES City(CID),
[FCTemp] [int] NOT NULL,
[ATemp] [int] NOT NULL)

GO

SET IDENTITY_INSERT City ON;
INSERT INTO City(CID, CName, CState)
VALUES
(1, 'Morgantown', 'WV'),
(2, 'Miami', 'FL'),
(3, 'Tulsa', 'OK'),
(4, 'Kansas City', 'KS'),
(5, 'New Orleans', 'LA'),
(6, 'Maui', 'HI'),
(7, 'San Diego', 'CA'),
(8, 'Oklahoma City', 'OK'),
(9, 'Houston', 'TX'),
(10, 'Huntsville', 'AL');
SET IDENTITY_INSERT City OFF;
DBCC CHECKIDENT ('City', RESEED, 10);

GO


INSERT INTO WeatherForecast(CID, WFTemp, WFDate)
VALUES
(1, 68, '2023-08-01'),
(1, 67, '2023-09-10'),
(1, 55, '2023-10-20'),
(1, 42, '2023-11-15'),
(1, 54, '2023-12-25'),
(1, 18, '2024-01-16'),
(2, 86, '2023-08-17'),
(2, 80, '2023-09-12'),
(2, 79, '2023-10-03'),
(2, 75, '2023-11-14'),
(2, 73, '2023-12-02'),
(2, 69, '2024-01-04'),
(3, 91, '2023-08-26'),
(3, 74, '2023-09-23'),
(3, 70, '2023-10-03'),
(3, 41, '2023-11-27'),
(3, 39, '2023-12-13'),
(3, 44, '2024-01-05'),
(4, 88, '2023-08-22'),
(4, 72, '2023-09-19'),
(4, 65, '2023-10-09'),
(4, 30, '2023-11-08'),
(4, 35, '2023-12-11'),
(4, 32, '2024-01-05'),
(5, 89, '2023-08-29'),
(5, 92, '2023-09-12'),
(6, 91, '2023-08-18'),
(6, 86, '2023-09-17'),
(6, 84, '2023-10-14'),
(6, 78, '2023-11-06'),
(6, 72, '2023-12-23'),
(6, 69, '2024-01-01'),
(7, 88, '2023-08-09'),
(7, 74, '2023-09-21'),
(7, 68, '2023-10-31'),
(7, 59, '2024-01-12'),
(8, 90, '2023-08-08'),
(8, 72, '2023-09-17'),
(8, 70, '2023-10-16'),
(9, 95, '2023-08-20'),
(10, 93, '2023-08-12')
GO