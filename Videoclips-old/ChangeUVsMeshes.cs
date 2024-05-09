// No se usa porque hay que tener La propiedad "Read/Write Enabled" se debe establecer manualmente en el Inspector dentro del Editor de Unity a
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ChangeUVsMeshes : MonoBehaviour
// {
//    void Start()
//     {
//         MeshFilter[] meshFilter = FindObjectsOfType<MeshFilter>();
//         for (int i = 0; i < meshFilter.Length; i++)
//         {
//             Mesh mesh = meshFilter[i].mesh;
//              // Obtener las coordenadas UV actuales
//             Vector2[] uvs = mesh.uv;

//             // Modificar las coordenadas UV
//             // Este es un ejemplo simple que invierte las coordenadas UV en el eje U
//             for (int j = 0; j < uvs.Length; j++)
//             {
//                 uvs[j] = new Vector2(1f - uvs[j].x, uvs[j].y);
//             }

//             Debug.Log("OYEEEE");

//             // Aplicar las UV modificadas al mesh
//             mesh.uv = uvs;
//         }
//     }

// }
