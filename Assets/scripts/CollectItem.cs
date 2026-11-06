using System.Runtime.CompilerServices;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
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

        if (other.CompareTag("Coin")) ;

        {
            Destroy(other.gameObject);
        }
    }
}