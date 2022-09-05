using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guess_manage : MonoBehaviour
{
	public float answer;
	public GameObject Inputfield;
	public GameObject[] guess_Go;
	public GameObject[] answer_Go;
	public GameObject guesses;
	//public string guessed_num;
    // Start is called before the first frame update
    void Start()
    {
	    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void guess()
	{
		string name = GameObject.Find ("InputField").GetComponent<InputField>().text;
		answer = float.Parse(name);
		for(int i=0 ; i<guess_Go.Length ; i++)
		{
			guess_Go[i].SetActive(false);
		}
		for(int i=0 ; i<answer_Go.Length ; i++)
		{
			answer_Go[i].SetActive(true);
		}
		guesses.GetComponent<show_num>().guesses = Mathf.Floor(Random.Range(1f , Mathf.Pow(2f,7f)));
	}
	public void back_to_normal()
	{
		Inputfield.GetComponent<InputField>().text = null;
		for(int i=0 ; i<guess_Go.Length ; i++)
		{
			guess_Go[i].SetActive(true);
		}
		for(int i=0 ; i<answer_Go.Length ; i++)
		{
			answer_Go[i].SetActive(false);
		}
	}
}
