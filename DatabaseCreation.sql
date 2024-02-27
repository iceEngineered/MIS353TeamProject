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

    
CREATE TABLE [ForecastvsActual](
[CID] int NOT NULL FOREIGN KEY REFERENCES City(CID),
[FCTemp] [int] NOT NULL,
[ATemp] [int] NOT NULL)
SET IDENTITY_INSERT City ON;

GO


    
CREATE TABLE [dbo].[NaturalDisasterHistory](
[CID] int NOT NULL FOREIGN KEY REFERENCES City(CID),
[NDType] [nvarchar] (max) NOT NULL,
[NDDate] [date] NOT NULL)

GO
    
ALTER TABLE NaturalDisasterHistory ADD CONSTRAINT PK
  PRIMARY KEY (CID, NDDate)
GO
