using UnityEngine;

[System.Serializable]
public class CellData
{
    [SerializeField]
    private string _content;

    [SerializeField]
    private Sprite _sprite;

    public Sprite sprite => _sprite;

    public string content => _content;

    public void SetValues(string contentValue, Sprite spriteValue)
    {
        _content = contentValue;
        _sprite = spriteValue;
    }
}