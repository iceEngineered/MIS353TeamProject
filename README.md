# MIS353TeamProject HW4

Curtis' APIs
* GetCityDisasters
  When given a CityID it returns every natural disaster that's happened there along with the type of disaster (Ex. Hurricane, Tornado, Wildfire) and the date it happened.
  
* AddDisaster
  When given a CityID, Natural Disaster Type, and Date it occured, it adds the information to the database and outputs a 1 if successful.


# Planned Webpages

* View Disaster by City
  A page where a user can go and enter the name of a city and state (Which will be converted into the CityID), after that all disasters that have taken place in that city will be counted and that will be displayed at the top. A list of all disaster with the most recent being displayed at the top, will be posted under the overall count.

* Add a Disaster
  A page where a user will be able to go and enter the location, type, and date of a disaster after it happens. This is meant to be used (hopefully) rarely but will be the main way Natural Disasters are added into the database. A similar list to the 'View Disaster By City' page will be displayed afterward so the user can verify a successful insertion.

* View Aid Organizations by State
  A page where a user will be able to go and enter a state, a list of Disaster Relief organizations will be printed sorted by the highest rating at the top. The list will be taken from the Catastrophe API, documentation can be found here https://documenter.getpostman.com/view/5841816/S17wM6DE. Any user will be able to find multiple aid organizations operating in their state/province if they need them.
