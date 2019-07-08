using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberGame : MonoBehaviour {
    public InputField input;
    public Text infoText;
    int guessNumber;
    int userGuess;

    void Start() {
        guessNumber = Random.Range(0, 100);
    }

    public void CheckGuess() {
        userGuess = int.Parse(input.text);
        if (userGuess == guessNumber) {
            infoText.text = "You Guessed The Number!";
        }
        else if (userGuess > guessNumber) {
            infoText.text = "Your number is greater than the Guess number";
        }
        else if (userGuess < guessNumber) {
            infoText.text = "Your number is lower than the Guess number";
        }

        input.text = "";
    }
}