using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    private float flapStrenght = 6;
    public _LogicManagerScript _logicManagerScript;
    private bool isBirdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        _logicManagerScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<_LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isBirdAlive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody2D.velocity = Vector2.up * flapStrenght;
            }

            if (transform.position.y > 15 || transform.position.y < -15)
            {
                _logicManagerScript.gameOver();
                isBirdAlive = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _logicManagerScript.gameOver();
        isBirdAlive = false;
    }
}
