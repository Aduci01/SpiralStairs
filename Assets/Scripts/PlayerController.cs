using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float rotationPerSec;
    public float jumpPower;

    private bool isJumped;
	// Use this for initialization
	void Start ()
    {
        //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, speed);

    }

    void FixedUpdate()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

    }

    // Update is called once per frame
    void Update () {

        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.deltaTime);
        inputHandler();
	}

    private void inputHandler()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -rotationPerSec * Time.deltaTime, 0));
            //transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, rotationPerSec * Time.deltaTime, 0));

            //transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(0, jumpPower, 0);

            //transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
