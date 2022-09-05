using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class save_number : MonoBehaviour
{
	public float number_entered;
	public float outcome;
	public GameObject Go;
	public void submit_number()
	{
		string name = GameObject.Find ("InputField").GetComponent<InputField>().text;
		print ("Saving "+name);
		number_entered = float.Parse(name);
	}
	public void guess()
	{
		Go.GetComponent<show_number>().counter = 0;
		string name = GameObject.Find ("InputField").GetComponent<InputField>().text;
		float num = float.Parse(name);
		float number = num;
		float To_zero = number;
		float To_High = Mathf.Pow(2f,7f) - number;
		
		if(To_High > To_zero)
		{
			float difference = Random.Range(0 , To_zero +1);
			float Mode = Random.Range(0,2);
			if(Mode == 1)
			{
				outcome = number - difference;
			}
			else{
				outcome = number + difference;
		
			}
		}
		else{
			float difference = Random.Range(0 , To_High+1);
			float Mode = Random.Range(0,2);
			if(Mode == 1)
			{
				outcome = number - difference;
			}
			else{
				outcome = number + difference;
		}
	}
	
	}
}
