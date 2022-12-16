using UnityEngine;

public class CoralSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Corals;
    [SerializeField] private float spawnRate = 2;
    private float spawnTime = 0;
    [SerializeField] private float coralOffset = 10;

    void Start()
    {
        spwanCoral();
    }

    void Update()
    {
        if (spawnTime < spawnRate)
        {
            spawnTime += Time.deltaTime;
        }
        else
        {
            spwanCoral();
            spawnTime = 0;
        }
    }
    void spwanCoral()
    {
        float lowestPoint = transform.position.y - coralOffset;
        float highestPoint = transform.position.y + coralOffset;

        Instantiate(Corals,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),transform.position.z), transform.rotation);
    }
}
