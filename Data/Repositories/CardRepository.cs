using FastKart.Data.Entities;
using FastKart.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastKart.Data.Repositories
{
    [NotMapped]
    public class CardRepository : ICardRepository
    {
        private readonly AppDbContext _context;
        public CardRepository(AppDbContext context)
        {
            _context = context;
        }

        public int AddCard(User User, string Code, string Password, string PaymentMethod)
        {
            return AddCard(User.Id, Code, Password, PaymentMethod);
        }

        public int AddCard(int UserId, string Code, string Password, string PaymentMethod)
        {
            bool validPaymentMethod = _context.paymentMethods.Where(P => P.Name == PaymentMethod).Count() > 0;

            if (validPaymentMethod)
            {
                var Card = new Card { UserId = UserId, Code = Code, Password = Password, PaymentMethodName = PaymentMethod };

                _context.Add(Card);
                _context.SaveChanges();

                return Card.Id;
            }
            return -1;
        }

        public int Count()
        {
            return _context.Cards.Count();
        }

        public void DeleteCard(int UserId, int CardId)
        {
            var Card = _context.Cards.Find(CardId);

            if(Card is not null && Card.UserId == UserId) 
                _context.Cards.Remove(Card);

            _context.SaveChanges();
        }

        public void DeleteCard(int UserId, Card Card)
        {
            if(Card.UserId == UserId)
            {
                _context.Remove(Card);
                _context.SaveChanges();
            }
        }

        public void DeleteCard(User User, int CardId)
        {
            DeleteCard(User.Id, CardId);
        }

        public void DeleteCard(User User, Card Card)
        {
            DeleteCard(User.Id, Card);
        }

        public void UpdateCardPassword(int CardId, string NewPassword)
        {
            var Card = _context.Cards.Find();
            if(Card is not null)
                UpdateCardPassword(Card, NewPassword);
        }

        public void UpdateCardPassword(Card Card, string NewPassword)
        {
            Card.Password = NewPassword;
            _context.SaveChanges();
        }
    }
}
