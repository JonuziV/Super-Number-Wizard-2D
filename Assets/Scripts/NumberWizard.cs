using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] int max = 1000;
     [SerializeField] int min = 1;
     [SerializeField] Text guessText;
     int guess = 500;
    void Start()
    {
        StartGame();  
    }

    void StartGame()
    {
        NextGuess();
    }
    // Update is called once per frame
    public void onPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void onPressLower()
    {
        max = guess;
        NextGuess();
    }
    void NextGuess()
    {
      guess = Random.Range( min, max + 1);
      guessText.text = guess.ToString();
    }
}

