using UnityEngine;

public class plane : MonoBehaviour
{
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("Bullet"))
        {
            other.gameObject.SetActive(false);
            GameManager.instance.GameOver();
        }
    }
}
