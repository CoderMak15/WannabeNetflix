namespace WannabeNetflix.src.ui
{
    internal static class UI
    {
        private static List<Form> _activeForms = new List<Form>();
        private static Dictionary<Type, Form> _uniqueForms = new Dictionary<Type, Form>();

        internal static T? TryOpenForm<T>() where T : Form, new()
        {
            if (_uniqueForms.ContainsKey(typeof(T)))
                return null;

            T form = new();
            form.Show();
            _activeForms.Add(form);
            _uniqueForms.Add(typeof(T), form);
            return form;
        }

        internal static void CloseForm<T>() where T : Form
        {
            if (_uniqueForms.TryGetValue(typeof(T), out Form form))
            {
                form.Close();
                _activeForms.Remove(form);
                _uniqueForms.Remove(typeof(T));
            }
        }

        internal static void CloseForm(Form form)
        {
            if (_uniqueForms.ContainsKey(form.GetType()))
            {
                _activeForms.Remove(form);
                _uniqueForms.Remove(form.GetType());
            }

            if(_uniqueForms.Count == 0)
            {
                Application.Exit();
            }
        }

        internal static void HideForm<T>(bool state) where T : Form
        {
            if (_uniqueForms.TryGetValue(typeof(T), out Form form))
            {
                form.Visible = state;
            }
        }

        internal static Form GetForm<T>() where T : Form
        {
            if (!_uniqueForms.ContainsKey(typeof(T)))
                return null;

            return _uniqueForms[typeof(T)];
        }
    }
}
