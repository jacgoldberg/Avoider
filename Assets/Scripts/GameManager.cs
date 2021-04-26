using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int numKeys = 0;
    public Text keyText;
    
    //A thing for future implementation but lets you collect keys.
    public void incrementKeys()
    {
        numKeys++;
        keyText.text = "Number of Keys: " + numKeys + "/5";
    }
}
