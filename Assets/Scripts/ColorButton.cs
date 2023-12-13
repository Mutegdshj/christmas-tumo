<<<<<<< Updated upstream
using System;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    [SerializeField] private Image colorImage;
    [SerializeField] private Image checkmark;
    
    public event Action OnButtonClick;

    public void SetColor(Color color)
    {
        colorImage.color = color;
    }

    public void OnClick()
    {
        OnButtonClick?.Invoke();
    }
=======
using UnityEngine;

public class ColorButton : MonoBehaviour
{
>>>>>>> Stashed changes
}
