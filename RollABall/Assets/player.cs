using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Rigidbody rd;
    public int score = 0;
    public Text scoreText;
    public GameObject Wintext;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rd.AddForce(Vector3.right);
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //Debug.Log(h);
        rd.AddForce(new Vector3(h,0,v)*3);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Food")
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = "分数:" + score;
        }
        if(score==6){
            Wintext.SetActive(true);
        }
    }

}
