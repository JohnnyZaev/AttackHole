using UnityEngine;

public class LayerManager : MonoBehaviour
{
    [SerializeField] private string[] masks;
    private const int Default = 0;
    private const int IgnoreCollision = 1;

    private void OnTriggerEnter(Collider other)
    {
        ChangeLayer(other, masks[Default]);
    }

    private void OnTriggerExit(Collider other)
    {
        ChangeLayer(other, masks[IgnoreCollision]);
    }

    private void ChangeLayer(Collider col, string layer)
    {
        col.gameObject.layer = LayerMask.NameToLayer(layer);
    }
}
