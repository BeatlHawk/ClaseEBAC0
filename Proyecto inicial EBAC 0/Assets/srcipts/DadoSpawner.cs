using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadoSpawner : MonoBehaviour
{
    public GameObject PrefabDado;
    public List<GameObject> ListaDeDados;
    public float FactorDeEscalamiento;
    public int NumDados=0;
    // Start is called before the first frame update
    void Start()
    {
        ListaDeDados = new List<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        NumDados++;
        GameObject tempGameObject = Instantiate<GameObject>( PrefabDado);
        tempGameObject.name = "Dadonumero" + NumDados;
        Color c = new Color(Random .value , Random .value, Random .value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitCircle;

        ListaDeDados.Add(tempGameObject);
        List<GameObject> ObjetosParEliminar = new List<GameObject>();
        foreach (GameObject go in ListaDeDados)
        {
            float scale = go.transform.localScale.x;
            scale *= FactorDeEscalamiento;
            go.transform.localScale=Vector3.one * scale;


            if (scale <= 0.1) 
            {
                ObjetosParEliminar.Add(go);
            }
        }

        foreach (GameObject go in ObjetosParEliminar)
        {
            ListaDeDados.Remove(go);
            Destroy(go);
        }
    }
}
