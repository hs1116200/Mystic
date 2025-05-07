using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] public Text interactableText;

    private InteractionObject targetInteraction;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        // Interact if user presses e
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryInteract();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        string interactionText = "";
        targetInteraction = other.gameObject.GetComponent<InteractionObject>();

        // Update interaction text
        if (targetInteraction && targetInteraction.enabled)
        {
            interactionText = targetInteraction.GetInteractionText();
        }

        SetInteractableNameText(interactionText);
    }

    // reset text dispay when user walks away from interaction object
    public void OnTriggerExit(Collider other)
    {
        targetInteraction = null;
        SetInteractableNameText("");
    }

    public void TryInteract()
    {
        if (targetInteraction && targetInteraction.enabled)
        {
            targetInteraction.Interact();
            targetInteraction = null;
            SetInteractableNameText("");
        }
    }

    private void SetInteractableNameText(string newText)
    {
        if (interactableText)
        {
            interactableText.text = newText;
        }
    }
}
