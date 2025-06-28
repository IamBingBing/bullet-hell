using Mono.Cecil;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Rendering;

public class GameManager : MonoBehaviour
{
    public GameObject bullet;
    public GameObject plane;
    public float generatespeed = 0.2f;
    private float timestamp = 0;
    
    void GameOver()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        if (Time.time > timestamp + generatespeed)
        {
            timestamp = Time.time;

            GameObject bul = Instantiate(bullet);
            float randx = Random.Range(-100, 100);
            float randy = Random.Range(-100, 100);
            Vector3 planev = plane.transform.position;
            bul.transform.position=  planev+= new Vector3(randx*0.1f,randy*0.1f,50);
        }
    }
}
