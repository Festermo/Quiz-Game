using UnityEngine;

[CreateAssetMenu(fileName = "New SpritesData", menuName = "SpritesData")]
public class SpritesData : ScriptableObject //contains all sprites of a certain type
{
    [SerializeField]
    private Sprite[] _sprites;

    public Sprite[] Sprites => _sprites;
}