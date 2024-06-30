using System.ComponentModel.DataAnnotations;

namespace test2.Models
{
    public class TestModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
