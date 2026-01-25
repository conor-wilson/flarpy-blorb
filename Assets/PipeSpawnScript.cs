using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnInterval = 2; // (seconds)
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnInterval)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
        timer = 0;
    }
}
