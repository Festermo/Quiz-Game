using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TaskManager : MonoBehaviour
{
    [SerializeField]
    private Text taskText;

    private List<string> usedContent = new List<string>();

    private string _currentTask;

    public string currentTask => _currentTask;

    public void FillTask(CellBundleData cellBundleData)
    {
        int randomIndex;
        Sequence sequence = DOTween.Sequence();
        do
        {
            randomIndex = Random.Range(0, cellBundleData.cellData.Length);
        }
        while (usedContent.Count != 0 && usedContent.Contains(cellBundleData.cellData[randomIndex].content)); //to avoid choosing same task
        string neededContent = cellBundleData.cellData[randomIndex].content;
        taskText.text = "Find " + neededContent;
        usedContent.Add(neededContent);
        _currentTask = neededContent;
        sequence.Append(taskText.DOFade(0, 0));
        sequence.Append(taskText.DOFade(1, 1.5f));
    }

    public void ClearUsedContent()
    {
        usedContent.Clear();
    }
}