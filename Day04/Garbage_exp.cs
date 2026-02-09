using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Garbage_exp:IDisposable
    {
        private FileStream? _fileStream;
        private bool _disposed=false;

        public void OpenFile(String path)
        {
            _fileStream = new FileStream(path, FileMode.Open);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                //disposed maged resource
                _fileStream?.Dispose();
            }
            //dispose unmanaged resource here if any
            _disposed = true;
        }

        ~Garbage_exp()
        {
            Dispose(false); 
        }

    }
}
