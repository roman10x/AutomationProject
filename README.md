# AutomationProject
Sample of automation project
In Assets/EntitiesPack we have all entities related classes and GoogleDataHelper that can be used to load Json via link and parse it to GoogleRequestObject

Sample of usage located in Assets/Sample
Use InitialScene to start the game
Work with entities loading and checking happens in  Assets/Sample/Scripts/Services/EntitiesManager class

When game is offline, or requested object is null - entity related object will be unavalable in MainMenu. Every open of MainMenu we're checking entites data and trying to make request of them.
