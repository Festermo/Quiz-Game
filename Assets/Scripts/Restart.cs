using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    [SerializeField]
    private GameEvent restartEvent;

    [SerializeField]
    private Image fader;

    [SerializeField]
    private TaskManager taskManager;

    [SerializeField]
    private Instantiator instantiator;

    [SerializeField]
    private GameObject restartButton;

    IEnumerator RestartLevels()
    {
        restartButton.SetActive(false);
        Sequence sequence = DOTween.Sequence();
        sequence.Append(fader.DOFade(1, 1));
        yield return new WaitForSeconds(1);
        instantiator.DestroyCurrentCells();
        sequence.Append(fader.DOFade(0, 1));
        Physics.queriesHitTriggers = true; //clicking cells work again
        taskManager.ClearUsedContent(); //to forget which content was used last game
        restartEvent.Raise(); //signal to FillData to start next game
        yield return null;
    }

    public void RestartGame()
    {
        StartCoroutine(RestartLevels());
    }
}