using KomodoClaimsClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims.UI
{
    public class ProgramUI
    {
        private ClaimRepository _newClaim = new ClaimRepository();

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select an Option:\n\n" +
                                  "**************************\n" +
                                  "1. See all claims\n" +
                                  "2. Take care of next claim\n" +
                                  "3. Enter a new claim\n" +
                                  "4. Exit Claims\n" +
                                  "**************************");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        EnterANewClaim();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Enter a valid option.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void EnterANewClaim()
        {
            Console.Clear();
            Claim newClaim = new Claim();

            Console.WriteLine("Enter the claim ID: ");
            newClaim.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the claim type: ");
            newClaim.ClaimType = Console.ReadLine();

            Console.WriteLine("Enter the claim description: ");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Amount of Damage: ");
            newClaim.ClaimAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Date of Incident: ");
            Console.WriteLine(DateTime.Now.ToString());
            Console.ReadLine();

            Console.WriteLine("Date Of Claim: ");
            string d = DateTime.Now.ToString();
            Console.WriteLine(d);
            Console.ReadLine();

            _newClaim.CreateNewClaim(newClaim);
        }

        private void TakeCareOfNextClaim()
        {
            Console.Clear();
            Claim nextClaim = _newClaim.Peek();
            Console.WriteLine($"ClaimID: {nextClaim.ClaimID}\n" +
                                  $"Claim Type: {nextClaim.ClaimType}\n" +
                                  $"Description: {nextClaim.Description}\n" +
                                  $"Amount: {nextClaim.ClaimAmount}\n" +
                                  $"Date Of Incident: {DateTime.Today}\n" +
                                  $"Date Of Claim: {DateTime.Now}\n" +
                                  $"Is the Claim Valid? {nextClaim.IsValid}\n" +
                                  $"************************************\n\n");

        Console.WriteLine("Would you like to deal with the next claim now? (y/n)");
            string input = Console.ReadLine();
            switch (input)
            {
                case "y":
                    Console.WriteLine("You can take care of the next claim now");
                    _newClaim.DequeueClaim();
                    break;
                case "n":
                    Console.WriteLine("You are not taking care of the next claim");
                    break;
                default:
                    Console.WriteLine("Invalid Option: y/n");
                    break;
            }
        }

        private void SeeAllClaims()
        {
            Console.Clear();

            Queue<Claim> queueOfClaims = _newClaim.GetAllClaims();

            foreach (Claim claim in queueOfClaims)
            {
                Console.WriteLine($"ClaimID: {claim.ClaimID}\n" + 
                                  $"Claim Type: {claim.ClaimType}\n" + 
                                  $"Description: {claim.Description}\n" + 
                                  $"Amount: {claim.ClaimAmount}\n" + 
                                  $"Date Of Incident: {DateTime.Today}\n" + 
                                  $"Date Of Claim: {DateTime.Now}\n" +
                                  $"Is the Claim Valid? {claim.IsValid}\n" +
                                  $"************************************\n\n");
            }
        }
    }
}

