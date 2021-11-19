using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CellBundleLevels", menuName = "CellBundleLevels")]
public class CellBundleLevels : ScriptableObject //contains bundles to select random one to random level data
{
    [SerializeField]
    private CellBundleList[] _cellBundleList;

    public CellBundleList[] cellBundleList => _cellBundleList;
}