using CommonBaseData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonBaseData.Entity.Repository
{
  public  interface IBaseValueRepository
    {
        Task<TblCommonBaseData> ws_loadBaseValueById(int id);
        //Task<TblCommonBaseType> ws_loadBaseTypeByIdIncloud(int id);
        IEnumerable<TblCommonBaseData> ws_loadBaseValue();
        Task<TblCommonBaseData> ws_loadBaseValueByTitle(string value);
        Task<TblCommonBaseData> ws_CreateBaseValue(TblCommonBaseData TblCommonBaseData);
        Task<TblCommonBaseData> ws_UpdateBaseValue(TblCommonBaseData TblCommonBaseData);
        Task<TblCommonBaseData> ws_DeleteBaseValue(int id);
        Task<bool> IsExists(int id);
        Task<bool> IsExistscode(string value);
    }
}
