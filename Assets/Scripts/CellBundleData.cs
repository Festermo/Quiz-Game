using UnityEngine;

[CreateAssetMenu(fileName = "New CellBundleData", menuName = "CellBundleData")]
public class CellBundleData : ScriptableObject //contains array if celldata, content strings and all sprites for this type of data
{
    [SerializeField]
    private CellData[] _cellData;

    public CellData[] cellData => _cellData;

    [SerializeField]
    private string[] _content;

    public string[] content => _content;

    [SerializeField]
    private SpritesData _spritesData;

    public SpritesData spritesData => _spritesData;
}