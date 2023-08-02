using FastKart.Data.Entities;
using FastKart.Data.Interfaces.Shared;

namespace FastKart.Data.Interfaces
{
    public interface IFormRepository : IBasicRepository<Form>
    {
        // Read :
        //Dictionary<Form, int> ProductPerForm();
        //IEnumerable<Form> GetAllForms();
        //IEnumerable<string> GetAllFormNames();

        // Create :
        //int AddForm(string FormName);

        //// Update :
        //void UpdateForm(Form Form, string Name);
        //void UpdateForm(string FormName, string Name);

        //// Delete :
        //void DeleteForm(string FormName);
        //void DeleteForm(Form Form);
    }
}
