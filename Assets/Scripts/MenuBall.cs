using UnityEngine;
using System.Collections;

public class MenuBall : MonoBehaviour {

    public int ballVel = 500;
    public Rigidbody rb;

    void Awake()
    {
        rb.velocity = new Vector3(ballVel, ballVel, 0);
    }
}
