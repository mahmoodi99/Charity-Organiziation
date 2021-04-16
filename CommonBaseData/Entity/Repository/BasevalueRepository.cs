using CommonBaseData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonBaseData.Entity.Repository
{
    public class BasevalueRepository : IBaseValueRepository
    {
        public Task<bool> IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistscode(string value)
        {
            throw new NotImplementedException();
        }

        public Task<TblCommonBaseData> ws_CreateBaseValue(TblCommonBaseData TblCommonBaseData)
        {
            throw new NotImplementedException();
        }

        public Task<TblCommonBaseData> ws_DeleteBaseValue(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TblCommonBaseData> ws_loadBaseValue()
        {
            throw new NotImplementedException();
        }

        public Task<TblCommonBaseData> ws_loadBaseValueById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TblCommonBaseData> ws_loadBaseValueByTitle(string value)
        {
            throw new NotImplementedException();
        }

        public Task<TblCommonBaseData> ws_UpdateBaseValue(TblCommonBaseData TblCommonBaseData)
        {
            throw new NotImplementedException();
        }
    }
}
