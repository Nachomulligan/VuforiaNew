using UnityEngine;
using UnityEngine.UI;

public class GroundPlaneModelCycler : MonoBehaviour
{
    [Header("Modelos y botones (mismo orden)")]
    [SerializeField] private GameObject[] models;
    [SerializeField] private Button[] buttons;

    [Header("Colores de los botones")]
    [SerializeField] private Color normalColor = Color.white;
    [SerializeField] private Color selectedColor = Color.green;

    private int currentIndex = 0;

    private void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; 
            buttons[i].onClick.AddListener(() => SelectModel(index));
        }

        SelectModel(0); 
    }

    public void SelectModel(int index)
    {
        if (index < 0 || index >= models.Length)
            return;

        currentIndex = index;
        UpdateButtonColors();
    }

    private void UpdateButtonColors()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].image.color =
                (i == currentIndex) ? selectedColor : normalColor;
        }
    }

    public void OnContentPlaced(GameObject stage)
    {
        if (models == null || models.Length == 0 || stage == null)
            return;

        Instantiate(models[currentIndex], stage.transform, false);
    }
}
