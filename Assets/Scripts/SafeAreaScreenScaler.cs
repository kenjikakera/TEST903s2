using UnityEngine;


/* SafeAreaScreenScaler
    RectTransformのSafeArea設定をするクラス
*/
public class SafeAreaScreenScaler : MonoBehaviour
{
    [SerializeField]
    public float screenXs = 1138f;
    public float screenYs = 640f;

    private void Awake()
    {
        var safeArea = Screen.safeArea;
        var rectTransform = transform as RectTransform;

        if (rectTransform == null)
        {
            return;
        }

        var side = safeArea.x * screenXs / Screen.width;
        var bottom = safeArea.y * screenYs / Screen.height;

        rectTransform.offsetMin = new Vector2(side, bottom);
        rectTransform.offsetMax = new Vector2(-side, 0f);
        Debug.Log("Scaler");
    }

}