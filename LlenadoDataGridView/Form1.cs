namespace LlenadoDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Persona persona1 = new Persona();
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona ("Juan", 25, "Correo@correo"));
            personas.Add(new Persona ("Ana", 25, "Correo@correo"));
            personas.Add(new Persona ("Pablo", 25, "Correo@correo"));
            personas.Add(new Persona ("Miguel", 25, "Correo@correo"));
            personas.Add(new Persona ("Juan", 25,  "Correo@correo" ));
          

            dataGridView1.DataSource = personas;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }*/

        //Persona persona1 = new Persona();

    }
}