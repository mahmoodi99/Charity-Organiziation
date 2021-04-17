using CommonBaseData.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonBaseData.Entity.Repository
{
    public class BasevalueRepository : IBaseValueRepository
    {
        private Base_Context _Context;
        public BasevalueRepository(Base_Context context)
        {
            _Context = context;
        }

        public async Task<bool> IsExists(int id)
        {
            return await _Context.TblCommonBaseData.AnyAsync(c => c.CommonBaseDataId == id);
        }

        public async Task<bool> IsExistscode(string value)
        {
            return await _Context.TblCommonBaseData.AnyAsync(c => c.BaseValue == value || c.BaseCode == value);
        }

        public async Task<TblCommonBaseData> ws_CreateBaseValue(TblCommonBaseData TblCommonBaseData)
        {

            await _Context.TblCommonBaseData.AddAsync(TblCommonBaseData);

            TblCommonBaseData = new TblCommonBaseData
            {

                CommonBaseTypeId = TblCommonBaseData.CommonBaseTypeId,
                BaseValue = TblCommonBaseData.BaseValue,
                BaseCode = TblCommonBaseData.BaseCode
            };        
                

            await _Context.SaveChangesAsync();
            return TblCommonBaseData;
        }




        public  async Task<TblCommonBaseData> ws_DeleteBaseValue(int id)
        {
            var baseData = await _Context.TblCommonBaseData.SingleAsync(t => t.CommonBaseDataId == id);
            _Context.TblCommonBaseData.Remove(baseData);
            await _Context.SaveChangesAsync();
            return (baseData);
        }




        public IEnumerable<TblCommonBaseData> ws_loadBaseValue()
        {
            return _Context.TblCommonBaseData.ToList();
        }




        public async Task<TblCommonBaseData> ws_loadBaseValueById(int id)
        {
            return await _Context.TblCommonBaseData.SingleOrDefaultAsync(c => c.CommonBaseDataId == id);
        }




        public async Task<TblCommonBaseData> ws_loadBaseValueByTitle(string value)
        {
            var baseData = await _Context.TblCommonBaseData.FirstOrDefaultAsync(p => p.BaseCode.Contains("value") || p.BaseValue.Contains("value"));

            return (baseData);
        }



        public Task<TblCommonBaseData> ws_UpdateBaseValue(TblCommonBaseData TblCommonBaseData)
        {
            throw new NotImplementedException();
        }
    }
}
