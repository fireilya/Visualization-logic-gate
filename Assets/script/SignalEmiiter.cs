using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalEmiiter : MonoBehaviour
{
    CubeMeaning selfMeaning;
    [SerializeField]
    Visualisation output;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor") return;
        var meaning = collision.gameObject.GetComponent<CubeMeaning>();
        output.VisualizeOutput(selfMeaning.Number, meaning.Number);
    }
    void Start()
    {
        selfMeaning = gameObject.GetComponent<CubeMeaning>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
