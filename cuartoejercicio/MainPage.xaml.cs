namespace cuartoejercicio;

//<Summary>
//<Createddate>9/7/2023</createddate>
//<company>INDEL</company>
//<lastmodificationdate>10/7/2023</lastmodificationdate>
//<lastmodificationdescription>
// Construí un programa que permita obtener el cuadrado y el cubo de un numero entero positivo
//</lastmodificationdescription>
//<lastmodifierautor> Maycol Barrera </lastmodifierautor>
//</Summary>
public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
	
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int nume1 = Convert.ToInt32(num1.Text);
     
        int r = nume1 * nume1 ;

        Respuesta1.Text = Convert.ToString(r);
    }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        int nume1 = Convert.ToInt32(num1.Text);
        
        int r = nume1 * nume1 * nume1;

        Respuesta2.Text = Convert.ToString(r);

    }
}

