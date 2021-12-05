using TMPro;
using UnityEngine;

public class LifeDisplayer : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    private LifeBehaviour lifeBehaviour;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        lifeBehaviour = GetComponentInParent<LifeBehaviour>();
    }

    public void UpdateLife()
    {
        textMesh.text = lifeBehaviour.currentHealth.ToString();
    }
}
