using ASPdotNetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNetCore.Domain.Repositoreis.Abstract
{
    interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();

        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(TextField entity);

        void DeleteTextField(Guid id);

    }
}
