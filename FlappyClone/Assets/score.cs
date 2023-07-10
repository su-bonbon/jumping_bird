using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int score1 = 0;
    public static int bscore1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        score1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score1.ToString();
    }
}
