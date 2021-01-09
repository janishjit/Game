using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private BitVector32 offset;

    public GameObject player;

    public GameObject center;

    public GameObject left;
    public GameObject right;

    public int step = 9;

    public float speed = (float)0.01;

    bool input = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input == true) {
            if (Input.GetKey(KeyCode.LeftArrow)) {
                StartCoroutine("moveLeft");
                input = false;
            }
            
            if (Input.GetKey(KeyCode.RightArrow))
            {
                StartCoroutine("moveRight");
                input = false;
            }
        }
    }

    IEnumerator moveRight()
    {
        for (int i = 0; i < (90 / step); i++) {
            player.transform.RotateAround(right.transform.position, Vector3.back, step);
            yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;
    }

    IEnumerator moveLeft()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            player.transform.RotateAround(left.transform.position, Vector3.forward, step);
            yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;
    }
}
