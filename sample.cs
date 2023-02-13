using System.ComponentModel;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private MainViewModel _viewModel = new MainViewModel();

        public Form1()
        {


            InitializeComponent();
            EEEComboBox.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.ComboSource));
            EEEComboBox.ValueMember = nameof(MainViewModelCombo.Value);
            EEEComboBox.DisplayMember = nameof(MainViewModelCombo.DisplayValue);
            EEEComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }

    public sealed class MainViewModelCombo
    {
        public MainViewModelCombo(int value, string displayValue)
        {
            Value = value;
            DisplayValue = displayValue;
        }

        public int Value { get; }
        public string DisplayValue { get; }
    }

    public sealed class MainViewModel
    {
        public MainViewModel()
        {
            ComboSource = new BindingList<MainViewModelCombo>();
            ComboSource.Add(new MainViewModelCombo(1, "1111"));
            ComboSource.Add(new MainViewModelCombo(2, "2222"));
            ComboSource.Add(new MainViewModelCombo(3, "3333"));
        }
        public BindingList<MainViewModelCombo> ComboSource { get; set; }
    }


}