using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP3.Abstracts;
using OOP3.Entities;

namespace OOP3.Concretes

{
    public class CampaignManager : ICampaignService
    {
        public void AddNewCampaign()
        {
            Campaign campaign = new Campaign();
            Console.WriteLine("Campaign Name : ");
            campaign.Name = Console.ReadLine();
            Console.WriteLine("Campaign Start Date : ");
            campaign.StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Campaign Finish Date");
            Console.WriteLine(@"/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\");
            Console.WriteLine($"{campaign.Name} added.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} deleted.");

        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} Updated.");
        }
    }
}