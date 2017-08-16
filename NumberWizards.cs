using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {
// A ; following the name of an instance variable will "Declare" it, making it referrable throughout the script but not assigning it an initial value. By assigning an initial value, you also "Initialise" it.
	int max = 1000; //Int (or Integer) is used for any countable variable, such as whole numbers (or integers)
	int min = 1; //To define an Integer, use the form: int <name> = <value>
	int guess = 500;

	// Use this for initialization
	void Start () {
		StartGame();// This calls the function StartGame and plays out its code. To call a function simply use <FunctionName>()
	}

	void StartGame ()//To create a custom function begin on the base indent and use the form: void <FunctionName> ()
	{//Don't forget to add these to any function you create, otherwise the function will never actually include anything.
		print ("Welcome to Number Wizard"); //Print returns a specified string to the user
		print ("Pick a number in your head, but don't tell me!"); //Print form: print (<string>)
		//A String is a series of characters such as a word or phrase. Strings are defined by wrapping text with ""

		print ("The highest number you can pick is " + max); //This is an example of how to complete a string with a variable
		print ("The lowest number you can pick is " + min); //"+ <var>" at the end of a string will add the specified variable to the end of the string

		print ("Is the number highger or lower than " + guess + "?");
		print ("Press the 'Up Arrow' for higher, 'Down Arrow' for lower, or 'Enter' if I guessed your number!");
		print ("Please don't lie, it breaks me! If you make a mistake, press R to start again.");

		max = max + 1; //This line solves the problem of rounding down the guess to 999 indefinitely if the player thinks of 1000.
	}

	// Update is called once per frame
	void Update ()
	{
		//Input.GetKeyDown tells the program to respond to the keyboard input of a key being pressed down
		if (Input.GetKeyDown (KeyCode.UpArrow)) { //KeyCode.<Key> defines the key on the keyboard being used
			min = guess;
			NextGuess ();
		} 
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess ();
		}		 
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won! Press Space to play again!");
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			Restart();
			max = max + 1;
			print ("Let's start again! Is your number " + guess + "?");
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Restart();
			StartGame ();
		}
	}

	void NextGuess () //New functions should only be made for code that you intend to use more than once, otherwise you're just overcomplicating things.
	{
		guess = (max + min) / 2; // Math can be done in code using simple BODMAS notation
		print ("Hmm...Is your number " + guess + "?");
	}

	void Restart ()
	{
		min = 1;
		guess = 500;
		max = 1000;
		print ("==================");
	}
}
// The "Scope" of a piece of code or variable refers to the range of functions it is applicable to. Initialising a variable before Start() is called will give it a scope of the entire script. These are called "Instance Variables".
// A piece of code's or variable's scope should not be increased unless required. Limited scope can be quite helpful.