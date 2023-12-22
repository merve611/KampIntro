using Lesson5Homework5.Abstract;
using Lesson5Homework5.Concrete;
using Lesson5Homework5.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        Gamer gamer1 = new Gamer { Id = 1, FirstName = "Merve", LastName = "Çakıroğlu", DateOfBirth = new DateTime(1996, 8, 30), NationalityId = "4562136257" };

        BaseGamerManager baseGamerManager = new BaseGamerManager();
        baseGamerManager.Update(gamer1);


        GamerManager gamerManager = new GamerManager(new GamerCheckManager());
        gamerManager.Save(gamer1);


        Game game1 = new Game { Id = 1, GameName = "GTA", UnitPrice = 500 };

        Campaign campaign1 = new Campaign { Id = 1, CampaignName = "Kasım Ayı ", Rate = 50 };

        SellManager sellManager = new SellManager();
        sellManager.Sell(gamer1,game1);

        

        CampaignManager campaignManager = new CampaignManager();
        campaignManager.Add(campaign1);

        
        
        
    }
}