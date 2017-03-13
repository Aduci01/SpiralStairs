using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    private float offset;
    public Transform playerTransform;

	// Use this for initialization
	void Start () {
        offset = transform.position.z - playerTransform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z + offset);
	}
}
