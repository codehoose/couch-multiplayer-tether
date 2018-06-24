using UnityEngine;

public class Tether : MonoBehaviour
{
    public Transform other;

    public float maxDistance = 20f;

    public bool AtMax { get; private set; }

    public float Distance
    {
        get
        {
            var distance = (other.position - transform.position).magnitude;
            return distance / maxDistance;
        }
    }

    public bool IsCloser(Vector3 pos)
    {
        var distance = (other.position - pos).magnitude;
        return distance < maxDistance;
    }

    private void Update()
    {
        var distance = (other.position - transform.position).magnitude;
        AtMax = distance >= maxDistance;
    }
}
