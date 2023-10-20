using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeScript : MonoBehaviour
{

    public Slider red;
    public Slider blue;
    public Slider green;
    public Slider alpha;
    public Slider scale;

    private Renderer cubeRenderer;


    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        cubeRenderer.material.color = new Color((float)red.value, (float)green.value, (float)blue.value, (float)alpha.value);
        
        this.transform.localScale = new Vector3(scale.value, scale.value, scale.value);
    }
}
