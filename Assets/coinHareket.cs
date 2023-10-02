using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinHareket : MonoBehaviour
{
    public bool don;
    public float donmeHiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (don == true)
        {
            transform.Rotate(0, donmeHiz * Time.deltaTime, 0, Space.World);
        }
    }
}
