using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject objectToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void hitButton()
    {
        Debug.Log("Hit the button");

        Destroy(objectToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
