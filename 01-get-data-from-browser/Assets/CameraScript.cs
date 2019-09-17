using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public TextMesh textMesh;
    // Start is called before the first frame update
    void Start()
    {
        Application.ExternalEval("OnUnityReady()");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setText(string text) {
        textMesh.text = text;
    }
}
