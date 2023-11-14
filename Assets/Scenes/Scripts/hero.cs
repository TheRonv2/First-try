using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hero : MonoBehaviour
{

    Rigidbody2D rb;
    Animator anim;
    private float moveInput;
    int Life = 5;
    public Transform punch1;
    public float punch1Radius;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") == 0)
        {

            anim.SetInteger("popka", 1);
        }
        else
        {
            Flip();
            anim.SetInteger("popka", 2);
        }

       


    }


    void OnTriggerEnter2D(Collider2D shit)
    {
        if (shit.gameObject.tag == "life")
        {
            Life++;
            Destroy(shit.gameObject);
        }


    }


    void OnCollisionEnter2D(Collision2D shit)
    {
        if (shit.gameObject.tag == "pipka")
        {
            Life--;
            if (Life <= 0)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    


    void ReloadFuckingLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }


    void Flip()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 12f, rb.velocity.y);
    }


    void pipirka()
    {
        rb.AddForce(transform.up * 8f, ForceMode2D.Impulse);

        
    }
}