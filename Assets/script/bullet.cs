using Unity.VisualScripting;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private float time ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -Time.deltaTime * 50f, 0));
        
    }
}
