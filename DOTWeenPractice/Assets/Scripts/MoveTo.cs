using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private Vector3 _pozition;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loop;
    
    private void Start()
    {
        transform.DOMove(_pozition, _duration).SetLoops(-1, _loop).SetEase(Ease.Linear);
    }
}