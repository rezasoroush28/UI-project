using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_H_manage : MonoBehaviour
{
	public GameObject Go;
	public GameObject Go_sucess;
	
    // Start is called before the first frame update
	public void guess_lower()
	{
		float new_out;
		float Base = Go.GetComponent<save_number>().number_entered;
		float Guess = Go.GetComponent<save_number>().outcome;
		new_out = Mathf.Floor(Random.Range(Guess,Base));
		Go.GetComponent<save_number>().outcome = new_out;
		
	}
	public void guess_higher()
	{
		float new_out;
		float Base = Go.GetComponent<save_number>().number_entered;
		float Guess = Go.GetComponent<save_number>().outcome;
		new_out = Mathf.Floor(Random.Range(Base,Guess))+1;
		Go.GetComponent<save_number>().outcome = new_out;
	}
	public void check_right()
	{
		float Base = Go.GetComponent<save_number>().number_entered;
		float Guess = Go.GetComponent<save_number>().outcome;
		
		
		if(Base == Guess)
		{
			Go_sucess.GetComponent<show_number>().sucess = true;
		}
	}
}
