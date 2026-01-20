using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // new

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb; // inisialisasi
    public float jumpForce; // tinggi loncat
    float score;

    public Text scoreTxt; // new
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // pemanggilan inisialisasi
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "" + score; //new
        if (Input.GetMouseButtonDown(0)) // klik mouse kiri / tap untuk hp
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            score++;
        }
            if(collision.gameObject.tag =="pipa")
            {
                Destroy(gameObject);
        }
    }
}

