##### Deployment guide: First, implement stored procedures on Microsoft SQL Server to connect to your APIs listed in HW4. Create a database to store stored procedures (DbMaker.sql). Copy & paste pages from HW4 and HW5 files respectively into Microsoft Virtual Studio. Run HW4 and 5 simultaneously. If you run into errors, refer to Joshua Meadows' GitHub repository, MIST 353 TravelSite2. 


# Homework 5

## Skylar's  /  City and Weather Forecast Razor Pages
##### The home page welcomes the user and shifts the homeowner's attention to a link that greets them with a dropdown menu. The homeowner can choose whichever city they desire to get the weather forecast for that location. A table is prompted after selection, which gives them the cityID and the WeatherForecast. This data comes from my APIs completed for HW4.

### APIs
#### GetCityData
##### Pulls the data from the SQL server to give the user access to the available city IDs to search.
#### GetWeatherForecasts
##### Gets database information that connects the city ID to the weather forecasts for that city.
###### Sources used: Chat GPT
###### Prompts used: write javascript code for a razor page that asks the user to enter a city id from a dropdown list


## Curtis'   /   Natural Disaster's displayed and able to be filtered by City, Add a natural disaster, and Privacy Policy Razor Pages
### DisastersByCity
Displays all disasters in the database sorted by CityID and allows them to be filtered by CityID
### AddDisaster
Lets a user add a disaster by entering CityID NDDate NDType
### Privacy Policy
Makes it clear any information entered on the AddDisaster page is stored, and that we track nothing else.

## Philip's  /  GetWeatherForecast and AddForecast Razor Pages
##### GetWeatherForecast Supposed to pull the api data from the SQL server to give the user a table of instances where that city got different Forecasts, and what they were originally predicted to be. Was supposed to have the same menu Skylar had for her getForecast but use it differently to keep the feel and structure of the website the same, using the dropdown menu, but i couldn't quite get the API to connect and display on the page. Input was supposed to be the CID from the dropdown used in the URL to take the user to a table with that CID and display every instance that CID was used in.

AddForecast (Create) Lets a user add an instance of a forecast and an actual temp by entering CID, FCTemp ATemp.
### Sources used: Recorded Lectures, ChatGPT when encountering errors, Used Skylar's GetCityData and changed the return value to give a different result from what her page did.
### Prompts used: I am writing code to display different Forecasts in different cities in a table format. The Variables are CID, FCTemp, ATemp. I am also trying to retrieve the data from an API. How would I go about doing this?


