using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pureiya1ugoki : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("i"))
        {
            transform.position += transform.forward * 0.1f;
        }
        if (Input.GetKey("k"))
        {
            transform.position -= transform.forward * 0.1f;
        }
        if (Input.GetKey("l"))
        {
            transform.Rotate(0, 5, 0);
        }
        if (Input.GetKey("j"))
        {
            transform.Rotate(0, -5, 0);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            transform.position = new Vector3(-6.4f, 2.5f, 7.4f);

        }
}}
