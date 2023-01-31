namespace WinFormOOP
{
    public partial class Interface : Form
    {
        Classroom _class = new Classroom();
        public Interface()
        {
            InitializeComponent();
            Course_List.SelectedValueChanged += Event;
        }

        private void Event(object? sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            foreach(Person person in this._class.GetData())
            {
                if (person.GetData()["Name"] == lb.SelectedItem)
                {
                    visible_name.Text = string.Format("{0} [อายุ {1} ปี]", person.GetData()["Name"], person.GetData()["Age"]);
                    visible_gpa.Text = "เกรดเฉลี่ย: " + person.GetData()["GPA"];
                }
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Course_List.Items.Clear();
            this._class.AddStudent(new Person()
                .SetData(EDataType.Name, input_Name.Text)
                .SetData(EDataType.BirthYear, input_BirthYear.Text)
                .SetData(EDataType.GPA, input_GPA.Text)
                );

            // Section Show in studnet info
            foreach (Person Student in this._class.GetData())
            {
                Course_List.Items.Add(Student.GetData()["Name"]);
            }
            textBox_NameGPAMAX.Text = this._class.GetSortGPA().Last().Key.ToString();
            textBox_Max_GPA.Text = this._class.GetSortGPA().Last().Value.ToString();
            textBox_NameGPAMIN.Text = this._class.GetSortGPA().First().Key.ToString();
            textBox_Min_GPA.Text = this._class.GetSortGPA().First().Value.ToString();
            textBox_Avg_GPA.Text = this._class.GetAvgStudents().ToString();
            textBox_SumAge.Text = this._class.GetSumOfStudentAge().ToString();

            // Section Clear input fields
            input_Name.Text = "";
            input_BirthYear.Text = "";
            input_GPA.Text = "";
        }
    }
}