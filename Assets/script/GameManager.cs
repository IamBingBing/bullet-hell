using System.Collections.Generic;
using Mono.Cecil;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Rendering;

public class GameManager : MonoBehaviour
{
    public GameObject bullet;
    public GameObject plane;
    public float generatespeed = 0.1f;
    private float timestamp = 0;
    public TextMeshPro text;
    private List<GameObject> bullets = new List<GameObject>();
    private float live;
    void Start()
    {
        live = Time.time;
        text.gameObject.SetActive(false);
    }
    void GameOver()
    {
        Time.timeScale = 0;
        text.gameObject.SetActive(true);
        text.text = "GameOver\n you survive " + (Time.time - live).ToString() + "seconds";
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
            bul.transform.position = planev += new Vector3(randx * 0.1f, randy * 0.1f, 50);
            bullets.Add(bul);
            if (bullets.Count > 20)
            {
                Destroy(bullets[0]);
                bullets.RemoveAt(0);
                
            }
        }
        
    }
}
