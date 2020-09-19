using System;
using System.Windows;
using Full_Form.DAL;
using Full_Form.Entidades;
using Full_Form.BLL;


namespace Full_Form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private Employees employee;
        public MainWindow()
        {
            InitializeComponent();
            employee = new Employees();
            this.DataContext = employee;
        }

        public void SaveButton_Click(object render, RoutedEventArgs e)
        {
            if(!Validar())
                return;
            var paso = EmployeesBLL.Save(employee);
            if(paso){
                Limpiar();
                MessageBox.Show("Guardado con Exito", "Exito!!",MessageBoxButton.OK);
            }
            else
            MessageBox.Show("Error al guardar", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void Limpiar(){
            this.employee = new Employees();
            this.DataContext = employee;
        }

        private void SearchButton_Click(object render, RoutedEventArgs e)
        {

            Contexto context = new Contexto();

            var found = EmployeesBLL.Search(Convert.ToInt32(IdTextBox.Text));

            if(found != null)
            this.employee = found;
            else{
            this.employee = new Employees();
            MessageBox.Show("No encontrado", "Error",MessageBoxButton.OK);
            }
            

            this.DataContext = this.employee;
        }

        private bool Validar(){
            bool esValido = true;
            if(IdTextBox.Text.Length == 0 && NameTextBox.Text.Length == 0 && PhoneTextBox.Text.Length == 0 && CedulaTextBox.Text.Length == 0 && AddressTextBox.Text.Length == 0 && BirthDatePicker.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Error, Intentelo de nuevo", "Error",MessageBoxButton.OKCancel);

                
            }
            return esValido;
        }

        private void NewButton_Click(object render, RoutedEventArgs e){
            Limpiar();
        }

        private void DeleteButton_Click(object render, RoutedEventArgs e){
            if(EmployeesBLL.Delete(Convert.ToInt32(IdTextBox.Text))){
                Limpiar();
                MessageBox.Show("Eliminado", "Exito",MessageBoxButton.OK);
            }
            else
            MessageBox.Show("Error al eliminar", "Error",MessageBoxButton.OK);
            
        }
        

    }
}
