namespace Loop_through_array
{
    public partial class Form1 : Form
    {
        int[] array;
        int currentIndex;
        public Form1()
        {
            InitializeComponent();
            array = new int[5];
            currentIndex = 0;
        }

        private void btnShowArray_Click(object sender, EventArgs e)
        {
            if (currentIndex == array.Length) // Solo mostrar si el arreglo est� lleno
            {
                ShowArray(array, 0); // Llamamos al m�todo recursivo para mostrar el arreglo
            }
            else
            {
                MessageBox.Show("A�n no se han ingresado todos los valores.");
            }
        }

        public static void ShowArray(int[] array, int index)
        {
            if (index < array.Length) // Verificamos que no hemos llegado al final del arreglo
            {
                MessageBox.Show("Elemento en la posici�n " + index + ": " + array[index]);
                ShowArray(array, index + 1); // Llamada recursiva
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertimos el texto ingresado a entero
                int value = Convert.ToInt32(txtNumber.Text);

                // Verificamos si a�n hay espacio en el arreglo
                if (currentIndex < array.Length)
                {
                    array[currentIndex] = value; // Guardamos el valor en el arreglo
                    currentIndex++; // Incrementamos el �ndice
                    MessageBox.Show("Valor agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("El arreglo ya est� lleno.");
                }
                txtNumber.Clear(); // Limpiamos el cuadro de texto
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, ingrese un n�mero v�lido.");
            }
        }
    }
}
