using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HL_manage : MonoBehaviour
{
	public GameObject guesses;
	public GameObject answer;
	public float low;
	public float High;
    // Start is called before the first frame update
    void Start()
    {
	    low = 0;
	    High = Mathf.Pow(2f , 7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void lower()
	{
		float G = guesses.GetComponent<show_num>().guesses;
		High = G;
		G = Random.Range(low,G+1);
		guesses.GetComponent<show_num>().guesses = Mathf.Floor(G);
	}
	public void Higher()
	{
		float G = guesses.GetComponent<show_num>().guesses;
		low = G;
		G = Random.Range(G,High);
		
		guesses.GetComponent<show_num>().guesses = Mathf.Floor(G);
		
	}
	public void check()
	{
		float Ans = answer.GetComponent<guess_manage>().answer;
		if(Ans == guesses.GetComponent<show_num>().guesses)
		{
			guesses.GetComponent<show_num>().right = true;
		}
	}
}
