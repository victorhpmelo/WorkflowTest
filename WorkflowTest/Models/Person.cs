using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace WorkflowTest.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "Date")]
        public DateTime BirthDate { get; set; }
    }
}
