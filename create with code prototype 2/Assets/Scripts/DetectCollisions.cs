using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject); *old before slider*
        //Destroy(other.gameObject); *old before slider*

        if (other.CompareTag("Animal"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            other.GetComponent<Transform>().localScale = new Vector3(3, 3, 3);
            Destroy(gameObject);
        }
    }
}
