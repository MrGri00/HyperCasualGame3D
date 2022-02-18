using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressionBar : MonoBehaviour
{
    Slider slider;

    public Transform startingPoint;
    public Transform finishLine;

    float totalDistance = 0f;
    float distanceLeft = 0f;
    float sliderValue = 0f;

    static Transform playerTransform = null;

    private void Start()
    {
        slider = GetComponent<Slider>();

        totalDistance = startingPoint.position.x - finishLine.position.x;
    }

    private void Update()
    {
        UpdateLevelProgress();
    }

    public void UpdateLevelProgress()
    {
        distanceLeft = totalDistance - (playerTransform.position.x - finishLine.position.x);
        sliderValue = distanceLeft / totalDistance;
        slider.value = Mathf.Lerp(slider.value, sliderValue, 5);
    }

    public static void UpdatePlayerRef(Transform newPlayerTransform)
    {
        playerTransform = newPlayerTransform;
    }
}
