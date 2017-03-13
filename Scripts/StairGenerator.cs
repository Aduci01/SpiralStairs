using UnityEngine;
using System.Collections;

public class StairGenerator : MonoBehaviour {

    public GameObject player;
    public float stairHeight;
    public Transform generationPoint;
    public GameObject stairPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (player.transform.position.y > generationPoint.position.y)
        {
            generationPoint.position = new Vector3(0, stairHeight * 3 + generationPoint.transform.position.y, 0);
            GameObject stair = Instantiate(stairPrefab);
            stair.transform.position = new Vector3(0, generationPoint.transform.position.y, 0);
        }
	}
}
