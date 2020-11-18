using UnityEngine;
using UnityEngine.XR;

// From https://yunhan.li/unity/2019/05/31/unity-oculus-standalone-graphic.html

public class VRRenderScale : MonoBehaviour
{


    public float textureResolutionScale = 1.5f;
    void Start()
    {
        XRSettings.eyeTextureResolutionScale = textureResolutionScale;
    }
}
