using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    int randX;
    int randY;

    public GameObject ball;

    void Start() {
        Spawn();
    }


    void Update() {
        if (Input.GetMouseButton(0)) {
            Spawn();
        }
    }

    void createRandomPosition()
    {
        randX = Random.Range(-8,8);
        randY = Random.Range(-4,4);
    }

    void Spawn() {
        createRandomPosition();
        Instantiate(ball, new Vector3(randX, randY, 0), Quaternion.identity);
    }
}
