using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public TextMesh currScore;
    public GameObject ballPref;
    public Transform paddleObject;

    GameObject ball;
    int score;

    void Update() {
        ball = GameObject.FindGameObjectWithTag("Ball");
        currScore.text = "" + score;
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Ball")
        {
            score += 1;
            Destroy(ball);
            (Instantiate(ballPref, new Vector3(paddleObject.transform.position.x + 2, paddleObject.transform.position.y, 0),Quaternion.identity) as GameObject).transform.parent = paddleObject;
        }
    }
}
