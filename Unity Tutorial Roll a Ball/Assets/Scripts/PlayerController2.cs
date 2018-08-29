using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //need for UI

public class PlayerController2 : MonoBehaviour
{

    private Rigidbody rb;
    private int count;
    public float speed;
    public Text countText;
    public Text winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //will find and return a ref to the attached Rigidbody
        count = 0;
        SetCountText();
        winText.text = "";
    }
    private void Update() //called before rendering a frame, game code will go
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 4)
        {
            winText.text = "You Win!";
        }
    }
}
