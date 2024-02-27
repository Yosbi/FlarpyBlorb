using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3.0f;
    private float timer = 0.0f;
    public float heightOffset = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } 
        else {
            spawnPipe();
            timer = 0.0f;
        }
        
    }

    void spawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, 
                new Vector3(
                    transform.position.x, 
                    Random.Range(lowestPoint, highestPoint), 
                    0), 
                transform.rotation);
    }
}
