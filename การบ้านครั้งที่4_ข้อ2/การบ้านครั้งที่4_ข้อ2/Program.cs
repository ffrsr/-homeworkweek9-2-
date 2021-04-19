using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านครั้งที่4_ข้อ2
{
    class Program
    {
        static void Main(string[] args)
        {
            char ans1, ans2;            
            string halfDNASequence = Console.ReadLine();

            

            if (IsValidSequence(halfDNASequence) == false)
            {
                Console.WriteLine("That half DNA sequence is invalid.");

                Console.Write("Do you want to process another sequence ? (Y/N) :");
                ans2 = char.Parse(Console.ReadLine());

                do
                {
                    string DNA = Console.ReadLine();                    
                    halfDNASequence = DNA;
                    if (ans2 == 'Y')
                    {

                        do
                        {
                            
                            if (IsValidSequence(halfDNASequence) == false)
                            {
                                Console.WriteLine("That half DNA sequence is invalid.");

                                Console.Write("Do you want to process another sequence ? (Y/N) :");
                                ans2 = char.Parse(Console.ReadLine());

                                do
                                {
                                    
                                    if (ans2 == 'N')
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("Please input Y or N.");
                                        Console.Write("Do you want to process another sequence ? (Y/N) :");
                                        ans2 = char.Parse(Console.ReadLine());
                                    }
                                } while (ans2 != 'Y' || ans2 != 'N');


                            }
                            else
                            {
                                
                                Console.WriteLine("Current half DNA sequence :{0}", halfDNASequence);
                                
                                Console.Write("Do you want to replicate it ? (Y/N) :");
                                ans1 = char.Parse(Console.ReadLine());

                            do
                            {
                                    string DNA1 = Console.ReadLine();
                                    halfDNASequence = DNA1;

                                if (ans1 == 'Y')
                                    {
                                        
                                        Console.WriteLine("Current half DNA sequence :{0}", halfDNASequence);
                                        Console.Write("Do you want to replicate it ? (Y/N) :");
                                        ans1 = char.Parse(Console.ReadLine());

                                        ReplicateSeqeunce(halfDNASequence);
                                        Console.WriteLine("Replicated half DNA sequence :{0}", ReplicateSeqeunce(halfDNASequence));

                                        Console.Write("Do you want to process another sequence ? (Y/N) :");
                                        ans2 = char.Parse(Console.ReadLine());

                                        do
                                        {
                                            
                                            if (ans2 == 'N')
                                            {

                                            }
                                            else
                                            {
                                                Console.WriteLine("Please input Y or N.");
                                                Console.Write("Do you want to process another sequence ? (Y/N) :");
                                                ans2 = char.Parse(Console.ReadLine());
                                            }
                                        } while (ans2 != 'Y' || ans2 != 'N');

                                    }
                                else if (ans1 == 'N')
                                    {
                                        Console.Write("Do you want to process another sequence ? (Y/N) :");
                                        ans1 = char.Parse(Console.ReadLine());

                                
                                    }
                                else
                                    {
                                        Console.WriteLine("Please input Y or N.");
                                        Console.Write("Do you want to replicate it ? (Y/N) :");
                                        ans1 = char.Parse(Console.ReadLine());
                                    }
                            
                                } while (ans1 != 'Y' || ans1 != 'N');
                            
                            }

                        } while (ans2 != 'N');
                    }
                    else if (ans2 == 'N')
                    {

                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.Write("Do you want to process another sequence ? (Y/N) :");
                        ans2 = char.Parse(Console.ReadLine());
                    }
                } while (ans2 != 'Y' || ans2 != 'N');

            }
            else
            {
                Console.WriteLine("Current half DNA sequence :{0}", halfDNASequence);
                Console.Write("Do you want to replicate it ? (Y/N) :");
                ans1 = char.Parse(Console.ReadLine());

                do
                {
                    if (ans1 == 'Y')
                    {

                        ReplicateSeqeunce(halfDNASequence);
                        Console.WriteLine("Replicated half DNA sequence :{0}", ReplicateSeqeunce(halfDNASequence));

                        Console.Write("Do you want to process another sequence ? (Y/N) :");
                        ans2 = char.Parse(Console.ReadLine());

                        do
                        {
                            if (ans2 == 'Y')
                            {
                                do
                                {
                                    string DNA = Console.ReadLine();
                                    halfDNASequence = DNA;
                                    
                                    if (IsValidSequence(halfDNASequence) == false)
                                    {
                                        Console.WriteLine("That half DNA sequence is invalid.");

                                        Console.Write("Do you want to process another sequence ? (Y/N) :");
                                        ans2 = char.Parse(Console.ReadLine());

                                        do
                                        {
                                            
                                            if (ans2 == 'N')
                                            {

                                            }
                                            else
                                            {

                                                Console.WriteLine("Please input Y or N.");
                                                Console.Write("Do you want to process another sequence ? (Y/N) :");
                                                ans2 = char.Parse(Console.ReadLine());


                                            }
                                        } while (ans2 != 'Y' || ans2 != 'N');


                                    }
                                    else
                                    {
                                        Console.WriteLine("Current half DNA sequence :{0}", halfDNASequence);
                                        Console.Write("Do you want to replicate it ? (Y/N) :");
                                        ans1 = char.Parse(Console.ReadLine());

                                        do
                                        {
                                            if (ans1 == 'Y')
                                            {
                                                ReplicateSeqeunce(halfDNASequence);
                                                Console.WriteLine("Replicated half DNA sequence :{0}", ReplicateSeqeunce(halfDNASequence));

                                                Console.Write("Do you want to process another sequence ? (Y/N) :");
                                                ans2 = char.Parse(Console.ReadLine());

                                                do
                                                {
                                                    
                                                    if (ans2 == 'N')
                                                    {

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Please input Y or N.");
                                                        Console.Write("Do you want to process another sequence ? (Y/N) :");
                                                        ans2 = char.Parse(Console.ReadLine());
                                                    }
                                                } while (ans2 != 'Y' || ans2 != 'N');

                                            }
                                            else if (ans1 == 'N')
                                            {
                                                Console.Write("Do you want to process another sequence ? (Y/N) :");
                                                ans2 = char.Parse(Console.ReadLine());
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please input Y or N.");
                                                Console.Write("Do you want to replicate it ? (Y/N) :");
                                                ans1 = char.Parse(Console.ReadLine());
                                            }
                                        } while (ans1 != 'Y' || ans1 != 'N');
                                    }
                                } while (ans2 != 'N');
                            }

                            else if (ans2 == 'N')
                            {

                            }
                            else
                            {
                                Console.WriteLine("Please input Y or N.");
                                Console.Write("Do you want to process another sequence ? (Y/N) :");
                                ans2 = char.Parse(Console.ReadLine());
                            }
                        } while (ans2 != 'Y' || ans2 != 'N');

                    }
                    else if (ans1 == 'N')
                    {
                        Console.Write("Do you want to replicate it ? (Y/N) :");
                        ans1 = char.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.Write("Please input Y or N.");
                        Console.Write("Do you want to replicate it ? (Y/N) :");
                        ans1 = char.Parse(Console.ReadLine());
                    }
                } while (ans1 != 'Y' || ans1 != 'N');
            }

        }        
               
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }   


        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }



    }
}
