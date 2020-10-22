using Clicker.Configuration;
using Clicker.Events;

namespace Clicker.User
{
    public class UserModel
    {
        private readonly int _originalPoints;
        private readonly int _originalClickValue;
        
        
        private int _points;
        private int _clickValue;

        public event PointEvent OnPointsChanged;
        public event PointEvent OnClickValueChanged;

        public int Points
        {
            get => _points;
            set
            {
                _points = value;
                if (OnPointsChanged != null) OnPointsChanged(value);
            }
        }
        
        public int ClickValue
        {
            get => _clickValue;
            set
            {
                _clickValue = value;
                if (OnClickValueChanged != null) OnClickValueChanged(value);
            }
        }        
        
        public UserModel(UserConfigData userConfigData)
        {
            _originalPoints = userConfigData.Points;
            _originalClickValue = userConfigData.ClickValue;

            _points = _originalPoints;
            _clickValue= _originalClickValue;
        }   
    } 
}
    
   
