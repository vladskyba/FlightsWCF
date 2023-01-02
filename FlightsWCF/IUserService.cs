using FlightsWCF.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace FlightsWCF
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        IEnumerable<User> GetAllUsers();

        [OperationContract]
        User GetById(int id);

        [OperationContract]
        void Add(User user);

        [OperationContract]
        void Update(User user);

        [OperationContract]
        void Delete(int id);
    }
}
