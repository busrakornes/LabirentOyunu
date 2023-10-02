using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class playerhareket : MonoBehaviour
{
    public float hareketHiz = 5f;
    public float donusHiz = 200f;
    public float jumpGucu = 50f;
   

    public int coinSayisi = 0;
    public Text txtCoinSayisi;
    public GameObject panelGameOver;

    public int toplamCoinSayisi;
    public int aktifLevelNo;

    private Animator animator;
    private Rigidbody rb;

    private bool havada = false;

    void Start()
    {
        animator = GetComponent<Animator>();
         rb = GetComponent<Rigidbody>(); 

    }

    void Update()
    {
        animator.SetBool("run", false);

        if(Input.GetKey(KeyCode.W))
        {
            animator.SetBool("run", true);
            transform.Translate(Vector3.forward * hareketHiz * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -donusHiz * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, donusHiz * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back* hareketHiz * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space) && havada == false)
        {
            havada = true;
            animator.SetBool("jump", true);
            rb.AddForce(force: Vector3.up * jumpGucu, ForceMode.Impulse);
        }
    }
      private void OnCollisionEnter(Collision collision)
     {
        animator.SetBool("jump", false);
        havada = false;

         if (collision.gameObject.tag == "ALTIN")
        {
            Destroy(collision.gameObject);
            coinSayisi++;
            txtCoinSayisi.text = "Altın Sayısı:" + coinSayisi.ToString();

            if (coinSayisi == toplamCoinSayisi)
            {
                Debug.Log("SONRAKİ LEVELI AÇ");
                SceneManager.LoadScene(aktifLevelNo +1);
            } 
        }
        if (collision.gameObject.tag == "MAYIN")
        {
            Destroy(collision.gameObject);
            panelGameOver.SetActive(true);
            Destroy(gameObject);
        }
    } 
}
