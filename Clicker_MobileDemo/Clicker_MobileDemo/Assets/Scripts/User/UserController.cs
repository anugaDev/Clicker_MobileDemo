namespace Clicker.User

{   
   public class UserController
   {
        private readonly UserView _view;
        private readonly UserModel _model;
        
        public UserController(UserModel model, UserView view)
        {            
            _model = model;
            _model.OnPointsChanged += OnPointsChanged;
            _model.OnClickValueChanged += OnClickValueChanged;
            
            _view = view;
            OnPointsChanged(_model.Points);
            OnClickValueChanged(_model.ClickValue);
            
        }

        private void OnPointsChanged(int value)
        {
            _view.SetUserPoints(value);
        }

        private void OnClickValueChanged(int value)
        {
            _view.SetClickValue(value);   
        }
    }
}