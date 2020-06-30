using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public static int score;
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
    float verticalInput = Input.GetAxis("Vertical");
    transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
    Vector3 minScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
    Vector3 maxScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minScreenBounds.x + 1, maxScreenBounds.x - 1), Mathf.Clamp(transform.position.y, minScreenBounds.y + 1, maxScreenBounds.y - 1), transform.position.z);

     scoretext.text = score.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            print("ouch");
            SceneManager.LoadScene("Gameover");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        print("oof");
        if (other.gameObject.tag=="Score")
        {
            score += 1;
            print(score);
        }
    }
}
