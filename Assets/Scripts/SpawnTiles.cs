using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTiles : MonoBehaviour
{

    public GameObject tileToSpawn;

    public GameObject referenceObject;

    public float timeOffset = 0.4f;

    public float distanceBetweenTiles = 5f;

    public float randValue;

    private Vector3 previousTilePostion;

    private float startTime;

    private Vector3 direction;

    private Vector3 mainDirection = new Vector3(0, 0, 1);
    private Vector3 otherDirection = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        previousTilePostion = referenceObject.transform.position;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time + startTime > 0.4f)
        {
            if(Random.value < randValue)
            {
                direction = mainDirection;
            }else
            {
                Vector3 temp = direction;
                direction = otherDirection;
                mainDirection = direction;
                otherDirection = temp;
            }
            Vector3 spawnPos = previousTilePostion + distanceBetweenTiles * direction;
            startTime = Time.time;
            Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0,0,0));
            previousTilePostion = spawnPos;
        }
    }
}
