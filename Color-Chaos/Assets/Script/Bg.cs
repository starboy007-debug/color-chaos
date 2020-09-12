using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bg : MonoBehaviour
{
    public float scroll_speed = 0.3f;
    private MeshRenderer mesh;


    void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        scroll();
    }

    void scroll()
    {
        Vector2 offset = mesh.sharedMaterial.GetTextureOffset("_MainTex");
        offset.y += scroll_speed * Time.deltaTime;
        mesh.sharedMaterial.SetTextureOffset("_MainTex", offset);

    }

}
