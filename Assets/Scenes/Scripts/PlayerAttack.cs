using UnityEngine;
using System.Collections;
public class PlayerAttack : MonoBehaviour
{
    public GameObject target;
    public float attackTimer;
    public float coolDown;
    GameObject Enemy;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        attackTimer = 0;
        coolDown = 2.0f;
        Enemy = GameObject.FindWithTag("Enemy");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (attackTimer > 0)
            attackTimer -= Time.deltaTime;

        if (attackTimer < 0)
            attackTimer = 0;

        if (Input.GetKeyUp(KeyCode.F) && (Input.GetAxis("Horizontal") == 0))
        {
            if (attackTimer == 0)
            {
                anim.SetTrigger("attack");
                Attack();
                attackTimer = coolDown;
            }
        }
        

    }

    private void Attack()
    {
        {
            float direction = Enemy.transform.position.x - transform.position.x;

            if (Mathf.Abs(direction) < 20)
            {
                EnemyHealth eh = (EnemyHealth)target.GetComponent("EnemyHealth");
                eh.AddjustCurrentHealth(-10);
            }
        }
    }
}