using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class show_num : MonoBehaviour
{
	public float guesses;
	public GameObject HL;
	public GameObject game_manage;
	float counter;
	float pre;
	public bool right;
	float T;
	
    // Start is called before the first frame update
    void Start()
	{
		T = 0;
	    counter = 0;
	    right = false;
    }

    // Update is called once per frame
    void Update()
	{
		
		if(pre != guesses)
		{
			counter++;
		}
		if(counter<5 && !right)
		{
			GetComponent<Text>().text = guesses.ToString();
			pre = guesses;
		}
		else if(counter>=5 && !right)
		{
			GetComponent<Text>().text = "Fail";
			T+=Time.deltaTime;
			if(T >2)
			{
				counter = 0;
				game_manage.GetComponent<guess_manage>().back_to_normal();
				T = 0;
				HL.GetComponent<HL_manage>().low = 0;
				HL.GetComponent<HL_manage>().High = 128;
			}
		}
		else if(right)
		{
			right = false;
			GetComponent<Text>().text = "success";
			T+=Time.deltaTime;
			if(T >2)
			{
				game_manage.GetComponent<guess_manage>().back_to_normal();
				T = 0;
				HL.GetComponent<HL_manage>().low = 0;
				HL.GetComponent<HL_manage>().High = 128;
			}
			
		}
	    
	}
	
}
