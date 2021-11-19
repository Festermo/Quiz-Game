using System.Collections;
using UnityEngine;
using DG.Tweening;

public class BounceAnimation : MonoBehaviour
{
    [SerializeField]
    private GameObject starParticle;

    [SerializeField]
    private FillData fillData;

    public IEnumerator BounceAndParticle(Transform cellTransform)
    {
        Sequence sequence = DOTween.Sequence();
        starParticle.transform.position = cellTransform.position;
        starParticle.SetActive(true);
        sequence.Append(cellTransform.DOScale(new Vector3(0.24f, 0.24f, 0.24f), 0.4f));
        yield return new WaitForSeconds(0.4f);
        sequence.Append(cellTransform.DOScale(new Vector3(0.12f, 0.12f, 0.12f), 0.4f));
        yield return new WaitForSeconds(0.4f);
        sequence.Append(cellTransform.DOScale(new Vector3(0.16f, 0.16f, 0.16f), 0.4f));
        yield return new WaitForSeconds(0.4f);
        starParticle.SetActive(false);
        fillData.NextIteration();   //start next level
        yield return null;
    }
}