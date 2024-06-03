using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 7;
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(new Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(new Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(new Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(new Vector3.right * Time.deltaTime * speed);
        }
    }
}
