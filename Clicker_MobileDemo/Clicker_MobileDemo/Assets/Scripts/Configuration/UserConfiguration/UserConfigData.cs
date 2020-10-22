using UnityEngine;

namespace Clicker.Configuration
{
    [CreateAssetMenu(menuName = "Config/PlayerConfigData", fileName = "PlayerConfigData")]
    public class UserConfigData : ScriptableObject
    {
        [SerializeField] private int _points; 
        [SerializeField] private int _clickValue;

        public int Points => _points;
        public int ClickValue => _clickValue;
    }
}