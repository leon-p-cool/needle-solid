// NEEDLE_CODEGEN_START
// auto generated code - do not edit directly

#pragma warning disable

namespace Needle.Typescript.GeneratedComponents
{
	public partial class NavmeshManager : UnityEngine.MonoBehaviour
	{
		public void RegisterNavAgent(UnityEngine.GameObject @agent) {}
		public void Awake() {}
	}
}

// NEEDLE_CODEGEN_END

namespace Needle.Typescript.GeneratedComponents
{

    public partial class NavmeshManager : UnityEngine.MonoBehaviour
    {
        public bool bakeNavmeshOnExport = true;
        public UnityEngine.Mesh navMesh => GetMesh();

        UnityEngine.Mesh GetMesh()
        {
#if UNITY_EDITOR
            if (bakeNavmeshOnExport)
            {
                print("Baking <b><color=#0AA5C0>Nav Mesh</color></b> on export.");
                UnityEditor.AI.NavMeshBuilder.BuildNavMesh();
            }
#endif
            UnityEngine.AI.NavMeshTriangulation newMesh = UnityEngine.AI.NavMesh.CalculateTriangulation();
            var mesh = new UnityEngine.Mesh();
            mesh.name = "ExportedNavMesh";
            mesh.vertices = newMesh.vertices;
            mesh.triangles = newMesh.indices;
            return mesh;
        }
    }
}
