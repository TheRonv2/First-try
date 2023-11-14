using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help : MonoBehaviour
{

    GameObject player;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger("help", 1);

        float direction = player.transform.position.x - transform.position.x;

        if (Mathf.Abs(direction) < 20)
        {
            anim.SetInteger("help", 2);
        }
    }
}
