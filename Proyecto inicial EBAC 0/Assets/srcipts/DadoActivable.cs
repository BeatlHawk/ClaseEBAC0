using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadoActivable : MonoBehaviour
{
    GameObject Objtospawn;
    Vector3[] vertices = {
        new Vector3(0,0,0), //vertice0
        new Vector3(1,0,0), //vertice1
        new Vector3(1,1,0), //vertice2
        new Vector3(0,1,0), //vertice3
        new Vector3(0,1,1), //vertice4
        new Vector3(1,1,1), //vertice5
        new Vector3(1,0,1), //vertice6
        new Vector3(0,0,1), //vertice7

    };
    int[] triangulos ={
        0, 2, 1, //Cara 1
        0, 3, 2,
        2, 3, 4, //Cara 2
        2, 4, 5,
        1, 2, 5, //Cara 3
        1, 5, 6,
        0, 7, 4, //Cara 4
        0, 4, 3,
        5, 4, 7, //Cara 5
        5, 7, 6,
        0, 6, 7, //Cara 6
        0, 1, 6,

    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnEnable()
    {
        Objtospawn = new GameObject("Dado Activable");
        Objtospawn.AddComponent<MeshFilter>();
        var MeshFilter = Objtospawn.GetComponent<MeshFilter>().mesh;
        MeshFilter.Clear();
        MeshFilter.vertices = vertices;
        MeshFilter.triangles = triangulos;
        MeshFilter.Optimize();
        MeshFilter.RecalculateNormals();
        Objtospawn.AddComponent<BoxCollider>();
        var BoxCollider = Objtospawn.GetComponent<BoxCollider>();
        BoxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        Objtospawn.AddComponent<MeshRenderer>();
        var MeshRendererMaterial = Objtospawn.GetComponent<MeshRenderer>().material;
        MeshRendererMaterial.color = Color.green;
        Objtospawn.transform.position = Vector3.one;
        Objtospawn.AddComponent<Rigidbody>();
        var  rigidbody = Objtospawn.GetComponent<Rigidbody>();
        rigidbody.mass = 99.0f;
        rigidbody.useGravity = true;
        rigidbody.angularDrag = 0.05f; 
        
        
        
    }
    public void OnDisable()
    {
        Objtospawn = new GameObject("Dado Activable");
        Objtospawn.AddComponent<MeshFilter>();
        var MeshFilter = Objtospawn.GetComponent<MeshFilter>().mesh;
        MeshFilter.Clear();
        MeshFilter.vertices = vertices;
        MeshFilter.triangles = triangulos;
        MeshFilter.Optimize();
        MeshFilter.RecalculateNormals();
        Objtospawn.AddComponent<BoxCollider>();
        var BoxCollider = Objtospawn.GetComponent<BoxCollider>();
        BoxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        Objtospawn.AddComponent<MeshRenderer>();
        var MeshRendererMaterial = Objtospawn.GetComponent<MeshRenderer>().material;
        MeshRendererMaterial.color = Color.black;
        Objtospawn.transform.position = Vector3.one;
        Objtospawn.AddComponent<Rigidbody>();
        var rigidbody = Objtospawn.GetComponent<Rigidbody>();
        rigidbody.mass = 99.0f;
        rigidbody.useGravity = true;
        rigidbody.angularDrag = 0.05f;
        
        
    }
}

