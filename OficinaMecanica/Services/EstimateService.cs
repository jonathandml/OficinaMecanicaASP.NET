using Microsoft.EntityFrameworkCore;
using OficinaMecanica.Data;
using OficinaMecanica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OficinaMecanica.Services
{
    public class EstimateService
    {

        private readonly OficinaMecanicaContext _context;

        public EstimateService(OficinaMecanicaContext oficinaMecanicaContext)
        {
            _context = oficinaMecanicaContext;
        }

        public async Task<List<Estimate>> Search(string seller, string client, DateTime? startDate, DateTime? endDate)
        {
            var list = from e in _context.Estimate select e;
            if (!String.IsNullOrEmpty(seller))
            {
                list = list.Where(x => x.Seller.ToUpper().Contains(seller.ToUpper()));
            }

            if (!String.IsNullOrEmpty(client))
            {
                list = list.Where(x => x.Client.ToUpper().Contains(client.ToUpper()));
            }

            if (startDate.HasValue)
            {
                list = list.Where(x => x.Date >= startDate);
            }

            if (endDate.HasValue)
            {
                list = list.Where(x => x.Date <= endDate);
            }
            return await list.OrderByDescending(x => x.Date).ToListAsync();
        }


    }
}
