using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Videoclip : MonoBehaviour
{
    public Material videoMaterial; // Asigna aquí el material del video
    // public RenderTexture videoTexture; // Asigna aquí tu Render Texture


    // Start is called before the first frame update
    void Start()
    {
        ReplaceSceneMaterials(videoMaterial);
        // Material videoMaterial = new Material(Shader.Find("Unlit/Texture"));
        // videoMaterial.mainTexture = videoTexture; // Usa la Render Texture como la textura principal del material
        // ReplaceSceneMaterials(videoMaterial);
    }

    void ReplaceSceneMaterials(Material newMaterial)
    {
        Renderer[] renderers = FindObjectsOfType<Renderer>(); // Encuentra todos los objetos con componente Renderer en la escena
        foreach (Renderer renderer in renderers)
        {
            Material[] mats = new Material[renderer.sharedMaterials.Length];
            for (int i = 0; i < mats.Length; i++)
            {
                mats[i] = newMaterial; // Reemplaza cada material por el material de video
            }
            renderer.sharedMaterials = mats; // Asigna el nuevo arreglo de materiales al renderer
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
