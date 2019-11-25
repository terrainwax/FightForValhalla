using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    [SerializeField]
    //Reference to the network object script
    private NetworkPlayer np;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        HealthSystem enemyHP = collision.collider.GetComponent<HealthSystem>();
        if (enemyHP)
        {
            //call take damage and supply some raycast hit information
            enemyHP.TakeDamage(5, "test");
        }
    }


        // Update is called once per frame
    void Update()
    {
        
    }
}
