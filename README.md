# Shagai Project
Mongolian Traditional Shagai Fortune Telling Game

# Shagai Fortune Teller

This C# Windows Forms application simulates the traditional Mongolian game of Shagai, a form of fortune-telling using sheep astragalus bones. 
The game involves throwing four "shagai" and interpreting the results based on the combinations of their faces. 
This digital version provides a user-friendly way to experience this cultural practice.

## Features

* **Random Shagai Throws:** The application uses a random number generator to simulate the throwing of four shagai, each with four possible faces: Horse, Sheep, Camel, and Goat.
    * Implementation: `Shagai.cs`, lines within the `button1_Click` event handler, specifically where `shagaiFace.Next(0, 4)` is used.
      
* **Visual Representation:** The results of the throws are displayed visually using picture boxes, each showing an image corresponding to the shagai face.
    * Implementation: `Shagai.cs`, lines within `LoadShagaiImages()` where the dictionary `shagaiImages` is filled, and lines within `button1_Click` where `pictureBox1.Image = shagaiImages[results[0]];` etc. are used.
      
* **Interpretation Dictionary:** The application uses a dictionary to store and retrieve interpretations based on the combination of shagai faces. This provides meaningful feedback to the user.
    * Implementation: `Shagai.cs`, lines within `button1_Click` where `interpretations.ContainsKey(key)` and `MessageBox.Show($"{interpretations[key]}")` are used.
      
* **Sound Effects:** A sound effect is played when the button is clicked, enhancing the user experience.
    * Implementation: `Shagai.cs`, lines within `button1_Click` where the `SoundPlayer` class is used.
      
* **Attempt Counter:** The application restricts the number of attempts to three, adding a game-like element.
    * Implementation: `Shagai.cs`, lines within `button1_Click` where the `attempts` variable is decremented, and the `UpdateAttemptsLabel()` method is called.
      
* **Win Conditions:** The game includes two win conditions. All four shagai are different, or all four shagai are horses.
    * Implementation: `Shagai.cs`, lines within `button1_Click` where the results are checked using `.Distinct().Count() == 4` and `.All(r => r == ShagaiFace.Horse)`.
* **Manu Strips:** The Manu Strip provides quick navigation and includes three main options:

         **Exit:** Closes the application.
            * Implementation: exToolStripMenuItem_Click method handles the exit functionality using: Application.Exit();
         **Shagai Game:** Displays an introduction to Shagai fortune telling, including its cultural and historical significance.
            * Implementation: shagaiGameToolStripMenuItem_Click method creates an introductionText string and shows it using:
               MessageBox.Show(introductionText, "Introduction of Shagai Fortune Telling Game"); 
         **Rules:** Displays the game rules and guides the player through gameplay mechanics.
         * Implementation: ruleToolStripMenuItem_Click method creates a rulesText string and shows it using: MessageBox.Show(rulesText, "Game Rules");


## How to Run

1.  **Prerequisites:**
    * Visual Studio (or a compatible C# IDE)
    * The sound file "click-soundeffect.wav" must be in the correct path or added to the resource files.
2.  **Clone the Repository:** Clone this repository to your local machine.
3.  **Open the Solution:** Open the `ShagaiProject.sln` file in Visual Studio.
4.  **Build and Run:** Build the solution and run the application.
5.  **Play the Game:** Click the "Throw" button to simulate the shagai throws and receive an interpretation.

## Notes

* The images for the shagai faces are included in the project's resources.
* The sound file path is currently hardcoded. For easier deployment, the sound file should be added to the project's resources.
* The PictureBox SizeMode is recommended to be set to Zoom, for better image display.
* The application uses MessageBoxes to display information, for a better experience, Labels within the form could be used.

## Future Improvements

* Add a "Restart" button.
* Improve the UI with a more visually appealing design.
* Add more interpretations and winning combinations.
* Implement a score-tracking system.
* Allow the user to change the sound volume.
* Add more sounds.
