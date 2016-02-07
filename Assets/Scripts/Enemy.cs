using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public float speed = 8;
    Vector3 targetPos;
    GameObject ballObj;

    void Start () {
        ballObj = GameObject.FindGameObjectWithTag("Ball");
	}
	
	void Update () {
        targetPos = Vector3.Lerp(gameObject.transform.position,ballObj.transform.position, Time.deltaTime * speed);
        gameObject.transform.position = new Vector3(20, targetPos.y, 0);
    }
}
