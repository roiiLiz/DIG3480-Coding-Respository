using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwoBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 2);
        if (transform.position.x < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}

/* Changelog:
    -Removed y-axis movement
    -Added x-axis movement
    -Changed if statement from transform.position.y to transform.position.x
    -Altered time rate from 3 --> 2

    -Liz Thompson 11/5/23
*/