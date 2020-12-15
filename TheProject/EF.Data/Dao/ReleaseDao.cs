using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    public class ReleaseDao
    {
        // todo member의 메서드 인자 확인해서 넣기
        public List<ReleaseEntity> GetList(List<MemberEntity> member)
        {
            using (var context = new projectEntities())
            {
                var query = from h in member
                            join x in context.Members on h.MemberId equals x.MemberId
                            join y in context.Reciepts on x.MemberId equals y.MemberId
                            join z in context.StorageSelections on y.ReceiptId equals z.ReceiptId
                            join a in context.Storages on z.StorageId equals a.StorageId
                            join b in context.Facilities on a.FacilityId equals b.FacilityId
                            where z.ExitDate == null
                            select new ReleaseEntity
                            {
                                Region = b.Region,
                                StorageId = a.StorageId,
                                StorageTypeId = a.StorageTypeId,
                                EntryDate = z.EntryDate,
                                ExitDateExpected = z.ExitDateExpected,
                                RemainingTime = DateTime.Now - z.ExitDateExpected
                            };

                return query.ToList();
            }
        }
    }
}
