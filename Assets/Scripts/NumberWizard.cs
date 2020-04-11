using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    void StartGame() {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();
        //Debug.Log("Is it higher or lower than guess: " + guess);
    }

    /*// Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Eyy, so we guessed it correctly! Your number is: "+guess);
            StartGame();
        }
    }*/
}
