using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hallo");
        Debug.Log(gameObject.name);
        gameObject.GetComponent<Button>().transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MouseEnter()
    {
        gameObject.GetComponent<Button>().transform.localScale = new Vector3(1.05f, 1.05f, 1.05f);
    }
    public void MouseExit()
    {
        gameObject.GetComponent<Button>().transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
