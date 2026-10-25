using UnityEngine;

public class GroundPlaneModelCycler : MonoBehaviour
{
    [SerializeField] private GameObject[] models;

    private int currentIndex = 0;

    public void OnContentPlaced(GameObject stage)
    {
        if (models == null || models.Length == 0 || stage == null)
            return;

        GameObject prefab = models[currentIndex];

        currentIndex = (currentIndex + 1) % models.Length;

        Instantiate(
       prefab,
       stage.transform.position,
       stage.transform.rotation
         );
    }
}