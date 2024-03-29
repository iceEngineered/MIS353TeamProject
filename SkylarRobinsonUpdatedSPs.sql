

USE [HOWeatherAppDB]
GO


SET ANSI_NULLS ON 
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spGetWeatherForecastsInAugust]

@CID int
AS
BEGIN
SELECT *
FROM WeatherForecast
WHERE WFDate < '2023-09-01' and CID = @CID

END;

CREATE PROCEDURE spGetCityDetails
    @CID int
AS
BEGIN
    SELECT * FROM City WHERE CID = @CID;
END;
GO

/*
EXEC spHGetCityDetails 
GO
*/

