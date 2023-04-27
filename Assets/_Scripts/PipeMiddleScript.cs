using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public _LogicManagerScript _logicManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        _logicManagerScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<_LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _logicManagerScript.addScore(1);
    }
}
