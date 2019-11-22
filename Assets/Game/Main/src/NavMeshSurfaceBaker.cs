using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshSurface))]
public class NavMeshSurfaceBaker : MonoBehaviour
{
    void Start()
    {
        _surface = GetComponent<NavMeshSurface>();
        StartCoroutine(TimeUpdate());
    }

    IEnumerator TimeUpdate()
    {
        while (true)
        {
            _surface.BuildNavMesh();

            yield return new WaitForSeconds(5.0f);
        }
    }

    NavMeshSurface _surface;
}