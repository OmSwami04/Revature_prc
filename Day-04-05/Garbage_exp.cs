using System;
using System.IO;

namespace Day04
{
    public class Garbage_exp : IDisposable
    {
        private FileStream? _fileStream;
        private bool _disposed = false;

        // Open file (unmanaged resource)
        public void OpenFile(string path)
        {
            _fileStream = new FileStream(path, FileMode.OpenOrCreate);
            Console.WriteLine("File opened");
        }

        // Called by using
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
                _fileStream?.Dispose();
                Console.WriteLine("File disposed");
            }

            _disposed = true;
        }

        // Finalizer (backup)
        ~Garbage_exp()
        {
            Dispose(false);
        }
    }
}
