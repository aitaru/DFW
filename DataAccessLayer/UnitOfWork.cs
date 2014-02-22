using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DFW;

namespace DataAccessLayer
{
    public class UnitOfWork : IDisposable
    {
        private DfwContext context = new DfwContext();
        private GenericRepository<Concern> _concernRepository;
        public GenericRepository<Concern> ConcernRepository
        {
            get
            {

                if (this._concernRepository == null)
                {
                    this._concernRepository = new GenericRepository<Concern>(context);
                }
                return _concernRepository;
            }
        }

        

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
