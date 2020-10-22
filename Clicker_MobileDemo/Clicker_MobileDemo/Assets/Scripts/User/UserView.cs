using TMPro;
using UnityEngine;

namespace Clicker.User
{
    public class UserView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _points;
        [SerializeField] private TextMeshProUGUI _clickValue;
        
        public void SetUserPoints(int value)
        {
            _points.text = value.ToString();
        }
        
        public void SetClickValue(int value)
        {
            _clickValue.text = value.ToString();
        }
    }
}