using UnityEngine;

[CreateAssetMenu(fileName = "New Positions", menuName = "Positions")]
public class Positions : ScriptableObject //to contain positions of cells to instantiate
{
    [SerializeField]
    private Vector3[] _cellPositions;

    public Vector3[] cellPositions => _cellPositions;
}