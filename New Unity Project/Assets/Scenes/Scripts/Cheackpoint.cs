using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheackpoint : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("PositionPlayer") == 1)
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("xPosition"), PlayerPrefs.GetFloat("yPosition"), PlayerPrefs.GetFloat("zPosition"));
        }
       

        if (PlayerPrefs.GetInt("PositionPlayer") == 2)
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("xPosition"), PlayerPrefs.GetFloat("yPosition"), PlayerPrefs.GetFloat("zPosition"));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("cheackpoint"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 1);
            PlayerPrefs.SetFloat("xPosition", transform.position.x);
            PlayerPrefs.SetFloat("yPosition", transform.position.y);
            PlayerPrefs.SetFloat("yPosition", transform.position.z);
        }

        if (collision.CompareTag("cheackpoint2"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 2);
            PlayerPrefs.SetFloat("xPosition", transform.position.x);
            PlayerPrefs.SetFloat("yPosition", transform.position.y);
            PlayerPrefs.SetFloat("yPosition", transform.position.z);
        }
    }

    
}
