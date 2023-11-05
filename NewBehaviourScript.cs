using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{

    public float speed;
    public float horizontalInput;
    public float verticalInput;
    public float horizontalScreenLimit;
    public float verticalScreenLimit;

    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;
        horizontalScreenLimit = 9.5f;
        verticalScreenLimit = 1.25f;
}

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);
        if (transform.position.x > horizontalScreenLimit || transform.position.x < -horizontalScreenLimit)
        {
            transform.position = new Vector3(-horizontalScreenLimit, transform.position.y, 0);
        }
        else if (transform.position.x < -horizontalScreenLimit)
        {
            transform.position = new Vector3(horizontalScreenLimit, transform.position.y, 0);
        }

        if (transform.position.y > verticalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x, -verticalScreenLimit - 3, 0);
        }
        else if (transform.position.y < -verticalScreenLimit - 3)
        {
            transform.position = new Vector3(transform.position.x, verticalScreenLimit, 0);
        }
    }

}
