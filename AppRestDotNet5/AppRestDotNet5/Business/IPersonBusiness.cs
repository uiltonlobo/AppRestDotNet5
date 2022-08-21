using AppRestDotNet5.Data.VO;
using AppRestDotNet5.Model;
using System.Collections.Generic;

namespace AppRestDotNet5.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
