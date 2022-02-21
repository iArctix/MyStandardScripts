using UnityEngine;
using UnityEngine.UI;

public class MapCompletionProgress : MonoBehaviour
{
    public GameObject Player;
    public Text PercentageComplete;

    public Transform MapStartingPoint;
    public Transform MapEndingPoint;

    public float percentcomplete;
 

    private float distanceToGoal;

    private void Start()
    {
        distanceToGoal = MapEndingPoint.position.y - MapStartingPoint.position.y;
    }

    private void Update()
    {
        float currentPlayerDistance = MapEndingPoint.position.y - Player.transform.position.y;
        float progress = 1.0f - (currentPlayerDistance / distanceToGoal);

        if (Player.transform.position.y > MapEndingPoint.position.y)
            progress = 1f;

        percentcomplete = progress;

        PercentageComplete.text = (percentcomplete * 100 ).ToString("F1") + ("%");
        

    }
}
