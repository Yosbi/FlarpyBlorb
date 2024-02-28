using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float deadZone = -45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position 
            + (Vector3.left * moveSpeed)
            * Time.deltaTime;

        if (transform.position.x < deadZone) {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
            
    }

    public void IncreaseSpeedBy(float deltaSpeed) {
        moveSpeed += deltaSpeed;
    }
}
