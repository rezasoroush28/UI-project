using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GuessManager : MonoBehaviour
{
    public int low, high, actualAnswer , guessTemp;
    public int counter;
    public GameObject[] firstUI;
    public GameObject[] secondUI;
    public bool firstUIbool = true , textBool = false;
    [SerializeField] SendAnswer sendAnswer;

    int GuessOperator()
    {
        if (counter == 1 )
        {
            low = 1;
            high = 127;
            //StartCoroutine(ChangeText());
            changeUI();
            
        }
        //counter++;
        var mid = (high + low) / 2;
        return mid;
    }

    int Guess()
    {
        int guessedNumber;
        if (counter <5)
        {
            guessedNumber = GuessOperator();
            return guessedNumber;
        }
        else
        {
            guessedNumber = (GuessOperator() + Random.Range(0, 5));
            return guessedNumber;
        }
    }

    string Outcome()
    {
        string guessText;
        if (counter <= 5)
        {
            actualAnswer = sendAnswer.Answer();
            int guess = Guess();
            if (Mathf.Abs(actualAnswer - guess) < .01 
                && Mathf.Abs(actualAnswer - guess) >= 0 )
            {
                guessText = (guess.ToString() + ": success");
                counter = 0;
                sendAnswer.Clean();
                StartCoroutine(ChangeText());
                changeUI();
            }
            else
            {
                guessTemp = guess;
                guessText = guess.ToString();
            }
        }
        else
        {
            guessText =  "fail";
            counter = 0;
            sendAnswer.Clean();
            StartCoroutine(ChangeText());
            changeUI();
        }

        return guessText;
    }

    public void SendGuessText()
    {
        counter++;
        //counter will increase
        //checking for succese or fail will be done
        GetComponent<Text>().text = Outcome();
    }

    public void Higher()
    { 
        //changing low and doing SendGuessText again;
        low = guessTemp;
        SendGuessText();
        
    }
    public void Lower()
    { 
        //changing low and doing SendGuessText again;
        high = guessTemp;
        SendGuessText();
        
    }

    
    
    // ReSharper disable Unity.PerformanceAnalysis
    IEnumerator ChangeText()
    {
        yield return new WaitForSecondsRealtime(1);
        GetComponent<Text>().text = "";
    }
    
    public void changeUI()
    {
        for (int i = 0; i < firstUI.Length; i++)
        {
            firstUI[i].SetActive(!firstUIbool) ;
        }
        for (int i = 0; i < secondUI.Length; i++)
        {
            secondUI[i].SetActive(firstUIbool) ;
        }

        firstUIbool = !firstUIbool;
    }


}
