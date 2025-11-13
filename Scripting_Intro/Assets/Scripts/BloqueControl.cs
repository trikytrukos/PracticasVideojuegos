using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueControl : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 nuevaposición;
        nuevaposición = new Vector3(2, 0.5f, 0);
        transform.position = nuevaposición;
        meshRenderer.material.color = Color.green;

    }

    public float tiempoEntreFotogramas, fotogramasPorSegundo;
    // Update is called once per frame
    void Update()
    {
        tiempoEntreFotogramas = Time.deltaTime;
        fotogramasPorSegundo = 1 / tiempoEntreFotogramas;
        transform.position += Vector3.right * tiempoEntreFotogramas;
    }
}
