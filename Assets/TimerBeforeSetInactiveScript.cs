using UnityEngine;

public class TimerBeforeSetInactiveScript : MonoBehaviour
{
    [SerializeField] private float timeToDisapear;
    private float timer;
    
    public void StartTimer()
    {
        gameObject.SetActive(true);
        timer = timeToDisapear;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
