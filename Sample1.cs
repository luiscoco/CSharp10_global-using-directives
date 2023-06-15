namespace global_using_directives
{
    public class Sample1
    {
        
        List<int> numbers = new();

        public Sample1() {
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
        }

        public void printValues() 
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    
   }
}
