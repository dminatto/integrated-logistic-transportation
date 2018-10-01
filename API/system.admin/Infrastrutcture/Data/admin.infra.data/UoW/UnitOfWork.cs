using admin.domain.Interfaces;
using admin.infra.data.DAO.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.infra.data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private bool _disposed;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
