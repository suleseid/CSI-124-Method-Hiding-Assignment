using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CSI_124_Method_Hiding_Assignment.Aggregate_Container
{
    /// <summary>
    /// Interaction logic for Agg_Contain_NoteAssignment.xaml
    /// </summary>
    public partial class Agg_Contain_NoteAssignment : Window
    {
        private readonly Teacher Will;
        List<Teacher> teachers = new List<Teacher>();
        public Agg_Contain_NoteAssignment()
        {
            
            InitializeComponent();

            // A Containment is when an object contains another object, but it cannot exist
            // independently to another
            List<Student> csi124Roster = new List<Student>();
            Course csi124 = new Course(
                "csi140",
                "Downtown Renton",
                new Teacher("Will", "Carm", 2));

            teachers.Add(Will);
            teachers.Add(new Teacher("Anne", "Nguen", 1));
            teachers.Add(new Teacher("Josh", "Emry", 3));

            csi124.Teacher = teachers[1];
            MessageBox.Show(csi124.Teacher.ToString());
        }
        public void AggregateExample()
        {
            //Aggregate takes another objects,but not required.
            Teacher Will = new Teacher("", "Cram", 2);
            Course csi124 = new Course("CSI 124", "Downtown Renton");

            teachers.Add(Will);
            teachers.Add(new Teacher("Anne", "Nguen", 1));
            teachers.Add(new Teacher("Josh", "Emry", 3));

            csi124.Teacher = teachers[1];
            MessageBox.Show(csi124.Teacher.ToString());
        }
    }
}
