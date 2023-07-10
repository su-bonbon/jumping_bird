using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdjump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpower;
    // Start is called before the first frame update
    void Start()  // only when the program started
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()  // every frame
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpower; // (0, 1) * jumpower
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (score.score1 > score.bscore1)
        {
            score.bscore1 = score.score1;
        }
        SceneManager.LoadScene("gameoverscene");
    }
}
