using DG.Tweening;
using UnityEngine;

public class RotateTo : MonoBehaviour
{
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DORotate(_endValue, _duration, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }
}
