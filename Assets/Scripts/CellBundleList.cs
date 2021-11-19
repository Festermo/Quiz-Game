using UnityEngine;

[System.Serializable]
public class CellBundleList //contains array of bundles to build each level
{
    [SerializeField]
    private CellBundleData[] _cellBundleData;

    public CellBundleData[] cellBundleData => _cellBundleData;
}