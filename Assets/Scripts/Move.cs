using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed = 3f;
    public static bool stop;
    // Start is called before the first frame update
    void Start()
    {
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false)
        {
            var temp = transform.position.z;
            temp = temp + Time.deltaTime * speed * 1;
            transform.position = new Vector3(0, 0, temp);
            //transform.position = new Vector3(speed*Time.deltaTime*3f, 0, 0);
        }
        else
        {
            gameObject.AddComponent<Rigidbody>();
        }

    }
}
