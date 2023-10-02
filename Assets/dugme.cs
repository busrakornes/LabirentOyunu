using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dugme : MonoBehaviour
{
    public void YenidenBasla()
    {
        Debug.Log("Düğmeye basıldı..");
        SceneManager.LoadScene(0);
    }
}
