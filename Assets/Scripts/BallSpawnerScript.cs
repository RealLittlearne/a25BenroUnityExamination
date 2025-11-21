using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefabToSpawn;
    
    private float timeBeforeNextSpawn;
    void Update()
    {
        timeBeforeNextSpawn -= Time.deltaTime;
        if (timeBeforeNextSpawn <= 0)
        {
            timeBeforeNextSpawn = 4f;
            Instantiate(ballPrefabToSpawn, transform.position, transform.rotation);
        }
    }
}
