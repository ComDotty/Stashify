using Microsoft.Maui.Controls;

namespace Stashify.Views.Controls
{
    public class PickerControl : Picker
    {
        public static readonly BindableProperty PickerBtnProperty =
            BindableProperty.Create(nameof(PickerBtn), typeof(Button), typeof(PickerControl), null);

        public Button PickerBtn
        {
            get => (Button)GetValue(PickerBtnProperty);
            set => SetValue(PickerBtnProperty, value);
        }

        public PickerControl()
        {
            this.SelectedIndexChanged += OnPickerSelectedIndexChanged;
            this.Unfocused += OnPickerUnfocused;
        }

        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SelectedItem != null)
            {
                PickerBtn.Text = this.SelectedItem.ToString();
                HidePicker();
            }
        }

        private void OnPickerUnfocused(object sender, FocusEventArgs e)
        {
            if(this.IsVisible == false) 
            {
                return;
            }

            HidePicker();
        }

        public void ShowPicker()
        {
            this.IsVisible = true;
            this.Focus();
        }

        public async void HidePicker()
        {
            await Task.Delay(200);
            this.IsVisible = false;
        }
    }
}
