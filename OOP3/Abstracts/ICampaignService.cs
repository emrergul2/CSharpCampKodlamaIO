using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP3.Entities;

namespace OOP3.Abstracts
{
    public interface ICampaignService
    {
        void AddNewCampaign();
        void UpdateCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
    }
}