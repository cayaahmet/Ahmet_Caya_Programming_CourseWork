# Tutorial 3
In this tutorial we are going to create a main menu, character selection screen. Create 2 character prefabs for the player to choose from which will be a "motorcycle" and a "taxi". We will also use "PlayerPrefs" to remember the player's character selection so that if the player presses "restart" or "retry" then the game will start over with the character that was selected last.
<br/><br/>
We will start by creating a scene called "MainMenu". You can do so by right-clicking in a empty spot in the "Project" settings. 
![image](https://github.com/cayaahmet/Ahmet_Caya_Programming_CourseWork/assets/125205290/b13498ea-b78e-4cd2-83a0-202071c3c595)
<br/><br/>
And create another one called "CharacterSelectScene".
<br/><br/>
![image](https://github.com/cayaahmet/Ahmet_Caya_Programming_CourseWork/assets/125205290/22fbf996-2eba-4964-93f1-c74ca60d5345)
<br/><br/>
Add the scenes to the "Build Settings".
<br/><br/>
![image](https://github.com/cayaahmet/Ahmet_Caya_Programming_CourseWork/assets/125205290/b6e23d08-27bd-4e49-8337-294fe43605cf)
<br/><br/>
You can create the black background effect by going in the camera in the hierarchy and pressing Clear Flags and putting the option as "Solid Colour" and then changing the background color to black.
![image](https://github.com/cayaahmet/Ahmet_Caya_Programming_CourseWork/assets/125205290/a5007b03-2a43-475b-88dc-a5bc2bb52d56)
<br/><br/>
For the Main Menu create a canvas and an empty game object inside it called "MainMenuUI".
<br/><br/>
Inside this empty game object we need 1 text UI for the title and 2 buttons, the play button will take the player to the character selection screen. And the quit button will quit the game.
![image](https://github.com/cayaahmet/Ahmet_Caya_Programming_CourseWork/assets/125205290/b33a470b-b4f0-40c7-ba32-3c5f75fb177f)
<br/><br/>
Now, lets create a script called MainMenuUI and write this code.
<br/><br/>
![image](https://github.com/cayaahmet/Ahmet_Caya_Programming_CourseWork/assets/125205290/c323a583-083a-467d-aea5-09c6d70b2a55)
<br/><br/>
Attach the code to your empty game object called MainMenuUI in the canvas and drag and drop the references needed.
<br/><br/>
![image](https://github.com/cayaahmet/Ahmet_Caya_Programming_CourseWork/assets/125205290/b6b471d5-8dcf-408f-8df0-a3e17732838f)
<br/><br/>
Great, now thats all ready so we can move onto our character selection scene.


