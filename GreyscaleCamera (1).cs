using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreyscaleCamera : MonoBehaviour
{

    public Material greyscaleMaterial;

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, greyscaleMaterial);
    }
}
