using UnityEngine;
using System.Collections;
public class EnemyAttack : MonoBehaviour
{
    public GameObject target;
    public float attackTimer;
    public float coolDown;
    GameObject player;

    // Use this for initialization
    void Start()
    {
        attackTimer = 0;
        coolDown = 2.0f;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (attackTimer > 0)
            attackTimer -= Time.deltaTime;

        if (attackTimer < 0)
            attackTimer = 0;

        if (attackTimer == 0)
        {
            Attack();
            attackTimer = coolDown;
        }
    }

    private void Attack()
    {
        
        {
            float direction = player.transform.position.x - transform.position.x;

            if (Mathf.Abs(direction) < 20)
            {
                PlayersHealth eh = (PlayersHealth)target.GetComponent("PlayersHealth");
                eh.AddjustCurrentHealth(-10);
            }
        }
    }
}