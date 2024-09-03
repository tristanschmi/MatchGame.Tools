using UnityEngine;
using UnityEngine.Events;
using System.Collections;
public class MonoEventsBehaviour : MonoBehaviour
{ 
    public UnityEvent startEvent, awakeEvent, disableEvent;
    private Material _material;
    
    private void Awake()
    {
        awakeEvent.Invoke();
        _material = GetComponent<Renderer>().material;
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }

    private void OnMouseDown()
    {
        if (_material != null)
        {
            _material.color = Color.magenta;
        }
    }

   
}
