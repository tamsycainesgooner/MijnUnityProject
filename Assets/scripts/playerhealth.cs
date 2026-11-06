using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int playerhealth = 100;
    public Transform startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Killzone"))
        {
            Debug.Log("change position");
            playerhealth -= 20;
            gameObject.transform.position = startPos.position;
        }
    }
}


