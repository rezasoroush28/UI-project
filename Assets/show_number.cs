using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_number : MonoBehaviour
{
	
	Text text;
	float number;
	float pre_number;
	public GameObject Go;
	public int counter;
	public bool sucess;
    // Start is called before the first frame update
    void Start()
    {
	    text = GetComponent<Text>();
	    counter = 0;
	    sucess = false;
    }

    // Update is called once per frame
    void Update()
	{
		if(!sucess)
		{
			number = Go.GetComponent<save_number>().outcome;
			if(number != pre_number)
			{
				counter ++;
			}
		
			if(number != null && counter <5)
			{
				text.text = number.ToString();  
			}
			else if( counter >= 5)
			{
				text.text = "fail";
			}
			pre_number = number;
		}
		else{
			text.text = "succes";
		}
		
		
	    
    }
}
