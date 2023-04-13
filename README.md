# Runescape item searcher
## Introduction
Runescape has a big economy with many items and categories. The prices change daily at 0:00 game time (not our time). The price is influenced by the player base. More demand = price going higher or price goes lower when no one is buying the item.
## Motivation
I currently have over 1000 hours in runescape and I always use chrome to search stuff for runescape. But having many tabs open on runescape isn't so nice for your memory. With this tool i can quickly search items and see the current price without needing tons of memory.
## Structure
### Main window
![MainWindowImage](https://github.com/HowestDAE/proj-LeeVangraefschepe/blob/main/Images/MainWindow.png)

The main window contains the search bar and button and ofcourse the runescape logo. It supports paging inside the window. This is where the following pages can be displayed.

### Overview page
![OverviewPageImage](https://github.com/HowestDAE/proj-LeeVangraefschepe/blob/main/Images/OverviewPage.png)

The overview page has the category filter option and lists the items found by using the main page input. When you select a item and click on the open button you will go to the detail page of that item.

There is also a switch repository button for switching between a offline json or the online api (more about that later).
### Detail page
![DetailPageImage](https://github.com/HowestDAE/proj-LeeVangraefschepe/blob/main/Images/DetailPage.png)

The detail page shows the most important data about an item. If you want to see the full history of that item you can click on the open button. This will bring you directly to the web page of that item.
## Repositories
### Online (API)
The online mode always gets the latest data from the API. It uses your input to find specific items with the latest price and info. When there is a new event or new items are added this API will automatically support it.
### Offline
When you are using offline the search input wont have any effect on the result. I do not recommend using it beceause it is also out dated data. This mode has been added for the requirements of the exercise and proof of concept.

For in the future i could integrate the "OfflineRepoCreator" into the main project. So the user can create a full offline repo with the newest data. Then it would make sense to also support searching.
## Result
![ResultGif](https://github.com/HowestDAE/proj-LeeVangraefschepe/blob/main/Images/Result.gif)
