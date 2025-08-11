using _11aug._11;

namespace _11aug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University uni = new University("BDU", 5);

            Group group1 = new Group("TI-86", 3);
            Group group2 = new Group("TI-87", 2);

            uni.AddGroup(group1);
            uni.AddGroup(group2);

            Student st1 = new Student("Nigar", "Aliyeva", 20);
            
            Student st3 = new Student("Aysel", "Mammadova", 19);

            group1.Add(st1);
            
            group2.Add(st3);

            uni.ShowGroups();
            uni.ShowAllStudents();

            Console.WriteLine(group1.StudentExists("Nigar")); 
            Console.WriteLine(group2.StudentExists("Rauf"));  

            group1.Remove("Elnur");
            uni.ShowAllStudents();
        }
    }
}
        
    

