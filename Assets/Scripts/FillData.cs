using System.Collections.Generic;
using UnityEngine;

public class FillData : MonoBehaviour
{
    [SerializeField]
    private CellBundleLevels cellBundleLevels;

    [SerializeField]
    private DataFilledGameEvent dataFilledGameEvent;

    [SerializeField]
    private EndGameManager endGameManager;

    private List<string> unusedContent; //available content for this round to avoid repeats

    private List<Sprite> unusedSprites; //same for sprites

    private int currentLevelIndex;

    private int currentBundleIndex;

    public void FillBundleData()
    {
        CellBundleData currentBundleData = cellBundleLevels.cellBundleList[currentLevelIndex].cellBundleData[currentBundleIndex];
        for (int i = 0; i < currentBundleData.cellData.Length; i++)
        {
            int randomIndex = Random.Range(0, unusedContent.Count);
            currentBundleData.cellData[i].SetValues(unusedContent[randomIndex], unusedSprites[randomIndex]);
            unusedContent.Remove(unusedContent[randomIndex]);
            unusedSprites.Remove(unusedSprites[randomIndex]);
        }
        dataFilledGameEvent.Raise(currentBundleData); //send information to initiator and task manager
    }

    private void Start()
    {
        CellBundleList currentBundleList = cellBundleLevels.cellBundleList[currentLevelIndex];
        currentBundleIndex = Random.Range(0, currentBundleList.cellBundleData.Length);
        unusedContent = new List<string>(currentBundleList.cellBundleData[currentBundleIndex].content);
        unusedSprites = new List<Sprite>(currentBundleList.cellBundleData[currentBundleIndex].spritesData.Sprites);
        FillBundleData();
    }

    public void NextIteration() //fill info for next level
    {
        if (currentLevelIndex >= cellBundleLevels.cellBundleList.Length - 1) //if no more levels available
        {
            endGameManager.EndGame();
        }
        else
        {
            currentLevelIndex++;
            Start();
        }
    }

    public void StartAgain() //start after clicking repeat button
    {
        currentLevelIndex = 0;
        Start();
    }
}