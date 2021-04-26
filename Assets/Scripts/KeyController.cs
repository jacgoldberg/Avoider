using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public GameObject gameManager;

    //Key logic
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            gameManager.GetComponent<GameManager>().incrementKeys();
            Destroy(this.gameObject);
        }
    }
}
