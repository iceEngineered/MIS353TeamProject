USE HOWeatherAppDB;
GO

-- 1 spAddForecastVsActual

Create proc spAddForecastVsActual

 @CityID int,
 @FCTemp int, 
 @ATemp int

AS
BEGIN
INSERT INTO ForecastvsActual([CID]
      ,[FCTemp]
      ,[ATemp])
Values(@CityID
      ,@FCTemp
      ,@ATemp)
END
GO

/*
exec spAddForecastVsActual 5, 35, 40
GO
*/

-- 2 spForecastVsActual
CREATE PROCEDURE spForecastVsActual
    @CityID int
AS
BEGIN
    SELECT CID as "City", FCTemp as "Forecasted Temperature", ATemp as "Actual Temperature" FROM ForecastvsActual WHERE CID = @CityID;
END
GO

/*
EXEC spForecastVsActual 3
GO
*/