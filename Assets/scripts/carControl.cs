using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carControl : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Vertical") * Time.deltaTime * speed, 0, 0);

        if(Input.GetKey("left"))
        {
            transform.Rotate(0f, 0f, 10f * Time.deltaTime * 15);
        }
        
        if(Input.GetKey("right"))
        {
            transform.Rotate(0f, 0f, -10f * Time.deltaTime * 15);
        }
    }
}
