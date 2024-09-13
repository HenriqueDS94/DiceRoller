namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void RollButton_Clicked(object sender, EventArgs e)
    {
        int numeroSelecionado = Convert.ToInt32(SidesPicker.SelectedItem.ToString());
        int numeroSorteado = new Random().Next(numeroSelecionado) + 1;
        ResultLabel.Text = numeroSorteado.ToString();

        
        

    }





}

