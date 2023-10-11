# Assignment-1
This is a non profit school assingment that used [Unity's Prototype1 Models](https://learn.unity.com/tutorial/set-up-your-first-project-in-unity?uv=2021.3&courseId=5cf96c41edbc2a2ca6e8810f&projectId=5caccdfbedbc2a3cef0efe63#) for educational purposes.

Student name: Aphiwit Lekphet
Unity ver: 2022.3.8f1

Intended behaviours/mechanics:
* Vehicles should be able to move using WASD or the arrow buttons.
* Vehicles should be able to flip over if the player is going at high speed towards a direction and turning too hard.
* Vehicles should be able to collide with the other player, checkpoints, barrels (I use these as my walls), and the lap checkpoint (LapManagerGO).
* Split camera should show both players.
* Speed power ups should just add force att the direction the player is looking towards.
* Main menu should take you into level1 or quit the application.

Unintended behaviours/mechanics that have yet to be fixed:
* The camera that follows the player can induce seizure as it is also flipped over if the player vehicles if flipped.
* Wheels can despawn from the player vehicle prefab when they are respawned into the scene after falling off the map.
* As the speed power up add force towards the direction the player is looking; if say the player is slighty tilted looking down, the force applied from the power up would be directed into the ground rather than
  towards the direction the player wanted to go. (Depends on the vehicles rb settings and model. The red and blue car should not have as much issue as for exaple; the tank.)


  
Instructions:
* Boot up the game from the main menu scene and it should work from there.

If it didn't work:
1. Check in the build settings if the following scenes exist:
   1. MainMenu
   2. Level1
   3. Level2
   4. Level3
   5. EndCreditScene
      
2. Check if the levels have the following gameobjects in them and that their neccesary components are attached:
   1. EventSystem - nothing to attach
   2. GameManager - player1Controller.cs and player2Controller.cs, and LapManagerGO.cs.
   3. LapManagerGO - It should have a list containing all of the checkpoint in the scene.
   4. Checkpoints - they should contain indexes that match the order of their placement on the map.
   5. MenuCanvas:
        1. PauseMenu.cs should contain PauseMenu game object and PlayerStats game object.
        2. PlayerStatWindowManager.cs should contain lapManager.cs, player1Controller.cs and player2Controller.cs, lapCountText for player1 and lapCounttext for player2 (TextMeshProUGUI).
   7. Player1 - should have a vehicle attached to it.
   8. Player2 - shoudl have a vechicle attached to it.



Main idea:
Have a structure that can be reskinned and is reuseable.

Structure:
The GameManager will watch over the games set lap and the players lap value, if the players respective laps matches the set lap count then the game will transition sceen using sceenemanager.
The LapManagerGO is red checkpoint with a script attached to it that uses a list of of all the checkpoints in the scene to check if the players saved index matches that of the list.count.
The checkpoint sees if the player took the correct way by looking at the players index = current checkpoint index -1.
The MenuCanvas has 2 nestled GOs in it; PauseMenu and PlayerStats.
  - PauseMenu is by default not set to active but is set active if the player presses ESC key, this also works in reverse as this event uses the same method; OnPause_OnResume().
  - PlayerStats currently consists of two panels containing info regarding the respective players stats, such as their lap count and in the future could contain more stuff such as their; hp, def, speed, etc.
    I structured it this way so that I can later implement those features as I want to try and make a slightly RPG-ish racing game with a focus on PvP.

Player related structure:
The players contains the playercontroller.cs and works as parent GOs that are meant to have a vehicle prefab attached to them, I structured it this way so that one could in the future choose between their vehicle models.

The playercontroller.cs is used for both player 1 and player 2 and a plethora of variables that are used for movement calculations and etc, some being public and private of course but a handfull of variables are currently not being in used in the current build.

The player 2 game object has a extra component; Player2CameraManager.cs - this script gets the vehicles rigidbody and camera to manage the player 2 split screen camera system, it also destroys player 2's audio listener.

The player despawns if they collide with a barrier that covers the map. The despawn mechanic utilizes 

Powerup related structure:
Used scriptable object as a basis so that the system could be reskinned and reuseable. I mostly followed BMo's video about it while adding some small twists to it.
https://www.youtube.com/watch?v=PkNRPOrtyls

Key mappings:
Player 1;
W&S - forward and backward
A&D - turn right and left

Player 2;
Up-arrow & down-arrow - forward and backward
Right-arrow & left-arrow - turn right and left

ESC-key - pause the game

Sources and inspiration:
[Used for main menu](https://www.youtube.com/watch?v=zc8ac_qUXQY)
[Used for pause menu](https://youtu.be/JivuXdrIHK0?si=ONjGnC8vELvMTL2d)
[Used as inpiration for playermovement](https://learn.unity.com/project/unit-1-driving-simulation?uv=2021.3&courseId=5cf96c41edbc2a2ca6e8810f)
[I also used this as inpiration for playermovement](https://youtu.be/Ul01SxwPIvk?si=9L4xMVU9U_pZuTbE)
[Used for learning basics behind text mesh pro](https://youtu.be/bR0clpZvjXo?si=KHU4IzbCAMDitpSs)
[Used as inpiration when making lap system](https://youtu.be/F1JRy8nFTb4?si=Bi1oaE6SdILuRjoo)
[Used for making power up](https://www.youtube.com/watch?v=PkNRPOrtyls)
[Used this as inpiration for reloading my player into the sceen when they hit the despawn plane](https://www.youtube.com/watch?v=CLSiRf_OrBk&pp=ygUQYnJhY2tleXMgcG93ZXJ1cA%3D%3D)
[Used as inspiration for making my player 2 camera split screen](https://youtu.be/rw2VKAdTdgQ?si=DUhicDTt8kLe1_Ba)
