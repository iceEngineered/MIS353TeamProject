# Homework 5

## Skylar's  /  City and Weather Forecast Razor Pages
##### The home page welcomes the user and shifts the homeowner's attention to a link that greets them with a dropdown menu. The homeowner can choose whichever city they desire to get the weather forecast for that location. A table is prompted after selection, which gives them the cityID and the WeatherForecast. This data comes from my APIs completed for HW4.

###APIs
#### GetCityData
##### Pulls the data from the SQL server to give the user access to the available city IDs to search.
####GetWeatherForecasts
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


##### Deployment guide: First, implement stored procedures on Microsoft SQL Server to connect to your APIs listed in HW4. Create a database to store stored procedures. Copy & Paste pages from HW4 and HW5 files respectively into Microsoft Virtual Studio. Run HW4 and 5 simultaneously. If you run into errors, refer to Joshua Meadows' GitHub repository, MIST 353 TravelSite2. 
