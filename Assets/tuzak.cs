using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuzak : MonoBehaviour
{
    public bool ileri_geri;
    public bool don;
    public float hareketHiz;
    public float donmeHiz;

    // Update is called once per frame
    void Update()
    {
        if(ileri_geri==true)
        {
            transform.Translate(0, 0, hareketHiz * Time.deltaTime, Space.World);
        }
        if(don==true)
        {
            transform.Rotate(0, donmeHiz * Time.deltaTime, 0, Space.World);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "plane") 
        {
            hareketHiz *= -1;
        }
    }
}
