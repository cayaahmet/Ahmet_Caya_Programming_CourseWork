# Tutorial 2
In this tutorial we are going to create a points and a timer system. Also "Game Over Screen" when the timer runs out. The points will go up every time a player collect a delivery point. Both the points system and timer system will have to be linked with UI and show up in the players game view to show them their points and how much time they have left. Every time the player collects a delivery point he will gain extra time. We will also do a High Score for the points, we will use PlayerPrefs for this. Therefore, the high score of the player will never go away and it will update every time that it is beaten.
<br/><br/>
We will start by creating our canvas for all of the UI we will need. To do so right-click the hierarchy and select UI>Canvas.
![image](https://github.com/cayaahmet/Ahmet_Caya_Programming_CourseWork/assets/125205290/4653761c-b671-47e7-b94f-a7b99e2bacb3)
<br/><br/>
Now in our canvas we will start creating all the UI text that we will need. 
<br/><br/>
It's just a bunch of UI>Text and UI>Background to get this look that we need. Create 2 empty game objects and call it "PointsUI" and "TimerUI", also 2 Text UIs are seperate from these game objects and name them "RewardText" and "RewardText1".
<br/><br/>
In the "PointsUI" game object that we created we have to create 2 image backgrounds and 5 Text UIs for points text, deliviries text and high score text. Seperate the "Points:" and "0" as the "0" will increase as the player collects delivery points and will be controlled by the script whereas the "Points:" will always stay the same. Do the same for "Deliviries Text:" and it's number ("0") as well as the "High Score:" and it's "0". 
<br/><br/>
For the "RewardText" and "RewardText1" write "Time increased" and "Well done" in their text as these will act us reward pop ups to give the player a sense of achivement when they collect a delivery as well as make them earn more time.
<br/><br/>
Here is how that will look.
![image](https://github.com/cayaahmet/Ahmet_Caya_Programming_CourseWork/assets/125205290/7c1c181a-e4e9-4d11-bbc4-b7bd11480f53)
<br/><br/>
After doing so we will start creating the 2 scripts that we need.
<br/><br/>
Now create 2 C# scripts one called "PointsSystem" and the other called "TimerUI".
![image](https://github.com/cayaahmet/Ahmet_Caya_Programming_CourseWork/assets/125205290/75474ae4-b38c-43aa-bc2b-c36c6afd10a0)
