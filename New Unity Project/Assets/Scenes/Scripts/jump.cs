using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    bool is_ground = false;
    Rigidbody2D player;
    Animator anim;
    public float force = 6;
    

    void Start()
    {
        player = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

    }

    void OnTriggerStay2D(Collider2D col){
        if (col.tag == "ground") is_ground = true;
    }
     void OnTriggerExit2D(Collider2D col){
        if (col.tag == "ground") is_ground = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && is_ground)

        player.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }
}