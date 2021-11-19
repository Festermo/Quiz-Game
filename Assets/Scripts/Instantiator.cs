using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Instantiator : MonoBehaviour
{
    [SerializeField]
    private GameObject cell;

    [SerializeField]
    private Positions positions;

    private List<GameObject> currentCells = new List<GameObject>();

    public void InstantiateCells(CellBundleData cellBundleData)
    {
        DestroyCurrentCells();
        for (int i = 0; i < cellBundleData.cellData.Length; i++)
        {
            Sequence sequence = DOTween.Sequence();
            GameObject currentCell = Instantiate(cell, positions.cellPositions[i], Quaternion.identity);
            sequence.Append(currentCell.transform.DOScale(new Vector3(2.64f, 2.64f, 2.64f), 0.5f));
            sequence.Append(currentCell.transform.DOScale(new Vector3(2.09f, 2.09f, 2.09f), 0.5f));
            sequence.Append(currentCell.transform.DOScale(new Vector3(2.2f, 2.2f, 2.2f), 0.5f));
            currentCell.GetComponent<Cell>().SetContent(cellBundleData.cellData[i].content);
            currentCells.Add(currentCell);
            currentCell.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = cellBundleData.cellData[i].sprite;
        }
    }

    public void DestroyCurrentCells()
    {
        for (int i = 0; i < currentCells.Count; i++)
        {
            Destroy(currentCells[i]);
        }
    }
}