using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    MeshRenderer mesh;
    Material mat;

    [SerializeField]
    Texture tex;
    Shader rim;

    void Start()
    {
       

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Test();
        }
    }
    public void Test()
    {


        //rim = Shader.Find("Shader Forge/MyRim");

        mesh = GetComponent<MeshRenderer>();

        mat = mesh.material;

        Debug.Log(mat.mainTexture);
        Debug.Log(tex);

        //tex = mat.GetTexture("_MainTex");

        //mat.shader = rim;

        //mat.SetTexture("MyText", tex);
        

        mat.EnableKeyword("MyText");
        mat.EnableKeyword("_MainTex");
        mat.mainTexture = tex;
        //mat.SetTexture("MyText", tex);
        Debug.Log(mesh.material.name);
        Debug.Log(mesh.material.shader.name);


    }

}
