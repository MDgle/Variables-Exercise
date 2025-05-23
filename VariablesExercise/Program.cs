namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string 
            //int
            //char
            //bool
            //double
            //decimal

            char orderIdentifier = 'A';
            double productCost = 28726.35;


            Console.WriteLine("Thank you for participating in this customer survey!");
            Console.WriteLine("Please answer the following questions.");
            Console.WriteLine("please enter your name");
            string participantName = Console.ReadLine();
            Console.WriteLine($"{participantName} purchased-");
            Console.WriteLine("Enter Quantity Purchased:");
            // Assistance via Grok for user input int.
            string input = Console.ReadLine();
            if (int.TryParse(input, out int qtyPurchased))
            {
                decimal totalCost = (decimal)(productCost * qtyPurchased);
                Console.WriteLine($"Thank you {participantName} for purchasing {qtyPurchased} Live Humpback Whales, at the low price of ${productCost} for a total of ${totalCost}!");
            }
            else
            {
                Console.WriteLine($"Order identified as order {orderIdentifier}...");
            }
            
            Console.WriteLine("Are you satisfied with your excellent purchase?");
            Console.Write("(yes/no): ");
            //Assistance via Grok for the bool logic statement.
            string answer = Console.ReadLine().ToLower();

            bool customerSatisfaction;

            if (answer == "yes" || answer == "y")
            {
                customerSatisfaction = true;
                Console.WriteLine("Fantastic!");
            }
            else if (answer == "no" || answer == "n")
            {
                customerSatisfaction = false;
                Console.WriteLine("That is unfortunate. Please learn to better apreciate whales.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }

            Console.WriteLine("We look forward to delivering your new pets to their new forever home!");
            Console.WriteLine("Thank you for participating in this customer survey!");


            
        }
    }
}