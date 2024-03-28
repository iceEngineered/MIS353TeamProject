
USE HOWeatherAppDB;
GO

-- 1 spAddDisaster
Create proc spAddNatDisaster
 @CID int,
 @NDType nvarchar(20), 
 @NDDate date --START date of disaster (if it even spans multiple dates)
AS
BEGIN
INSERT INTO NaturalDisasterHistory([CID]
      ,[NDType]
      ,[NDDate])
Values(@CityID
      ,@NDType
      ,@NDDate)
END
GO

/*
exec spAddNatDisaster 2, 'ab', '2022-1-1'
GO
*/

-- 2 spGetDisasterEventByCity
CREATE PROCEDURE spGetDisasterEventsByCity
    @CID int
AS
BEGIN
    SELECT CID, NDDate, NDType  FROM NaturalDisasterHistory WHERE CID = @CID;
END
GO

/*
EXEC spGetDisasterEventsByCity 2
GO
*/
