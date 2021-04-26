using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int numKeys = 0;
    public Text keyText;
    
    public void incrementKeys()
    {
        numKeys++;
        keyText.text = "Number of Keys: " + numKeys + "/5";
    }
}
