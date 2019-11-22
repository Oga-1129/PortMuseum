using UnityEngine;
using UnityEngine.AI;

[DefaultExecutionOrder(-103)]
public class BuildNavmesh : MonoBehaviour
{
    void Awake()
    {
        GetComponent<NavMeshSurface>().Bake();
    }
}