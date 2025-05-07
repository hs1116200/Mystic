using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(BoxCollider))]
public class InteractionObject : MonoBehaviour
{
    [SerializeField] private string interactionText = "You should find a seed to plant";

    public UnityEvent OnInteract = new UnityEvent();

    void Start()
    {
    
    }

    public string GetInteractionText()
    {
        return interactionText;
    }

    public void Interact()
    {
        OnInteract.Invoke();
    }
}
