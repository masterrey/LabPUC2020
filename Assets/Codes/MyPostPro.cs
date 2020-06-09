using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPostPro : MonoBehaviour
{
    public Material mypostmat;
    float color = 0;
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, mypostmat);
       
    }
    // Start is called before the first frame update
    void Start()
    {
        mypostmat.SetColor("_Color", Color.black);
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(1);
        while (color < 1)
        {
            yield return new WaitForEndOfFrame();
            color += Time.deltaTime;
            mypostmat.SetColor("_Color", new Color(color, color, color));
        }
        this.enabled = false;
    }

    public void CallFadeOut() => StartCoroutine(FadeOut());
    
    IEnumerator FadeOut()
    {
        this.enabled = true;
        while (color > 0)
        {
            yield return new WaitForEndOfFrame();
            color -= Time.deltaTime;
            mypostmat.SetColor("_Color", new Color(color, color, color));
        }
       
    }
}
