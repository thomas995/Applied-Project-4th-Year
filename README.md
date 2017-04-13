## Applied-Project-4th-Year

# Description:
A C# Application for my 4th year project as part of a team.

Within this project we created a Brain Training game called BrainWorks using __Universal Windows within Visual Studio 2015.__ The Application is written in __C#__ using __Microsoft Expression Blend__ for the design of the games (Storyboards).

We also have created a __Website__ written in __Golang__ with a __HTML/Javascript/Bootstrap frontend__ that connects to the Universal Application to __pull scores__ into the website using __SQLite/Easy Tables on Azure.__ Golang pulls in the scores from the UWP Application using a __JSON GET request__ to the table on __Azure.__ Golang also connects to a __MySQL database on Azure__ to deal with Login/SignUp to the website. The UWP Application also makes use of __SlashDb (/db) API__ to pull in a list of users registered with our website.

Within this game we have 4 different areas of learning: Attention, Problem-Solving, Memory and Speed.

Within _Attention_ you will find 3 games that are aimed at improving your attention:

1. __Everything has a Porpoise:__ Try to click all of the Porpoise only once to progress to the next level. The porpoise move around the screen using a storyboard created in Blend. The number of Porpoise start out small but grow as the levels progress making it difficult to distinguish which ones you may have already clicked. Click the same porpoise twice and you end the game. Your score is then written to a textbox which is then sent to the SQLite database by pressing a button. The score is displayed in the app along with previous scores you may have saved. You can also refresh the database by pressing a button.

2. __Picture Perfect:__ Look at a picture carefully, then choose which item was in the picture you just looked at by clicking on the right button. Click the wrong one and the game ends. Your score is then recorded in the SQLite database.

3. __Total Recall:__ Using a dictionary in C# to store all of the possible words, the user must enter in as many words as they can think of starting with whatever letters are displayed at that current time. Get 15 words to progress in levels. Enter in the wrong word and you will not get any points. There is a dispatcher Timer to decide when the game ends. Progress in levels to begin the timer again. Let the timer run out befire getting the 5 words then the game ends and the score is recorded in the database.


Within _Speed_ you will find 3 games that are aimed at improving your Speed:

1. __Foal Shadow:__
2. __Go With The BufFlow:__
3. __Spot the Difference:__

Within _Problem-Solving_ you will find 3 games that are aimed at improving your Problem-Solving Skills:

1. __Higher or Lower:__ Upon pressing the start button, you will be met by two clickable buttons. You will be able to click one of these before a new set is randomly made. The aim is to click the one that has the highest combined number. You will be up against the clock with the game becoming progressively more difficult in increments of five correct answers.

2. __Manic Maths:__ While racing against the clock, you must read each randomly generated sentence carefully to see how many fruits the two chosen people have altogether. These answers are entered into the textbox below the paragraph of text and submitted using the button to the right of the textbox. The game is over when the timer reaches zero.

3. __Quick RPG:__ Starting with weaker enemies, and working your way up through the game, you will be tasked with surviving the onslaught of as many randomly selected enemies as possible. To do this, you must level up your character to deal more damage and use your limited stock of potions to recover health as you play. The game ends when your health points(HP) reaches zero.

Within _Memory_ you will find 1 game that is aimed at improving your Memory:

1. __Sequential:__
