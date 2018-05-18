# SIT305_Project
# Name: Sameera Dinusha Priyananda
# SID:215158268
# Project - Sonic Game App
# Device Platform - Android and iOS
# This game created using by Unity Software.(version 2017.1.0f3)
  for run and test this game app in computer, you must need;
    - the latest version of Unity software in your computer
# Instructions for run the game in Android device:
you will need;

	The latest version of Unity (available here)
	An Android device running the latest version of Android
	The Simple Mobile Placeholder project (available from the Asset Store)
	
	Open the project in Unity
	make sure that you set up the SDK in your unity if not you need to download the SDK pack
	Within Unity, open the Build Settings from the top menu (File > Build Settings).
	Highlight Android from the list of platforms on the left and choose Switch Platform at the bottom of the window
	Open the Player Settings in the Inspector panel (Edit > Project Settings > Player).
	Expand the section at the bottom called Other Settings, and enter your chosen bundle identifier where it says Bundle identifier.
	Using the top menu, navigate to Unity > Preferences (on OSX) or Edit > Preferences (on Windows).
	When the Preferences window opens, navigate to External Tools.
	Where it says Android SDK Location, click Browse, navigate to where you put the directory containing Android SDK Tools and click Choose.

  Preparing your Android device;
  
  	On your Android device, navigate to Settings > About phone or Settings > About tablet.
	Scroll to the bottom and then tap Build number seven times. A popup will appear, confirming that you are now a developer.
	Now navigate to Settings > Developer options > Debugging and enable USB debugging.

  Building and Testing the game on your Android device;
   
   	Connect your Android device to your computer using a USB cable.
	You may see a prompt asking you to confirm that you wish to enable USB debugging on the device. If so, click OK.
	In Unity, open the Build Settings from the top menu (File > Build Settings).
	Click Add Open Scenes to add the Main scene to the list of scenes that will be built.
	Click Build And Run.
  
  # Instructions for run the game in IOS device:
   you will need;
   
	A Mac computer running running OS X 10.11 or later
	The latest version of Xcode (available from the Mac App Store)
	Unity version 2017.1.0f3 or latest version of Unity
	An iOS device
	The Simple Mobile Placeholder project (available from the UnityAsset)
	
	open the project in Unity
	now you need to go to switch platforms in Unity so that we can build our game for iOS.
	Within Unity, open the Build Settings from the top menu (File > Build Settings).
	Highlight iOS from the list of platforms on the left and choose Switch Platform at the bottom of the window.
	
  Building an Xcode project using Unity;
  
	Open the Build Settings from the top menu (File > Build Settings).
	Click Add Open Scenes to add the Main scene to the list of scenes that will be built.
	Click Build to build
	Click the down arrow in the top right of the prompt to expand it, and then click New Folder.
	When prompted to choose a name, enter "Builds" and click Create. This will create a new folder called “Builds” in the root directory for your project.
	In the text input field marked Save As, enter "iOS" and click Save.
	
  Building the sample project to your device using Xcode;
  
  	Double click the .xcodeproj file to open the project with Xcode.
	In the top left, select Unity-iPhone to view the project settings. It will open with the General tab selected.
	Under the topmost section called Identity, you may see a warning and a button that says Fix Issue. This warning doesn’t mean we’ve done anything wrong - it just means that Xcode needs to download or create some files for code signing.
	Click the Fix Issue button.
	A popup will appear, showing details of any teams that have been added to Xcode.
	Make sure that the correct team is shown in the dropdown - if you’re using a free Apple ID, it should be your name followed by "(Personal Team)".
	Click Choose to instruct Xcode to download any required certificates and generate a provisioning profile. The warning will then disappear.
	n your device, go to Settings > Display & Brightness > Auto-Lock.
	To disable locking, select Never.
	(It is worth noting that when in Low Power Mode, the Auto-Lock settings cannot be changed until Low Power Mode is turned off.)
	To turn off Low Power Mode, go to Settings > Battery > Low Power Mode and set this to "Off".
	Now it’s time to build to your device.
	In the top left of the Xcode interface, click Run (the "play" button).
	Enable Developer Mode by choosing Enable, and enter your password when prompted
  	On your device, go to Settings > General > Device Management > Developer App > [your app name].
	Choose your Apple ID, and then choose Trust.
	
  Testing the game on your iOS device;
  
  	Connect your device to your computer.
	Open the Xcode project by double clicking the .xcodeproj icon, as before.
	In Xcode, choose Run (the "play" button).
  
# Directory Layout

  - Sonic Game 
  - Library
  - obj
  - ProjectSettings
  - Assets; 
    
  		1.Animations folder -> all the animations that used for the game
		2.prefebs -> all the game template objects that create new instances of the same object in the scene
		3.scenes -> contains game environment and menus of the game
		4.scripts -> all the code files that conect with the internal workings of the game
		5.Art -> all the object images that I used.
		Phy6Meterials -> physics material that attached to the player to reduce friction. Removing friction will reduce the drag amount of the player and ground.
		
  - Sonic Game.apk (final game APK fikle. you can directly instrall this into your android mobile and play the game)
		
		

		


