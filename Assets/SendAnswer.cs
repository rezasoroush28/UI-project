using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendAnswer : MonoBehaviour
{
     public int Answer()
     {
         int ans = int.Parse(GetComponent<InputField>().text);
         return ans;
     }

     public void Clean()
     {
         GetComponent<InputField>().text = null;
     }
    
}
