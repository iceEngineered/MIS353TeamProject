USE HOWeatherAppDB

GO

--1 spAddWeatherForecast
CREATE PROCEDURE spAddWeatherForecast
@CID int,
@WFTemp int,
@WFDate date

AS
BEGIN

INSERT INTO WeatherForecast(
[CID],
[WFTemp],
[WFDate])
VALUES
(@CID,
@WFTemp,
@WFDate)

END
GO

--2 spGetWeatherForecastsInAugust
CREATE PROCEDURE spGetWeatherForecastsInAugust

@CID int,
@WFDate date

AS
BEGIN
SELECT @CID, @WFDate 
FROM WeatherForecast
WHERE @WFDate < '2023-09-01'

END
GO
