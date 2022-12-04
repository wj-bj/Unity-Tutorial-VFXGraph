using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class EmitterVFXEvent : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]VisualEffect vfx;
    static readonly int loop = Shader.PropertyToID("Loop");
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.A)){
            var value = vfx.GetBool(loop);
            vfx.SetBool(loop, !value);
        }
    }
}
