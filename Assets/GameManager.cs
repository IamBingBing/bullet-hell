using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject bullet;
    
    void GameOver()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Instantiate(bullet);
    }
}
