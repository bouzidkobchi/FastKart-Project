using FastKart.Data.Entities;

namespace FastKart.Data.Interfaces
{
    public interface ICardRepository
    {
        // Read :
        int Count();

        // Create :
        int AddCard(User User, string Code, string Password, string PaymentMethod); // return -1 if Code small , -2 if paymentMethod not found
        int AddCard(int UserId, string Code, string Password, string PaymentMethod); // return -1 if Code small , -2 if paymentMethod not found

        // Update :
        void UpdateCardPassword(int CardId, string NewPassword);
        void UpdateCardPassword(Card Card, string NewPassword);
        
        // Delete :
        void DeleteCard(int UserId , int CardId);
        void DeleteCard(int UserId , Card Card);
        void DeleteCard(User User , int CardId);
        void DeleteCard(User User , Card Card);
    }
}
