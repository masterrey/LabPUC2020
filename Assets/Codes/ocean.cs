using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ocean : MonoBehaviour
{
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.SetTextureOffset("_MainTex", new Vector2(Time.time*0.01f, 0));
        rend.material.SetTextureOffset("_DetailAlbedoMap", new Vector2(Time.time * -0.01f, 0));
    }
}

