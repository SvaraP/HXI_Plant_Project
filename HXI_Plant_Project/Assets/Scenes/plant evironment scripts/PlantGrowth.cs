using UnityEngine;
using System.Collections.Generic;

public class PlantGrowth : MonoBehaviour
{
    public List<GameObject> childobjectList = new List<GameObject>();
    private int currentProgression = 0;
    public int timeBetweenGrowth;
    public int maxGrowth;

    void Start()
    {
        // Populate the list with child objects
        for (int i = 0; i < transform.childCount; i++)
        {
            childobjectList.Add(transform.GetChild(i).gameObject);
            childobjectList[i].SetActive(false); // Ensure all start inactive
        }
        
        if (childobjectList.Count > 0)
        {
            InvokeRepeating("Growth", timeBetweenGrowth, timeBetweenGrowth);
        }
    }

    public void Growth()
    {
        if (currentProgression < maxGrowth && currentProgression < childobjectList.Count)
        {
            childobjectList[currentProgression].SetActive(true);
        }
        
        if (currentProgression > 0 && currentProgression < childobjectList.Count)
        {
            childobjectList[currentProgression - 1].SetActive(false);
        }
        
        if (currentProgression < maxGrowth)
        {
            currentProgression++;
        }
    }
}
